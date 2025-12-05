using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, представляющий магазин, хранящий списки товаров и клиентов.
    /// </summary>
    internal class Store
    {
        /// <summary>
        /// Коллекция товаров магазина.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Коллекция покупателей магазина.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает и задаёт коллекцию товаров магазина.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
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
        /// Возвращает и задаёт коллекцию покупателей магазина.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                if (value == null)
                {
                    _customers = new List<Customer>();
                }
                else
                {
                    _customers = value;
                }
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// Инициализирует обе коллекции пустыми списками.
        /// </summary>
        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customer>();
        }
    }
}