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
    /// Пользовательский контроль для выбора и обработки времени года.
    /// </summary>
    public partial class SeasonHandleUserControl : UserControl
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="SeasonHandleUserControl"/> и настраивает ComboBox с сезонами.
        /// </summary>
        public SeasonHandleUserControl()
        {
            InitializeComponent();
            InitializeSeasonComboBox();
        }

        /// <summary>
        /// Инициализирует ComboBox с перечислением сезонов.
        /// </summary>
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

        /// <summary>
        /// Обработчик события нажатия на кнопку "Go".
        /// Выполняет действия в зависимости от выбранного сезона.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
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
                    // Меняем цвет фона на оранжевый
                    this.BackColor = AppColors.Orange;
                    break;

                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;

                case Season.Spring:
                    // Меняем цвет фона на зеленый
                    this.BackColor = AppColors.Green;
                    break;

                default:
                    MessageBox.Show("Выберите время года.");
                    break;
            }
        }
    }
}
