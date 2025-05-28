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
        Random random = new Random();
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
            InitializeEnumsList();
            InitializeSeasonComboBox();
            InitializeRectangles();
            InitializeMovies();
            PopulateRectanglesListBox();
            PopulateMoviesListBox();
            PopulateRectanglesListBox5(); 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
                                      
        private void InitializeEnumsList()
        {
            var enumTypes = Assembly.GetExecutingAssembly().GetTypes().Where
                (type => type.IsEnum && type.Namespace == "Programming.Model").ToList();
            
            EnumsListBox.DataSource = enumTypes;
            EnumsListBox.DisplayMember = "Name";

            if (EnumsListBox.Items.Count > 0)
            {
                EnumsListBox.SelectedIndex = 0;
                UpdateValuesListBox();
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateValuesListBox();
        }

        private void UpdateValuesListBox()
        {

            if (EnumsListBox.SelectedItem != null)
            {
                Type selectedType = ((Type)EnumsListBox.SelectedItem);
                Array values = Enum.GetValues(selectedType);
                ValuesListBox.DataSource = values;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem is Enum selectedValue)
            {
                ValueTextBox.Text = Convert.ToInt32(selectedValue).ToString();
            }
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {   
            //Получение текста из текстового поля
            string inputText = WeekdayTextBox.Text;

            //Попытка разбора текста в перечисление
            if (Enum.TryParse(inputText, out Weekday parsedWeekday))
            {
                // Разбор успешен
                int weekdayValue = (int)parsedWeekday;
                WeekdayLabel.Text = $"Это день недели ({parsedWeekday} = {weekdayValue})";
            }
            else
            {
                // Разбор не успешен
                WeekdayLabel.Text = "Нет такого дня недели";
            }

        }

        private void InitializeSeasonComboBox()
        {
            // Получаем тип перечисления Season
            Type seasonType = typeof(Season);

            // Получаем все значения перечисления Season
            Array seasonValues = Enum.GetValues(seasonType);

            // Устанавливаем источник данных для SeasonComboBox
            SeasonComboBox.DataSource = seasonValues;
            SeasonComboBox.DisplayMember = "Name"; 

            // Устанавливаем выбранный элемент, если есть значения
            if (SeasonComboBox.Items.Count > 0)
            {
                SeasonComboBox.SelectedIndex = 0; 
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            // Получаем выбранное значение из SeasonComboBox
            Season selectedSeason = (Season)SeasonComboBox.SelectedItem;

            // Используем оператор switch-case для выполнения действий в зависимости от выбранного времени года
            switch (selectedSeason)
            {
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;

                case Season.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45"); // Меняем цвет фона на оранжевый
                    break;

                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;

                case Season.Spring:
                    this.BackColor = ColorTranslator.FromHtml("#559c45"); // Меняем цвет фона на зеленый
                    break;

                default:
                    MessageBox.Show("Выберите время года.");
                    break;
            }
        }

        private void InitializeRectangles()
        {
            _rectangles = new Model.Rectangle[5];

            for (int i = 0; i < _rectangles.Length; i++)
            {
                // Генерация случайной длины
                double length = random.Next(1, 100); 
                // Генерация случайной ширины
                double width = random.Next(1, 100);
                // Выбор цвета по умолчанию из перечисления: Red
                string color = Convert.ToString(Model.Color.Red);

                _rectangles[i] = new Model.Rectangle(length, width, color);
            }
        }

        private void PopulateRectanglesListBox()
        {
            // Очистка списка перед добавлением новых элементов
            RectanglesListBox.Items.Clear(); 
            // Счетчик для имен прямоугольников
            int index = 0; 

            foreach (var rectangle in _rectangles)
            {
                // Добавление имени в нужном формате
                RectanglesListBox.Items.Add($"Rectangle {index}"); 
                index++; 
            }
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
            UpdateIntLimitsProperty((value) => _currentRectangle.Length = value, LengthTextBox);
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateIntLimitsProperty((value) => _currentRectangle.Width = value, WidthTextBox);
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateEnumTypeProperty<Model.Color>(ColorTextBox, (value) => _currentRectangle.Color = value);
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
        private void UpdateIntLimitsProperty(Action<int> updateAction, TextBox textBox, int LowerLimit = 0, int UpperLimit = int.MaxValue)
        {
            try
            {
                int value = int.Parse(textBox.Text);
                // Условие отключенно так как значения проверяются внутри классов
                // if (value < LowerLimit || value > UpperLimit) throw new ArgumentOutOfRangeException();
                updateAction(value);
                textBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
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
                    textBox.BackColor = System.Drawing.Color.White;
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
            UpdateMovieNameProperty(TitleTextBox, 156, (value) => _currentMovie.Title = value);
        }

        private void DurationInMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateIntLimitsProperty((value) => _currentMovie.DurationInMinutes = value, DurationInMinutesTextBox);
        }
        
        // Самый ранний фильм датируется 1888 годом
        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateIntLimitsProperty((value) => _currentMovie.ReleaseYear = value, ReleaseYearTextBox, 1888, DateTime.Now.Year);
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateEnumTypeProperty<Genre>(GenreTextBox, (value) => _currentMovie.Genre = value);
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateIntLimitsProperty((vlue) => _currentMovie.Rating = vlue, RatingTextBox, 0, 10);
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
                textBox.BackColor = System.Drawing.Color.White;
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

        private void PopulateRectanglesListBox5()
        {
            // Очистка списка перед добавлением новых элементов
            RectanglesListBox5.Items.Clear();
            // Счетчик для имен прямоугольников
            int index = 0;

            foreach (var rectangle in _rectangles)
            {
                // Добавление имени в нужном формате
                RectanglesListBox5.Items.Add($"Rectangle {index}");
                index++;
            }
        }

        private void RectanglesListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox5.SelectedIndex >= 0)
            {
                _currentRectangle = _rectangles[RectanglesListBox5.SelectedIndex];
                UpdateRectangleFiledsTextBoxes5();
            }
        }

        private void UpdateRectangleFiledsTextBoxes5()
        {
            IdTextBox5.Text = _currentRectangle.Id.ToString();
            XTextBox5.Text = _currentRectangle.Center.X.ToString();
            YTextBox5.Text = _currentRectangle.Center.Y.ToString();
            LengthTextBox5.Text = _currentRectangle.Length.ToString();
            WidthTextBox5.Text = _currentRectangle.Width.ToString();
        }

        private void AddRectangleButton5_Click(object sender, EventArgs e)
        {
            var _rectanglesList = _rectangles.ToList();

            // Генерация случайной длины
            double length = random.Next(1, 100);
            // Генерация случайной ширины
            double width = random.Next(1, 100);
            // Выбор цвета по умолчанию из перечисления: Red
            string color = Convert.ToString(Model.Color.Red);

            _rectanglesList.Add(new Model.Rectangle(length, width, color));
        }
    }
}
