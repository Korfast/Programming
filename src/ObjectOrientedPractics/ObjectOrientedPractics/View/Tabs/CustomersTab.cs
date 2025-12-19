using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список всех покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Выбрнный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// При установке обновляется отображение ListBox.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                if (value == null)
                {
                    _customers = new List<Customer>();
                }
                else
                {
                    _customers = value;
                }
                UpdateListBox();
            }
        }

        /// <summary>
        /// Обновляет ListBox с текущим списком покупателей.
        /// </summary>
        private void UpdateListBox()
        {
            if (customersListBox == null)
            {
                return;
            }

            customersListBox.Items.Clear();

            if (_customers == null)
            {
                return;
            }

            foreach (var item in _customers)
            {
                customersListBox.Items.Add(item);
                // Предположим, что Customer переопределяет ToString()
            }
        }

        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Заполняет список элементов <see cref="customersListBox"
        /// /> текущими покупателями.
        /// </summary>
        private void PopulateCustomersListBox()
        {
            customersListBox.Items.Clear();

            foreach (Customer customer in _customers)
            {
                customersListBox.Items.Add($"Покупатель {customer.Id}");
            }
        }

        

        /// <summary>
        /// Обработчик события клика по кнопке добавления нового покупателя.
        /// Создает случайного покупателя,
        /// добавляет его в список и обновляет интерфейс.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Создаем и добавляем нового случайного покупателя
            _customers.Add(CustomerFactory.Randomize(0, 100000));

            // Обновляем список отображения
            PopulateCustomersListBox();

            // Устанавливаем последний добавленный элемент как выбранный
            customersListBox.SelectedIndex = customersListBox.Items.Count - 1;
        }

        /// <summary>
        /// Обработчик события клика по кнопке удаления выбранного покупателя.
        /// Удаляет выбранного покупателя из списка и обновляет интерфейс.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = customersListBox.SelectedIndex;

            // Проверка, что что-то выбрано
            if (selectedIndex >= 0 && selectedIndex < _customers.Count)
            {
                // Удаляем выбранного покупателя
                _customers.RemoveAt(selectedIndex);

                // Обновляем отображение списка
                PopulateCustomersListBox();

                // Обновляем выбранный индекс
                if (_customers.Count > 0)
                {
                    int newIndex = selectedIndex;
                    if (newIndex >= _customers.Count)
                    {
                        newIndex = _customers.Count - 1;
                    }
                    // Это присваивание АВТОМАТИЧЕСКИ вызовет
                    // customersListBox_SelectedIndexChanged,
                    // который обновит _currentCustomer и заполнит поля
                    customersListBox.SelectedIndex = newIndex;
                }
                else
                {
                    // Если список пуст, сбрасываем выбор
                    customersListBox.SelectedIndex = -1;

                    // Очищаем поля вручную
                    _currentCustomer = null;
                    idTextBox.Text = "";
                    fullNameTextBox.Text = "";
                    isPriorityCheckBox.Checked = false;

                    // Очищаем адрес
                    addressControl.ClearFields();

                    // Сбрасываем цвета валидации
                    fullNameTextBox.BackColor = SystemColors.Window;
                }
            }
        }

        /// <summary>
        /// Обновляет свойство имени на основе текста из TextBox.
        /// </summary>
        /// <param name="textBox">TextBox для ввода имени.</param>
        /// <param name="length">Максимальная длина имени.</param>
        /// <param name="updateAction">
        /// Делегат для обновления свойства имени.</param>
        private void UpdateNameProperty
            (System.Windows.Forms.TextBox textBox, int length,
            Action<string> updateAction)
        {
            try
            {
                string value = textBox.Text;
                if (!"ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(value[0]) &&
                    !"АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЭЮЯ".Contains(value[0]))
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value.Length > length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                updateAction(value);
                textBox.BackColor = SystemColors.Window;
            }
            catch
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Обновляет текстовые поля формы 
        /// текущими свойствами выбранного покупателя.
        /// </summary>
        private void UpdateCustomerFieldsTextBoxes()
        {
            if (_currentCustomer != null)
            {
                idTextBox.Text = _currentCustomer.Id.ToString();
                fullNameTextBox.Text = _currentCustomer.Fullname.ToString();
                isPriorityCheckBox.Checked = _currentCustomer.IsPriority;
                // Передача адреса в AddressControl
                addressControl.Address = _currentCustomer.Address;
            }
        }

        /// <summary>
        /// Обработчик изменения выбранного элемента списка.
        /// Обновляет текущего покупателя и отображает его свойства.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex >= 0)
            {
                _currentCustomer = _customers[customersListBox.SelectedIndex];
                UpdateCustomerFieldsTextBoxes();
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле полного имени.
        /// Выполняет валидацию и обновление модели.
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex >= 0)
            {
                UpdateNameProperty(fullNameTextBox, 200, (value) =>
                _currentCustomer.Fullname = value);
            }
        }

        /// <summary>
        /// Обработчик изменения состояния чекбокса приоритетного покупателя.
        /// Обновляет свойство IsPriority у текущего покупателя.
        /// </summary>
        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                _currentCustomer.IsPriority = isPriorityCheckBox.Checked;
            }
        }
    }
}
