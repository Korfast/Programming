using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Перечисление, описывающее возможные состояния заказа.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Новый заказ.
        /// </summary>
        New,

        /// <summary>
        /// Заказ обрабатывается.
        /// </summary>
        Processing,

        /// <summary>
        /// Заказ собирается на складе.
        /// </summary>
        Assembly,

        /// <summary>
        /// Заказ отправлен.
        /// </summary>
        Sent,

        /// <summary>
        /// Заказ доставлен.
        /// </summary>
        Delivered,

        /// <summary>
        /// Возврат заказа.
        /// </summary>
        Returned,

        /// <summary>
        /// Заказ отменен.
        /// </summary>
        Abandoned
    }
}