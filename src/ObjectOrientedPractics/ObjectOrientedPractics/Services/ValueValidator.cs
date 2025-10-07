using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Статический класс, содержащий методы для валидации данных.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет, что значение положительное (больше нуля).
        /// </summary>
        /// <param name="value">Значение для проверки.</param>
        /// <param name="propertyName">Имя свойства или параметра.</param>
        public static void AssertOnPositiveValue
            (int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException
                    ($"{propertyName} must be a positive value.");
            }
        }

        /// <summary>
        /// Проверяет, что значение типа double положительное (больше нуля).
        /// </summary>
        /// <param name="value">Значение для проверки.</param>
        /// <param name="propertyName">Имя свойства или параметра.</param>
        public static void AssertOnPositiveValue
            (double value, string propertyName)
        {
            if (value <= 0.0)
            {
                throw new ArgumentException
                    ($"{propertyName} must be a positive value.");
            }
        }

        /// <summary>
        /// Проверяет, что значение находится в диапазоне от min до max.
        /// </summary>
        /// <param name="value">Значение для проверки.</param>
        /// <param name="min">Минимальное допустимое значение.</param>
        /// <param name="max">Максимальное допустимое значение.</param>
        /// <param name="propertyName">Имя свойства или параметра.</param>
        public static void AssertValueInRange
            (int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{propertyName} " +
                    $"must be in the range of {min} to {max}.");
            }
        }

        /// <summary>
        /// Перегрузка метода для проверки,
        /// что значение типа double находится в диапазоне от min до max.
        /// </summary>
        /// <param name="value">Значение для проверки.</param>
        /// <param name="min">Минимальное допустимое значение.</param>
        /// <param name="max">Максимальное допустимое значение.</param>
        /// <param name="propertyName">Имя свойства или параметра.</param>
        public static void AssertValueInRange
            (double value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{propertyName} " +
                    $"must be in the range of {min} to {max}.");
            }
        }

        /// <summary>
        /// Проверяет, что длина строки 
        /// не превышает максимально допустимое значение.
        /// Выбрасывает ArgumentException, если длина строки больше maxLength.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимально допустимая 
        /// длина строки.</param>
        /// <param name="propertyName">Имя свойства или параметра.</param>
        public static void AssertStringOnLength
            (string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} " +
                    $"should not be more than {maxLength}.");
            }
        }
    }
}
