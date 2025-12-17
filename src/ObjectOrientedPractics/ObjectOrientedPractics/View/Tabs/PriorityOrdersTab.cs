using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Текущий приоритетный заказ.
        /// </summary>
        private PriorityOrder _currentOrder;

        public PriorityOrdersTab()
        {
            InitializeComponent();

            // Заполняем статусы
            foreach (var status in Enum.GetValues(typeof(OrderStatus)))
            {
                statusComboBox.Items.Add(status);
            }

            // Заполняем время доставки
            deliveryTimeComboBox.Items.AddRange(PriorityOrder.DeliveryTimeRanges);

            // Создаем новый пустой заказ при запуске
            _currentOrder = new PriorityOrder();

            // Инициализируем UI по данным заказа
            UpdateOrderInfo();
        }

        /// <summary>
        /// Обновляет данные на форме согласно текущему объекту заказа.
        /// </summary>
        private void UpdateOrderInfo()
        {
            if (_currentOrder == null) return;

            // Заполняем поля ID и Дата
            idTextBox.Text = _currentOrder.Id.ToString();
            createdTextBox.Text = _currentOrder.CreationDate.
                ToString("dd.MM.yyyy HH:mm");

            // Заполняем статус
            statusComboBox.SelectedItem = _currentOrder.Status;

            // Заполняем время доставки
            deliveryTimeComboBox.SelectedItem = 
                _currentOrder.DesiredDeliveryTime;

            // Передаем адрес в контрол
            addressControl.Address = _currentOrder.DeliveryAddress;

            // Обновляем список товаров
            orderItemsListBox.Items.Clear();
            foreach (var item in _currentOrder.Items)
            {
                orderItemsListBox.Items.Add(item.Name);
            }

            // Обновляем стоимость
            costLabel.Text = _currentOrder.TotalAmount.ToString("N2");
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            // Создаем случайный товар
            Item newItem = ItemFactory.Randomize(10, 200);

            // Добавляем в заказ
            _currentOrder.Items.Add(newItem);

            // Обновляем отображение
            UpdateOrderInfo();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = orderItemsListBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                // Удаляем товар из заказа
                _currentOrder.Items.RemoveAt(selectedIndex);

                // Обновляем список
                UpdateOrderInfo();

                // Логика выбора следующего элемента 
                if (_currentOrder.Items.Count > 0)
                {
                    // Выбираем меньшее из двух чисел:
                    // старый индекс или индекс последнего элемента
                    orderItemsListBox.SelectedIndex = 
                    Math.Min(selectedIndex, _currentOrder.Items.Count - 1);
                }
            }
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            // По ТЗ: создаем новый экземпляр заказа
            _currentOrder = new PriorityOrder();

            // Сбрасываем выбор в UI (так как новый объект пустой)
            addressControl.ClearFields(); // Очистка AddressControl

            UpdateOrderInfo();
        }

        private void StatusComboBox_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            if (statusComboBox.SelectedIndex != -1)
            {
                _currentOrder.Status = 
                    (OrderStatus)statusComboBox.SelectedItem;
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            if (deliveryTimeComboBox.SelectedIndex != -1)
            {
                _currentOrder.DesiredDeliveryTime = 
                    deliveryTimeComboBox.SelectedItem.ToString();
            }
        }
    }
}