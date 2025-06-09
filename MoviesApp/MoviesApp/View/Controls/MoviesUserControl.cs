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
        private readonly Random random = new Random();
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

        private void FillGenreComboBox()
        {
            // Заполняем ComboBox значениями enum
            GenreComboBox.DataSource = Enum.GetValues(typeof(Model.Enums.Genre));
            // Выбираем пустой элемент
            GenreComboBox.SelectedIndex = -1;
        }

        private void UpdateSelectedMovieInList()
        {
            int selectedIndex = MoviesListBox.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= _movies.Count)
                return; 

            // Обновляем ваш объект в списке _movies
            Movie movie = _movies[selectedIndex];

            // Теперь обновляем только выбранную строку в листбоксе
            MoviesListBox.Items[selectedIndex] = $"{movie.Title}/{movie.ReleaseYear}/{movie.Genre}";
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
            // Запоминаем текущий выбранный элемент
            Object selectedItem = MoviesListBox.SelectedItem;

            // Сортируем список по названию
            _movies = _movies.OrderBy(m => m.Title).ToList();

            // Очищаем список элементов ListBox
            MoviesListBox.Items.Clear();

            // Добавляем отсортированные фильмы в ListBox в нужном формате
            foreach (Movie movie in _movies)
            {
                MoviesListBox.Items.Add($"{movie.Title}/{movie.ReleaseYear}/{movie.Genre}");
            }

            // Восстанавливаем выбранный элемент, если он был
            if (selectedItem != null)
            {
                int index = -1;
                // Находим индекс совпадающего элемента в новом списке
                for (int i = 0; i < _movies.Count; i++)
                {
                    string itemString = $"{_movies[i].Title}/{_movies[i].ReleaseYear}/{_movies[i].Genre}";
                    if (itemString == selectedItem.ToString())
                    {
                        index = i;
                        break;
                    }
                }

                if (index != -1)
                {
                    MoviesListBox.SelectedIndex = index;
                }
            }
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
            if (_isEditingAllowed && _selectedMovie != null && MoviesListBox.SelectedIndex >= 0)
            {
                UpdateMovieNameProperty(TitleTextBox, 100, (value) => _selectedMovie.Title = value);
            }
            if (TitleTextBox.BackColor == SystemColors.Window)
            {
                UpdateSelectedMovieInList();
                SortAndDisplayMovies();
            }
        }

        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isEditingAllowed && _selectedMovie != null && MoviesListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) => _selectedMovie.ReleaseYear = value, ReleaseYearTextBox);
            }
            if (ReleaseYearTextBox.BackColor == SystemColors.Window)
            {
                UpdateSelectedMovieInList();
            }
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isEditingAllowed && _selectedMovie != null && MoviesListBox.SelectedIndex >=0)
            {
                _selectedMovie.Genre = GenreComboBox.SelectedItem.ToString();
            }
            UpdateSelectedMovieInList();
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isEditingAllowed && _selectedMovie != null && MoviesListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) => _selectedMovie.Rating = value, RatingTextBox);
            }
        }

        private void DurationInMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isEditingAllowed && _selectedMovie != null && MoviesListBox.SelectedIndex >= 0)
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
            }
        }

        // Метод для управления доступностью полей
        private void SetFieldsEditable(bool editable)
        {
            TitleTextBox.Enabled = editable;
            ReleaseYearTextBox.Enabled = editable;
            GenreComboBox.Enabled = editable;
            RatingTextBox.Enabled = editable;
            DurationInMinutesTextBox.Enabled = editable;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Генерация случайных данных
            //string title = GenerateName(3, 12);
            string title = $"NewMovie {_movies.Count}";
            int durationInMinutes = random.Next(1, 300);
            int releaseYear = random.Next(1888, DateTime.Now.Year);
            string genre = GenerateGenre();
            double rating = random.Next(0, 11);

            // Создаём новый фильм с этими данными
            Movie newMovie = new Model.Movie(title, durationInMinutes, releaseYear, genre, rating);

            // Добавляем новый фильм в список
            _movies.Add(newMovie);
            // Добавляем новый фильм в MoviesListBox
            MoviesListBox.Items.Add(newMovie);
            // Выбираем новый фильм
            MoviesListBox.SelectedIndex = _movies.Count - 1;
            // Сортируем список с новым фильмом
            SortAndDisplayMovies();  
        }

        /// <summary>
        /// Генерирует случайное название из букв алфавита.
        /// </summary>
        /// <param name="lowerLimit">Минимальная длина названия.</param>
        /// <param name="upperLimit">Максимальная длина названия.</param>
        /// <returns>Случайное название.</returns>
        private string GenerateName(int lowerLimit, int upperLimit)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string name = "";
            int nameLength = random.Next(lowerLimit, upperLimit);

            for (int i = 0; i < nameLength; i++)
            {
                int symbolIndex = random.Next(26);
                name += alphabet.ElementAt(symbolIndex);
                if (i == 0)
                {
                    name = name.ToUpper();
                }
            }
            return name;
        }

        private string GenerateGenre()
        {
            Array genres = Enum.GetValues(typeof(Model.Enums.Genre));
            Model.Enums.Genre randomGenre = (Model.Enums.Genre)genres.GetValue(random.Next(genres.Length));
            string genreString = randomGenre.ToString();
            return genreString;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Проверяем, что вообще что-то выбрано
            if (MoviesListBox.SelectedIndex != -1) 
            {
                // Индекс выбранного объекта
                int selectedIndex = MoviesListBox.SelectedIndex;
                // Удаляем из _movies
                _movies.RemoveAt(selectedIndex);
                // Удаляем из ListBox
                MoviesListBox.Items.RemoveAt(selectedIndex);
                // Выбираем новый элемент
                MoviesListBox.SelectedIndex = selectedIndex - 1;
                //Обновляет список фильмов в ListBox
                SortAndDisplayMovies(); 

                // Очистка деталей если нет выбранного элемента
                if (MoviesListBox.SelectedIndex == -1)
                {
                    ClearMovieDetails();
                }
            }
        }

        private void ClearMovieDetails()
        {
            _selectedMovie = null;
            // Очищение всех боксов с данными фильма
            TitleTextBox.Clear();
            ReleaseYearTextBox.Clear();
            GenreComboBox.SelectedIndex = -1;
            RatingTextBox.Clear();
            DurationInMinutesTextBox.Clear();
        }
    }
}
