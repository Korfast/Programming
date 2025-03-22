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
        public MainForm()
        {
            InitializeComponent();
            InitializeEnumsList();
            InitializeSeasonComboBox();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /* 
            // Плохой вариант:
            // Добавление названий всех перечислений в EnumsListBox
            EnumsListBox.Items.Add("Weekday");
            EnumsListBox.Items.Add("Genre");
            EnumsListBox.Items.Add("Color");
            EnumsListBox.Items.Add("EducationForm");
            EnumsListBox.Items.Add("SmartphoneManufacturer");
            EnumsListBox.Items.Add("Season");

            // Первый элемент по умолчанию
            EnumsListBox.SelectedIndex = 0;*/
        }
                                      
        private void InitializeEnumsList()
        {
            var enumTypes = Assembly.GetExecutingAssembly().GetTypes().Where
                (t => t.IsEnum && t.Namespace == "Programming.Model").ToList();
            
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

            /*
            // Очищаем ValuesListBox
            ValuesListBox.Items.Clear();

            // Получаем название выбранного перечисления
            string selectedEnum = EnumsListBox.SelectedItem.ToString();

            // Получаем значения выбранного перечисления и добавляем их в ValuesListBox
            switch (selectedEnum)
            {
                case "Weekday":
                    foreach (var value in Enum.GetValues(typeof(Weekday)))
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "Genre":
                    foreach (var value in Enum.GetValues(typeof(Genre)))
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "Color":
                    foreach (var value in Enum.GetValues(typeof(Model.Color)))
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "EducationForm":
                    foreach (var value in Enum.GetValues(typeof(EducationForm)))
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "SmartphoneManufacturer":
                    foreach (var value in Enum.GetValues(typeof(SmartphoneManufacturer)))
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "Season":
                    foreach (var value in Enum.GetValues(typeof(Season)))
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
            }*/
        }

        private void UpdateValuesListBox()
        {

            if (EnumsListBox.SelectedItem != null)
            {
                Type selectedType = ((Type)EnumsListBox.SelectedItem);
                Array values = Enum.GetValues(selectedType);
                ValuesListBox.DataSource = values;
            }
            /*if (EnumsListBox.SelectedItem is Enum selectedEnum)
            {
                ValuesListBox.DataSource = Enum.GetValues(selectedEnum);   
            }*/
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem is Enum selectedValue)
            {
                ValueTextBox.Text = Convert.ToInt32(selectedValue).ToString();
            }

            /*
            // Проверяем, чтобы что-то было выбрано
            if (ValuesListBox.SelectedItem != null)
            {
                // Получаем выбранное значение
                string selectedValue = ValuesListBox.SelectedItem.ToString();
                string selectedEnum = EnumsListBox.SelectedItem.ToString();

                // Определяем соответствующии перечисления и получаем их числовые значения
                switch (selectedEnum)
                {
                    case "Weekday":
                        Weekday weekday = (Weekday)Enum.Parse(typeof(Weekday), selectedValue);
                        ValueTextBox.Text = ((int)weekday).ToString(); // Преобразуем в целочисленное значение
                        break;
                    case "Genre":
                        Genre genre = (Genre)Enum.Parse(typeof(Genre), selectedValue);
                        ValueTextBox.Text = ((int)genre).ToString();
                        break;
                    case "Color":
                        Model.Color color = (Model.Color)Enum.Parse(typeof(Model.Color), selectedValue);
                        ValueTextBox.Text = ((int)color).ToString();
                        break;
                    case "EducationForm":
                        EducationForm formOfStudyOfTheStudent = (EducationForm)Enum.Parse(typeof(EducationForm), selectedValue);
                        ValueTextBox.Text = ((int)formOfStudyOfTheStudent).ToString();
                        break;
                    case "SmartphoneManufacturer":
                        SmartphoneManufacturer manufacturers = (SmartphoneManufacturer)Enum.Parse(typeof(SmartphoneManufacturer), selectedValue);
                        ValueTextBox.Text = ((int)manufacturers).ToString();
                        break;
                    case "Season":
                        Season timeOfYear = (Season)Enum.Parse(typeof(Season), selectedValue);
                        ValueTextBox.Text = ((int)timeOfYear).ToString();
                        break;

                }
            }*/
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            /*
            //Вариант Голубчикка 
            //Получение текста из текстового поля
            string input = WeekdayTextBox.Text.Trim();
            if (!int.TryParse(input, out _))
            {
                //Попытка разбора текста в перечисление
                if (Enum.TryParse<Weekday>(input, true, out Weekday result) && Enum.IsDefined(typeof(Weekday), result))
                {
                    // Разбор успешен
                    int weekdayValue = (int)result;
                    WeekdayLabel.Text = $"Это день недели ({result} = {weekdayValue})";
                }
                else
                {
                    // Разбор не успешен
                    WeekdayLabel.Text = "Нет такого дня недели";
                }
            }
            else 
            {
                WeekdayLabel.Text = "";
            } */
            
            // Мой вариант:
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
    }
}
