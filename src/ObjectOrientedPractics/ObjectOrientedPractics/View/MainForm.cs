using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        // Поле для хранения централизованных данных магазина
        private Store _store;

        public MainForm()
        {
            InitializeComponent();

            // Инициализация поля _store новым объектом
            _store = new Store();

            // Присвоение списков вкладкам из объекта Store
            if (itemsTab != null)
            {
                itemsTab.Items = _store.Items;
            }

            /*if (customersTab != null)
            {
                customersTab.Customers = _store.Customers;
            }*/
        }
    }
}
