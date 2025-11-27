using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс для генерации случайных покупателей (Customer).
    /// </summary>
    public static class CustomerFactory
    {
        private static readonly Random _random = new Random();

        // Имена для покупателей
        private static readonly string[] _firstNames =
        {
            "Алексей", "Мария", "Иван", "Дарья", "Павел", "Ольга",
            "Сергей", "Елена", "Дмитрий", "Анна", "Максим", "Ксения"
        };

        private static readonly string[] _lastNames =
        {
            "Иванов", "Петрова", "Смирнов", "Кузнецова", "Соколов", "Леонова",
            "Борисов", "Зайцева", "Морозов", "Васильева", "Попов", "Лаврова"
        };

        private static readonly string[] _streetNames =
        {
            "Ленина", "Советская", "Мира", "Кирова", "Пролетарская",
            "Победная", "Маяковского", "Гагарина", "Карла Маркса", "Пушкина",
            "Гагарина", "Театральная"
        };

        private static readonly string[] _countries =
        {
            "Россия", "Украина", "Беларусь", "Казахстан", "Кыргызстан",
            "Армения", "Грузия", "Азербайджан", "Молдова", "Турция",
            "Курская Республика", "Нидерланды", "Германия"
        };

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
        /// <param name="minLen">Минимальная длина имени.</param>
        /// <param name="maxLen">Максимальная длина имени.</param>
        /// <returns>Строка с полным именем.</returns>
        private static string GenerateFullName(int minLen, int maxLen)
        {
            string firstName = _firstNames[_random.Next(_firstNames.Length)];
            string lastName = _lastNames[_random.Next(_lastNames.Length)];
            string fullName = $"{firstName} {lastName}";

            // Если нужно, можно дополнительно добавить среднее имя или увеличить сложность
            // Проверим длину и при необходимости добавим что-то
            if (fullName.Length < minLen)
            {
                // Можно дополнительно добавлять отчество или другие части
                fullName += " Иванович"; // пример
            }

            // Обрезка, если имя слишком длинное
            if (fullName.Length > maxLen)
            {
                fullName = fullName.Substring(0, maxLen);
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
            string street = $"{_random.Next(1, 300)}";
            string building = $"{_random.Next(1, 1000)}";
            string apartment = $"{_random.Next(1, 100)}";

            Address address = new Address
                (index, country, city, street, building, apartment);

            return address;
        }
    }
}