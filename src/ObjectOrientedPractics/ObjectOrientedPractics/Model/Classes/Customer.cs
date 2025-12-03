using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, представляющий покупателя (Customer) 
    /// с уникальным id, полным именем и адресом доставок.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Статическое поле-счётчик для генерации уникальных Id.
        /// </summary>
        private static int _counter = 0;

        /// <summary>
        /// Уникальный идентификатор покупателя (readonly).
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя, до 200 символов.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес доставки, до 500 символов.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Список заказов покупателя.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Возвращает id покупателя.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// Должно быть не более 200 символов.
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength
                    (value, 200, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес доставки покупателя.
        /// </summary>
        public Address Address
        {
            get  {return _address; }
            set
            {
                // задаем новый Address, если null
                if (value == null)
                {
                    _address = new Address();
                }
                else
                {
                    _address = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает корзину покупателя.
        /// </summary>
        public Cart Cart
        {
            get{ return _cart; }
            set
            {
                // Корзина не может быть null
                if (value == null)
                {
                    _cart = new Cart();
                }
                else
                {
                    _cart = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает список заказов покупателя.
        /// </summary>
        public List<Order> Orders
        {
            get { return _orders;}
            set
            {
                // Список заказов не может быть null
                if (value == null)
                {
                    _orders = new List<Order>();
                }
                else
                {
                    _orders = value;
                }
            }
        }

        /// <summary>
        /// Конструктор c параметрами класса Customer.
        /// Инициализирует все свойства.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="address">Адрес доставки.</param>
        public Customer(string fullname, Address address)
        {
            // Уникальный Id покупателя
            _id = _counter++;
            Fullname = fullname;
            Address = address;
            Cart = new Cart();
            Orders = new List<Order>();
        }

        /// <summary>
        /// Конструктор класса Customer без параметров. 
        /// Создает объект с пустыми значениями и инициализирует списки.
        /// </summary>
        public Customer()
        {
            _id = _counter++;
            Fullname = string.Empty;
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
        }
    }
}