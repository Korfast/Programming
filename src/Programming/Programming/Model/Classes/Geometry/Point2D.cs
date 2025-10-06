using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Класс для представления точки в двумерном пространстве.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Вещественное поле для хранения координаты X (только для чтения).
        /// </summary>
        private readonly double _x;

        /// <summary>
        /// Вещественное поле для хранения координаты Y (только для чтения).
        /// </summary>
        private readonly double _y;

        /// <summary>
        /// Получает значение координаты X.
        /// </summary>
        public double X => _x;

        /// <summary>
        /// Получает значение координаты Y.
        /// </summary>
        public double Y => _y;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Point2D"/> с заданными координатами.
        /// </summary>
        /// <param name="x">Координата X. Должна быть неотрицательной.</param>
        /// <param name="y">Координата Y. Должна быть неотрицательной.</param>
        public Point2D(double x, double y)
        {
            // Валидация принемаемых значений
            if (x < 0) throw new ArgumentOutOfRangeException(nameof(x), "X coordinate must be non-negative.");
            if (y < 0) throw new ArgumentOutOfRangeException(nameof(y), "Y coordinate must be non-negative.");

            // Присваивание значений полям
            _x = x; 
            _y = y;
        }
    }
}
