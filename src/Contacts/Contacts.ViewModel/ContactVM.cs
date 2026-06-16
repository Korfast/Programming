using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Contacts.Model;

namespace Contacts.ViewModel
{
    /// <summary>
    /// ViewModel для отдельного контакта. Наследуется от ObservableValidator,
    /// чтобы использовать встроенную валидацию на основе атрибутов.
    /// </summary>
    public class ContactVM : ObservableValidator
    {
        /// <summary>
        /// Модель данных контакта.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Поле для имени контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Поле для номера телефона.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Поле для адреса электронной почты.
        /// </summary>
        private string _email;

        /// <summary>
        /// Конструктор, создающий пустой контакт.
        /// </summary>
        public ContactVM()
        {
            _contact = new Contact();
            this.ValidateAll();
        }

        /// <summary>
        /// Конструктор, инициализирующий ViewModel на основе существующей модели.
        /// </summary>
        /// <param name="contact">Объект Contact, данные которого будут использоваться.</param>
        public ContactVM(Contact contact)
        {
            _contact = contact;
            _name = contact.Name;
            _phone = contact.Phone;
            _email = contact.Email;
            this.ValidateAll();
        }

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// При изменении вызывает валидацию.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                // SetProperty из ObservableObject обновляет поле и вызывает PropertyChanged.
                // Параметр true включает валидацию.
                this.SetProperty(ref _name, value, true);
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта.
        /// При изменении вызывает валидацию.
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                this.SetProperty(ref _phone, value, true);
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес электронной почты контакта.
        /// При изменении вызывает валидацию.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                this.SetProperty(ref _email, value, true);
            }
        }

        // Свойство HasErrors из базового класса ObservableValidator уже существует.
        // Оно возвращает true, если есть ошибки валидации.
        // Используйте его в привязках, например, для блокировки кнопки Apply.

        /// <summary>
        /// Принудительно запускает валидацию для всех свойств.
        /// Вызывается в конструкторах и при отмене редактирования.
        /// </summary>
        public void ValidateAll()
        {
            this.ValidateProperty(this.Name, nameof(this.Name));
            this.ValidateProperty(this.Phone, nameof(this.Phone));
            this.ValidateProperty(this.Email, nameof(this.Email));
        }
    }
}