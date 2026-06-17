using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using Contacts.Model;
using Contacts.Model.Services;
using System.Diagnostics;

namespace Contacts.ViewModel
{
    /// <summary>
    /// Главная ViewModel приложения. Управляет коллекцией контактов,
    /// выбранным контактом, режимами добавления/редактирования и командами.
    /// </summary>
    public class MainVM : ObservableObject
    {
        /// <summary>
        /// Сериализатор для сохранения и загрузки данных.
        /// </summary>
        private readonly ContactSerializer _serializer;

        /// <summary>
        /// Коллекция контактов, отображаемая в списке.
        /// </summary>
        private ObservableCollection<ContactVM> _contacts;

        /// <summary>
        /// Текущий выбранный в списке контакт.
        /// </summary>
        private ContactVM _selectedContact;

        /// <summary>
        /// Временный контакт, используемый при добавлении/редактировании до нажатия Apply.
        /// </summary>
        private ContactVM _editingContact;

        /// <summary>
        /// Флаг, указывающий, находится ли приложение в режиме редактирования/добавления.
        /// </summary>
        private bool _isEditing;

        /// <summary>
        /// Текст поиска (пока не используется, но зарезервировано).
        /// </summary>
        private string _searchText;

        /// <summary>
        /// Конструктор. Инициализирует коллекцию, загружает данные и создаёт команды.
        /// </summary>
        public MainVM()
        {
            _serializer = new ContactSerializer();
            _contacts = new ObservableCollection<ContactVM>();
            _contacts.CollectionChanged += this.OnContactsCollectionChanged;
            this.LoadContacts();

            // Создание команд с использованием RelayCommand из MVVM Toolkit
            this.AddCommand = new RelayCommand(this.Add, this.CanAdd);
            this.EditCommand = new RelayCommand(this.Edit, this.CanEditRemove);
            this.RemoveCommand = new RelayCommand(this.Remove, this.CanEditRemove);
            this.ApplyCommand = new RelayCommand(this.Apply, this.CanApply);
        }

        /// <summary>
        /// Возвращает коллекцию контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts
        {
            get
            {
                return _contacts;
            }
        }

        /// <summary>
        /// Возвращает и задаёт выбранный в списке контакт.
        /// При смене выбранного контакта, если активен режим редактирования, вызывается отмена изменений.
        /// </summary>
        public ContactVM SelectedContact
        {
            get
            {
                return _selectedContact;
            }
            set
            {
                Debug.WriteLine($"SelectedContact setter called, value={value?.GetHashCode()}, IsEditing={IsEditing}");
                if (_selectedContact == value) return;
                if (this.IsEditing) this.CancelEditing();
                _selectedContact = value;
                this.OnPropertyChanged(nameof(this.SelectedContact));
                this.OnPropertyChanged(nameof(this.CurrentContact));
                this.OnPropertyChanged(nameof(this.IsEditRemoveEnabled));
                this.AddCommand?.NotifyCanExecuteChanged();
                this.EditCommand?.NotifyCanExecuteChanged();
                this.RemoveCommand?.NotifyCanExecuteChanged();
            }
        }

        /// <summary>
        /// Возвращает текущий контакт, отображаемый в правой панели.
        /// В режиме редактирования возвращает временный контакт, иначе — выбранный.
        /// </summary>
        public ContactVM CurrentContact
        {
            get
            {
                var result = (this.IsEditing && _editingContact != null) ? _editingContact : _selectedContact;
                Debug.WriteLine($"CurrentContact: IsEditing={IsEditing}, _editingContact={_editingContact?.GetHashCode()}, _selectedContact={_selectedContact?.GetHashCode()}, returning={result?.GetHashCode()}");
                return result;
            }
        }

        /// <summary>
        /// Возвращает и задаёт флаг режима редактирования.
        /// При изменении вызывает уведомления для зависимых свойств.
        /// </summary>
        public bool IsEditing
        {
            get
            {
                return _isEditing;
            }
            set
            {
                if (_isEditing == value)
                {
                    return;
                }

                _isEditing = value;
                this.OnPropertyChanged(nameof(this.IsEditing));
                this.OnPropertyChanged(nameof(this.IsReadOnly));
                this.OnPropertyChanged(nameof(this.IsApplyVisible));
                this.OnPropertyChanged(nameof(this.IsAddEditRemoveEnabled));
                this.OnPropertyChanged(nameof(this.IsEditRemoveEnabled));
                this.OnPropertyChanged(nameof(this.CurrentContact));
            }
        }

