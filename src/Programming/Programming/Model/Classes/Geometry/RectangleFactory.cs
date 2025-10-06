using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Статический класс для создания случайных объектов Rectangle.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Статичное поле, содержащее объект класса Random для генерации случайных чисел.
        /// </summary>
        private static readonly Random _random = new Random();

        /// <summary>
        /// Создает случайный прямоугольник с длиной и шириной в диапазоне целых чисел.
        /// </summary>
        /// <param name="LowerLimit">Нижняя граница диапазона (включительно).</param>
        /// <param name="UpperLimit">Верхняя граница диапазона (не включительно).</param>
        /// <returns>Объект типа Rectangle с случайными размерами и цветом LightGreen.</returns>
        public static Rectangle Randomize(int LowerLimit, int UpperLimit)
        {
            // Генерация случайной длины в диапазоне [LowerLimit, UpperLimit)
            double length = _random.Next(LowerLimit, UpperLimit);
            // Генерация случайной ширины в диапазоне [LowerLimit, UpperLimit)
            double width = _random.Next(LowerLimit, UpperLimit);
            // Установка цвета по умолчанию из перечисления Model.Color.LightGreen
            string color = Convert.ToString(Model.Color.LightGreen);

            // Создание нового объекта Rectangle с полученными параметрами
            Rectangle rectangle = new Rectangle(length, width, color);

            return rectangle;
        }

        /// <summary>
        /// Создает случайный прямоугольник с длиной и шириной в диапазоне с плавающей точкой.
        /// </summary>
        /// <param name="LowerLimit">Нижняя граница диапазона.</param>
        /// <param name="UpperLimit">Верхняя граница диапазона.</param>
        /// <returns>Объект типа Rectangle с случайными размерами и цветом LightGreen.</returns>
        public static Rectangle Randomize(double LowerLimit, double UpperLimit)
        {
            // Генерация случайной длины в диапазоне [LowerLimit, UpperLimit)
            double length = LowerLimit + _random.NextDouble() * (UpperLimit - LowerLimit);
            // Генерация случайной ширины в диапазоне [LowerLimit, UpperLimit)
            double width = LowerLimit + _random.NextDouble() * (UpperLimit - LowerLimit);
            // Установка цвета по умолчанию из перечисления Model.Color.LightGreen
            string color = Convert.ToString(Model.Color.LightGreen);

            // Создание нового объекта Rectangle с полученными параметрами
            Rectangle rectangle = new Rectangle(length, width, color);

            return rectangle;
        }
    }
}
