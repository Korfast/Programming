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

        // <summary>
        /// Список товаров, отображаемых в данный момент.
        /// </summary>
        private List<Item> _displayedItems = new List<Item>();

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// При установке обновляется отображение ListBox.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
        /// Возникает при изменении списка товаров или любого товара в списке.
        /// </summary>
        public event EventHandler<EventArgs> ItemsChanged;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            FillCatagoryComboBox();
            InitializeOrganizingComboBox();
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
        /// Инициализирует выпадающий список способами сортировки 
        /// </summary>
        private void InitializeOrganizingComboBox()
        {
            // Очищаем на случай повторного вызова
            organizingProductsComboBox.Items.Clear();

            // Добавляем варианты сортировки
            organizingProductsComboBox.Items.AddRange(new string[]
            {
                "ID (Default)",
                "Name",
                "Cost (Ascending)",
                "Cost (Descending)"
            });

            // Устанавливаем сортировку по умолчанию — по имени
            organizingProductsComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Уведомляет подписчиков об изменениях.
        /// </summary>
        private void NotifyItemsChanged()
        {
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обновляет ListBox с текущим списком товаров.
        /// </summary>
        private void UpdateListBox()
        {
            // Очищаем список всегда, даже если данных нет
            itemsListBox.Items.Clear();

            // Проверяем именно отображаемый список. 
            // Если он null или пустой — просто выходим (список уже очищен).
            if (_displayedItems == null || _displayedItems.Count == 0)
            {
                return;
            }

            foreach (Item item in _displayedItems)
            {
                // Используем форматированный вывод
                itemsListBox.Items.Add($"Товар {item.Id}");
            }
        }

        /// <summary>
        /// Очищает все текстовые поля и сбрасывает выбор в ComboBox.
        /// </summary>
        private void ClearItemFields()
        {
            _currentItem = null;
            idTextBox.Text = string.Empty;
            costTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            categoryComboBox.SelectedIndex = -1;

            // Сбрасываем цвета полей на стандартные
            costTextBox.BackColor = SystemColors.Window;
            nameTextBox.BackColor = SystemColors.Window;
            descriptionTextBox.BackColor = SystemColors.Window;
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

            // Обновляем список отображения - сортируем
            ApplyFilterAndSort();

            // Устанавливаем последний добавленный элемент как выбранный
            itemsListBox.SelectedIndex = itemsListBox.Items.Count - 1;
            // Обновляем текущий выбранный товар
            _currentItem = _items[itemsListBox.SelectedIndex];

            // Уведомляем об изменениях
            NotifyItemsChanged();
        }

        /// <summary>
        /// Обработчик события клика по кнопке удаления выбранного товара.
        /// Удаляет выбранный товар из списка и обновляет интерфейс.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex >= 0 && _currentItem != null)
            {
                // Удаляем по объекту, а не по индексу
                // Это гарантирует удаление правильного товара даже при фильтрации
                _items.Remove(_currentItem);

                ApplyFilterAndSort();

                if (_displayedItems.Count > 0)
                {
                    // Выбираем первый элемент в списке после удаления
                    itemsListBox.SelectedIndex = 0;
                    _currentItem = _displayedItems[0];
                    UpdateItemFieldsTextBoxes();
                }
                else
                {

                    ClearItemFields(); 
                }

                // Уведомляем об изменениях
                NotifyItemsChanged();
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

                    // Уведомляем об изменениях
                    NotifyItemsChanged();

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

                // Уведомляем об изменениях
                NotifyItemsChanged();

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
            int index = itemsListBox.SelectedIndex;
            if (index >= 0 && index < _displayedItems.Count)
            {
                // Берем объект из отображаемого списка
                _currentItem = _displayedItems[index];

                // Теперь мы знаем конкретный объект, и нам не важно, 
                // какой у него индекс в основном списке _items.
                UpdateItemFieldsTextBoxes();
            }
        }

        /// <summary>
        /// Обновляет текстовые поля формы 
        /// текущими свойствами выбранного товара.
        /// </summary>
        private void UpdateItemFieldsTextBoxes()
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

        /// <summary>
        /// Обработчик изменения выбранной категории товара.
        /// Обновляет категорию текущего выбранного товара.
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex >= 0)
            {
                _currentItem.Category =
                    (Category)categoryComboBox.SelectedIndex;

                // Уведомляем об изменениях
                NotifyItemsChanged();
            }
        }

        /// <summary>
        /// Применяет фильтрацию и сортировку одновременно.
        /// </summary>
        private void ApplyFilterAndSort()
        {
            if (_items == null) return;

            // 1. Фильтрация 
            string query = findTextBox.Text.ToLower();

            // Используем ваш самодельный делегат ItemFilter
            _displayedItems = DataTools.FilterItems(_items, (item) =>
            {
                // Если строка поиска пуста — возвращаем true (товар подходит)
                if (string.IsNullOrWhiteSpace(query)) return true;

                // Иначе проверяем, содержит ли имя поисковый запрос
                return item.Name.ToLower().Contains(query);
            });

            // 2. Сортировка 
            // Выбираем способ сортировки на основе ComboBox
            switch (organizingProductsComboBox.SelectedIndex)
            {
                case 0: // По умолчанию (по ID / Индексу)
                    _displayedItems = DataTools.SortItems(_displayedItems, (x, y) => x.Id.CompareTo(y.Id));
                    break;
                case 1: // Name
                    _displayedItems = DataTools.SortItems(_displayedItems, (x, y) => x.Name.CompareTo(y.Name));
                    break;
                case 2: // Cost Asc
                    _displayedItems = DataTools.SortItems(_displayedItems, (x, y) => x.Cost.CompareTo(y.Cost));
                    break;
                case 3: // Cost Desc
                    _displayedItems = DataTools.SortItems(_displayedItems, (x, y) => y.Cost.CompareTo(x.Cost));
                    break;
            }

            UpdateListBox();
        }

        /// <summary>
        /// Обработчик события изменения текста в поле поиска.
        /// Вызывает пересчет фильтрации и сортировки для обновления списка отображаемых товаров.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        /// <summary>
        /// Обработчик события изменения выбранного способа сортировки в выпадающем списке.
        /// Обновляет порядок отображения товаров, сохраняя при этом текущую фильтрацию.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void OrganizingProductsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }
    }
}