using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, представляющий заказ с уникальным Id, датой создания,
    /// адресом доставки, списком товаров и общей стоимостью.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Статическое поле-счётчик для генерации уникальных Id.
        /// </summary>
        private static int _counter = 0;

        /// <summary>
        /// Целочисленное поле для хранения id (только для чтения).
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Дата и время создания заказа.
        /// </summary>
        private readonly DateTime _creationDate;

        /// <summary>
        /// Статус заказа.
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _deliveryAddress;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Возвращает id заказа.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime CreationDate
        {
            get
            {
                return _creationDate;
            }
        }

        /// <summary>
        /// Возвращает и задаёт статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес доставки.
        /// </summary>
        public Address DeliveryAddress
        {
            get
            {
                return _deliveryAddress;
            }
            set
            {
                // Адрес не должен быть null 
                if (value == null)
                {
                    _deliveryAddress = new Address();
                }
                // если пришло null - создаем пустой
                else
                {
                    _deliveryAddress = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт список товаров заказа.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                // Список товаров не должен быть null
                if (value == null)
                {
                    _items = new List<Item>();
                }
                else
                {
                    _items = value;
                }
            }
        }

        /// <summary>
        /// Вычисляет общую стоимость всех товаров в заказе.
        /// </summary>
        public double Amount
        {
            get
            {
                double amount = 0.0;
                if (_items == null)
                {
                    return amount;
                }

                foreach (Item item in _items)
                {
                    amount += item.Cost;
                }
                return amount;
            }
        }

        /// <summary>
        /// Возвращает и задаёт размер примененной скидки.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Возвращает конечную стоимость заказа (сумма товаров минус скидка).
        /// </summary>
        public double Total
        {
            get
            {
                return Amount - DiscountAmount;
            }
        }

        /// <summary>
        /// Конструктор для создания заказа.
        /// Инициализирует поля, устанавливает дату создания и статус "New".
        /// </summary>
        /// <param name="deliveryAddress">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        public Order(Address deliveryAddress, List<Item> items)
        {
            _id = _counter++;
            _creationDate = DateTime.Now;
            _status = OrderStatus.New;
            DeliveryAddress = deliveryAddress;
            Items = items;
        }

        /// <summary>
        /// Конструктор без параметров 
        /// (для сериализации или создания пустого заказа).
        /// </summary>
        public Order()
        {
            _id = _counter++;
            _creationDate = DateTime.Now;
            _status = OrderStatus.New;
            DeliveryAddress = new Address();
            Items = new List<Item>();
        }
    }
}