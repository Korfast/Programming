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
        // Новый заказ
        New,
        // Обрабатывается
        Processing,
        // Собирается на складе
        Assembly,
        // Отправлен
        Sent,
        // Доставлен
        Delivered,
        // Возврат
        Returned,
        // Отменен (со стороны магазина)
        Abandoned
    }
}