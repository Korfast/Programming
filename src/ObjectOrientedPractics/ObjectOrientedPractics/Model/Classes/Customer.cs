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
        private string _address;

        /// <summary>
        /// Корзина товаров покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Id покупателя.
        /// </summary>
        public int Id
        { 
            get { return _id; } 
        }

        /// <summary>
        /// Полное имя покупателя.
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
        /// Адрес доставки покупателя.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringOnLength
                    (value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Конструктор c параметрами класса Customer.
        /// Инициализирует все свойства.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="address">Адрес доставки.</param>
        public Customer(string fullname, string address)
        {
            // Уникальный Id покупателя
            _id = _counter++; 
            Fullname = fullname;
            Address = address;
            _cart = new Cart();
        }
        /// <summary>
        /// Конструктор класса Customer без параметров. 
        /// Создает объект с пустыми значениями.
        /// </summary>>
        public Customer()
        {
            _id = ++_counter;
        }
    }
}