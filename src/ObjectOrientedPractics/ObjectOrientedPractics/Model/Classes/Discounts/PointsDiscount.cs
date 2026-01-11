using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс накопительной скидки на основе баллов.
    /// Баллы накапливаются при покупке товаров и могут быть
    /// использованы для получения скидки.
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        /// <summary>
        /// Максимальный процент скидки.
        /// </summary>
        private const double MaxDiscountPercent = 0.3;

        /// <summary>
        /// Количество накопленных баллов.
        /// </summary>
        private int _points;

        /// <summary>
        /// Возвращает и задает количество накопленных баллов.
        /// </summary>
        public int Points
        {
            get { return _points; }
            private set
            {
                ValueValidator.AssertValueInRange(
                    value, 0, int.MaxValue, nameof(Points));
                _points = value;
            }
        }

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        { 
            get { return $"Накопительная – {Points} баллов"; } 
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        public PointsDiscount()
        {
            Points = 0;
        }

        /// <summary>
        /// Рассчитывает размер скидки для указанного списка товаров
        /// на основе текущего количества накопленных баллов.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер доступной скидки.</returns>
        public double Calculate(List<Item> items)
        {
            if (items == null || items.Count == 0)
            {
                return 0.0;
            }

            double totalAmount = GetTotalAmount(items);
            double maxDiscount = totalAmount * MaxDiscountPercent;

            return Math.Min(Points, maxDiscount);
        }

        /// <summary>
        /// Применяет скидку к указанному списку товаров,
        /// списывает использованные баллы и
        /// возвращает размер примененной скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер примененной скидки.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);

            if (discount <= 0.0)
            {
                return 0.0;
            }

            int spentPoints = (int)Math.Round(discount);
            Points -= spentPoints;

            return discount;
        }

        /// <summary>
        /// Обновляет количество накопленных баллов
        /// на основе списка купленных товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            if (items == null || items.Count == 0)
            {
                return;
            }

            double totalAmount = GetTotalAmount(items);
            int addedPoints = (int)Math.Ceiling(totalAmount * 0.1);

            ValueValidator.AssertOnPositiveValue(
                addedPoints, nameof(Points));

            Points += addedPoints;
        }

        #region Interface Implementations

        /// <inheritdoc />
        public int CompareTo(PointsDiscount other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            // Сравнение по количеству баллов (пункт 5 ТЗ)
            return Points.CompareTo(other.Points);
        }

        #endregion

        /// <summary>
        /// Вычисляет общую стоимость списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>
        /// Общая стоимость всех товаров в списке.
        /// </returns>
        private double GetTotalAmount(List<Item> items)
        {
            double sum = 0.0;
            foreach (Item item in items)
            {
                sum += item.Cost;
            }
            return sum;
        }
    }
}
