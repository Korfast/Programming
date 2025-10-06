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

namespace Programming.View.Controls
{
    /// <summary>
    /// Пользовательский контроль для отображения и выбора перечислений и их значений.
    /// </summary>
    public partial class EnumerationsControl : UserControl
    {
        /// <summary>
        /// Инициализация нового экземпляра класса и загрузка списка перечислений.
        /// </summary>
        public EnumerationsControl()
        {
            InitializeComponent();
            InitializeEnumsList();
        }

        /// <summary>
        /// Инициализирует список доступных перечислений из сборки.
        /// Отбирает типы, являющиеся перечислениями в пространстве имен "Programming.Model".
        /// </summary>
        private void InitializeEnumsList()
        {
            // Получение всех типов в текущей сборке, являющихся перечислениями и находящихся в пространстве имен "Programming.Model"
            var enumTypes = Assembly.GetExecutingAssembly().GetTypes().Where
                (type => type.IsEnum && type.Namespace == "Programming.Model").ToList();

            // Установка источника данных для ListBox с перечислениями
            EnumsListBox.DataSource = enumTypes;
            EnumsListBox.DisplayMember = "Name";

            // Если есть элементы, выбираем первый по умолчанию и обновляем список значений
            if (EnumsListBox.Items.Count > 0)
            {
                EnumsListBox.SelectedIndex = 0;
                UpdateValuesListBox();
            }
        }

        /// <summary>
        /// Обработчик изменения выбранного элемента в списке перечислений.
        /// Обновляет список значений для выбранного типа.
        /// </summary>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateValuesListBox();
        }

        /// <summary>
        /// Обновляет список значений для выбранного типа перечисления.
        /// </summary>
        private void UpdateValuesListBox()
        {
            if (EnumsListBox.SelectedItem != null)
            {
                // Получение выбранного типа
                Type selectedType = ((Type)EnumsListBox.SelectedItem);
                // Получение всех значений этого перечисления
                Array values = Enum.GetValues(selectedType);
                // Установка источника данных для ListBox с значениями
                ValuesListBox.DataSource = values;
            }
        }

        /// <summary>
        /// Обработчик изменения выбранного значения в списке значений.
        /// Отображает числовое значение выбранного элемента.
        /// </summary>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem is Enum selectedValue)
            {
                // Преобразование выбранного значения к целому числу и отображение в TextBox
                ValueTextBox.Text = Convert.ToInt32(selectedValue).ToString();
            }
        }
    }
}
