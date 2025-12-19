using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка пользовательского интерфейса для просмотра и обработки
    /// заказов покупателей, включая приоритетные заказы.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Список заказов, отображаемых в таблице.
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

        /// <summary>
        /// Возвращает или задает список покупателей,
        /// заказы которых отображаются на вкладке.
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
                    UpdateOrders();
                }
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="OrdersTab"/>.
        /// Выполняет настройку элементов управления и таблицы заказов.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();

            // Заполняем ComboBox статусов значениями перечисления
            foreach (Enum status in Enum.GetValues(typeof(OrderStatus)))
            {
                statusComboBox.Items.Add(status);
            }

            // Заполняем возможные интервалы времени доставки
            foreach (string deliveryTime in PriorityOrder.DeliveryTimeRanges)
            {
                deliveryTimeComboBox.Items.Add(deliveryTime);
            }

            // Настраиваем таблицу заказов
            SetupDataGridView();

            // Запрещаем редактирование адреса доставки
            addressControl.ReadOnly = true;
        }

        /// <summary>
        /// Выполняет настройку столбцов и параметров таблицы заказов.
        /// </summary>
        private void SetupDataGridView()
        {
            ordersDataGridView.Columns.Clear();
            ordersDataGridView.Columns.Add("IdColumn", "Id");
            ordersDataGridView.Columns.Add("CreatedColumn", "Created");
            ordersDataGridView.Columns.Add("StatusColumn", "Order Status");
            ordersDataGridView.Columns.Add("CustomerColumn", "Customer Full Name");
            ordersDataGridView.Columns.Add("AddressColumn", "Delivery Address");
            ordersDataGridView.Columns.Add("AmountColumn", "Amount");

            ordersDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            ordersDataGridView.MultiSelect = false;
            ordersDataGridView.ReadOnly = true;
            ordersDataGridView.RowHeadersVisible = true;
        }

        /// <summary>
        /// Обновляет данные на вкладке заказов.
        /// Вызывается из главной формы приложения.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
        }

        /// <summary>
        /// Собирает заказы всех покупателей и
        /// отображает их в таблице заказов.
        /// </summary>
        private void UpdateOrders()
        {
            _orders.Clear();
            ordersDataGridView.Rows.Clear();

            if (_customers == null)
            {
                return;
            }

            foreach (Customer customer in _customers)
            {
                foreach (Order order in customer.Orders)
                {
                    if (showOnlyPriorityOrdersСheckBox.Checked &&
                        order.GetType() != typeof(PriorityOrder))
                    {
                        continue;
                    }

                    _orders.Add(order);

                    string address =
                        $"{order.DeliveryAddress.Country}, " +
                        $"{order.DeliveryAddress.City}, " +
                        $"{order.DeliveryAddress.Street}, " +
                        $"{order.DeliveryAddress.Building}, " +
                        $"{order.DeliveryAddress.Apartment}";

                    int rowIndex = ordersDataGridView.Rows.Add(
                        order.Id,
                        order.CreationDate.ToString("dd.MM.yyyy HH:mm"),
                        order.Status,
                        customer.Fullname,
                        address,
                        order.Amount.ToString("N2"));

                    ordersDataGridView.Rows[rowIndex].Tag = order;
                }
            }
        }

        /// <summary>
        /// Обработчик изменения выбранной строки таблицы заказов.
        /// Обновляет информацию о текущем заказе.
        /// </summary>
        private void OrdersDataGridView_SelectionChanged
            (object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedRows.Count == 0)
            {
                ClearOrderInfo();
                return;
            }

            DataGridViewRow selectedRow =
                ordersDataGridView.SelectedRows[0];

            if (selectedRow.Tag == null)
            {
                ClearOrderInfo();
                return;
            }

            _currentOrder = (Order)selectedRow.Tag;

            if (_currentOrder.GetType() == typeof(PriorityOrder))
            {
                _currentPriorityOrder =
                    (PriorityOrder)_currentOrder;
                priorityOptionsPanel.Visible = true;
            }
            else
            {
                _currentPriorityOrder = null;
                priorityOptionsPanel.Visible = false;
            }

            UpdateOrderInfo();
        }

        /// <summary>
        /// Отрисовывает дополнительные элементы в заголовках строк таблицы.
        /// Используется для отображения звезды у приоритетных заказов.
        /// </summary>
        private void OrdersDataGridView_RowPostPaint
            (object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

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

        /// <summary>
        /// Обновляет элементы пользовательского интерфейса
        /// в соответствии с данными текущего заказа.
        /// </summary>
        private void UpdateOrderInfo()
        {
            if (_currentOrder == null)
            {
                return;
            }

            idTextBox.Text = _currentOrder.Id.ToString();
            createdTextBox.Text =
                _currentOrder.CreationDate.ToString("dd.MM.yyyy HH:mm");
            statusComboBox.SelectedItem = _currentOrder.Status;

            if (_currentPriorityOrder != null)
            {
                deliveryTimeComboBox.SelectedItem =
                    _currentPriorityOrder.DesiredDeliveryTime;
            }

            addressControl.Address = _currentOrder.DeliveryAddress;

            ordeItemsistBox.Items.Clear();
            foreach (var item in _currentOrder.Items)
            {
                ordeItemsistBox.Items.Add(item.Name);
            }

            costLabel.Text =
                _currentOrder.Amount.ToString("N2");
        }

        /// <summary>
        /// Очищает элементы пользовательского интерфейса
        /// и сбрасывает текущий выбранный заказ.
        /// </summary>
        private void ClearOrderInfo()
        {
            _currentOrder = null;

            idTextBox.Clear();
            createdTextBox.Clear();
            statusComboBox.SelectedIndex = -1;
            deliveryTimeComboBox.SelectedIndex = -1;
            addressControl.ClearFields();
            ordeItemsistBox.Items.Clear();
            costLabel.Text = "0,00";
        }

        /// <summary>
        /// Обработчик изменения статуса заказа.
        /// Обновляет статус текущего заказа.
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            if (_currentOrder != null &&
                statusComboBox.SelectedIndex != -1)
            {
                _currentOrder.Status =
                    (OrderStatus)statusComboBox.SelectedItem;

                if (ordersDataGridView.SelectedRows.Count > 0)
                {
                    ordersDataGridView.SelectedRows[0]
                        .Cells[2].Value = _currentOrder.Status;
                }
            }
        }

        /// <summary>
        /// Обработчик изменения времени доставки.
        /// Применяет значение только к приоритетным заказам.
        /// </summary>
        private void DeliveryTimeComboBox_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            if (deliveryTimeComboBox.SelectedIndex == -1 ||
                _currentOrder == null)
            {
                return;
            }

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

            _currentPriorityOrder =
                (PriorityOrder)_currentOrder;

            _currentPriorityOrder.DesiredDeliveryTime =
                (string)deliveryTimeComboBox.SelectedItem;
        }

        /// <summary>
        /// Обработчик изменения состояния флажка
        /// отображения только приоритетных заказов.
        /// </summary>
        private void ShowOnlyPriorityOrdersСheckBox_CheckedChanged
            (object sender, EventArgs e)
        {
            UpdateOrders();
        }
    }
}
