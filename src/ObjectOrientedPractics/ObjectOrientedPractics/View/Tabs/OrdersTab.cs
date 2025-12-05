using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Список заказов (отображается в таблице).
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Текущий выбранный заказ.
        /// </summary>
        private Order _currentOrder;

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
                if (_customers != null) UpdateOrders();
            }
        }

        public OrdersTab()
        {
            InitializeComponent();

            // Инициализация ComboBox статусов значениями из Enum
            foreach (var status in Enum.GetValues(typeof(OrderStatus)))
            {
                statusComboBox.Items.Add(status);
            }

            // Настройка таблицы
            SetupDataGridView();

            // Блокируем AddressControl для редактирования 
            addressControl.ReadOnly = true;
        }

        private void SetupDataGridView()
        {
            ordersDataGridView.Columns.Clear();
            ordersDataGridView.Columns.Add("IdColumn", "Id");
            ordersDataGridView.Columns.Add("CreatedColumn", "Created");
            ordersDataGridView.Columns.Add("StatusColumn", "Order Status");
            ordersDataGridView.Columns.Add("CustomerColumn", "Customer Full Name");
            ordersDataGridView.Columns.Add("AddressColumn", "Delivery Address");
            ordersDataGridView.Columns.Add("AmountColumn", "Amount");

            // Настройки поведения таблицы
            // Выделять всю строку
            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Только одна строка
            ordersDataGridView.MultiSelect = false;
            // Запрет редактирования ячеек
            ordersDataGridView.ReadOnly = true;
            // Скрываем уродливый первый столбец заголовков строк                                    
            ordersDataGridView.RowHeadersVisible = false;
        }

        /// <summary>
        /// Обновляет данные на вкладке (вызывается из MainForm).
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
        }

        /// <summary>
        /// Собирает все заказы всех покупателей и выводит их в таблицу.
        /// </summary>
        private void UpdateOrders()
        {
            _orders.Clear();
            ordersDataGridView.Rows.Clear();

            if (_customers == null) return;

            foreach (var customer in _customers)
            {
                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);

                    // Формируем строку адреса
                    string address = $"{order.DeliveryAddress.Country}, {order.DeliveryAddress.City}, " +
                                     $"{order.DeliveryAddress.Street}, {order.DeliveryAddress.Building}, " +
                                     $"{order.DeliveryAddress.Apartment}";

                    ordersDataGridView.Rows.Add(
                        order.Id,
                        order.CreationDate.ToString("dd.MM.yyyy HH:mm"),
                        order.Status,
                        customer.Fullname,
                        address,
                        order.TotalAmount.ToString("N2")
                    );
                }
            }
        }

        // Переименованный метод обработчика
        private void ordersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Если ничего не выбрано или список заказов пуст
            if (ordersDataGridView.SelectedRows.Count == 0 || _orders.Count == 0)
            {
                ClearOrderInfo();
                return;
            }

            // Получаем индекс выбранной строки
            int index = ordersDataGridView.SelectedRows[0].Index;

            // Находим соответствующий заказ в списке _orders
            if (index >= 0 && index < _orders.Count)
            {
                _currentOrder = _orders[index];
                UpdateOrderInfo();
            }
        }

        private void UpdateOrderInfo()
        {
            if (_currentOrder == null) return;

            idTextBox.Text = _currentOrder.Id.ToString();
            createdTextBox.Text = _currentOrder.CreationDate.ToString("dd.MM.yyyy HH:mm");
            statusComboBox.SelectedItem = _currentOrder.Status;

            // Передаем адрес в AddressControl
            addressControl.Address = _currentOrder.DeliveryAddress;

            // Заполняем список товаров
            ordeItemsistBox.Items.Clear();
            foreach (var item in _currentOrder.Items)
            {
                ordeItemsistBox.Items.Add(item.Name);
            }

            costLabel.Text = _currentOrder.TotalAmount.ToString("N2");
        }

        private void ClearOrderInfo()
        {
            _currentOrder = null;
            idTextBox.Clear();
            createdTextBox.Clear();
            statusComboBox.SelectedIndex = -1;
            addressControl.ClearFields();
            ordeItemsistBox.Items.Clear();
            costLabel.Text = "0,00";
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Меняем статус заказа при выборе в ComboBox
            if (_currentOrder != null && statusComboBox.SelectedIndex != -1)
            {
                _currentOrder.Status = (OrderStatus)statusComboBox.SelectedItem;

                // Обновляем ячейку статуса в таблице визуально
                if (ordersDataGridView.SelectedRows.Count > 0)
                {
                    ordersDataGridView.SelectedRows[0].Cells[2].Value = _currentOrder.Status;
                }
            }
        }
    }
}