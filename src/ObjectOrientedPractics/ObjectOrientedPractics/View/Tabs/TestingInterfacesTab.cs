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
            _items.Add(new Item("Apple", "Green", 100, Category.Toys));
            _items.Add(new Item("Laptop", "Fast", 50000, Category.Electronics));

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
        /// Обновляет отображение списка товаров в ListBox.
        /// </summary>
        private void UpdateItemsListBox()
        {
            itemsListBox.Items.Clear();
            foreach (var item in _items)
            {
                // Выводим стоимость и имя для наглядности результата сортировки
                itemsListBox.Items.Add($"{item.Cost} - {item.Name}");
            }
        }
    }
}