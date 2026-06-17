using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Contacts.ViewModel;

namespace Contacts.View
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
            InitializeComponent();
            DataContext = new MainVM();
        }
    }
}