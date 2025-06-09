using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Пользовательский контроль для отображения и редактирования информации о фильмах.
    /// </summary>
    public partial class MoviesInformationUserControl : UserControl
    {
        /// <summary>
        /// Экземпляр объекта Random для генерации случайных данных.
        /// </summary>
        private readonly Random random = new Random();

        /// <summary>
        /// Массив фильмов.
        /// </summary>
        private Model.Movie[] _movies;

        /// <summary>
        /// Текущий выбранный фильм.
        /// </summary>
        private Model.Movie _currentMovie;

        /// <summary>
        /// Конструктор, инициализирующий контроль, генерирующий фильмы и заполняющий список.
        /// </summary>
        public MoviesInformationUserControl()
        {
            InitializeComponent();
            InitializeMovies();
            PopulateMoviesListBox();
        }

        /// <summary>
        /// Инициализация массива фильмов с случайными данными.
        /// </summary>
        private void InitializeMovies()
        {
            _movies = new Model.Movie[5];

            for (int i = 0; i < _movies.Length; i++)
            {
                // Генерация случайного названия
                string title = GenerateName(3, 12);
                // Генерация случайной продолжительности
                int durationInMinutes = random.Next(1, 200);
                // Генерация случайного года выпуска
                int releaseYear = random.Next(1888, 2026);
                // Название жанра по умолчанию — Comedy
                string genre = Convert.ToString(Model.Genre.Comedy);
                // Генерация случайного рейтинга
                double rating = random.Next(0, 11);

                // Создание нового фильма с сгенерированными параметрами
                _movies[i] = new Model.Movie(title, durationInMinutes, releaseYear, genre, rating);
            }
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

        /// <summary>
        /// Заполняет MoviesListBox фильмами.
        /// </summary>
        private void PopulateMoviesListBox()
        {
            MoviesListBox.Items.Clear();

            foreach (Movie movie in _movies)
            {
                MoviesListBox.Items.Add($"{movie.Title}");
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

        /// <summary>
        /// Обновляет числовое свойство типа double на основе текста из TextBox.
        /// </summary>
        /// <param name="updateAction">Делегат для обновления свойства.</param>
        /// <param name="textBox">Текстовое поле для ввода.</param>
        private void UpdateDoubleLimitsProperty(Action<double> updateAction, TextBox textBox)
        {
            try
            {
                if (double.TryParse(textBox.Text, out double value))
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
        /// Обновляет свойство перечисления по имени из TextBox.
        /// </summary>
        /// <typeparam name="EnumType">Тип перечисления.</typeparam>
        /// <param name="textBox">Текстовое поле для ввода.</param>
        /// <param name="updateAction">Делегат для обновления свойства.</param>
        private void UpdateEnumTypeProperty<EnumType>(TextBox textBox, Action<string> updateAction) where EnumType : struct, Enum
        {
            try
            {
                string value = textBox.Text.Trim();

                if (double.TryParse(value, out _))
                {
                    throw new ArgumentException($"Invalid {typeof(EnumType).Name} name.");
                }

                if (Enum.IsDefined(typeof(EnumType), value))
                {
                    updateAction(value);
                    textBox.BackColor = SystemColors.Window;
                }
                else
                {
                    throw new ArgumentException($"Invalid {typeof(EnumType).Name} name.");
                }
            }
            catch
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик изменения выбранного элемента в списке фильмов.
        /// Обновляет текущий фильм и отображает его данные в полях.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex >= 0)
            {
                _currentMovie = _movies[MoviesListBox.SelectedIndex];
                UpdateMovieFiledsTextBoxes();
            }
        }

        /// <summary>
        /// Обновляет текстовые поля формы данными текущего выбранного фильма.
        /// </summary>
        private void UpdateMovieFiledsTextBoxes()
        {
            TitleTextBox.Text = _currentMovie.Title;
            DurationInMinutesTextBox.Text = _currentMovie.DurationInMinutes.ToString();
            ReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            GenreTextBox.Text = _currentMovie.Genre.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        /// <summary>
        /// Обработчик изменения текста в поле Название фильма.
        /// Проверяет и обновляет название текущего фильма.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex >= 0)
            {
                UpdateMovieNameProperty(TitleTextBox, 156, (value) => _currentMovie.Title = value);
                PopulateMoviesListBox();
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле Продолжительность.
        /// Проверяет и обновляет продолжительность фильма.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void DurationInMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) => _currentMovie.DurationInMinutes = (int)value, DurationInMinutesTextBox);
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле Год выпуска.
        /// Проверяет и обновляет год выпуска фильма.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) => _currentMovie.ReleaseYear = value, ReleaseYearTextBox);
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле Жанр.
        /// Проверяет и обновляет жанр фильма по имени перечисления.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex >= 0)
            {
                UpdateEnumTypeProperty<Model.Genre>(GenreTextBox, (value) => _currentMovie.Genre = value);
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле Рейтинг.
        /// Проверяет и обновляет рейтинг фильма.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) => _currentMovie.Rating = value, RatingTextBox);
            }

        }

        /// <summary>
        /// Ищет индекс фильма с максимальным рейтингом среди массива фильмов.
        /// </summary>
        /// <returns>
        /// Индекс фильма с максимальным рейтингом, или -1, если массив пуст.
        /// </returns> 
        private int FindMovieWithMaxRating()
        {
            // Проверка на пустой массив фильмов
            if (_movies.Length == 0)
            {
                return -1; // Возвращаем -1 при отсутствии фильмов
            }

            int maxIndex = 0;
            double maxRating = _movies[0].Rating;

            for (int i = 1; i < _movies.Length; i++)
            {
                if (_movies[i].Rating > maxRating)
                {
                    maxRating = _movies[i].Rating;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки поиска фильма с максимальным рейтингом.
        /// Вызывает метод поиска и выделяет соответствующий элемент в списке.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие (обычно кнопка).</param>
        /// <param name="e">Аргументы события.</param>
        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int index = FindMovieWithMaxRating();
            MoviesListBox.SelectedIndex = index;
        }
    }
}
