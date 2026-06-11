using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для элемента контакта. Реализует уведомления об изменениях и валидацию данных.
    /// </summary>
    public class ContactVM : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        /// <summary>
        /// Модель контакта, содержащая основные данные.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Словарь ошибок валидации. Ключ — имя свойства, значение — список ошибок.
        /// </summary>
        private readonly Dictionary<string, List<string>> _errors = new Dictionary<string, List<string>>();

        /// <summary>
        /// Событие, возникающее при изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Событие, возникающее при изменении списка ошибок валидации.
        /// </summary>
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

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
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name
        {
            get { return _contact.Name; }
            set
            {
                if (_contact.Name == value) return;
                _contact.Name = value;
                OnPropertyChanged();
                ValidateName(value);
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта.
        /// </summary>
        public string Phone
        {
            get { return _contact.Phone; }
            set
            {
                if (_contact.Phone == value) return;
                _contact.Phone = value;
                OnPropertyChanged();
                ValidatePhone(value);
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес электронной почты контакта.
        /// </summary>
        public string Email
        {
            get { return _contact.Email; }
            set
            {
                if (_contact.Email == value) return;
                _contact.Email = value;
                OnPropertyChanged();
                ValidateEmail(value);
            }
        }

        /// <summary>
        /// Возвращает признак наличия ошибок валидации.
        /// </summary>
        public bool HasErrors
        {
            get { return _errors.Count > 0; }
        }

        /// <summary>
        /// Возвращает список ошибок для указанного свойства.
        /// </summary>
        /// <param name="propertyName">Имя свойства.</param>
        /// <returns>Список ошибок или null, если ошибок нет.</returns>
        public IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName)) return null;
            return _errors.ContainsKey(propertyName) ? _errors[propertyName] : null;
        }

        /// <summary>
        /// Принудительно запускает валидацию для всех свойств.
        /// </summary>
        public void ValidateAll()
        {
            ValidateName(Name);
            ValidatePhone(Phone);
            ValidateEmail(Email);
        }

        /// <summary>
        /// Вызывает событие PropertyChanged для указанного свойства.
        /// </summary>
        /// <param name="propertyName">Имя изменившегося свойства.</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Проверяет имя контакта на соответствие правилам валидации.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        private void ValidateName(string value)
        {
            ClearErrors(nameof(Name));

            if (string.IsNullOrWhiteSpace(value))
            {
                AddError(nameof(Name), "Имя не может быть пустым.");
            }
            else if (value.Length > 100)
            {
                AddError(nameof(Name), "Имя не должно превышать 100 символов.");
            }
        }

        /// <summary>
        /// Проверяет номер телефона контакта на соответствие правилам валидации.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        private void ValidatePhone(string value)
        {
            ClearErrors(nameof(Phone));

            if (string.IsNullOrWhiteSpace(value))
            {
                AddError(nameof(Phone), "Телефон не может быть пустым.");
            }
            else if (value.Length > 100)
            {
                AddError(nameof(Phone), "Телефон не должен превышать 100 символов.");
            }
            else if (!IsValidPhoneFormat(value))
            {
                AddError(nameof(Phone), "Телефон может содержать только цифры и символы + - ( ).");
            }
        }

        /// <summary>
        /// Проверяет адрес электронной почты контакта на соответствие правилам валидации.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        private void ValidateEmail(string value)
        {
            ClearErrors(nameof(Email));

            if (string.IsNullOrWhiteSpace(value))
            {
                AddError(nameof(Email), "Email не может быть пустым.");
            }
            else if (value.Length > 100)
            {
                AddError(nameof(Email), "Email не должен превышать 100 символов.");
            }
            else if (!value.Contains("@"))
            {
                AddError(nameof(Email), "Email должен содержать символ @.");
            }
        }

        /// <summary>
        /// Проверяет, соответствует ли номер телефона допустимому формату.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <returns>true, если формат правильный; иначе false.</returns>
        private bool IsValidPhoneFormat(string value)
        {
            string pattern = @"^[0-9+\-()\s]+$";
            return Regex.IsMatch(value, pattern);
        }

        /// <summary>
        /// Добавляет ошибку для указанного свойства.
        /// </summary>
        /// <param name="propertyName">Имя свойства.</param>
        /// <param name="error">Текст ошибки.</param>
        private void AddError(string propertyName, string error)
        {
            if (!_errors.ContainsKey(propertyName))
            {
                _errors[propertyName] = new List<string>();
            }
            if (!_errors[propertyName].Contains(error))
            {
                _errors[propertyName].Add(error);
                OnErrorsChanged(propertyName);
            }
        }

        /// <summary>
        /// Удаляет все ошибки для указанного свойства.
        /// </summary>
        /// <param name="propertyName">Имя свойства.</param>
        private void ClearErrors(string propertyName)
        {
            if (_errors.ContainsKey(propertyName))
            {
                _errors.Remove(propertyName);
                OnErrorsChanged(propertyName);
            }
        }

        /// <summary>
        /// Вызывает событие ErrorsChanged для указанного свойства.
        /// </summary>
        /// <param name="propertyName">Имя свойства.</param>
        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            OnPropertyChanged(nameof(HasErrors));
        }
    }
}