using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет приоритетный заказ.
    /// Хранит желаемую дату и время доставки.
    /// Наследуется от класса <see cref="Order"/>.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        private DateTime _desiredDeliveryDate;

        /// <summary>
        /// Желаемое время доставки.
        /// </summary>
        private string _desiredDeliveryTime;

        /// <summary>
        /// Список допустимых диапазонов доставки.
        /// </summary>
        private static readonly string[] _deliveryTimeRanges =
        {
            "9:00 – 11:00",
            "11:00 – 13:00",
            "13:00 – 15:00",
            "15:00 – 17:00",
            "17:00 – 19:00",
            "19:00 – 21:00"
        };

        /// <summary>
        /// Возвращает и задает желаемую дату доставки.
        /// Значение должно соответствовать одному из диапазонов из списка.
        /// </summary>
        public DateTime DesiredDeliveryDate
        {
            get { return _desiredDeliveryDate; }
            set { _desiredDeliveryDate = value; }
        }

        /// <summary>
        /// Возвращает и задает желаемое время доставки.
        /// Строка должна содержать диапазон, из DeliveryTimeRanges.
        /// </summary>
        public string DesiredDeliveryTime
        {
            get { return _desiredDeliveryTime; }
            set
            {
                // Проверяем, есть ли пришедшее значение (value)
                // в списке разрешенных
                // Используем System.Linq для метода Contains
                if (!_deliveryTimeRanges.Contains(value))
                {
                    throw new ArgumentException
                        ($"Value '{value}' " +
                        $"is not a valid delivery time range.");
                }

                _desiredDeliveryTime = value;
            }
        }

        public static string[] DeliveryTimeRanges
        { 
            get { return _deliveryTimeRanges; }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="deliveryAddress">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        /// <param name="desiredDeliveryDate">Желаемая дата доставки.</param>
        /// <param name="desiredDeliveryTime">Желаемое время доставки.</param>
        public PriorityOrder(Address deliveryAddress, List<Item> items, 
            DateTime desiredDeliveryDate, string desiredDeliveryTime)
            : base(deliveryAddress, items)
        {
            DesiredDeliveryDate = desiredDeliveryDate;
            DesiredDeliveryTime = desiredDeliveryTime;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="deliveryAddress">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        public PriorityOrder(Address deliveryAddress, List<Item> items)
            : base(deliveryAddress, items)
        {
            DesiredDeliveryDate = DateTime.Now.AddDays(7);
            DesiredDeliveryTime = DeliveryTimeRanges[0];

        }

        /// <summary>
        /// Конструктор без параметров <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder() : base()
        {

        }
    }
}