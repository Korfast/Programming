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

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Подпискка на событие изменения выбора
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Добавление названий всех перечислений в EnumsListBox
            EnumsListBox.Items.Add("Weekday");
            EnumsListBox.Items.Add("Genre");
            EnumsListBox.Items.Add("Color");
            EnumsListBox.Items.Add("FormOfStudyOfTheStudent");
            EnumsListBox.Items.Add("SmartphoneManufacturers");
            EnumsListBox.Items.Add("TimeOfYear");

            // Первый элемент по умолчанию
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                case "FormOfStudyOfTheStudent":
                    foreach (var value in Enum.GetValues(typeof(FormOfStudyOfTheStudent)))
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "SmartphoneManufacturers":
                    foreach (var value in Enum.GetValues(typeof(SmartphoneManufacturers)))
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "TimeOfYear":
                    foreach (var value in Enum.GetValues(typeof(TimeOfYear)))
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                    case "FormOfStudyOfTheStudent":
                        FormOfStudyOfTheStudent formOfStudyOfTheStudent = (FormOfStudyOfTheStudent)Enum.Parse(typeof(FormOfStudyOfTheStudent), selectedValue);
                        ValueTextBox.Text = ((int)formOfStudyOfTheStudent).ToString();
                        break;
                    case "SmartphoneManufacturers":
                        SmartphoneManufacturers manufacturers = (SmartphoneManufacturers)Enum.Parse(typeof(SmartphoneManufacturers), selectedValue);
                        ValueTextBox.Text = ((int)manufacturers).ToString();
                        break;
                    case "TimeOfYear":
                        TimeOfYear timeOfYear = (TimeOfYear)Enum.Parse(typeof(TimeOfYear), selectedValue);
                        ValueTextBox.Text = ((int)timeOfYear).ToString();
                        break;

                }
            }
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            //Получение текста из текстового поля
            string inputText = InputWeekdayTextBox.Text;

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
    }
}
