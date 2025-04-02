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
        // Массив прямоугольников
        private Model.Rectangle[] _rectangles; 
        // Текущий прямоугольник
        private Model.Rectangle _currentRectangle; 

        public MainForm()
        {
            InitializeComponent();
            InitializeEnumsList();
            InitializeSeasonComboBox();
            InitializeRectangles();
            PopulateListBox();
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
            Weekday parsedWeekday;

            //Попытка разбора текста в перечисление
            if (Enum.TryParse(inputText, out parsedWeekday))
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
            SeasonComboBox.DisplayMember = "Name"; // Если у вас есть свойство Name, иначе просто уберите эту строку

            // Устанавливаем выбранный элемент, если есть значения
            if (SeasonComboBox.Items.Count > 0)
            {
                SeasonComboBox.SelectedIndex = 0; // Устанавливаем первый элемент как выбранный
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
            Random random = new Random();
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

        private void PopulateListBox()
        {
            // Очистка списка перед добавлением новых элементов
            RectanglesListBox.Items.Clear(); 
            // Счетчик для имен прямоугольников
            int index = 1; 

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
                UpdateTextBoxes();
            }
        }

        private void UpdateTextBoxes()
        {
            LenghTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
        }

        private void LenghTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateRectangleProperty(LenghTextBox, (value) => _currentRectangle.Length = value);
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateRectangleProperty(WidthTextBox, (value) => _currentRectangle.Width = value);
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateRectangleProperty(TextBox textBox, Action<int> updateAction)
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

        private void FindButton_Click(object sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth();
            RectanglesListBox.SelectedIndex = index;
        }

        private int
    }
}
