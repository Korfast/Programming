using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel главного окна. 
    /// Предоставляет свойства для привязки данных 
    /// и хранит текущий контакт.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Модель текущего контакта, 
        /// данные которого синхронизированы с элементами интерфейса.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Сериализатор для сохранения и загрузки контакта.
        /// </summary>
        private readonly ContactSerializer _serializer;

        /// <summary>
        /// Команда сохранения контакта.
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Команда загрузки контакта.
        /// </summary>
        public ICommand LoadCommand { get; }

        /// <summary>
        /// Конструктор по умолчанию. 
        /// Инициализирует новый пустой контакт.
        /// </summary>
        public MainVM()
        {
            _contact = new Contact();
            _serializer = new ContactSerializer();
            SaveCommand = new SaveCommand(this, _serializer);
            LoadCommand = new LoadCommand(this, _serializer);
        }

        /// <summary>
        /// Возвращает текущий объект контакта.
        /// </summary>
        public Contact Contact
        {
            get { return _contact; }
        }

        /// <summary>
        /// Имя контакта.
        /// </summary>
        public string Name
        {
            get { return _contact.Name; }
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
        /// Номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get { return _contact.Phone; }
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
        /// Адрес электронной почты контакта.
        /// </summary>
        public string Email
        {
            get { return _contact.Email; }
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
        /// Событие для уведомления об изменении свойств.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Вызывает событие PropertyChanged.
        /// </summary>
        /// <param name="prop">Изменившееся свойство (заполняется автоматически).</param>
        protected void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
