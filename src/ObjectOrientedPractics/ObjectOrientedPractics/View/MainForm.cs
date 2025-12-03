using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Главное окно приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Хранилище данных (товары и покупатели).
        /// </summary>
        private Store _store;

        /// <summary>
        /// Конструктор главного окна.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Создаем экземпляр магазина
            _store = new Store();

            // Передаем списки товаров и покупателей во вкладки
            itemsTab.Items = _store.Items;
            customersTab.Customers = _store.Customers;
            cartsTab.Items = _store.Items;
            cartsTab.Customers = _store.Customers;
            ordersTab.Customers = _store.Customers;
        }

        /// <summary>
        /// Обработчик события смены вкладки.
        /// Обновляет данные на вкладках, которым нужна актуальная информация.
        /// </summary>
        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверяем, какая вкладка выбрана.
            // Индекс 2 соответствует вкладке CartsTab (если порядок: Items, Customers, Carts)
            if (mainTabControl.SelectedIndex == 2)
            {
                cartsTab.RefreshData();
            }


            if (mainTabControl.SelectedIndex == 3)
            {
                ordersTab.RefreshData();
            }
        }
    }
}