using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class Validator
    {
        // Метод для проверки положительного значения
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{propertyName} must be a positive value.");
            }
        }

        // Перегрузка метода для проверки положительного значения (double)
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0.0)
            {
                throw new ArgumentException($"{propertyName} must be a positive value.");
            }
        }

        // Метод для проверки, находится ли значение в заданном диапазоне
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{propertyName} must be in the range of {min} to {max}.");
            }
        }

        public static void AssertValueInRange(double value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{propertyName} must be in the range of {min} to {max}.");
            }
        }
    }
}
