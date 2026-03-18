using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Команда загрузки контакта из файла.
    /// </summary>
    public class LoadCommand : ICommand
    {
        /// <summary>
        /// Ссылка на главную ViewModel для обновления свойств после загрузки.
        /// </summary>
        private readonly MainVM _mainVM;

        /// <summary>
        /// Сериализатор для загрузки контакта из файла.
        /// </summary>
        private readonly ContactSerializer _serializer;

        /// <summary>
        /// Инициализирует новый экземпляр команды загрузки.
        /// </summary>
        /// <param name="mainVM">Ссылка на главную ViewModel.</param>
        /// <param name="serializer">Сериализатор для работы с файлом.</param>
        public LoadCommand(MainVM mainVM, ContactSerializer serializer)
        {
            _mainVM = mainVM;
            _serializer = serializer;
        }

        /// <summary>
        /// Событие, которое возникает при изменении возможности выполнения команды.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Определяет, может ли команда выполняться. Всегда возвращает true.
        /// </summary>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет загрузку контакта из файла и обновляет свойства ViewModel.
        /// </summary>
        public void Execute(object parameter)
        {
            Contact loaded = _serializer.Load();
            _mainVM.Name = loaded.Name;
            _mainVM.PhoneNumber = loaded.Phone;
            _mainVM.Email = loaded.Email;
        }
    }
}
