using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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

        /// <summary>
        /// Текущий выбранный приоритетный заказ.
        /// </summary>
        private PriorityOrder _currentPriorityOrder;

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
            foreach (Enum status in Enum.GetValues(typeof(OrderStatus)))
            {
                statusComboBox.Items.Add(status);
            }

            foreach (string deliveryTime in PriorityOrder.DeliveryTimeRanges)
            {
                deliveryTimeComboBox.Items.Add(deliveryTime);
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
            // НЕ Скрываем уродливый первый столбец заголовков строк                                    
            ordersDataGridView.RowHeadersVisible = true;
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

            foreach (Customer customer in _customers)
            {
                foreach (Order order in customer.Orders)
                {

                    if (showOnlyPriorityOrdersСheckBox.Checked 
                        && order.GetType() != typeof(PriorityOrder))
                    {
                        continue;
                    }

                    _orders.Add(order);

                    // Формируем строку адреса
                    string address = 
                        $"{order.DeliveryAddress.Country}, " +
                        $"{order.DeliveryAddress.City}, " +
                        $"{order.DeliveryAddress.Street}, " +
                        $"{order.DeliveryAddress.Building}, " +
                        $"{order.DeliveryAddress.Apartment}";

                    int rowIndex = 
                        ordersDataGridView.Rows.Add(
                        order.Id,
                        order.CreationDate.ToString("dd.MM.yyyy HH:mm"),
                        order.Status,
                        customer.Fullname,
                        address,
                        order.TotalAmount.ToString("N2"));

                    ordersDataGridView.Rows[rowIndex].Tag = order;
                }
            }
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedRows.Count == 0)
            {
                ClearOrderInfo();
                return;
            }

            DataGridViewRow selectedRow = ordersDataGridView.SelectedRows[0];

            if (selectedRow.Tag == null)
            {
                ClearOrderInfo();
                return;
            }

            _currentOrder = (Order)selectedRow.Tag;

            if (_currentOrder.GetType() == typeof(PriorityOrder))
            {
                _currentPriorityOrder = (PriorityOrder)_currentOrder;
                priorityOptionsPanel.Visible = true;
            }
            else
            {
                _currentPriorityOrder = null;
                priorityOptionsPanel.Visible = false;
            }

            UpdateOrderInfo();
        }

        private void OrdersDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridView grid = (DataGridView)sender;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            Order order = (Order)row.Tag;

            if (order != null &&
            order.GetType() == typeof(PriorityOrder))
            {
                Rectangle bounds = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                grid.RowHeadersWidth,
                e.RowBounds.Height);

                TextRenderer.DrawText(
                    e.Graphics,
                    "★",
                    grid.Font,
                    bounds,
                    Color.Gold,
                    TextFormatFlags.HorizontalCenter |
                    TextFormatFlags.VerticalCenter);
        }
    }


        private void UpdateOrderInfo()
        {
            if (_currentOrder == null) return;

            idTextBox.Text = _currentOrder.Id.ToString();
            createdTextBox.Text = _currentOrder.CreationDate.ToString("dd.MM.yyyy HH:mm");
            statusComboBox.SelectedItem = _currentOrder.Status;
            if (_currentPriorityOrder != null)
            {
                deliveryTimeComboBox.SelectedItem = _currentPriorityOrder.DesiredDeliveryTime;
            }

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
            deliveryTimeComboBox.SelectedIndex = -1;
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ничего не выбрано
            if (deliveryTimeComboBox.SelectedIndex == -1
                || _currentOrder == null)
            {
                return;
            }

            // Проверяем, что заказ приоритетный
            if (_currentOrder.GetType() != typeof(PriorityOrder))
            {
                MessageBox.Show(
                    "Время доставки можно менять только у приоритетных заказов.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                deliveryTimeComboBox.SelectedIndex = -1;
                return;
            }

            // Безопасное приведение
            _currentPriorityOrder = (PriorityOrder)_currentOrder;

            // Применяем выбранное время доставки
            _currentPriorityOrder.DesiredDeliveryTime =
                (string)deliveryTimeComboBox.SelectedItem;
        }

        private void ShowOnlyPriorityOrdersСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrders();
        }  
    }
}