using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс процентной скидки на товары определенной категории.
    /// Скидка накапливается в процессе покупок и применяется
    /// только к товарам выбранной категории.
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        /// <summary>
        /// Текущий процент скидки.
        /// </summary>
        private int _percent;

        /// <summary>
        /// Общая сумма покупок товаров данной категории.
        /// </summary>
        private double _totalSpent;

        /// <summary>
        /// Возвращает текущий процент скидки.
        /// </summary>
        public int Percent
        {
            get { return _percent; }
            private set
            {
                ValueValidator.AssertValueInRange(
                    value, 1, 10, nameof(Percent));
                _percent = value;
            }
        }

        /// <summary>
        /// Возвращает категорию товаров,
        /// на которую распространяется скидка.
        /// </summary>
        public Category Category { get; }

        /// <summary>
        /// Возвращает информацию о скидке в строковом виде.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная \"{Category}\" - {Percent}%";
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса
        /// <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="category">
        /// Категория товаров, на которую предоставляется скидка.
        /// </param>
        public PercentDiscount(Category category)
        {
            Category = category;
            Percent = 1;
            _totalSpent = 0.0;
        }

        /// <summary>
        /// Рассчитывает размер скидки для указанного списка товаров.
        /// Скидка применяется только к товарам нужной категории.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер доступной скидки.</returns>
        public double Calculate(List<Item> items)
        {
            if (items == null || items.Count == 0)
            {
                return 0.0;
            }

            double categorySum = GetCategoryTotal(items);

            if (categorySum == 0.0)
            {
                return 0.0;
            }

            return categorySum * Percent / 100.0;
        }

        /// <summary>
        /// Применяет процентную скидку к списку товаров
        /// и возвращает размер примененной скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер примененной скидки.</returns>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Обновляет накопленные данные по покупкам
        /// и увеличивает процент скидки при необходимости.
        /// </summary>
        /// <param name="items">Список купленных товаров.</param>
        public void Update(List<Item> items)
        {
            if (items == null || items.Count == 0)
            {
                return;
            }

            double addedSum = GetCategoryTotal(items);

            if (addedSum <= 0.0)
            {
                return;
            }

            _totalSpent += addedSum;

            int newPercent = 1 + (int)(_totalSpent / 1000);

            if (newPercent > 10)
            {
                newPercent = 10;
            }

            Percent = newPercent;
        }

        #region Interface Implementations

        /// <inheritdoc />
        public int CompareTo(PercentDiscount other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            // Сравнение по проценту скидки (пункт 5 ТЗ)
            return Percent.CompareTo(other.Percent);
        }

        #endregion

        /// <summary>
        /// Вычисляет общую стоимость товаров нужной категории.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>
        /// Суммарная стоимость товаров выбранной категории.
        /// </returns>
        private double GetCategoryTotal(List<Item> items)
        {
            double sum = 0.0;

            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    sum += item.Cost;
                }
            }

            return sum;
        }
    }
}
