using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    // Класс Контакт
    public class Contact
    {
        // Строковое поле Имя
        private string _name;
        // Строковое поле Номер телефона
        private string _phoneNumber;
        // Строковое поле Email
        private string _email;
        // Строковое поле Адрес
        private string _address;

        // Свойство для доступа к имени
        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
        public Contact(string name, string phoneNumber, string email, string address)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
        }

        // Конструктор без параметров
        public Contact() { }
    }
}