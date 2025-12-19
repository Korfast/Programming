using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Интерфейс, представляющий скидку,
    /// которая может быть применена к списку товаров.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Получает описание скидки.
        /// </summary>
        /// <value>
        /// Строка, содержащая описание скидки.
        /// </value>
        string Info { get; }

        /// <summary>
        /// Вычисляет сумму скидки для списка товаров.
        /// </summary>
        /// <param name="items">Список товаров,
        /// для которых будет рассчитана скидка.</param>
        /// <returns>
        /// Сумма скидки для предоставленных товаров.
        /// </returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку к списку товаров.
        /// </summary>
        /// <param name="items">Список товаров,
        /// к которым будет применена скидка.</param>
        /// <returns>
        /// Новая сумма после применения скидки.
        /// </returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет скидку на основе изменений в списке товаров.
        /// </summary>
        /// <param name="items">Список товаров,
        /// для которых будет обновлена скидка.</param>
        void Update(List<Item> items);
    }
}
