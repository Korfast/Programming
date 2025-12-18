using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка пользовательского интерфейса для работы с корзинами покупателей:
    /// добавление товаров, оформление заказов и очистка корзины.
    /// </summary>
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

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает или задает список доступных товаров.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                if (_items != null)
                {
                    UpdateItemsListBox();
                }
            }
        }

        /// <summary>
        /// Возвращает или задает список покупателей.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                if (_customers != null)
                {
                    UpdateCustomersComboBox();
                }
            }
        }

        /// <summary>
        /// Обновляет данные на вкладке корзин.
        /// Вызывается из главной формы при переключении вкладок.
        /// </summary>
        public void RefreshData()
        {
            UpdateItemsListBox();
            UpdateCustomersComboBox();

            // Сбрасываем текущий выбор покупателя
            customersComboBox.SelectedIndex = -1;
            _currentCustomer = null;

            // Очищаем корзину и стоимость
            cartsListBox.Items.Clear();
            costLabel.Text = "0,00";
        }

        /// <summary>
        /// Обновляет список доступных товаров.
        /// </summary>
        private void UpdateItemsListBox()
        {
            itemsListBox.Items.Clear();
            foreach (Item item in _items)
            {
                itemsListBox.Items.Add(item.Name);
            }
        }

        /// <summary>
        /// Обновляет список покупателей в выпадающем списке.
        /// </summary>
        private void UpdateCustomersComboBox()
        {
            customersComboBox.Items.Clear();
            foreach (Customer customer in _customers)
            {
                customersComboBox.Items.Add(customer.Fullname);
            }
        }

        /// <summary>
        /// Обновляет список товаров в корзине выбранного покупателя
        /// и пересчитывает итоговую стоимость.
        /// </summary>
        private void UpdateCartListBox()
        {
            cartsListBox.Items.Clear();

            if (_currentCustomer == null)
            {
                costLabel.Text = "0,00";
                return;
            }

            foreach (Item item in _currentCustomer.Cart.Items)
            {
                cartsListBox.Items.Add(item.Name);
            }

            costLabel.Text = _currentCustomer.Cart.Amount.ToString();
        }

        /// <summary>
        /// Обработчик изменения выбранного покупателя.
        /// Обновляет текущую корзину.
        /// </summary>
        private void CustomersComboBox_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            if (customersComboBox.SelectedIndex == -1)
            {
                _currentCustomer = null;
            }
            else
            {
                _currentCustomer =
                    _customers[customersComboBox.SelectedIndex];
            }

            UpdateCartListBox();
        }

        /// <summary>
        /// Обработчик нажатия кнопки добавления товара в корзину.
        /// Добавляет выбранный товар в корзину текущего покупателя.
        /// </summary>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex == -1 ||
                _currentCustomer == null)
            {
                return;
            }

            Item selectedItem =
                _items[itemsListBox.SelectedIndex];

            _currentCustomer.Cart.Items.Add(selectedItem);

            UpdateCartListBox();
        }

        /// <summary>
        /// Обработчик нажатия кнопки создания заказа.
        /// Формирует заказ на основе содержимого корзины покупателя.
        /// </summary>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null ||
                _currentCustomer.Cart.Items.Count == 0)
            {
                return;
            }

            List<Item> orderItems =
                new List<Item>(_currentCustomer.Cart.Items);

            Order newOrder;

            if (_currentCustomer.IsPriority)
            {
                newOrder =
                    new PriorityOrder(_currentCustomer.Address, orderItems);
            }
            else
            {
                newOrder =
                    new Order(_currentCustomer.Address, orderItems);
            }

            _currentCustomer.Orders.Add(newOrder);

            _currentCustomer.Cart.Items.Clear();
            UpdateCartListBox();
        }

        /// <summary>
        /// Обработчик нажатия кнопки удаления товара из корзины.
        /// Удаляет выбранный товар из корзины текущего покупателя.
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (cartsListBox.SelectedIndex == -1 ||
                _currentCustomer == null)
            {
                return;
            }

            _currentCustomer.Cart.Items.RemoveAt(
                cartsListBox.SelectedIndex);

            UpdateCartListBox();
        }

        /// <summary>
        /// Обработчик нажатия кнопки очистки корзины.
        /// Удаляет все товары из корзины текущего покупателя.
        /// </summary>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                return;
            }

            _currentCustomer.Cart.Items.Clear();
            UpdateCartListBox();
        }
    }
}
