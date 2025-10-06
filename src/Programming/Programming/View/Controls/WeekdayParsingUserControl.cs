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
    /// Пользовательский контроль для парсинга дня недели из текста.
    /// </summary>
    public partial class WeekdayParsingUserControl : UserControl
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="WeekdayParsingUserControl"/>.
        /// </summary>
        public WeekdayParsingUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Parse".
        /// Выполняет разбор текста в поле <see cref="WeekdayTextBox"/> и отображает результат в <see cref="WeekdayLabel"/>.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            // Получение текста из текстового поля
            string inputText = WeekdayTextBox.Text;

            // Попытка разбора текста в перечисление
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
    }
}
