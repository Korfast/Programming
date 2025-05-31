using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    // Класс Менеджер столкновений
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            // Вычисляеи расстояние между центрами прямоугольников
            double xDistance = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double yDistance = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

            // Проверяем прямоугольники на пересечение
            if (xDistance < (rectangle1.Width + rectangle2.Width) / 2
                && yDistance < (rectangle1.Length + rectangle2.Length) / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            // Вычисляем расстояние между центрами колец
            double distance = Math.Sqrt(Math.Pow(ring1.Center.X - ring2.Center.X, 2)
                + Math.Pow(ring1.Center.Y - ring2.Center.Y, 2));

            // Проверяем на вписывание одного кольца в другое
            if (distance < Math.Abs(ring1.OuterRadius - ring2.InnerRadius))
            {
                return true;
            }

            // Проверяем кольца на пересечение
            if (distance < (ring1.OuterRadius + ring2.OuterRadius))
            {
                return true;
            }

            return false;
        }
    }
}
