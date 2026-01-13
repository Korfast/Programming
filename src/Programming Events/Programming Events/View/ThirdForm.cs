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
    /// Представляет третье окно для редактирования данных контакта.
    /// Наследует базовую логику синхронизации из <see cref="ContactForm"/>.
    /// </summary>
    public partial class ThirdForm : ContactForm
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="ThirdForm"/>.
        /// </summary>
        public ThirdForm()
        {
            // InitializeComponent дочерней формы (обычно пустой)
            InitializeComponent();
            this.Text = "Third Window";
        }
    }
}
