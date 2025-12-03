using ObjectOrientedPractics.Model;
using System;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс для генерации случайных покупателей (Customer).
    /// </summary>
    public static class CustomerFactory
    {
        /// <summary>
        /// Статичное поле, содержащее объект класса Random 
        /// для генерации случайных чисел.
        /// </summary>
        private static readonly Random _random = new Random();

        /// <summary>
        /// Массив имен для генерации случайных данных.
        /// </summary>
        private static readonly string[] _firstNames =
        {
            "Алексей", "Мария", "Иван", "Дарья", "Павел", "Ольга",
            "Сергей", "Елена", "Дмитрий", "Анна", "Максим", "Ксения"
        };

        /// <summary>
        /// Массив фамилий для генерации случайных данных.
        /// </summary>
        private static readonly string[] _lastNames =
        {
            "Иванов", "Петрова", "Смирнов", "Кузнецова", "Соколов", "Леонова",
            "Борисов", "Зайцева", "Морозов", "Васильева", "Попов", "Лаврова"
        };

        /// <summary>
        /// Массив названий улиц для генерации случайных данных.
        /// </summary>
        private static readonly string[] _streetNames =
        {
            "Ленина", "Советская", "Мира", "Кирова", "Пролетарская",
            "Победная", "Маяковского", "Гагарина", "Карла Маркса", "Пушкина",
            "Гагарина", "Театральная"
        };

        /// <summary>
        /// Массив названий стран для генерации случайных данных.
        /// </summary>
        private static readonly string[] _countries =
        {
            "Россия", "Украина", "Беларусь", "Казахстан", "Кыргызстан",
            "Армения", "Грузия", "Азербайджан", "Молдова", "Турция",
            "Курская Республика", "Нидерланды", "Германия"
        };

        /// <summary>
        /// Массив названий городов для генерации случайных данных.
        /// </summary>
        private static readonly string[] _cities =
        {
            "Москва", "Санкт-Петербург", "Новосибирск", "Екатеринбург",
            "Казань", "Ростов", "Воронеж", "Краснодар", "Самара", "Уфа",
            "Челябинск", "Омск"
        };

        /// <summary>
        /// Создает случайного покупателя с именем и адресом,
        /// длиной в указанном диапазоне.
        /// </summary>
        /// <param name="minNameLength">
        /// Минимальная длина полного имени.</param>
        /// <param name="maxNameLength">
        /// Максимальная длина полного имени.</param>
        /// <returns>Объект Customer с случайными данными.</returns>
        public static Customer Randomize(int minNameLength, int maxNameLength)
        {
            string fullname = GenerateFullName(minNameLength, maxNameLength);
            Address address = GenerateAddress();

            return new Customer(fullname, address);
        }

        /// <summary>
        /// Генерирует случайное полное имя.
        /// </summary>
        /// <param name="minNameLength">Минимальная длина имени.</param>
        /// <param name="maxNameLength">Максимальная длина имени.</param>
        /// <returns>Строка с полным именем.</returns>
        private static string GenerateFullName
            (int minNameLength, int maxNameLength)
        {
            string firstName = _firstNames[_random.Next(_firstNames.Length)];
            string lastName = _lastNames[_random.Next(_lastNames.Length)];
            string fullName = $"{firstName} {lastName}";

            // Пытаемся сгенерировать имя снова, если оно слишком короткое
            if (fullName.Length < minNameLength)
            {
                return GenerateFullName(minNameLength, maxNameLength);
            }

            // Обрезка, если имя слишком длинное
            if (fullName.Length > maxNameLength)
            {
                fullName = fullName.Substring(0, maxNameLength);
            }

            return fullName;
        }

        /// <summary>
        /// Генерирует случайный объект Address.
        /// </summary>
        /// <returns>Объект Address с случайными данными.</returns>
        private static Address GenerateAddress()
        {
            int index = _random.Next(100000, 999999);
            string country = _countries[_random.Next(_countries.Length)];
            string city = _cities[_random.Next(_cities.Length)];
            string street = _streetNames[_random.Next(_streetNames.Length)];
            string building = $"{_random.Next(1, 1000)}";
            string apartment = $"{_random.Next(1, 100)}";

            Address address = new Address
                (index, country, city, street, building, apartment);

            return address;
        }
    }
}