using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Model
{
    /// <summary>
    /// Модель контакта, хранящая имя, номер телефона и адрес электронной почты.
    /// исполняется для отображения и редактирования данных в приложении.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Поле имени контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Поле номера телефона контакта.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Поле адреса электронной почты контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта.
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        /// <summary>
        /// Возвращает и задаёт адрес электронной почты контакта.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// Конструктор по умолчанию. Инициализирует пустой контакт.
        /// </summary>
        public Contact()
        {
            _name = string.Empty;
            _phone = string.Empty;
            _email = string.Empty;
        }

        /// <summary>
        /// Конструктор для создания контакта с заданными параметрами.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="phone">Номер телефона.</param>
        /// <param name="email">Электронная почта.</param>
        public Contact(string name, string phone, string email)
        {
            _name = name;
            _phone = phone;
            _email = email;
        }

        /// <summary>
        /// Переопределение метода ToString для удобного отображения контакта.
        /// </summary>
        /// <returns>Строка с информацией о контакте.</returns>
        public override string ToString()
        {
            return $"{Name} | {Phone} | {Email}";
        }
    }
}
