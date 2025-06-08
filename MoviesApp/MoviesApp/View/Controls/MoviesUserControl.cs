using MoviesApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesApp.View.Controls
{
    public partial class MoviesUserControl : UserControl
    {
        private List<Movie> _movies = new List<Movie>();
        private Movie _selectedMovie;
        private readonly string _dataFilePath = "movies.csv";
        private bool _isEditingAllowed = false;

        public MoviesUserControl()
        {
            InitializeComponent();
            FillGenreComboBox();
            LoadData();
        }
        /*
        private void LoadData()
        {
            if (File.Exists(_dataFilePath))
            {
                var json = File.ReadAllText(_dataFilePath);
                _movies = JsonSerializer.Deserialize<List<Movie>>(json);
                SortAndDisplayMovies();
            }
        }

        private void SaveData()
        {
            var json = JsonSerializer.Serialize(_movies);
            File.WriteAllText(_dataFilePath, json);
        }
        */

        // Заполняем ComboBox значениями enum
        private void FillGenreComboBox()
        {
            GenreComboBox.DataSource = Enum.GetValues(typeof(Model.Enums.Genre));
        }

        public void SaveData()
        {
            List<string> lines = new List<string>();
            foreach (Movie movie in _movies)
            {
                // Создаем строку вида: Title,ReleaseYear,Genre,Rating,DurationInMinutes
                string line = $"{EscapeCsv(movie.Title)},{movie.ReleaseYear},{EscapeCsv(movie.Genre)},{movie.Rating},{movie.DurationInMinutes}";
                lines.Add(line);
            }
            File.WriteAllLines(_dataFilePath, lines);
        }

        // Вспомогательный метод для экранирования запятых и кавычек
        private string EscapeCsv(string field)
        {
            if (field.Contains(",") || field.Contains("\""))
            {
                // Экранируем кавычки
                field = field.Replace("\"", "\"\"");
                // Оборачиваем в кавычки
                return $"\"{field}\"";
            }
            return field;
        }

        private void LoadData()
        {
            if (File.Exists(_dataFilePath))
            {
                string[] lines = File.ReadAllLines(_dataFilePath);
                _movies.Clear();
                foreach (string line in lines)
                {
                    string[] parts = ParseCsvLine(line);
                    if (parts.Length == 5)
                    {
                        Movie movie = new Movie
                        {
                            Title = parts[0],
                            ReleaseYear = int.TryParse(parts[1], out int year) ? year : 0,
                            Genre = parts[2],
                            Rating = double.TryParse(parts[3], out double rating) ? rating : 0.0,
                            DurationInMinutes = int.TryParse(parts[4], out int duration) ? duration : 0
                        };
                        _movies.Add(movie);
                    }
                }
                SortAndDisplayMovies();
            }
        }

        // Простая парсилка строки CSV с учетом кавычек
        private string[] ParseCsvLine(string line)
        {
            List<string> result = new List<string>();
            bool inQuotes = false;
            StringBuilder currentField = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '\"')
                {
                    if (inQuotes && i + 1 < line.Length && line[i + 1] == '\"')
                    {
                        // Экранированная кавычка внутри поля
                        currentField.Append('\"');
                        i++;
                    }
                    else
                    {
                        inQuotes = !inQuotes;
                    }
                }
                else if (c == ',' && !inQuotes)
                {
                    result.Add(currentField.ToString());
                    currentField.Clear();
                }
                else
                {
                    currentField.Append(c);
                }
            }

            // добавляем последний элемент
            result.Add(currentField.ToString());

            return result.ToArray();
        }

        private void SortAndDisplayMovies()
        {
            _movies = _movies.OrderBy(m => m.Title).ToList();
            MoviesListBox.Items.Clear();
            foreach (Movie movie in _movies)
            { 
                MoviesListBox.Items.Add(movie);
            }
        }

        // Метод для управления доступностью полей
        private void SetFieldsEditable(bool editable)
        {
            TitleTextBox.ReadOnly = !editable;
            ReleaseYearTextBox.ReadOnly = !editable;
            GenreComboBox.Enabled = editable;
            RatingTextBox.ReadOnly = !editable;
            DurationInMinutesTextBox.ReadOnly = !editable;
        }

        private void SetGenreSelectedItem(string genreName)
        {
            Model.Enums.Genre[] genres = (MoviesApp.Model.Enums.Genre[])GenreComboBox.DataSource;
            int index = Array.FindIndex(genres, g => g.ToString() == genreName);
            if (index >= 0)
            {
                GenreComboBox.SelectedIndex = index;
            }
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = MoviesListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _movies.Count)
            {
                _selectedMovie = _movies[selectedIndex];

                // Заполняем поля данными выбранного фильма
                TitleTextBox.Text = _selectedMovie.Title;
                ReleaseYearTextBox.Text = Convert.ToString(_selectedMovie.ReleaseYear);
                // GenreComboBox заполняется по особенному
                SetGenreSelectedItem(_selectedMovie.Genre);
                RatingTextBox.Text = Convert.ToString(_selectedMovie.Rating);
                DurationInMinutesTextBox.Text = Convert.ToString(_selectedMovie.DurationInMinutes);
            }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isEditingAllowed && _selectedMovie != null)
            {
                UpdateMovieNameProperty(TitleTextBox, 100, (value) => _selectedMovie.Title = value);
            }
        }

        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isEditingAllowed && _selectedMovie != null)
            {
                UpdateIntLimitsProperty((value) => _selectedMovie.ReleaseYear = value, ReleaseYearTextBox);
            }
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isEditingAllowed && _selectedMovie != null)
            {
                _selectedMovie.Genre = GenreComboBox.SelectedItem.ToString();
            }
        }

        private void GenreComboBox_TextChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            string input = comboBox.Text;

            // Проверяем наличие элемента
            bool exists = false;
            var items = (Model.Enums.Genre[])comboBox.DataSource;
            exists = items.Any(g => g.ToString().Equals(input, StringComparison.OrdinalIgnoreCase));

            if (exists)
            {
                // Находим соответствующий элемент и устанавливаем его как выбранный
                var matchedItem = items.First(g => g.ToString().Equals(input, StringComparison.OrdinalIgnoreCase));
                comboBox.SelectedItem = matchedItem; // Устанавливаем выбранный элемент
                comboBox.BackColor = SystemColors.Window; // Подсветка в норму
            }
            else
            {
                // Нет такого элемента — подсветка красным
                comboBox.BackColor = Color.LightPink;
                // Можно оставить SelectedItem как есть или сбросить:
                // comboBox.SelectedItem = null;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isEditingAllowed && _selectedMovie != null)
            {
                UpdateIntLimitsProperty((value) => _selectedMovie.Rating = value, RatingTextBox);
            }
        }

        private void DurationInMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isEditingAllowed && _selectedMovie != null)
            {
                UpdateIntLimitsProperty((value) => _selectedMovie.DurationInMinutes = value, DurationInMinutesTextBox);
            }
        }

        /// <summary>
        /// Обновляет свойства фильма на основе текста из TextBox с проверками.
        /// </summary>
        /// <param name="textBox">Текстовое поле для ввода.</param>
        /// <param name="length">Максимальная длина названия.</param>
        /// <param name="updateAction">Делегат для обновления свойства фильма.</param>
        private void UpdateMovieNameProperty(TextBox textBox, int length, Action<string> updateAction)
        {
            try
            {
                string value = textBox.Text;
                if (!"ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(value[0])) throw new ArgumentOutOfRangeException();
                if (value.Length > length) throw new ArgumentOutOfRangeException();
                updateAction(value);
                textBox.BackColor = SystemColors.Window;
            }
            catch
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Обновляет целочисленное свойство фильма на основе текста из TextBox.
        /// </summary>
        /// <param name="updateAction">Делегат для обновления свойства.</param>
        /// <param name="textBox">Текстовое поле для ввода.</param>
        private void UpdateIntLimitsProperty(Action<int> updateAction, TextBox textBox)
        {
            try
            {
                if (int.TryParse(textBox.Text, out int value))
                {
                    updateAction(value);
                    textBox.BackColor = SystemColors.Window;
                }
                else
                {
                    textBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private bool ValidateComboBoxInput(ComboBox comboBox, string input)
        {
            Model.Enums.Genre[] items = (Model.Enums.Genre[])comboBox.DataSource;
            bool exists = items.Any(g => g.ToString().Equals(input, StringComparison.OrdinalIgnoreCase));

            if (exists)
                comboBox.BackColor = SystemColors.Window;
            else
                comboBox.BackColor = Color.LightPink;

            return exists;
        }

        private bool ValidateInputs(out string errorMessage)
        {
            errorMessage = "";
            bool isValid = true;

            // Название
            if (string.IsNullOrWhiteSpace(TitleTextBox.Text) || TitleTextBox.Text.Length > 100)
            {
                isValid = false;
                HighlightControl(TitleTextBox);
                errorMessage += "Некорректное название.\n";
            }
            else ResetHighlight(TitleTextBox);

            // Год выпуска
            if (!int.TryParse(ReleaseYearTextBox.Text, out int year) || year <= 0)
            {
                isValid = false;
                HighlightControl(ReleaseYearTextBox);
                errorMessage += "Некорректный год.\n";
            }
            else ResetHighlight(ReleaseYearTextBox);

            // Жанр - выбран ли?
            if (GenreComboBox.SelectedIndex == -1)
            {
                isValid = false;
                HighlightControl(GenreComboBox);
                errorMessage += "Выберите жанр.\n";
            }
            else ResetHighlight(GenreComboBox);

            // Рейтинг
            if (!double.TryParse(RatingTextBox.Text, out double rating) || rating < 0 || rating > 10)
            {
                isValid = false;
                HighlightControl(RatingTextBox);
                errorMessage += "Некорректный рейтинг.\n";
            }
            else ResetHighlight(RatingTextBox);

            // Продолжительность
            if (!int.TryParse(DurationInMinutesTextBox.Text, out int duration) || duration < 1 || duration > 300)
            {
                isValid = false;
                HighlightControl(DurationInMinutesTextBox);
                errorMessage += "Некорректная продолжительность.\n";
            }
            else ResetHighlight(DurationInMinutesTextBox);

            return isValid;
        }

        private void HighlightControl(Control control)
        {
            control.BackColor = Color.LightPink;
            control.Focus(); // Можно добавить подсказку через ToolTip
        }

        private void ResetHighlight(Control control)
        {
            control.BackColor = SystemColors.Window;
        }

        private void ReloadMovieData()
        {
            if (_selectedMovie == null)
                return;

            // Для каждого поля проверяем цвет
            if (TitleTextBox.BackColor == Color.LightPink)
                TitleTextBox.Text = _selectedMovie.Title;

            if (ReleaseYearTextBox.BackColor == Color.LightPink)
                ReleaseYearTextBox.Text = _selectedMovie.ReleaseYear.ToString();

            if (GenreComboBox.BackColor == Color.LightPink)
                GenreComboBox.SelectedItem = _selectedMovie.Genre;
                GenreComboBox.Text = _selectedMovie.Genre;

            if (RatingTextBox.BackColor == Color.LightPink)
                RatingTextBox.Text = _selectedMovie.Rating.ToString();

            if (DurationInMinutesTextBox.BackColor == Color.LightPink)
                DurationInMinutesTextBox.Text = _selectedMovie.DurationInMinutes.ToString();
        }

        private void ResetAllFieldHighlights()
        {
            TitleTextBox.BackColor = SystemColors.Window;
            ReleaseYearTextBox.BackColor = SystemColors.Window;
            GenreComboBox.BackColor = SystemColors.Window;
            RatingTextBox.BackColor = SystemColors.Window;
            DurationInMinutesTextBox.BackColor = SystemColors.Window;
        }

        private void EditMovieButton_Click(object sender, EventArgs e)
        {
            if (!_isEditingAllowed)
            {
                // Включить режим редактирования
                SetFieldsEditable(true);
                _isEditingAllowed = true;
                EditMovieButton.Text = "Lock"; // или "Заблокировать"
            }
            else
            {
                // Выйти из режима редактирования
                SetFieldsEditable(false);
                _isEditingAllowed = false;
                EditMovieButton.Text = "Edit";
                ReloadMovieData();
                ResetAllFieldHighlights();

                // Обновляем данные выбранного фильма из полей (если нужно сохранять изменения)
                /*
                if (_selectedMovie != null)
                {
                    _selectedMovie.Title = TitleTextBox.Text;
                    if (int.TryParse(ReleaseYearTextBox.Text, out int year))
                        _selectedMovie.ReleaseYear = year;

                    if (GenreComboBox.SelectedItem != null)
                        _selectedMovie.Genre = GenreComboBox.SelectedItem.ToString();

                    if (double.TryParse(RatingTextBox.Text, out double rating))
                        _selectedMovie.Rating = rating;

                    if (int.TryParse(DurationInMinutesTextBox.Text, out int duration))
                        _selectedMovie.DurationInMinutes = duration;

                    // Можно обновить список или интерфейс, если нужно
                    RefreshMoviesList();
                }
                */
            }
        }

        private void DisplayMovieDetails(Movie movie)
        {
            TitleTextBox.Text = movie.Title;
            ReleaseYearTextBox.Text = movie.ReleaseYear.ToString();
            GenreComboBox.SelectedItem = movie.Genre;
            RatingTextBox.Text = movie.Rating.ToString();
            DurationInMinutesTextBox.Text = movie.DurationInMinutes.ToString();
        }

        private void SaveChanges()
        {
            if (MoviesListBox.SelectedItem is Movie selectedMovie)
            {
                if (!ValidateInputs(out string error))
                {
                    MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                selectedMovie.Title = TitleTextBox.Text.Trim();
                selectedMovie.ReleaseYear = int.Parse(ReleaseYearTextBox.Text);
                selectedMovie.Genre = GenreComboBox.SelectedItem.ToString();
                selectedMovie.Rating = double.Parse(RatingTextBox.Text);
                selectedMovie.DurationInMinutes = int.Parse(DurationInMinutesTextBox.Text);

                SortAndDisplayMovies();

                // Обновляем выбранный элемент
                MoviesListBox.SelectedItem = selectedMovie;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Movie newMovie = new Movie();

            if (!ValidateInputs(out string error))
            {
                MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            newMovie.Title = TitleTextBox.Text.Trim();
            newMovie.ReleaseYear = int.Parse(ReleaseYearTextBox.Text);
            newMovie.Genre = GenreComboBox.SelectedItem.ToString();
            newMovie.Rating = double.Parse(RatingTextBox.Text);
            newMovie.DurationInMinutes = int.Parse(DurationInMinutesTextBox.Text);

            _movies.Add(newMovie);
            SortAndDisplayMovies();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedItem is Movie selectedMovie)
            {
                _movies.Remove(selectedMovie);
                SortAndDisplayMovies();

                // Очистка деталей
                ClearDetails();
            }
        }

        private void ClearDetails()
        {
            TitleTextBox.Clear();
            ReleaseYearTextBox.Clear();
            GenreComboBox.SelectedIndex = -1;
            RatingTextBox.Clear();
            DurationInMinutesTextBox.Clear();
        }
    }
}
