using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary> /// Статический класс, предоставляющий методы 
    /// для определения столкновений между различными геометрическими фигурами. /// </summary>
    public static class CollisionManager
    {
        /// <summary> 
        /// Проверяет, пересекаются ли два прямоугольника. 
        /// </summary> 
        /// <param name="rectangle1">Первый прямоугольник.</param> 
        /// <param name="rectangle2">Второй прямоугольник.</param> 
        /// <returns>Возвращает true, если прямоугольники пересекаются; иначе — false.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            // Вычисляеи расстояние между центрами прямоугольников
            double xDistance = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double yDistance = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

            // Проверяем прямоугольники на пересечение
            // Проверяем пересечение по горизонтали и вертикали
            return (xDistance < (rectangle1.Width + rectangle2.Width) / 2) &&
                   (yDistance < (rectangle1.Length + rectangle2.Length) / 2);
        }

        /// <summary>
        /// Проверяет, пересекаются ли два кольца.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>Возвращает true, если кольца пересекаются или одно вписывается в другое; иначе — false.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            // Вычисляет расстояние между центрами колец по формуле расстояния между точками
            double distance = Math.Sqrt(Math.Pow(ring1.Center.X - ring2.Center.X, 2)
                + Math.Pow(ring1.Center.Y - ring2.Center.Y, 2));

            // Проверяет, входит ли одно кольцо в другое (вписывание)
            if (distance < Math.Abs(ring1.OuterRadius - ring2.InnerRadius))
            {
                return true;
            }

            // Проверяет, пересекаются ли кольца (пересечение внешних окружностей)
            if (distance < (ring1.OuterRadius + ring2.OuterRadius))
            {
                return true;
            }

            // В противном случае — колёса не пересекаются
            return false;
        }
    }
}
