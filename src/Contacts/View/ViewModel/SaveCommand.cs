using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Команда сохранения контакта в файл.
    /// </summary>
    public class SaveCommand : ICommand
    {
        /// <summary>
        /// Ссылка на главную ViewModel для доступа к текущему контакту.
        /// </summary>
        private readonly MainVM _mainVM;

        /// <summary>
        /// Сериализатор для сохранения контакта в файл.
        /// </summary>
        private readonly ContactSerializer _serializer;

        /// <summary>
        /// Инициализирует новый экземпляр команды сохранения.
        /// </summary>
        /// <param name="mainVM">Ссылка на главную ViewModel.</param>
        /// <param name="serializer">Сериализатор для работы с файлом.</param>
        public SaveCommand(MainVM mainVM, ContactSerializer serializer)
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
        /// Выполняет сохранение текущего контакта в файл.
        /// </summary>
        public void Execute(object parameter)
        {
            _serializer.Save(_mainVM.Contact);
        }
    }
}
