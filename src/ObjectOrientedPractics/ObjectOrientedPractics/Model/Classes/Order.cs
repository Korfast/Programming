using ObjectOrientedPractics.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
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
        private string _deliveryAddress;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Возвращает id заказа.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime CreationDate
        {
            get { return _creationDate; }
        }

        /// <summary>
        /// Возвращает или задаёт статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// Возвращает или задаёт адрес доставки.
        /// </summary>
        public string DeliveryAddress
        {
            get { return _deliveryAddress; }
            set { _deliveryAddress = value; }
        }

        /// <summary>
        /// Возвращает или задаёт список товаров заказа.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Вычесляет общую стоимость всех товаров в заказе.
        /// </summary>
        public double TotalAmount
        {
            get
            {
                double total = 0.0;
                foreach (Item item in Items)
                {
                    total += item.Cost;
                }
                return total;
            }
        }

        /// <summary>
        /// Конструктор для создания заказа.
        /// </summary>
        /// <param name="deliveryAddress">Адрес доставки</param>
        /// <param name="items">Список товаров</param>
        public Order(string deliveryAddress, List<Item> items)
        {
            _id = ++_counter;
            _creationDate = DateTime.Now;
            DeliveryAddress = deliveryAddress;
            Items = items ?? new List<Item>();
        }
    }
}
