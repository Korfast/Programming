using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Описывает корзину товаров покупателя.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Открытое свойство для доступа к списку товаров.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Вычисляет общую стоимость всех товаров в корзине.
        /// </summary>
        public double Amount
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
        /// Конструктор. Инициализирует список товаров.
        /// </summary>
        public Cart()
        {
            _items = new List<Item>();
        }

        /// <inheritdoc />
        public object Clone()
        {
            Cart clone = new Cart();
            // Клонируем список товаров, чтобы изменения в одном списке не влияли на другой
            foreach (Item item in Items)
            {
                clone.Items.Add((Item)item.Clone());
            }
            return clone;
        }
    }
}