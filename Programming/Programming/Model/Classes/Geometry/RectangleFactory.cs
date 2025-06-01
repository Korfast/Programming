using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal static class RectangleFactory
    {
        // Статичное поле объект класса Random
        private static readonly Random _random = new Random();

        public static Rectangle Randomize(int LowerLimit, int UpperLimit)
        {
            // Генерация случайной длины
            double length = _random.Next(LowerLimit, UpperLimit);
            // Генерация случайной ширины
            double width = _random.Next(LowerLimit, UpperLimit);
            // Выбор цвета по умолчанию из перечисления: LightGreen
            string color = Convert.ToString(Model.Color.LightGreen);

            Rectangle rectangle = new Rectangle(length, width, color);

            return rectangle;
        }

        public static Rectangle Randomize(double LowerLimit, double UpperLimit) 
        {
            // Генерация случайных длины
            double length = LowerLimit + _random.NextDouble() * (UpperLimit - LowerLimit);
            // Генерация случайной ширины
            double width = LowerLimit + _random.NextDouble() * (UpperLimit - LowerLimit);
            // Выбор цвета по умолчанию из перечисления: LightGreen
            string color = Convert.ToString(Model.Color.LightGreen);

            Rectangle rectangle = new Rectangle(length, width, color);

            return rectangle;
        }
    }
}
