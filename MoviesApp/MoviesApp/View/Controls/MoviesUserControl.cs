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
using static System.Windows.Forms.LinkLabel;

namespace MoviesApp.View.Controls
{
    /// <summary>
    /// Пользовательский контроль для управления и отображения списка фильмов.
    /// </summary>
    public partial class MoviesUserControl : UserControl
    {
        /// <summary>
        /// Генерирует случайные числа для различных внутренних целей.
        /// </summary>
        private readonly Random random = new Random();

        /// <summary>
        /// Список объектов Movie, содержащих информацию о фильмах.
        /// </summary>
        private List<Movie> _movies = new List<Movie>();

        /// <summary>
        /// Текущий выбранный фильм, отображаемый или редактируемый в интерфейсе.
        /// </summary>
        private Movie _selectedMovie;

        /// <summary>
        /// Путь к CSV файлу для хранения данных о фильмах.
        /// </summary>
        private readonly string _dataFilePath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
    "MoviesApp",
    "movies.csv");

        /// <summary>
        /// Флаг, разрешающий или запрещающий редактирование данных.
        /// </summary>
        private bool _isEditingAllowed = false;

        /// <summary>
        /// Конструктор класса: инициализация компонентов и загрузка данных.
        /// </summary>
        public MoviesUserControl()
        {
            InitializeComponent();
            FillGenreComboBox();
            LoadData();
        }

        /// <summary>
        /// Заполняет ComboBox по жанрам фильмам, используя перечисление Model.Enums.Genre.
        /// </summary>
        private void FillGenreComboBox()
        {
            // Заполняем ComboBox значениями enum Genre
            GenreComboBox.DataSource = Enum.GetValues(typeof(Model.Enums.Genre));
            // Устанавливаем пустой выбранный элемент
            GenreComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Обновляет отображение выбранного фильма в списке ListBox.
        /// </summary>
        private void UpdateSelectedMovieInList()
        {
            int selectedIndex = MoviesListBox.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= _movies.Count)
                return;

            // Обновляем объект фильма в списке
            Movie movie = _movies[selectedIndex];

            // Обновляем отображаемый текст в списке
            MoviesListBox.Items[selectedIndex] = $"{movie.Title}/{movie.ReleaseYear}/{movie.Genre}";
        }

        /// <summary>
        /// Сохраняет текущий список фильмов в CSV файл.
        /// </summary>
        public void SaveData()
        {
            List<string> lines = new List<string>();
            foreach (Movie movie in _movies)
            {
                // Формируем строку для CSV: Title,ReleaseYear,Genre,Rating,DurationInMinutes
                string line = $"{EscapeCsv(movie.Title)},{movie.ReleaseYear},{EscapeCsv(movie.Genre)},{movie.Rating},{movie.DurationInMinutes}";
                lines.Add(line);
            }
            File.WriteAllLines(_dataFilePath, lines);
        }

        /// <summary>
        /// Вспомогательный метод для экранирования строк, содержащих запятые или кавычки, для CSV.
        /// </summary>
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

        /// <summary>
        /// Загружает данные из CSV файла и визуализирует список фильмов.
        /// </summary>
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

