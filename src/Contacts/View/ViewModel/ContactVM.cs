using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для элемента контакта. Содержит данные одного контакта и реализует
    /// интерфейс INotifyPropertyChanged для уведомления об изменениях свойств.
    /// </summary>
    public class ContactVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Модель контакта, содержащая основные данные.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _contact.Name;
            }
            set
            {
                if (_contact.Name != value)
                {
                    _contact.Name = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта.
        /// </summary>
        public string Phone
        {
            get
            {
                return _contact.Phone;
            }
            set
            {
                if (_contact.Phone != value)
                {
                    _contact.Phone = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес электронной почты контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return _contact.Email;
            }
            set
            {
                if (_contact.Email != value)
                {
                    _contact.Email = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Событие, возникающее при изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Инициализирует новый экземпляр ContactVM с пустым контактом.
        /// </summary>
        public ContactVM()
        {
            _contact = new Contact();
        }

        /// <summary>
        /// Инициализирует новый экземпляр ContactVM на основе существующей модели контакта.
        /// </summary>
        /// <param name="contact">Объект Contact, данные которого будут использоваться.</param>
        public ContactVM(Contact contact)
        {
            _contact = contact;
        }

        /// <summary>
        /// Вызывает событие PropertyChanged для указанного свойства.
        /// </summary>
        /// <param name="propertyName">Имя изменившегося свойства. Если не задано,
        /// используется имя вызывающего члена.</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
