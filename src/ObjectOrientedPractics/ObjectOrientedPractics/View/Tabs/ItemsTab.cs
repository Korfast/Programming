using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Пользовательский элемент управления для отображения
    /// и редактирования списка товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список всех товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Текущий выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// При установке обновляется отображение ListBox.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (value == null)
                {
                    _items = new List<Item>();
                }
                else
                {
                    _items = value;
                }
                UpdateListBox();
            }
        }

        /// <summary>
        /// Обновляет ListBox с текущим списком товаров.
        /// </summary>
        private void UpdateListBox()
        {
            if (itemsListBox == null)
            {
                return;
            }

            itemsListBox.Items.Clear();

            if (_items == null)
            {
                return;
            }

            foreach (var item in _items)
            {
                itemsListBox.Items.Add(item);
                // Предположим, что Item переопределяет ToString()
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            FillCatagoryComboBox();
        }

        /// <summary>
        /// Заполняет список элементов <see cref="itemsListBox"
        /// /> текущими товарами.
        /// </summary>
        private void PopulateItemsListBox()
        {
            itemsListBox.Items.Clear();

            foreach (Item item in _items)
            {
                itemsListBox.Items.Add($"Товар {item.Id}");
            }
        }

        /// <summary>
        /// Заполняет ComboBox по категориям товаров,
        /// используя перечисление Model.Category
        /// </summary>
        private void FillCatagoryComboBox()
        {
            // Заполняем ComboBox значениями enum Category
            categoryComboBox.DataSource =
                Enum.GetValues(typeof(Model.Category));
            // Устанавливаем пустой выбранный элемент
            categoryComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Обработчик события клика по кнопке добавления нового товара.
        /// Создает случайный товар,
        /// добавляет его в список и обновляет интерфейс.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Создаем и добавляем новый случайный товар
            _items.Add(Services.ItemFactory.Randomize(0, 100000));

            // Обновляем список отображения
            PopulateItemsListBox();

            // Устанавливаем последний добавленный элемент как выбранный
            itemsListBox.SelectedIndex = itemsListBox.Items.Count - 1;
            // Обновляем текущий выбранный товар
            _currentItem = _items[itemsListBox.SelectedIndex];
        }

        /// <summary>
        /// Обработчик события клика по кнопке удаления выбранного товара.
        /// Удаляет выбранный товар из списка и обновляет интерфейс.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = itemsListBox.SelectedIndex;

            // Проверка, что что-то выбрано
            if (selectedIndex >= 0 && selectedIndex < _items.Count)
            {
                // Удаляем выбранный элемент
                _items.RemoveAt(selectedIndex);

                // Обновляем отображение списка
                PopulateItemsListBox();

                // Обновляем выбранный индекс
                if (_items.Count > 0)
                {
                    int newIndex = Math.Min(selectedIndex, _items.Count - 1);
                    itemsListBox.SelectedIndex = newIndex;
                    _currentItem = _items[newIndex];
                    UpdateItemFiledsTextBoxes();
                }
                else
                {
                    // Если список пуст, очищаем поля
                    _currentItem = null;
                    idTextBox.Text = "";
                    costTextBox.Text = "";
                    nameTextBox.Text = "";
                    descriptionTextBox.Text = "";

                    // Обнуляем цвет фона
                    costTextBox.BackColor = SystemColors.Window;
                    nameTextBox.BackColor = SystemColors.Window;
                    descriptionTextBox.BackColor = SystemColors.Window;
                }
            }
        }

        /// <summary>
        /// Обновляет свойства численных ограничений по введенному значению.
        /// </summary>
        /// <param name="updateAction">Делегат,
        /// вызываемый для обновления свойства.</param>
        /// <param name="textBox">Текстовое поле для ввода значения.</param>
        private void UpdateIntLimitsProperty
            (Action<int> updateAction, System.Windows.Forms.TextBox textBox)
        {
            try
            {
                if (int.TryParse(textBox.Text, out int value))
                {
                    updateAction(value);
                    textBox.BackColor = SystemColors.Window;
                }
                else
                {
                    textBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Обновляет свойство имени товара на основе текста из TextBox.
        /// </summary>
        /// <param name="textBox">TextBox для ввода имени.</param>
        /// <param name="length">Максимальная длина имени.</param>
        /// <param name="updateAction">
        /// Делегат для обновления свойства имени.</param>
        private void UpdateItemNameProperty
            (System.Windows.Forms.TextBox textBox, int length,
            Action<string> updateAction)
        {
            try
            {
                string value = textBox.Text;
                if (!"ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(value[0]) &&
                    !"АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЭЮЯ".Contains(value[0]))
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value.Length > length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                updateAction(value);
                textBox.BackColor = SystemColors.Window;
            }
            catch
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик изменения выбранного элемента списка.
        /// Обновляет текущий товар и отображает его свойства.
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex >= 0)
            {
                _currentItem = _items[itemsListBox.SelectedIndex];
                UpdateItemFiledsTextBoxes();
            }
        }

        /// <summary>
        /// Обновляет текстовые поля формы 
        /// текущими свойствами выбранного товара.
        /// </summary>
        private void UpdateItemFiledsTextBoxes()
        {
            idTextBox.Text = _currentItem.Id.ToString();
            costTextBox.Text = _currentItem.Cost.ToString();
            // Устанавливаем жанр в ComboBox с учетом особенности
            SetCategorySelectedItem(_currentItem.Category.ToString());
            nameTextBox.Text = _currentItem.Name;
            descriptionTextBox.Text = _currentItem.Info;
        }

        /// <summary>
        /// Обработчик изменения текста в текстовом поле стоимости товара.
        /// </summary>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) =>
                _currentItem.Cost = value, costTextBox);
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле имени товара.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex >= 0)
            {
                UpdateItemNameProperty(nameTextBox, 200, (value) =>
                _currentItem.Name = value);
            }
        }

        /// <summary>
        /// Обработчик изменения описания товара.
        /// </summary>
        private void DescriptionTextBox_TextChanged
            (object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex >= 0)
            {
                UpdateItemNameProperty(descriptionTextBox, 1000, (value) =>
                _currentItem.Info = value);
            }
        }

        /// <summary>
        /// Устанавливает выбранный элемент ComboBox по названию категории.
        /// </summary>
        /// <param name="cadtegoryName">
        /// Название категории, которое нужно установить.</param>
        private void SetCategorySelectedItem(string categoryName)
        {
            Model.Category[] categories =
                (Model.Category[])categoryComboBox.DataSource;
            int index = Array.FindIndex
                (categories, c => c.ToString() == categoryName);
            if (index >= 0)
            {
                categoryComboBox.SelectedIndex = index;
            }
        }

        private void CategoryComboBox_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex >= 0)
            {
                _currentItem.Category =
                    (Category)categoryComboBox.SelectedIndex;
            }
        }
    }
}