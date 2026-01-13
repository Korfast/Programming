using Programming_Events.Model;
using Programming_Events.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Events
{
    /// <summary>
    /// Содержит логику 
    /// управления жизненным циклом приложения 
    /// и инициализацию главных окон.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Хранит количество текущих открытых форм приложения.
        /// </summary>
        private static int _openFormsCount = 0;

        /// <summary>
        /// Главная точка входа для приложения.
        /// Инициализирует общий объект данных 
        /// и запускает три синхронизированных окна.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Создаем ОДИН общий объект контакта (бизнес-логика)
            Contact sharedContact = new Contact(
                "Иван Иванов Иванович",
                "+7 (999) 123-45-67",
                "г. Москва, ул. Ленина, д. 1"
            );

            // Создаем три экземпляра дочерних форм
            FirstForm f1 = new FirstForm();
            SecondForm f2 = new SecondForm();
            ThirdForm f3 = new ThirdForm();

            // Передаем объект данных в каждую форму 
            f1.Contact = sharedContact;
            f2.Contact = sharedContact;
            f3.Contact = sharedContact;

            // Подписываем каждую форму на событие закрытия
            RegisterForm(f1);
            RegisterForm(f2);
            RegisterForm(f3);

            // Показываем все формы
            f1.Show();
            f2.Show();
            f3.Show();

            // Запускаем цикл приложения на третьей форме. 
            // Когда вы закроете ТРЕТЬЕ окно, программа завершится.
            Application.Run();
        }

        /// <summary>
        /// Регистрирует форму в системе отслеживания открытых окон.
        /// Добавляет обработчик события закрытия 
        /// для корректного завершения процесса приложения.
        /// </summary>
        /// <param name="form">Форма, которую необходимо поставить на учет.</param>
        private static void RegisterForm(Form form)
        {
            _openFormsCount++;

            form.FormClosed += (sender, e) =>
            {
                _openFormsCount--;

                // Если закрылось последнее окно — завершаем приложение
                if (_openFormsCount <= 0)
                {
                    Application.Exit();
                }
            };
        }
    }
}
