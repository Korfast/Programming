using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Реализация интерфейса ICommand, позволяющая делегировать выполнение команды
    /// и проверку возможности её выполнения переданным делегатам.
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Делегат, выполняющий логику команды.
        /// </summary>
        private readonly Action<object> _execute;

        /// <summary>
        /// Делегат, определяющий, может ли команда быть выполнена.
        /// </summary>
        private readonly Func<object, bool> _canExecute;  

        /// <summary>
        /// Событие, возникающее при изменении возможности выполнения команды.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса RelayCommand.
        /// </summary>
        /// <param name="execute">Делегат, вызываемый при выполнении команды.</param>
        /// <param name="canExecute">Делегат, определяющий возможность выполнения команды.
        /// Если параметр равен null, команда считается всегда доступной.</param>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Определяет, может ли команда быть выполнена в текущем состоянии.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        /// <returns>true, если команда может быть выполнена; иначе false.</returns>
        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
            {
                return true;
            }
            return _canExecute(parameter);
        }

        /// <summary>
        /// Выполняет логику команды.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        public void Execute(object parameter)
        {
            if (_execute == null)
            {
                return;
            }
            _execute(parameter);
        }
    }
}
