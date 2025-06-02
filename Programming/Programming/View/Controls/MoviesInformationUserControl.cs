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
    public partial class MoviesInformationUserControl : UserControl
    {
        // Экземпляр обЪекта random вынесен для удобства
        private readonly Random random = new Random();
        // Массив фильмов
        private Model.Movie[] _movies;
        // Текущий фильм
        private Model.Movie _currentMovie;

        public MoviesInformationUserControl()
        {
            InitializeComponent();
            InitializeMovies();
            PopulateMoviesListBox();
        }

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
                // Выбор жанра по умолчанию из перечисления: Comedy
                string genre = Convert.ToString(Model.Genre.Comedy);
                // Генерация случайного рейтинга
                double rating = random.Next(0, 11);

                // Создание нового объекта фильма с сгенерированными параметрами и добавление его в массив _movies
                _movies[i] = new Model.Movie(title, durationInMinutes, releaseYear, genre, rating);
            }
        }

        private string GenerateName(int lowerLimit, int upperLimit)
        {
            // Генерация случайного названия
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string name = "";
            int nameLenght = random.Next(lowerLimit, upperLimit);

            for (int i = 0; i < nameLenght; i++)
            {
                int symbol = random.Next(26);
                name += alphabet.ElementAt(symbol);
                if (i == 0)
                {
                    name = name.ToUpper();
                }
            }
            return name;
        }

        private void PopulateMoviesListBox()
        {
            // Очистка списка перед добавлением новых элементов
            MoviesListBox.Items.Clear();

            foreach (var movie in _movies)
            {
                // Добавление имени в нужном формате
                MoviesListBox.Items.Add($"{movie.Title}");
            }
        }

        // Новая функция с задаваемыми лимитами
        private void UpdateIntLimitsProperty(Action<int> updateAction, TextBox textBox)
        {
            // Пытаемся преобразовать текст в целое число
            if (int.TryParse(textBox.Text, out int value))
            {
                // Если успешно, вызываем делегат для обновления свойства
                updateAction(value);
                // Восстанавливаем стандартный цвет фона
                textBox.BackColor = SystemColors.Window;
            }
            else
            {
                // Если не удалось преобразовать, выделяем поле розовым
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void UpdateDoubleLimitsProperty(Action<double> updateAction, TextBox textBox)
        {
            // Пытаемся преобразовать текст в число с плавающей точкой
            if (double.TryParse(textBox.Text, out double value))
            {
                // Если успешно, вызываем делегат для обновления свойства
                updateAction(value);
                // Восстанавливаем стандартный цвет фона
                textBox.BackColor = SystemColors.Window;
            }
            else
            {
                // Если не удалось преобразовать, выделяем поле розовым
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        // Функция для валидации текстбоксов ColorTextBox и GenreTextBox
        private void UpdateEnumTypeProperty<EnumType>(TextBox textBox, Action<string> updateAction) where EnumType : struct, Enum
        {

            try
            {
                // Проверяет является ли текст текстбокса элементом перечисления
                string value = textBox.Text;
                if (Enum.TryParse(value.Trim(), true, out EnumType result))
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

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex >= 0)
            {
                _currentMovie = _movies[MoviesListBox.SelectedIndex];
                UpdateMovieFiledsTextBoxes();
            }
        }

        private void UpdateMovieFiledsTextBoxes()
        {
            TitleTextBox.Text = _currentMovie.Title;
            DurationInMinutesTextBox.Text = _currentMovie.DurationInMinutes.ToString();
            ReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            GenreTextBox.Text = _currentMovie.Genre.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        // Самое длинное название фильма = 156 символов
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex >= 0)
            {
                UpdateMovieNameProperty(TitleTextBox, 156, (value) => _currentMovie.Title = value);
            }
        }

        private void DurationInMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) => _currentMovie.DurationInMinutes = (int)value, DurationInMinutesTextBox);
            }
        }

        // Самый ранний фильм датируется 1888 годом
        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) => _currentMovie.ReleaseYear = value, ReleaseYearTextBox);
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex >= 0)
            {
                UpdateEnumTypeProperty<Genre>(GenreTextBox, (value) => _currentMovie.Genre = value);
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((vlue) => _currentMovie.Rating = vlue, RatingTextBox);
            }

        }

        private void UpdateMovieNameProperty(TextBox textBox, int length, Action<string> updateAction)
        {
            try
            {
                //string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                // Название должно начинаться с заглавной буквы
                string value = textBox.Text;
                if (!"ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(textBox.Text[0])) throw new ArgumentOutOfRangeException();
                if (value.Length > length) throw new ArgumentOutOfRangeException();
                updateAction(value);
                textBox.BackColor = SystemColors.Window;
            }
            catch
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private int FindMovieWithMaxRating()
        {
            // Проверка на пустой массив
            if (_movies.Length == 0)
            {
                // Возвращаем -1, если массив пустой
                return -1;
            }

            // Индекс фильма с максимальным рейтингом
            int maxIndex = 0;
            // Начальный макксимальый рейтинг
            double maxRating = _movies[0].Rating;

            for (int i = 1; i < _movies.Length; i++)
            {
                // Если текущая ширина больше максимальной
                if (_movies[i].Rating > maxRating)
                {
                    // Обновляем максимальную ширину
                    maxRating = _movies[i].Rating;
                    // Обновляем индекс
                    maxIndex = i;
                }
            }
            // Возвращаем индекс фильма с наибольшим рейтингом
            return maxIndex;
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int index = FindMovieWithMaxRating();
            MoviesListBox.SelectedIndex = index;
        }
    }
}
