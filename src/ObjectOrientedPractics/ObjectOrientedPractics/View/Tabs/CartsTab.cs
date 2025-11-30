using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список всех товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список всех покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        public List<Customer> Customers
        {
            get 
            { 
                return _customers; 
            }
            set 
            {
                _customers = value;
            }
        }

        public CartsTab()
        {
            InitializeComponent();
        }
    }
}