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
using Contacts.ViewModel;

namespace View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Конструктор главного окна приложения.
        /// </summary>
        public MainWindow()
        {
            // Инициализация компонентов пользовательского интерфейса, созданных в XAML
            InitializeComponent();

            // Устанавливает контекст данных для окна, связывая его с экземпляром ViewModel.
            // Это позволяет использовать привязки данных (Data Binding) между элементами интерфейса
            // и свойствами/командами MainVM.
            DataContext = new MainVM();
        }
    }
}
