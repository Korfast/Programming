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
    public partial class TestingInterfacesTab : UserControl
    {
        private List<Item> _items = new List<Item>();

        public TestingInterfacesTab()
        {
            InitializeComponent();

            // Инициализируем контролы, чтобы избежать NullReference
            firstAddressControl.Address = new Address();
            secondAddressControl.Address = new Address();

            // Создаем тестовые данные для товаров
            _items.Add(new Item("Coffee", "Tasty", 500, Category.Toys));
            _items.Add(new Item("Apple", "Green", 100, Category.Toys));
            _items.Add(new Item("Laptop", "Fast", 50000, Category.Electronics));

            UpdateItemsListBox();
        }

        private void CloneButton_Click(object sender, EventArgs e)
        {
            // Тестируем ICloneable
            Address source = firstAddressControl.Address;
            Address clone = (Address)source.Clone();
            secondAddressControl.Address = clone;

            resultLabel.Text = "Status: Address Cloned";
            resultLabel.ForeColor = Color.Blue;
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            // Тестируем IEquatable
            Address addr1 = firstAddressControl.Address;
            Address addr2 = secondAddressControl.Address;

            if (addr1.Equals(addr2))
            {
                resultLabel.Text = "Status: Equal";
                resultLabel.ForeColor = Color.Green;
            }
            else
            {
                resultLabel.Text = "Status: Different";
                resultLabel.ForeColor = Color.Red;
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            // Тестируем IComparable
            _items.Sort();
            UpdateItemsListBox();
            resultLabel.Text = "Status: Items Sorted by Cost";
            resultLabel.ForeColor = Color.Black;
        }

        private void UpdateItemsListBox()
        {
            itemsListBox.Items.Clear();
            foreach (var item in _items)
            {
                itemsListBox.Items.Add($"{item.Cost} - {item.Name}");
            }
        }
    }
}