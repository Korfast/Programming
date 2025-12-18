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
            UpdateCartListBox();

            // Очищает discount CheckedListBox
            UpdateDiscountsCheckedListBox();
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

            // Пересчитываем скидки и итоговую цену, так как корзина изменилась
            UpdateAmounts();
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
            UpdateDiscountsCheckedListBox();
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

            double appliedDiscount = 0;

            // Применяем только выбранные скидки
            for (int i = 0; i < _currentCustomer.Discounts.Count; i++)
            {
                if (discountsCheckedListBox.GetItemChecked(i))
                {
                    appliedDiscount += _currentCustomer.Discounts[i]
                        .Apply(_currentCustomer.Cart.Items);
                }
            }

            // Обновляем все скидки (начисление баллов за покупку)
            foreach (IDiscount discount in _currentCustomer.Discounts)
            {
                discount.Update(_currentCustomer.Cart.Items);
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

            // Записываем примененную скидку в заказ
            newOrder.DiscountAmount = appliedDiscount;

            _currentCustomer.Orders.Add(newOrder);
            _currentCustomer.Cart.Items.Clear();

            // Обновляем интерфейс (скидки пересчитаются и галочки вернутся)
            UpdateCartListBox();
            UpdateDiscountsCheckedListBox();
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

        /// <summary>
        /// Обновляет список скидок в CheckedListBox и включает их все по умолчанию.
        /// </summary>
        private void UpdateDiscountsCheckedListBox()
        {
            discountsCheckedListBox.Items.Clear();

            if (_currentCustomer == null)
            {
                UpdateAmounts();
                return;
            }

            foreach (IDiscount discount in _currentCustomer.Discounts)
            {
                // Добавляем Info скидки и сразу ставим галочку (true)
                discountsCheckedListBox.Items.Add(discount.Info, true);
            }

            // После заполнения обновляем итоговые суммы
            UpdateAmounts();
        }

        /// <summary>
        /// Рассчитывает общую сумму скидки и итоговую стоимость корзины 
        /// с учетом выбранных скидок.
        /// </summary>
        private void UpdateAmounts()
        {
            double amount = 0;
            if (_currentCustomer != null 
                && _currentCustomer.Cart.Items.Count > 0)
            {
                amount = _currentCustomer.Cart.Amount;
            }

            double totalDiscountAmount = 0;

            // Считаем скидку только если есть покупатель и товары
            if (_currentCustomer != null && _currentCustomer.Discounts != null 
                && _currentCustomer.Cart.Items.Count > 0)
            {
                for (int i = 0; i < _currentCustomer.Discounts.Count; i++)
                {
                    // Расчет на основе метода Calculate() для выбранных галочек
                    if (i < discountsCheckedListBox.Items.Count 
                        && discountsCheckedListBox.GetItemChecked(i))
                    {
                        totalDiscountAmount += _currentCustomer.Discounts[i]
                            .Calculate(_currentCustomer.Cart.Items);
                    }
                }
            }

            // Ограничение: скидка не может быть больше суммы корзины
            if (totalDiscountAmount > amount)
            {
                totalDiscountAmount = amount;
            }

            // Вывод данных (discountCostLabel - это цифры,
            // discountAmountLabel - это текст "Discount Amount")
            costLabel.Text = amount.ToString("F2");
            discountCostLabel.Text = totalDiscountAmount.ToString("F2");
            totalCostLabel.Text = (amount - totalDiscountAmount).ToString("F2");
        }

        /// <summary>
        /// Обработчик события изменения состояния галочки в списке скидок.
        /// </summary>
        private void DiscountsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Используем BeginInvoke, чтобы пересчет произошел ПОСЛЕ изменения состояния галочки
            BeginInvoke(new Action(UpdateAmounts));
        }
    }
}
