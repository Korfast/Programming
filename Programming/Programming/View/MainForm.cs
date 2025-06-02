using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        // Экземпляр обЪекта random вынесен для удобства
        private readonly Random random = new Random();
        // Массив прямоугольников
        private Model.Rectangle[] _rectangles; 
        // Текущий прямоугольник
        private Model.Rectangle _currentRectangle; 
        // Массив фильмов
        private Model.Movie[] _movies;
        // Текущий фильм
        private Model.Movie _currentMovie;
        

        public MainForm()
        {
            InitializeComponent();
            InitializeRectangles();
            InitializeMovies();
            PopulateRectanglesListBox();
            PopulateMoviesListBox();           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeRectangles()
        {
            _rectangles = new Model.Rectangle[5];

            for (int i = 0; i < _rectangles.Length; i++)
            {
                // Создание прямоугольника с помощью класса RectangleFactory
                _rectangles[i] = RectangleFactory.Randomize(10, 100);
            }
        }

        private void PopulateRectanglesListBox()
        {
            // Очистка списка перед добавлением новых элементов
            RectanglesListBox.Items.Clear(); 

            foreach (var rectangle in _rectangles)
            {
                // Добавление имени в нужном формате
                RectanglesListBox.Items.Add($"Rectangle {rectangle.Id}");             }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0)
            {
                _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
                UpdateRectangleFiledsTextBoxes();
            }
        }

        private void UpdateRectangleFiledsTextBoxes()
        {
            IdTextBox.Text = _currentRectangle.Id.ToString();
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) => _currentRectangle.Length = value, LengthTextBox);
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) => _currentRectangle.Width = value, WidthTextBox);
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0)
            {
                UpdateEnumTypeProperty<Model.Color>(ColorTextBox, (value) => _currentRectangle.Color = value);
            }
        }

        // Старая необобщённая функция
        private void UpdateRectangleSizeProperty(TextBox textBox, Action<int> updateAction)
        {
            try
            {
                int value = int.Parse(textBox.Text);
                if (value < 1 || value > 100) throw new ArgumentOutOfRangeException();
                updateAction(value);
                textBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
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

        private int FindRectangleWithMaxWidth()
        {
            // Проверка на пустой массив
            if (_rectangles.Length == 0) 
            {
                // Возвращаем -1, если массив пустой
                return -1; 
            }

            // Индекс прямоугольника с максимальной шириной
            int maxIndex = 0;
            // Начальная максимальная ширина
            double maxWidth = _rectangles[0].Width; 

            for (int i = 1; i < _rectangles.Length; i++)
            {
                // Если текущая ширина больше максимальной
                if (_rectangles[i].Width > maxWidth) 
                {
                    // Обновляем максимальную ширину
                    maxWidth = _rectangles[i].Width;
                    // Обновляем индекс
                    maxIndex = i; 
                }
            }

            // Возвращаем индекс прямоугольника с максимальной шириной
            return maxIndex; 
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth();
            RectanglesListBox.SelectedIndex = index;
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

        // ОТСЮДА начинается 5 лабораторная работа
        
        private void UpdateRectangleInfo(Model.Rectangle rectangle)
        {
            if (rectangle == null)
                return;

            // Обновляем текущий выбранный прямоугольник
            _currentRectangle = rectangle;

            // Обновляем отображение в текстовых полях
            UpdateRectangleFiledsTextBoxes();
            //UpdateRectangleFiledsTextBoxes5();
        }

        private void ClearRectangleInfo()
        {
            // Приведение изменяемых свойств текстбоксов к начальному состоянию

            /*
            IdTextBox5.Text = "";
            IdTextBox5.BackColor = SystemColors.Control;

            XTextBox5.Text = "";
            XTextBox5.BackColor = SystemColors.Control;

            YTextBox5.Text = "";
            YTextBox5.BackColor = SystemColors.Control;

            LengthTextBox5.Text = "";
            LengthTextBox5.BackColor = SystemColors.Window;

            WidthTextBox5.Text = "";
            WidthTextBox5.BackColor = SystemColors.Window;
            */

            IdTextBox.Text = "";
            IdTextBox.BackColor = SystemColors.Control;

            XTextBox.Text = "";
            XTextBox.BackColor = SystemColors.Control;

            YTextBox.Text = "";
            YTextBox.BackColor = SystemColors.Control;

            LengthTextBox.Text = "";
            LengthTextBox.BackColor = SystemColors.Window;

            WidthTextBox.Text = "";
            WidthTextBox.BackColor = SystemColors.Window;

            ColorTextBox.Text = "";
            ColorTextBox.BackColor = SystemColors.Window;
        }

    }
}
