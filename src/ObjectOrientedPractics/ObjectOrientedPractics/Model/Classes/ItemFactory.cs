using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public static class ItemFactory
    {

        /// <summary>
        /// Статичное поле, содержащее объект класса Random 
        /// для генерации случайных чисел.
        /// </summary>
        private static readonly Random _random = new Random();

        /// <summary>
        /// Массив возможных названий товаров.
        /// </summary>
        private static readonly string[] _names =
        {
            "Магазин", "Подарок", "Книга", "Ручка", "Компьютер", "Телефон",
            "Кот", "Пес", "Игрушка", "Мяч",
            "Часы", "Очки", "Рюкзак", "Футболка", "Кофе", "Стул",
            "Стол", "Лампа", "Зеркало", "Телевизор", "Фотоаппарат", "Ноутбук",
            "Планшет", "Музыкальный центр", "Клавиатура", "Мышь", "Колонки",
            "Велосипед", "Книга рецептов", "Картина", "Ваза"
        };

        /// <summary>
        /// Массив возможных описаний товаров,
        /// соответствует индексам массива названий.
        /// </summary>
        private static readonly string[] _infos =
        {
            "Маленький уютный магазин",
            "Уникальный подарок для близких",
            "Интересная книга по искусству",
            "Стильная и удобная ручка",
            "Мощный игровой компьютер",
            "Современный смартфон с камерой",
            "Мягкий и ласковый котёнок",
            "Верный друг и защитник",
            "Яркая игрушка для детей",
            "Прыгающий мяч для игр",
            "Элегантные наручные часы",
            "Солнцезащитные очки высокого качества",
            "Прочный и вместительный рюкзак",
            "Удобная и красивая футболка",
            "Ароматный и бодрящий кофе",
            "Комфортабельный стул для офиса",
            "Большой деревянный стол",
            "Настольная лампа с мягким светом",
            "Красивая настенная зеркало",
            "Современный LED телевизор",
            "Профессиональный цифровой фотоаппарат",
            "Легкий и мощный ноутбук",
            "Планшет с ярким экраном",
            "Мощный музыкальный центр для дома",
            "Удобная клавиатура для работы",
            "Быстрая и точная компьютерная мышь",
            "Стильные колонки с отличным звуком",
            "Легкий городской велосипед",
            "Вкусная книга с рецептами",
            "Красочная картина для интерьера",
            "Элегантная декоративная ваза"
        };

        /// <summary>
        /// Возвращает массив возможных названий товаров.
        /// </summary>
        public static string[] Names
        { get { return _names; } }

        /// <summary>
        /// Возвращает массив возможных описаний товаров.
        /// </summary>
        public static string[] Infos 
        { get { return _infos; } }

        /// <summary>
        /// Создает случайный товар с названием, информацией и ценой.
        /// </summary>
        /// <param name="lowerCostLimit">Нижняя граница цены 
        /// (включительно).</param>
        /// <param name="upperCostLimit">Верхняя граница цены 
        /// (не включительно).</param>
        /// <returns>Объект типа Item 
        /// с случайными значениями</returns>
        public static Item Randomize(int lowerCostLimit, int upperCostLimit)
        {
            int index = _random.Next(_names.Length);
            // Генерация случайного названия
            string name = _names[index];
            // Генерация случайнго описания
            string info = _infos[index];
            // Генерация цены в пределах
            double cost = _random.Next(lowerCostLimit, upperCostLimit);
            

            // Создание нового объекта Item с полученными параметрами
            Item item = new Item(name, info, cost);

            return item;
        }

        /// <summary>
        /// Создает случайный товар с названием,
        /// информацией и ценой.
        /// </summary>
        /// <param name="lowerCostLimit">Нижняя граница цены 
        /// (включительно).</param>
        /// <param name="upperCostLimit">Верхняя граница цены 
        /// (не включительно).</param>
        /// <returns>Объект типа Item с случайными значениями.</returns>
        public static Item Randomize(double lowerCostLimit, double upperCostLimit)
        {
            int index = _random.Next(_names.Length);
            // Генерация случайного названия
            string name = _names[index];
            // Генерация соответствующего описания
            string info = _infos[index];

            // Генерация цены в диапазоне с плавающей точкой
            double cost = lowerCostLimit + _random.NextDouble() * (upperCostLimit - lowerCostLimit);

            // Создание нового объекта Item с полученными параметрами
            Item item = new Item(name, info, cost);

            return item;
        }
    }
}