        /// <summary>
        /// Простая парсилка строки CSV с учетом кавычек.
        /// </summary>
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
                        // Экранированная кавычка
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
            // Добавляем последний элемент
            result.Add(currentField.ToString());
            return result.ToArray();
        }

        /// <summary>
        /// Сортирует список фильмов по названию и отображает их в ListBox.
        /// </summary>
        private void SortAndDisplayMovies()
        {
            // Запоминаем выбранный элемент
            object selectedItem = MoviesListBox.SelectedItem;

            // Сортируем список по названию
            _movies = _movies.OrderBy(m => m.Title).ToList();

            // Очищаем список элементов ListBox
            MoviesListBox.Items.Clear();

            // Добавляем отсортированные фильмы в список
            foreach (Movie movie in _movies)
            {
                MoviesListBox.Items.Add($"{movie.Title}/{movie.ReleaseYear}/{movie.Genre}");
            }

            // Восстанавливаем выбранный элемент, если он был
            if (selectedItem != null)
            {
                int index = -1;
                string itemString = selectedItem.ToString();
                for (int i = 0; i < _movies.Count; i++)
                {
                    if ($"{_movies[i].Title}/{_movies[i].ReleaseYear}/{_movies[i].Genre}" == itemString)
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

        /// <summary>
        /// Устанавливает выбранный элемент ComboBox по названию жанра.
        /// </summary>
        /// <param name="genreName">Название жанра, которое нужно установить.</param>
        private void SetGenreSelectedItem(string genreName)
        {
            Model.Enums.Genre[] genres = (Model.Enums.Genre[])GenreComboBox.DataSource;
            int index = Array.FindIndex(genres, g => g.ToString() == genreName);
            if (index >= 0)
            {
                GenreComboBox.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Обработчик изменения выбранного элемента ListBox.
        /// Загружает данные выбранного фильма в поля ввода.
        /// </summary>
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = MoviesListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _movies.Count)
            {
                _selectedMovie = _movies[selectedIndex];

                // Заполняем поля данными выбранного фильма
                TitleTextBox.Text = _selectedMovie.Title;
                ReleaseYearTextBox.Text = Convert.ToString(_selectedMovie.ReleaseYear);
                // Устанавливаем жанр в ComboBox с учетом особенности
                SetGenreSelectedItem(_selectedMovie.Genre);
                RatingTextBox.Text = Convert.ToString(_selectedMovie.Rating);
                DurationInMinutesTextBox.Text = Convert.ToString(_selectedMovie.DurationInMinutes);
            }
        }

        /// <summary>
        /// Обработчик изменения текста в TextBox для названия фильма.
        /// Обновляет свойство фильма, если разрешено редактирование.
        /// </summary>
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

        /// <summary>
        /// Обработчик изменения текста в TextBox для года выпуска.
        /// Обновляет свойство фильма, если разрешено редактирование.
        /// </summary>
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

        /// <summary>
        /// Обработчик изменения выбранного пункта ComboBox жанра.
        /// Обновляет свойство жанра в текущем фильме.
        /// </summary>
        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isEditingAllowed && _selectedMovie != null && MoviesListBox.SelectedIndex >= 0)
            {
                _selectedMovie.Genre = GenreComboBox.SelectedItem.ToString();
            }
            UpdateSelectedMovieInList();
        }

        /// <summary>
        /// Обработчик изменения текста в Rating TextBox.
        /// Обновляет рейтинг фильма при разрешении редактирования.
        /// </summary>
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isEditingAllowed && _selectedMovie != null && MoviesListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) => _selectedMovie.Rating = value, RatingTextBox);
            }
        }

        /// <summary>
        /// Обработчик изменения текста в Duration TextBox.
        /// Обновляет продолжительность фильма при разрешении редактирования.
        /// </summary>
        private void DurationInMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isEditingAllowed && _selectedMovie != null && MoviesListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) => _selectedMovie.DurationInMinutes = value, DurationInMinutesTextBox);
            }
        }

        /// <summary>
        /// Обновляет название свойства фильма на основе текста в TextBox с проверками.
        /// </summary>
        /// <param name="textBox">Текстовое поле для ввода названия.</param>
        /// <param name="length">Максимальная длина названия.</param>
        /// <param name="updateAction">Делегат для обновления свойства фильма.</param>
        private void UpdateMovieNameProperty(TextBox textBox, int length, Action<string> updateAction)
        {
            try
            {
                string value = textBox.Text;
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentOutOfRangeException();

                // Можно добавить более строгие проверки, если нужно
                if (value.Length > length)
                    throw new ArgumentOutOfRangeException();

                // пример проверки на первую букву (можно заменить или убрать)
                if (!char.IsLetter(value[0]))
                    throw new ArgumentOutOfRangeException();

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

        /// <summary>
        /// Обновляет поля данных о фильме на базе текущего выбранного объекта, только если соответствующие поля подсвечены LightPink.
        /// </summary>
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
            {
                GenreComboBox.SelectedItem = _selectedMovie.Genre;
                GenreComboBox.Text = _selectedMovie.Genre;
            }

            if (RatingTextBox.BackColor == Color.LightPink)
                RatingTextBox.Text = _selectedMovie.Rating.ToString();

            if (DurationInMinutesTextBox.BackColor == Color.LightPink)
                DurationInMinutesTextBox.Text = _selectedMovie.DurationInMinutes.ToString();
        }

        /// <summary>
        /// Сбрасывает все подсветки полей редактирования к стандартному виду.
        /// </summary>
        private void ResetAllFieldHighlights()
        {
            TitleTextBox.BackColor = SystemColors.Window;
            ReleaseYearTextBox.BackColor = SystemColors.Window;
            GenreComboBox.BackColor = SystemColors.Window;
            RatingTextBox.BackColor = SystemColors.Window;
            DurationInMinutesTextBox.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Обработчик нажатия на кнопку для переключения режима редактирования фильма.
        /// Включает или выключает режим редактирования.
        /// </summary>
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

        /// <summary>
        /// Устанавливает свойства полей формы, делая их доступными или недоступными для редактирования.
        /// </summary>
        /// <param name="editable">Если true, поля доступны для редактирования, иначе — недоступны.</param>
        private void SetFieldsEditable(bool editable)
        {
            TitleTextBox.Enabled = editable;
            ReleaseYearTextBox.Enabled = editable;
            GenreComboBox.Enabled = editable;
            RatingTextBox.Enabled = editable;
            DurationInMinutesTextBox.Enabled = editable;
        }

        /// <summary>
        /// Обработчик нажатия на кнопку добавления нового фильма.
        /// Создаёт фильм со случайными данными и добавляет его в список и отображение.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Генерация случайных данных
            string title = $"NewMovie {_movies.Count}";
            int durationInMinutes = random.Next(1, 300);
            int releaseYear = random.Next(1888, DateTime.Now.Year);
            string genre = GenerateGenre();
            double rating = random.Next(0, 11);

            // Создаём новый фильм
            Movie newMovie = new Model.Movie(title, durationInMinutes, releaseYear, genre, rating);

            // Добавляем в список и UI
            _movies.Add(newMovie);
            MoviesListBox.Items.Add(newMovie);
            MoviesListBox.SelectedIndex = _movies.Count - 1;
            SortAndDisplayMovies();
        }

        /// <summary>
        /// Генерирует случайное название из букв алфавита заданной длины.
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

        /// <summary>
        /// Генерирует случайное название жанра из перечисления Enum.
        /// </summary>
        /// <returns>Строковое представление жанра.</returns>
        private string GenerateGenre()
        {
            Array genres = Enum.GetValues(typeof(Model.Enums.Genre));
            Model.Enums.Genre randomGenre = (Model.Enums.Genre)genres.GetValue(random.Next(genres.Length));
            string genreString = randomGenre.ToString();
            return genreString;
        }

        /// <summary>
        /// Обработчик нажатия на кнопку удаления выбранного фильма.
        /// Удаляет фильм из списка и обновляет UI.
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex != -1)
            {
                int selectedIndex = MoviesListBox.SelectedIndex;
                _movies.RemoveAt(selectedIndex);
                MoviesListBox.Items.RemoveAt(selectedIndex);
                MoviesListBox.SelectedIndex = selectedIndex - 1;
                SortAndDisplayMovies();

                if (MoviesListBox.SelectedIndex == -1)
                {
                    ClearMovieDetails();
                }
            }
        }

        /// <summary>
        /// Очищает поля отображения деталей выбранного фильма и сбрасывает ссылку на фильм.
        /// </summary>
        private void ClearMovieDetails()
        {
            _selectedMovie = null;
            TitleTextBox.Clear();
            ReleaseYearTextBox.Clear();
            GenreComboBox.SelectedIndex = -1;
            RatingTextBox.Clear();
            DurationInMinutesTextBox.Clear();
        }
    }
}
