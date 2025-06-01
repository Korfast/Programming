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

        public static Rectangle Randomize(double LowerLimit, double UpperLimit) 
        {
            // Преобразование лимитов в целочисленные
            int IntLowerLimit = Convert.ToInt32(LowerLimit);
            int IntUpperLimit = Convert.ToInt32(UpperLimit);

            // Генерация случайной длины
            double length = _random.Next(IntLowerLimit, IntUpperLimit);
            // Генерация случайной ширины
            double width = _random.Next(IntLowerLimit, IntUpperLimit);
            // Выбор цвета по умолчанию из перечисления: LightGreen
            string color = Convert.ToString(Model.Color.LightGreen);

            Rectangle rectangle = new Rectangle(length, width, color);

            return rectangle;
        }
    }
}