        /// <summary>
        /// Возвращает и задаёт текст поиска (пока без функциональности).
        /// </summary>
        public string SearchText
        {
            get
            {
                return _searchText;
            }
            set
            {
                if (_searchText == value)
                {
                    return;
                }

                _searchText = value;
                this.OnPropertyChanged(nameof(this.SearchText));
            }
        }

        /// <summary>
        /// Возвращает признак, что поля ввода должны быть только для чтения.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return !this.IsEditing;
            }
        }

        /// <summary>
        /// Возвращает признак, что кнопка Apply должна быть видна.
        /// </summary>
        public bool IsApplyVisible
        {
            get
            {
                return this.IsEditing;
            }
        }

        /// <summary>
        /// Возвращает признак, что кнопки Add, Edit, Remove доступны.
        /// </summary>
        public bool IsAddEditRemoveEnabled
        {
            get
            {
                return !this.IsEditing;
            }
        }

        /// <summary>
        /// Возвращает признак, что кнопки Edit и Remove доступны (требуется выбранный контакт и не режим редактирования).
        /// </summary>
        public bool IsEditRemoveEnabled
        {
            get
            {
                return !this.IsEditing && _selectedContact != null;
            }
        }

        /// <summary>
        /// Команда добавления нового контакта.
        /// </summary>
        public RelayCommand AddCommand { get; }

        /// <summary>
        /// Команда редактирования выбранного контакта.
        /// </summary>
        public RelayCommand EditCommand { get; }

        /// <summary>
        /// Команда удаления выбранного контакта.
        /// </summary>
        public RelayCommand RemoveCommand { get; }

        /// <summary>
        /// Команда применения изменений (добавление или редактирование).
        /// </summary>
        public RelayCommand ApplyCommand { get; }

        /// <summary>
        /// Проверка доступности команды Add.
        /// </summary>
        /// <returns>true, если не в режиме редактирования.</returns>
        private bool CanAdd()
        {
            return !this.IsEditing;
        }

        /// <summary>
        /// Выполнение команды Add: переход в режим добавления.
        /// </summary>
        private void Add()
        {
            this.SelectedContact = null;
            this.StartEditing(new ContactVM());
        }

        /// <summary>
        /// Проверка доступности команд Edit и Remove.
        /// </summary>
        /// <returns>true, если не в режиме редактирования и выбран контакт.</returns>
        private bool CanEditRemove()
        {
            return !this.IsEditing && _selectedContact != null;
        }

        /// <summary>
        /// Выполнение команды Edit: создание копии выбранного контакта и переход в режим редактирования.
        /// </summary>
        private void Edit()
        {
            ContactVM copy = new ContactVM();
            copy.Name = _selectedContact.Name;
            copy.Phone = _selectedContact.Phone;
            copy.Email = _selectedContact.Email;
            this.StartEditing(copy);
        }

        /// <summary>
        /// Выполнение команды Remove: удаление выбранного контакта.
        /// </summary>
        private void Remove()
        {
            if (_selectedContact == null)
            {
                return;
            }

            int index = _contacts.IndexOf(_selectedContact);
            _contacts.Remove(_selectedContact);

            // Выбор следующего или предыдущего контакта
            if (_contacts.Count > 0)
            {
                if (index >= _contacts.Count)
                {
                    this.SelectedContact = _contacts[_contacts.Count - 1];
                }
                else
                {
                    this.SelectedContact = _contacts[index];
                }
            }
            else
            {
                this.SelectedContact = null;
            }

            this.SaveContacts();
        }

        /// <summary>
        /// Проверка доступности команды Apply.
        /// </summary>
        /// <returns>true, если в режиме редактирования, временный контакт существует и не имеет ошибок.</returns>
        private bool CanApply()
        {
            bool result = this.IsEditing && _editingContact != null && !_editingContact.HasErrors;
            Debug.WriteLine($"CanApply: IsEditing={IsEditing}, _editingContact={_editingContact?.GetHashCode()}, HasErrors={_editingContact?.HasErrors}, result={result}");
            return result;
        }

        /// <summary>
        /// Выполнение команды Apply: применение изменений (добавление или редактирование).
        /// </summary>
        private void Apply()
        {
            if (_editingContact == null)
            {
                return;
            }

            if (_selectedContact == null)
            {
                // Режим добавления
                ContactVM newContact = new ContactVM();
                newContact.Name = _editingContact.Name;
                newContact.Phone = _editingContact.Phone;
                newContact.Email = _editingContact.Email;
                _contacts.Add(newContact);
                this.SelectedContact = newContact;
            }
            else
            {
                // Режим редактирования
                _selectedContact.Name = _editingContact.Name;
                _selectedContact.Phone = _editingContact.Phone;
                _selectedContact.Email = _editingContact.Email;
            }

            this.FinishEditing();
            this.SaveContacts();
        }


        /// <summary>
        /// Переход в режим редактирования с указанным временным контактом.
        /// </summary>
        /// <param name="editingContact">Временный контакт, который будет редактироваться.</param>
        private void StartEditing(ContactVM editingContact)
        {
            _editingContact = editingContact;
            this.IsEditing = true;

            _editingContact.ValidateAll();
            _editingContact.ErrorsChanged += this.OnEditingContactErrorsChanged;

            this.AddCommand?.NotifyCanExecuteChanged();
            this.EditCommand?.NotifyCanExecuteChanged();
            this.RemoveCommand?.NotifyCanExecuteChanged();
            this.ApplyCommand?.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Отменяет редактирование без сохранения изменений.
        /// Сбрасывает временный контакт и обновляет валидацию выбранного контакта.
        /// </summary>
        private void CancelEditing()
        {
            if (_editingContact != null)
            {
                _editingContact.ErrorsChanged -= this.OnEditingContactErrorsChanged;
            }

            this.IsEditing = false;
            _editingContact = null;

            // Принудительно обновляем валидацию выбранного контакта (сбрасываем красные рамки)
            _selectedContact?.ValidateAll();

            this.AddCommand?.NotifyCanExecuteChanged();
            this.EditCommand?.NotifyCanExecuteChanged();
            this.RemoveCommand?.NotifyCanExecuteChanged();
            this.ApplyCommand?.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Завершает режим редактирования/добавления с сохранением изменений.
        /// </summary>
        private void FinishEditing()
        {
            if (_editingContact != null)
            {
                _editingContact.ErrorsChanged -= this.OnEditingContactErrorsChanged;
            }

            this.IsEditing = false;
            _editingContact = null;

            this.AddCommand?.NotifyCanExecuteChanged();
            this.EditCommand?.NotifyCanExecuteChanged();
            this.RemoveCommand?.NotifyCanExecuteChanged();
            this.ApplyCommand?.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Обработчик события изменения ошибок валидации временного контакта.
        /// </summary>
        private void OnEditingContactErrorsChanged(object sender, DataErrorsChangedEventArgs e)
        {
            this.ApplyCommand?.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Загружает список контактов из файла.
        /// </summary>
        private void LoadContacts()
        {
            try
            {
                System.Collections.Generic.List<Contact> loaded = _serializer.LoadAll();
                _contacts.Clear();
                foreach (Contact c in loaded)
                {
                    _contacts.Add(new ContactVM(c));
                }

                if (_contacts.Count > 0)
                {
                    this.SelectedContact = _contacts[0];
                }
            }
            catch
            {
                _contacts.Clear();
                this.SelectedContact = null;
            }
        }

        /// <summary>
        /// Сохраняет текущую коллекцию контактов в файл.
        /// </summary>
        private void SaveContacts()
        {
            try
            {
                System.Collections.Generic.List<Contact> toSave = new System.Collections.Generic.List<Contact>();
                foreach (ContactVM vm in _contacts)
                {
                    toSave.Add(new Contact(vm.Name, vm.Phone, vm.Email));
                }

                _serializer.SaveAll(toSave);
            }
            catch
            {
                // Игнорируем ошибку сохранения (можно добавить логирование)
            }
        }

        /// <summary>
        /// Обработчик изменения коллекции (автосохранение).
        /// </summary>
        private void OnContactsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.SaveContacts();
        }
    }
}