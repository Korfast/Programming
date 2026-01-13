using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Events.View
{
    /// <summary>
    /// Представляет второе окно для редактирования данных контакта.
    /// Наследует базовую логику синхронизации из <see cref="ContactForm"/>.
    /// </summary>
    public partial class SecondForm : ContactForm
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="SecondForm"/>.
        /// </summary>
        public SecondForm()
        {
            InitializeComponent();
            this.Text = "Second Window";
        }
    }
}
