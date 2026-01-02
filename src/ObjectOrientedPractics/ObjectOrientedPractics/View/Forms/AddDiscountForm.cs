using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Forms
{
    /// <summary>
    /// Предоставляет пользовательский интерфейс для добавления новой скидки.
    /// </summary>
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Возвращает выбранную категорию товаров для создания скидки.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Category SelectedCategory { get; private set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="AddDiscountForm"/>.
        /// Инициализирует список категорий в ComboBox.
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();

            // Заполняем ComboBox значениями из перечисления Category
            var categories = Enum.GetValues(typeof(Category));
            foreach (var category in categories)
            {
                categoryComboBox.Items.Add(category);
            }

            if (categoryComboBox.Items.Count > 0)
            {
                categoryComboBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки подтверждения выбора.
        /// Сохраняет выбранную категорию и закрывает форму с результатом OK.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedItem != null)
            {
                SelectedCategory = (Category)categoryComboBox.SelectedItem;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки отмены.
        /// Закрывает форму с результатом Cancel.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
