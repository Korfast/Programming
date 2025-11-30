using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, представляющий адрес.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Целочисленное поле почтовый индекс, целое шестизначное число.
        /// </summary>
        private int _index;

        /// <summary>
        /// Поле - страна/регион, строка, не более 50 символов.
        /// </summary>
        private string _country;

        /// <summary>
        /// Поле – город (населенный пункт), строка, не более 50 символов.
        /// </summary>
        private string _city;

        /// <summary>
        /// Поле – улица, строка, не более 100 символов.
        /// </summary>
        private string _street;

        /// <summary>
        /// Поле – номер дома, строка, не более 10 символов.
        /// </summary>
        private string _building;

        /// <summary>
        /// Поле – номер квартиры/помещения, не более 10 символов.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задаёт почтовый индекс.
        /// Значение должно быть шестизначным числом 
        /// в диапазоне от 100000 до 999999.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                ValueValidator.AssertValueInRange
                    (value, 100000, 999999, nameof(Index));
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт название страны или региона.
        /// Максимальная длина строки — 50 символов.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertStringOnLength
                    (value, 50, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт название города.
        /// Максимальная длина строки — 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт название улицы.
        /// Максимальная длина строки — 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertStringOnLength
                    (value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер дома.
        /// Максимальная длина строки — 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                ValueValidator.AssertStringOnLength
                    (value, 10, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер квартиры или помещения.
        /// Максимальная длина строки — 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                ValueValidator.AssertStringOnLength
                    (value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию. 
        /// Создаёт экзэмпляр класса<see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 999999;
            Country = string.Empty;
            City = string.Empty;
            Street = string.Empty;
            Building = string.Empty;
            Apartment = string.Empty;
        }

        /// <summary>
        /// Конструктор с параметрами для инициализации всех свойств.
        /// </summary>
        /// <param name="index">Почтовый индекс (6-значное число).</param>
        /// <param name="country">Страна или регион
        /// (не более 50 символов).</param>
        /// <param name="city">Город (не более 50 символов).</param>
        /// <param name="street">Улица (не более 100 символов).</param>
        /// <param name="building">Номер дома (не более 10 символов).</param>
        /// <param name="apartment">Номер квартиры/помещения
        /// (не более 10 символов).</param>
        public Address(int index, string country, string city,
            string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}