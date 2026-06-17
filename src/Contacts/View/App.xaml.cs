using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Contacts.View
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Конструктор приложения. Устанавливает программный режим рендеринга
        /// для предотвращения возможных проблем с отображением элементов интерфейса,
        /// связанных с аппаратным ускорением графики.
        /// </summary>
        public App()
        {
            RenderOptions.ProcessRenderMode = System.Windows.Interop.RenderMode.SoftwareOnly;
        }
    }
}
