using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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
    /// ViewModel главного окна. Управляет коллекцией контактов, выбранным контактом,
    /// режимами добавления/редактирования и командами.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        #region Поля

        /// <summary>
        /// Коллекция контактов, отображаемая в списке.
        /// </summary>
        private ObservableCollection<ContactVM> _contacts;

        /// <summary>
        /// Выбранный в списке контакт.
        /// </summary>
        private ContactVM _selectedContact;

        /// <summary>
        /// Флаг режима редактирования или добавления.
        /// </summary>
        private bool _isEditing;

        /// <summary>
        /// Временный контакт, используемый при добавлении/редактировании до нажатия Apply.
        /// </summary>
        private ContactVM _editingContact;

        /// <summary>
        /// Текст поиска (пока не используется, но заготовка для будущего).
        /// </summary>
        private string _searchText;

        /// <summary>
        /// Сериализатор для сохранения и загрузки коллекции контактов.
        /// </summary>
        private readonly ContactSerializer _serializer;

        #endregion

        #region Свойства

        /// <summary>
        /// Возвращает коллекцию контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts
        {
            get { return _contacts; }
        }

        /// <summary>
        /// Возвращает и задаёт выбранный в списке контакт.
        /// </summary>
        public ContactVM SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                if (_selectedContact != value)
                {
                    // Если режим редактирования активен, отменяем его
                    if (_isEditing)
                    {
                        CancelEditing();
                    }
                    _selectedContact = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(CurrentContact));
                    OnPropertyChanged(nameof(IsEditRemoveEnabled));
                }
            }
        }

        /// <summary>
        /// Возвращает текущий отображаемый контакт (в зависимости от режима).
        /// </summary>
        public ContactVM CurrentContact
        {
            get
            {
                if (_isEditing && _editingContact != null)
                {
                    return _editingContact;
                }
                return _selectedContact;
            }
        }

        /// <summary>
        /// Возвращает флаг, указывающий, что поля ввода должны быть доступны только для чтения.
        /// </summary>
        public bool IsReadOnly
        {
            get { return !_isEditing; }
        }

        /// <summary>
        /// Возвращает флаг, показывающий, должна ли быть видна кнопка Apply.
        /// </summary>
        public bool IsApplyVisible
        {
            get { return _isEditing; }
        }

        /// <summary>
        /// Возвращает флаг, разрешающий использование кнопок Add, Edit, Remove.
        /// </summary>
        public bool IsAddEditRemoveEnabled
        {
            get { return !_isEditing; }
        }

        /// <summary>
        /// Возвращает флаг, разрешающий использование кнопок Edit и Remove (требуется выбранный контакт).
        /// </summary>
        public bool IsEditRemoveEnabled
        {
            get { return !_isEditing && _selectedContact != null; }
        }

        /// <summary>
        /// Возвращает и задаёт текст поиска (пока без функциональности).
        /// </summary>
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;
                    OnPropertyChanged();
                    // Здесь можно будет добавить фильтрацию
                }
            }
        }

        #endregion

        #region Команды

        /// <summary>
        /// Команда добавления нового контакта.
        /// </summary>
        public ICommand AddCommand { get; private set; }

        /// <summary>
        /// Команда редактирования выбранного контакта.
        /// </summary>
        public ICommand EditCommand { get; private set; }

        /// <summary>
        /// Команда удаления выбранного контакта.
        /// </summary>
        public ICommand RemoveCommand { get; private set; }

        /// <summary>
        /// Команда применения изменений (добавление или редактирование).
        /// </summary>
        public ICommand ApplyCommand { get; private set; }

        #endregion

        #region Конструктор

        /// <summary>
        /// Инициализирует новый экземпляр MainVM. Загружает сохранённые контакты и создаёт команды.
        /// </summary>
        public MainVM()
        {
            _serializer = new ContactSerializer();
            _contacts = new ObservableCollection<ContactVM>();
            _contacts.CollectionChanged += OnContactsCollectionChanged;

            // Загрузка данных
            LoadContacts();

            // Команды
            AddCommand = new RelayCommand(ExecuteAdd, CanExecuteAdd);
            EditCommand = new RelayCommand(ExecuteEdit, CanExecuteEdit);
            RemoveCommand = new RelayCommand(ExecuteRemove, CanExecuteRemove);
            ApplyCommand = new RelayCommand(ExecuteApply, CanExecuteApply);
        }

        #endregion

        #region Методы команд

        /// <summary>
        /// Определяет, можно ли выполнить команду Add.
        /// </summary>
        private bool CanExecuteAdd(object parameter)
        {
            return !_isEditing;
        }

        /// <summary>
        /// Выполняет команду Add: переводит приложение в режим добавления.
        /// </summary>
        private void ExecuteAdd(object parameter)
        {
            SelectedContact = null;
            StartEditing(new ContactVM());
        }

        /// <summary>
        /// Определяет, можно ли выполнить команду Edit.
        /// </summary>
        private bool CanExecuteEdit(object parameter)
        {
            return !_isEditing && _selectedContact != null;
        }

        /// <summary>
        /// Выполняет команду Edit: переводит приложение в режим редактирования выбранного контакта.
        /// </summary>
        private void ExecuteEdit(object parameter)
        {
            // Создаём копию выбранного контакта для редактирования
            ContactVM copy = new ContactVM();
            copy.Name = _selectedContact.Name;
            copy.Phone = _selectedContact.Phone;
            copy.Email = _selectedContact.Email;
            StartEditing(copy);
        }

        /// <summary>
        /// Определяет, можно ли выполнить команду Remove.
        /// </summary>
        private bool CanExecuteRemove(object parameter)
        {
            return !_isEditing && _selectedContact != null;
        }

        /// <summary>
        /// Выполняет команду Remove: удаляет выбранный контакт.
        /// </summary>
        private void ExecuteRemove(object parameter)
        {
            if (_selectedContact == null)
                return;

            int index = _contacts.IndexOf(_selectedContact);
            _contacts.Remove(_selectedContact);

            // Выбор следующего или предыдущего контакта
            if (_contacts.Count > 0)
            {
                if (index >= _contacts.Count)
                {
                    SelectedContact = _contacts[_contacts.Count - 1];
                }
                else
                {
                    SelectedContact = _contacts[index];
                }
            }
            else
            {
                SelectedContact = null;
            }

            SaveContacts();
        }

        /// <summary>
        /// Определяет, можно ли выполнить команду Apply.
        /// </summary>
        private bool CanExecuteApply(object parameter)
        {
            return _isEditing && _editingContact != null && !_editingContact.HasErrors;
        }

        /// <summary>
        /// Выполняет команду Apply: сохраняет изменения (добавление или редактирование).
        /// </summary>
        private void ExecuteApply(object parameter)
        {
            if (_editingContact == null)
                return;

            // Режим добавления
            if (_selectedContact == null) 
            {
                ContactVM newContact = new ContactVM();
                newContact.Name = _editingContact.Name;
                newContact.Phone = _editingContact.Phone;
                newContact.Email = _editingContact.Email;
                _contacts.Add(newContact);
                SelectedContact = newContact;
            }
            // Режим редактирования
            else
            {
                _selectedContact.Name = _editingContact.Name;
                _selectedContact.Phone = _editingContact.Phone;
                _selectedContact.Email = _editingContact.Email;
                // Имя в списке обновится автоматически через INotifyPropertyChanged
            }

            FinishEditing();
            SaveContacts();
        }

        #endregion

        #region Вспомогательные методы

        /// <summary>
        /// Переводит ViewModel в режим редактирования с указанным временным контактом.
        /// </summary>
        /// <param name="editingContact">Временный контакт для редактирования.</param>
        private void StartEditing(ContactVM editingContact)
        {
            _isEditing = true;
            _editingContact = editingContact;

            // Принудительно запускаем валидацию для нового контакта (покажет ошибки для пустых полей)
            _editingContact.ValidateAll();

            // Подписываемся на изменение ошибок валидации временного контакта
            _editingContact.ErrorsChanged += OnEditingContactErrorsChanged;

            OnPropertyChanged(nameof(IsReadOnly));
            OnPropertyChanged(nameof(IsApplyVisible));
            OnPropertyChanged(nameof(IsAddEditRemoveEnabled));
            OnPropertyChanged(nameof(IsEditRemoveEnabled));
            OnPropertyChanged(nameof(CurrentContact));
            CommandManager.InvalidateRequerySuggested();
        }

        /// <summary>
        /// Завершает режим редактирования/добавления.
        /// </summary>
        private void FinishEditing()
        {
            // Отписываемся от события ошибок до обнуления
            if (_editingContact != null)
            {
                _editingContact.ErrorsChanged -= OnEditingContactErrorsChanged;
            }

            _isEditing = false;
            _editingContact = null;

            OnPropertyChanged(nameof(IsReadOnly));
            OnPropertyChanged(nameof(IsApplyVisible));
            OnPropertyChanged(nameof(IsAddEditRemoveEnabled));
            OnPropertyChanged(nameof(IsEditRemoveEnabled));
            OnPropertyChanged(nameof(CurrentContact));
            CommandManager.InvalidateRequerySuggested();
        }

        /// <summary>
        /// Отменяет редактирование без сохранения изменений.
        /// </summary>
        private void CancelEditing()
        {
            // Отписываемся от события ошибок до обнуления
            if (_editingContact != null)
            {
                _editingContact.ErrorsChanged -= OnEditingContactErrorsChanged;
            }

            _isEditing = false;
            _editingContact = null;

            // Принудительно обновляем валидацию для выбранного контакта (чтобы убрать красные рамки, если они были)
            _selectedContact?.ValidateAll();

            OnPropertyChanged(nameof(IsReadOnly));
            OnPropertyChanged(nameof(IsApplyVisible));
            OnPropertyChanged(nameof(IsAddEditRemoveEnabled));
            OnPropertyChanged(nameof(IsEditRemoveEnabled));
            OnPropertyChanged(nameof(CurrentContact));
            CommandManager.InvalidateRequerySuggested();
        }

        /// <summary>
        /// Загружает список контактов из файла и преобразует в ObservableCollection.
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
                    SelectedContact = _contacts[0];
                }
            }
            catch (Exception)
            {
                // Если загрузка не удалась, оставляем пустую коллекцию
                _contacts.Clear();
                SelectedContact = null;
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
            catch (Exception)
            {
                // Можно добавить уведомление пользователя, но по заданию не требуется
            }
        }

        /// <summary>
        /// Обработчик изменения коллекции (автосохранение).
        /// </summary>
        private void OnContactsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            SaveContacts();
        }

        /// <summary>
        /// Обработчик изменения ошибок валидации временного контакта.
        /// </summary>
        private void OnEditingContactErrorsChanged(object sender, DataErrorsChangedEventArgs e)
        {
            // Принудительно обновляем состояние команды Apply
            CommandManager.InvalidateRequerySuggested();
        }

        #endregion

        #region INotifyPropertyChanged

        /// <summary>
        /// Событие, возникающее при изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Вызывает событие PropertyChanged для указанного свойства.
        /// </summary>
        /// <param name="propertyName">Имя изменившегося свойства.</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}