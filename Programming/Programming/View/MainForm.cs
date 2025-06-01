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
        // Список панелей
        private List<Panel> _rectanglePanels = new List<Panel>();

        public MainForm()
        {
            InitializeComponent();
            InitializeEnumsList();
            InitializeSeasonComboBox();
            InitializeRectangles();
            InitializeMovies();
            InitializeRectanglesListBox5();
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
                    this.BackColor = System.Drawing.Color.Orange; // Меняем цвет фона на оранжевый
                    break;

                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;

                case Season.Spring:
                    this.BackColor = System.Drawing.Color.Green; // Меняем цвет фона на зеленый
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
                textBox.BackColor = SystemColors.Window;
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

        private void ValidateAndUpdateProperty(Action<int> updateAction, TextBox textBox)
        {
            try
            {
                int value = int.Parse(textBox.Text);
                updateAction(value);
                textBox.BackColor = SystemColors.Window;

                // После успешного обновления перерисовываем панель и ищем пересечения
                if (_currentRectangle != null)
                {
                    RecreateRectanglePanels();
                }
            }
            catch
            {
                // Ошибка преобразования
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }


        private void PopulateRectanglesListBox5()
        {
            // Очистка списка перед добавлением новых элементов
            RectanglesListBox5.Items.Clear();

            foreach (var rectangle in _rectangles)
            {
                // Добавление имени в нужном формате
                RectanglesListBox5.Items.Add($"{rectangle.Id}: (X={rectangle.Center.X}; " +
                    $"Y={rectangle.Center.Y}; L={rectangle.Length}; W={rectangle.Width})");
            }
        }

        private void InitializeRectanglesListBox5()
        {
            // Добавляем все изначально существующие прямоугольники
            PopulateRectanglesListBox5();

            // Создаем для них панели через отдельную функцию
            foreach (var rectangle in _rectangles)
            {
                Panel rectanglePanel = CreateRectanglePanel(rectangle);

                // Добавляем панель на RectanglesPanel5
                RectanglesPanel5.Controls.Add(rectanglePanel);

                // Добавляем панель в список для дальнейшего управления
                _rectanglePanels.Add(rectanglePanel);
            }

            // Обновляем цвета панелей
            FindCollisions();
        }

        private void RectanglesListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (RectanglesListBox5.SelectedIndex >= 0)
            {
                _currentRectangle = _rectangles[RectanglesListBox5.SelectedIndex];
                UpdateRectangleFiledsTextBoxes5(); 
            }
            else
            {
                _currentRectangle = null;
                ClearRectangleInfo();
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
        
        private void UpdateRectangleInfo(Model.Rectangle rectangle)
        {
            if (rectangle == null)
                return;

            // Обновляем текущий выбранный прямоугольник
            _currentRectangle = rectangle;

            // Обновляем отображение в текстовых полях
            UpdateRectangleFiledsTextBoxes();
            UpdateRectangleFiledsTextBoxes5();
        }

        private void ClearRectangleInfo()
        {
            // Приведение изменяемых свойств текстбоксов к начальному состоянию

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

        private void AddRectangleButton5_Click(object sender, EventArgs e)
        {
            List<Model.Rectangle> _rectanglesList = _rectangles.ToList();

            // Создаём и добавляем новый прямоугольник в список
            _rectanglesList.Add(RectangleFactory.Randomize(10, 100));
            // Преобразуем список в массив
            _rectangles = _rectanglesList.ToArray();

            // Обновляем RectanglesListBox
            PopulateRectanglesListBox();
            // Обновляем RectanglesListBox5
            PopulateRectanglesListBox5();

            // Задаём последний элемент списка как выбранный
            RectanglesListBox5.SelectedIndex = RectanglesListBox5.Items.Count - 1;
            // Задаём текущий прямоугольник 
            _currentRectangle = _rectangles[RectanglesListBox5.SelectedIndex];

            // Создаем панель через отдельную функцию
            Panel rectanglePanel = CreateRectanglePanel(_currentRectangle);

            // Добавляем панель на RectanglesPanel5
            RectanglesPanel5.Controls.Add(rectanglePanel);

            // Добавляем панель в список для дальнейшего управления
            _rectanglePanels.Add(rectanglePanel);

            //CheckTheCorrespondenceOfRectanglesAndPanelsElements();

            // Обновляем цвета панелей
            FindCollisions();
        }

        private void DeleteRectangleButton5_Click(object sender, EventArgs e)
        {
            // Проверяем, что есть выбранный элемент
            int selectedIndex = RectanglesListBox5.SelectedIndex;
            if (selectedIndex == -1)
            {
                // Ничего не выбрано, выходим
                return;
            }

            // Удаляем из списка _rectangles
            _rectangles = _rectangles.Where((rect, index) => index != selectedIndex).ToArray();

            // Удаляем из ListBox
            RectanglesListBox5.Items.RemoveAt(selectedIndex);

            // Обновляем RectanglesListBox
            PopulateRectanglesListBox();

            // Удаляем соответствующую панель
            if (_rectanglePanels.Count > selectedIndex)
            {
                Panel panelToRemove = _rectanglePanels[selectedIndex];
                RectanglesPanel5.Controls.Remove(panelToRemove);
                _rectanglePanels.RemoveAt(selectedIndex);
                panelToRemove.Dispose();
            }

            // Обновляем текущий выбранный индекс
            if (RectanglesListBox5.Items.Count > 0)
            {
                RectanglesListBox5.SelectedIndex = Math.Min(selectedIndex, RectanglesListBox5.Items.Count - 1);
                _currentRectangle = _rectangles[RectanglesListBox5.SelectedIndex];
            }

            // Обновляем цвета панелей
            FindCollisions();
        }

        private Panel CreateRectanglePanel(Model.Rectangle rectangle)
        {
            // Создаем новый Panel
            Panel rectanglePanel = new Panel();

            // Вычисляем верхний левый угол так, чтобы центр совпадал с rectangle.Center
            int x = Convert.ToInt32(rectangle.Center.X - rectangle.Width / 2);
            int y = Convert.ToInt32(rectangle.Center.Y - rectangle.Length / 2);

            // Устанавливаем размеры и позицию панели согласно Rectangle
            rectanglePanel.Location = new Point(x, y);
            rectanglePanel.Size = new Size(Convert.ToInt32(rectangle.Width), Convert.ToInt32(rectangle.Length));

            // Назначаем цвет фона (прозрачный зеленый)
            rectanglePanel.BackColor = System.Drawing.Color.LightGreen;

            return rectanglePanel;
        }

        private void LengthTextBox5_TextChanged(object sender, EventArgs e)
        {
            //UpdateIntLimitsProperty((value) => _currentRectangle.Length = value, LengthTextBox5); 

            ValidateAndUpdateProperty((value) => _currentRectangle.Length = value, LengthTextBox5);
        }

        private void WidthTextBox5_TextChanged(object sender, EventArgs e)
        {
            //UpdateIntLimitsProperty((value) => _currentRectangle.Width = value, WidthTextBox5);

            ValidateAndUpdateProperty((value) => _currentRectangle.Width = value, WidthTextBox5);
        }

        private void FindCollisions()
        {
            
            // Перекрашиваем все панели в зеленый цвет
            foreach (Panel panel in _rectanglePanels)
            {
                panel.BackColor = System.Drawing.Color.LightGreen;
            }

            // Перебираем все пары прямоугольников
            for (int i = 0; i < _rectangles.Length - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Length; j++)
                {
                    // Проверка столкновения
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        // Перекрашиваем панели в красный цвет
                        _rectanglePanels[i].BackColor = System.Drawing.Color.LightPink;
                        _rectanglePanels[j].BackColor = System.Drawing.Color.LightPink;
                    }
                }
            }
        }

        private void CheckTheCorrespondenceOfRectanglesAndPanelsElements()
        {
            for (int i = 0; i < _rectangles.Length; i++)
            {
                Model.Rectangle rect = _rectangles[i];
                Panel panel = _rectanglePanels[i];

                // Проверка размеров
                bool sizeMatches = panel.Width == Convert.ToInt32(rect.Width) && panel.Height == Convert.ToInt32(rect.Length);

                // Проверка позиции (учитывая, что позиция — это центр)
                int expectedX = Convert.ToInt32(rect.Center.X - rect.Width / 2);
                int expectedY = Convert.ToInt32(rect.Center.Y - rect.Length / 2);
                bool positionMatches = panel.Location.X == expectedX && panel.Location.Y == expectedY;

                if (sizeMatches || positionMatches)
                {
                    Console.WriteLine($"Несовпадение в элементе {i}:");
                    if (sizeMatches)
                        Console.WriteLine($"  Размеры: панель ({panel.Width},{panel.Height}), ожидаемые ({rect.Width},{rect.Length})");
                    if (positionMatches)
                        Console.WriteLine($"  Позиция: панель ({panel.Location.X},{panel.Location.Y}), ожидаемая ({expectedX},{expectedY})  начальные {rect.Center.X}, {rect.Center.Y}");
                }
            }
        }

        private void RecreateRectanglePanels()
        {
            // Удаляем старые панели из контейнера и очищаем список
            foreach (Panel panel in _rectanglePanels)
            {
                if (panel.Parent != null)
                    panel.Parent.Controls.Remove(panel);
                panel.Dispose();
            }
            _rectanglePanels.Clear();

            // Создаем новые панели для каждого прямоугольника
            foreach (Model.Rectangle rectangle in _rectangles)
            {
                Panel newPanel = CreateRectanglePanel(rectangle);
                _rectanglePanels.Add(newPanel);
                // Добавляем панель в главный контейнер RectanglesPanel5
                RectanglesPanel5.Controls.Add(newPanel);

                // Добавляем панель в список для дальнейшего управления
                //_rectanglePanels.Add(newPanel);
            }

            // Обновляем цвета панелей
            FindCollisions();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            // Пересоздаём все панели
            RecreateRectanglePanels();
        }
    }
}
