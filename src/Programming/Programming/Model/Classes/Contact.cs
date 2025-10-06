using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Класс, представляющий контакт с информацией о человеке.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Поле для хранения имени контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Поле для хранения фамилии контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Поле для хранения номера телефона.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Поле для хранения email.
        /// </summary>
        private string _email;

        /// <summary>
        /// Поле для хранения адреса.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает и задаёт имя контакта. Проверяет, что имя содержит только английские буквы.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Name));
                if (_name != value)
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию контакта. Проверяет, что фамилия содержит только английские буквы.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Surname));
                if (_surname != value)
                {
                    _surname = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        /// <summary>
        /// Возвращает и задаёт email.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// Возвращает и задаёт адрес.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Конструктор класса Contact с параметрами.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="surname">Фамилия контакта.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        /// <param name="email">Email.</param>
        /// <param name="address">Адрес.</param>
        public Contact(string name, string surname, string phoneNumber, string email, string address)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
        }

        /// <summary>
        /// Конструктор без параметров. Создает пустой контакт.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Закрытый метод валидации строки на наличие только английских букв.
        /// Выбрасывает исключение, если строка содержит недопустимые символы.
        // </summary> 
        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException($"{propertyName} must contain only English alphabet characters.");
            }
        }
    }
}