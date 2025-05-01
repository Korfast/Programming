using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model
{
    // Класс Контакт
    public class Contact
    {
        // Строковое поле Имя
        private string _name;
        // Строковое поле Фамилия
        private string _surname;
        // Строковое поле Номер телефона
        private string _phoneNumber;
        // Строковое поле Email
        private string _email;
        // Строковое поле Адрес
        private string _address;

        // Свойство для доступа к имени
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

        // Свойство для доступа к Фамилии
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

        // Свойство для доступа к номеру телефона
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        // Свойство для доступа к email
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        // Свойство для доступа к адресу
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        // Конструктор с параметрами
        public Contact(string name, string surname, string phoneNumber, string email, string address)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
        }

        // Конструктор без параметров
        public Contact() { }

        // Закрытый метод валидации строки на наличие только английских букв
        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException($"{propertyName} must contain only English alphabet characters.");
            }
        }
    }
}