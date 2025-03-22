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
    }
}
