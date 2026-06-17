using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Contacts.View.Controls
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
            string allowedChars = "0123456789+-() ";
            foreach (char ch in e.Text)
            {
                // В .NET Framework 4.8 нет Contains(char), используем IndexOf
                if (allowedChars.IndexOf(ch) == -1)
                {
                    e.Handled = true;
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
                string allowedChars = "0123456789+-() ";
                foreach (char ch in pastedText)
                {
                    if (allowedChars.IndexOf(ch) == -1)
                    {
                        e.CancelCommand();
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