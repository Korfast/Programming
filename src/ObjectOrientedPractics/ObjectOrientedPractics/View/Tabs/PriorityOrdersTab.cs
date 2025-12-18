using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка пользовательского интерфейса для создания и редактирования
    /// приоритетных заказов.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Текущий приоритетный заказ.
        /// </summary>
        private PriorityOrder _currentOrder;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PriorityOrdersTab"/>.
        /// Выполняет начальную настройку элементов управления и
        /// создает новый пустой приоритетный заказ.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();

            // Заполняем статусы
            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
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
        /// Обновляет элементы пользовательского интерфейса в соответствии
        /// с данными текущего приоритетного заказа.
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
            foreach (Item item in _currentOrder.Items)
            {
                orderItemsListBox.Items.Add(item.Name);
            }

            // Обновляем стоимость
            costLabel.Text = _currentOrder.Amount.ToString("N2");
        }

        /// <summary>
        /// Обработчик нажатия кнопки добавления товара в заказ.
        /// Создает случайный товар и добавляет его в текущий заказ.
        /// </summary>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            // Создаем случайный товар
            Item newItem = ItemFactory.Randomize(10, 200);

            // Добавляем в заказ
            _currentOrder.Items.Add(newItem);

            // Обновляем отображение
            UpdateOrderInfo();
        }

        /// <summary>
        /// Обработчик нажатия кнопки удаления товара из заказа.
        /// Удаляет выбранный товар из списка товаров текущего заказа.
        /// </summary>
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

        /// <summary>
        /// Обработчик нажатия кнопки очистки заказа.
        /// Создает новый пустой приоритетный заказ и сбрасывает данные формы.
        /// </summary>

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            // По ТЗ: создаем новый экземпляр заказа
            _currentOrder = new PriorityOrder();

            // Сбрасываем выбор в UI (так как новый объект пустой)
            addressControl.ClearFields(); // Очистка AddressControl

            UpdateOrderInfo();
        }

        /// <summary>
        /// Обработчик изменения выбранного статуса заказа.
        /// Обновляет статус текущего приоритетного заказа.
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            if (statusComboBox.SelectedIndex != -1)
            {
                _currentOrder.Status = 
                    (OrderStatus)statusComboBox.SelectedItem;
            }
        }

        /// <summary>
        /// Обработчик изменения выбранного времени доставки.
        /// Обновляет желаемое время доставки текущего приоритетного заказа.
        /// </summary>
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