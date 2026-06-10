using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty IsReadOnlyProperty =
        DependencyProperty.Register(nameof(IsReadOnly), typeof(bool), typeof(ContactControl));

        public bool IsReadOnly
        {
            get => (bool)GetValue(IsReadOnlyProperty);
            set => SetValue(IsReadOnlyProperty, value);
        }

        /// <summary>
        /// Фильтрация вводимых символов для поля телефона.
        /// Разрешены: цифры, +, -, (, ), пробел
        /// </summary>
        private void OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Разрешённые символы
            string allowedChars = "0123456789+-() ";

            // Проверяем каждый вводимый символ
            foreach (char ch in e.Text)
            {
                if (!allowedChars.Contains(ch))
                {
                    e.Handled = true; // Запрещаем ввод
                    return;
                }
            }
        }

        /// <summary>
        /// Фильтрация вставки из буфера обмена для поля телефона.
        /// </summary>
        private void OnPasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string pastedText = (string)e.DataObject.GetData(typeof(string));

                // Разрешённые символы
                string allowedChars = "0123456789+-() ";

                // Проверяем каждый символ вставляемого текста
                foreach (char ch in pastedText)
                {
                    if (!allowedChars.Contains(ch))
                    {
                        e.CancelCommand(); // Отменяем вставку
                        return;
                    }
                }
            }
            else
            {
                e.CancelCommand();
            }
        }
    }
}
