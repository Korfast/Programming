using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Events.Model
{
    /// <summary>
    /// Представляет бизнес-логику контакта 
    /// с уведомлениями об изменениях.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Поле хранящее полное имя
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Поле хранящее номер телефона
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Поле хранящее адрес
        /// </summary>
        private string _address;

        /// <summary>
        /// Событие, возникающее при изменении 
        /// любого из свойств контакта.
        /// </summary>
        public event EventHandler ContactChanged;

        /// <summary>
        /// Возвращает или задает полное имя. 
        /// Вызывает событие <see cref="ContactChanged"/> при изменении значения.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (_fullName != value) 
                {
                    _fullName = value;
                    OnContactChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает или задает номер телефона. 
        /// Вызывает событие <see cref="ContactChanged"/> при изменении значения.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    OnContactChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает или задает адрес проживания. 
        /// Вызывает событие <see cref="ContactChanged"/> при изменении значения.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                if (_address != value)
                {
                    _address = value;
                    OnContactChanged();
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/> с начальными данными.
        /// </summary>
        /// <param name="name">Полное имя.</param>
        /// <param name="phone">Номер телефона.</param>
        /// <param name="address">Адрес.</param>
        public Contact(string name, string phone, string address)
        {
            _fullName = name;
            _phoneNumber = phone;
            _address = address;
        }

        /// <summary>
        /// Оповещает всех подписчиков об изменении данных контакта.
        /// </summary>
        protected virtual void OnContactChanged()
        {
            ContactChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
