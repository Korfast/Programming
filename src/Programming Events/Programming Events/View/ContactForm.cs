using Programming_Events.Model;
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
    public partial class ContactForm : Form
    {
        private Contact _contact;

        public Contact Contact
        {
            get { return _contact; }
            set
            {
                // Условие 2: отписка от старого, подписка на новый
                if (_contact != null)
                {
                    _contact.ContactChanged -= Contact_Changed;
                }

                _contact = value;

                if (_contact != null)
                {
                    _contact.ContactChanged += Contact_Changed;
                    UpdateScreen(); // Обновляем поля при смене объекта
                }
            }
        }

        public ContactForm()
        {
            InitializeComponent();
            // Подписываемся на событие закрытия формы (Условие 3)
            this.FormClosing += ContactForm_FormClosing;
        }

        // Обновление UI при срабатывании события в классе Contact
        private void Contact_Changed(object sender, EventArgs e)
        {
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            // Важно: меняем текст только если он отличается, 
            // чтобы не зацикливать события TextBox
            if (FullNameTextBox.Text != _contact.FullName)
                FullNameTextBox.Text = _contact.FullName;

            if (PhoneTextBox.Text != _contact.PhoneNumber)
                PhoneTextBox.Text = _contact.PhoneNumber;

            if (AddressTextBox.Text != _contact.Address)
                AddressTextBox.Text = _contact.Address;
        }

        // Передача данных из UI в объект
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (_contact == null) return;

            _contact.FullName = FullNameTextBox.Text;
            _contact.PhoneNumber = PhoneTextBox.Text;
            _contact.Address = AddressTextBox.Text;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Условие 3: обязательная отписка для предотвращения утечек памяти
            if (_contact != null)
            {
                _contact.ContactChanged -= Contact_Changed;
            }
        }
    }
}
