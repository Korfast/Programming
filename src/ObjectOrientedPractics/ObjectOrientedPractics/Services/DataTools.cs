using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет инструменты для обработки данных.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Делегат для методов фильтрации товаров.
        /// </summary>
        /// <param name="item">Товар для проверки.</param>
        /// <returns>True, если товар соответствует критерию.</returns>
        public delegate bool ItemFilter(Item item);

        /// <summary>
        /// Универсальный метод фильтрации списка товаров.
        /// </summary>
        /// <param name="items">Исходный список товаров.</param>
        /// <param name="filter">Делегат с критерием фильтрации.</param>
        /// <returns>Новый список товаров, прошедших фильтрацию.</returns>
        public static List<Item> FilterItems(List<Item> items, ItemFilter filter)
        {
            List<Item> filteredItems = new List<Item>();

            foreach (Item item in items)
            {
                // Используем делегат для проверки условия
                if (filter(item))
                {
                    filteredItems.Add(item);
                }
            }

            return filteredItems;
        }

        /// <summary>
        /// Сортирует список товаров по внешнему алгоритму.
        /// </summary>
        /// <param name="items">Список для сортировки.</param>
        /// <param name="sortMethod">Метод сравнения/сортировки.</param>
        public static List<Item> SortItems(List<Item> items, Comparison<Item> sortMethod)
        {
            List<Item> sortedList = new List<Item>(items);
            sortedList.Sort(sortMethod);
            return sortedList;
        }

        /// <summary>
        /// Критерий фильтрации: стоимость товара выше 5000.
        /// </summary>
        public static bool IsExpensive(Item item)
        {
            return item.Cost > 5000;
        }

        /// <summary>
        /// Критерий фильтрации: принадлежность к категории (например, Automotive).
        /// </summary>
        public static bool IsAutomotive(Item item)
        {
            return item.Category == Category.Automotive;
        }
    }
}
