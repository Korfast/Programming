using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список доступных товаров (ссылка на Store.Items).
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список всех покупателей (ссылка на Store.Customers).
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Текущий выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        public CartsTab()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                if (_items != null) UpdateItemsListBox();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                if (_customers != null) UpdateCustomersComboBox();
            }
        }

        /// <summary>
        /// Обновляет данные на вкладке. 
        /// Вызывается из MainForm при переключении вкладок.
        /// </summary>
        public void RefreshData()
        {
            UpdateItemsListBox();
            UpdateCustomersComboBox();

            // Всегда сбрасываем выбор, чтобы избежать ошибок рассинхронизации
            customersComboBox.SelectedIndex = -1;
            _currentCustomer = null;

            // Очищаем корзину и цену
            cartsListBox.Items.Clear();
            costLabel.Text = "0,00";
        }

        private void UpdateItemsListBox()
        {
            itemsListBox.Items.Clear();
            foreach (Item item in _items)
            {
                itemsListBox.Items.Add(item.Name);
            }
        }

        private void UpdateCustomersComboBox()
        {
            customersComboBox.Items.Clear();
            foreach (Customer customer in _customers)
            {
                customersComboBox.Items.Add(customer.Fullname);
            }
        }

        private void UpdateCartListBox()
        {
            cartsListBox.Items.Clear();

            // Если покупатель не выбран, очищаем сумму и список
            if (_currentCustomer == null)
            {
                costLabel.Text = "0,00";
                return;
            }

            // Заполняем список товарами из корзины покупателя
            foreach (Item item in _currentCustomer.Cart.Items)
            {
                cartsListBox.Items.Add(item.Name);
            }

            // Обновляем итоговую сумму (свойство Amount из класса Cart)
            costLabel.Text = _currentCustomer.Cart.Amount.ToString();
        }

        private void CustomersComboBox_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            if (customersComboBox.SelectedIndex == -1)
            {
                _currentCustomer = null;
            }
            else
            {
                _currentCustomer = _customers[customersComboBox.SelectedIndex];
            }
            UpdateCartListBox();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            // Проверки: выбран ли товар в левом списке и выбран ли покупатель
            if (itemsListBox.SelectedIndex == -1 || _currentCustomer == null)
            {
                return;
            }

            // Берем товар из общего списка и добавляем в корзину покупателя
            Item selectedItem = _items[itemsListBox.SelectedIndex];
            _currentCustomer.Cart.Items.Add(selectedItem);

            UpdateCartListBox();
        }
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            // Проверка: есть ли покупатель и есть ли товары в корзине
            if (_currentCustomer == null || _currentCustomer.Cart.Items.Count == 0)
            {
                return;
            }

            // Создаем список товаров для заказа (копируем из корзины)
            List<Item> orderItems = new List<Item>(_currentCustomer.Cart.Items);

            // Создаем заказ.
            Order newOrder;

            // Проверяем, является ли покупатель приоритетным
            if (_currentCustomer.IsPriority)
            {
                newOrder = new PriorityOrder(_currentCustomer.Address, orderItems);
            }
            else
            {
                newOrder = new Order(_currentCustomer.Address, orderItems);
            }

            // Добавляем заказ в список заказов покупателя
            _currentCustomer.Orders.Add(newOrder);

            // Очищаем корзину после создания заказа
            _currentCustomer.Cart.Items.Clear();
            UpdateCartListBox();

            // Опционально: сообщаем об успехе
            // MessageBox.Show("Order created successfully!"); 
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (cartsListBox.SelectedIndex == -1 || _currentCustomer == null)
            {
                return;
            }

            // Удаляем товар из корзины по индексу
            _currentCustomer.Cart.Items.RemoveAt(cartsListBox.SelectedIndex);

            UpdateCartListBox();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;

            _currentCustomer.Cart.Items.Clear();
            UpdateCartListBox();
        }

        
    }
}