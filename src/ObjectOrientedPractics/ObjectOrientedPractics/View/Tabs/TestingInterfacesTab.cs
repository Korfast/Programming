using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Пользовательский элемент управления для тестирования реализации стандартных интерфейсов.
    /// Демонстрирует работу клонирования, сравнения и сортировки объектов.
    /// </summary>
    public partial class TestingInterfacesTab : UserControl
    {
        /// <summary>
        /// Тестовый список товаров для проверки сортировки.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Флаг, указывающий, применена ли в данный момент фильтрация.
        /// </summary>
        private bool _isFiltered = false;

        /// <summary>
        /// Создает экземпляр класса <see cref="TestingInterfacesTab"/>.
        /// Инициализирует тестовые данные и элементы управления.
        /// </summary>
        public TestingInterfacesTab()
        {
            InitializeComponent();

            // Инициализируем контролы адресов новыми объектами во избежание ошибок
            firstAddressControl.Address = new Address();
            secondAddressControl.Address = new Address();

            // Создаем начальный набор тестовых данных для товаров
            _items.Add(new Item("Coffee", "Tasty", 500, Category.Toys));
            _items.Add(new Item("Apple", "GreertButton_Click остаются без изменений ...n", 100, Category.Toys));
            _items.Add(new Item("Laptop", "Fast", 50000, Category.Electronics));
            _items.Add(new Item("Car Toy", "Small", 6000, Category.Automotive));

            UpdateItemsListBox();
        }

        /// <summary>
        /// Обработчик события клика по кнопке "Clone".
        /// Выполняет глубокое копирование адреса из первого контрола во второй с использованием ICloneable.
        /// </summary>
        private void CloneButton_Click(object sender, EventArgs e)
        {
            // Используем реализованный метод Clone() интерфейса ICloneable
            // Сеттер свойства Address автоматически обновит текстовые поля в UI
            secondAddressControl.Address = (Address)firstAddressControl.Address.Clone();
        }

        /// <summary>
        /// Обработчик события клика по кнопке "Equals".
        /// Сравнивает два адреса, используя перегруженный метод Equals и интерфейс IEquatable.
        /// </summary>
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (firstAddressControl.Address == null || secondAddressControl.Address == null) return;

            // Используем типизированный метод Equals интерфейса IEquatable<Address>
            if (firstAddressControl.Address.Equals(secondAddressControl.Address))
            {
                resultLabel.Text = "Addresses are Equal";
                resultLabel.ForeColor = Color.Green;
            }
            else
            {
                resultLabel.Text = "Addresses are Different";
                resultLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Обработчик события клика по кнопке "Sort".
        /// Выполняет сортировку списка товаров по стоимости, используя интерфейс IComparable.
        /// </summary>
        private void SortButton_Click(object sender, EventArgs e)
        {
            // Метод Sort() автоматически использует CompareTo(), реализованный в классе Item
            _items.Sort();
            UpdateItemsListBox();

            resultLabel.Text = "Status: Items Sorted by Cost";
            resultLabel.ForeColor = Color.Black;
        }

        /// <summary>
        /// Обновляет отображение списка товаров. 
        /// Если передан конкретный список, отображает его, иначе — весь основной список.
        /// </summary>
        /// <param name="displayList">Список для отображения (необязательно).</param>
        private void UpdateItemsListBox(List<Item> displayList = null)
        {
            // Если список не передан, используем глобальный _items
            List<Item> currentList = displayList;
            if (currentList == null)
            {
                currentList = _items;
            }

            itemsListBox.Items.Clear();
            foreach (var item in currentList)
            {
                itemsListBox.Items.Add($"{item.Cost} - {item.Name}");
            }
        }

        /// <summary>
        /// Обработчик события клика по кнопке фильтрации.
        /// Тестирует универсальный метод DataTools.FilterItems.
        /// </summary>
        private void FilterItemsButton_Click(object sender, EventArgs e)
        {
            if (!_isFiltered)
            {
                // Можно заменить фильтер на IsExpensive
                Services.DataTools.ItemFilter filter = Services.DataTools.IsAutomotive;

                // Тестируем делегат и метод FilterItems
                List<Item> filteredItems = 
                    Services.DataTools.FilterItems(_items, filter);

                // Обновляем ListBox только отфильтрованными данными
                UpdateItemsListBox(filteredItems);

                filterItemsButton.Text = "Clear Filter";
                resultLabel.Text = $"Status: Filter Applied ({filter.Method.Name})";
                resultLabel.ForeColor = Color.Black;
                _isFiltered = true;
            }
            else
            {
                // Сбрасываем фильтр, показывая основной список
                UpdateItemsListBox();

                filterItemsButton.Text = "Filter Items";
                resultLabel.Text = "Status: Filter Cleared";
                resultLabel.ForeColor = Color.Black;
                _isFiltered = false;
            }
        }
    }
}