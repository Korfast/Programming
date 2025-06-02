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
    public partial class SeasonHandleUserControl : UserControl
    {
        public SeasonHandleUserControl()
        {
            InitializeComponent();
            InitializeSeasonComboBox();
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
                    // this.BackColor = System.Drawing.Color.Orange; // Меняем цвет фона на оранжевый
                    break;

                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;

                case Season.Spring:
                    // this.BackColor = System.Drawing.Color.Green; // Меняем цвет фона на зеленый
                    break;

                default:
                    MessageBox.Show("Выберите время года.");
                    break;
            }
        }
    }
}
