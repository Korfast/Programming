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

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;

        // Атрибуты скрывают свойство от Дизайнера, чтобы он не ломал код
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public Address Address
        {
            get
            {
                {
                    return _address;
                }
            }

            set
            {
                if (value == null)
                {
                    _address = new Address();
                }
                else
                {
                    _address = value;                   
                }

                // Обновляем UI
                UpdateAddressFiledsTextBoxes();
            }
        }

        public AddressControl()
        {
            InitializeComponent();
            _address = new Address();
        }

        /// <summary>
        /// Возвращает или задает значение, указывающее, доступен ли элемент управления только для чтения.
        /// </summary>
        public bool ReadOnly
        {
            get
            {
                return postIndexTextBox.ReadOnly;
            }
            set
            {
                postIndexTextBox.ReadOnly = value;
                countryTextBox.ReadOnly = value;
                cityTextBox.ReadOnly = value;
                streetTextBox.ReadOnly = value;
                buildingTextBox.ReadOnly = value;
                apartmentTextBox.ReadOnly = value;
            }
        }

        /// <summary>
        /// Обновляет текстовые поля формы 
        /// текущими свойствами выбранного адреса.
        /// </summary>
        private void UpdateAddressFiledsTextBoxes()
        {
            // 1. Если адрес еще не задан — выходим
            if (_address == null)
            {
                return;
            }

            // 2. ГЛАВНАЯ ЗАЩИТА: Если текстовые поля еще не созданы (InitializeComponent не доработал) — выходим
            // Дизайнер часто вызывает этот метод раньше времени.
            if (postIndexTextBox == null || countryTextBox == null ||
                cityTextBox == null || streetTextBox == null ||
                buildingTextBox == null || apartmentTextBox == null)
            {
                return;
            }

            // Если всё есть, заполняем
            postIndexTextBox.Text = _address.Index.ToString();
            countryTextBox.Text = _address.Country;
            cityTextBox.Text = _address.City;
            streetTextBox.Text = _address.Street;
            buildingTextBox.Text = _address.Building;
            apartmentTextBox.Text = _address.Apartment;
        }

        public void ClearFields()
        {
            postIndexTextBox.Text = "";
            countryTextBox.Text = "";
            cityTextBox.Text = "";
            streetTextBox.Text = "";
            buildingTextBox.Text = "";
            apartmentTextBox.Text = "";

        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            // Если поле пустое, мы не считаем это ошибкой валидации сейчас
            // (или считаем, но не красим в красный)
            if (string.IsNullOrWhiteSpace(postIndexTextBox.Text))
            {
                postIndexTextBox.BackColor = SystemColors.Window;
                return;
            }

            try
            {
                // Пытаемся присвоить
                // (тут может упасть int.Parse или сеттер свойства Index)
                _address.Index = int.Parse(postIndexTextBox.Text);
                // Если всё прошло успешно — убираем ошибку
                ClearValidationError(postIndexTextBox);
            }
            catch (Exception ex)
            {
                // Показываем сообщение из исключения (ex.Message)
                ShowValidationError(postIndexTextBox, ex.Message);
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;

            if (string.IsNullOrWhiteSpace(countryTextBox.Text))
            {
                ClearValidationError(countryTextBox);
                return;
            }

            try
            {
                _address.Country = countryTextBox.Text;
                ClearValidationError(countryTextBox);
            }
            catch (Exception ex)
            {
                ShowValidationError(countryTextBox, ex.Message);
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;

            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                ClearValidationError(cityTextBox);
                return;
            }

            try
            {
                _address.City = cityTextBox.Text;
                ClearValidationError(cityTextBox);
            }
            catch (Exception ex)
            {
                ShowValidationError(cityTextBox, ex.Message);
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;

            if (string.IsNullOrWhiteSpace(streetTextBox.Text))
            {
                ClearValidationError(streetTextBox);
                return;
            }

            try
            {
                _address.Street = streetTextBox.Text;
                ClearValidationError(streetTextBox);
            }
            catch (Exception ex)
            {
                ShowValidationError(streetTextBox, ex.Message);
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;

            if (string.IsNullOrWhiteSpace(buildingTextBox.Text))
            {
                ClearValidationError(buildingTextBox);
                return;
            }

            try
            {
                _address.Building = buildingTextBox.Text;
                ClearValidationError(buildingTextBox);
            }
            catch (Exception ex)
            {
                ShowValidationError(buildingTextBox, ex.Message);
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;

            if (string.IsNullOrWhiteSpace(apartmentTextBox.Text))
            {
                ClearValidationError(apartmentTextBox);
                return;
            }

            try
            {
                _address.Apartment = apartmentTextBox.Text;
                ClearValidationError(apartmentTextBox);
            }
            catch (Exception ex)
            {
                ShowValidationError(apartmentTextBox, ex.Message);
            }
        }

        private ErrorProvider errorProvider = new ErrorProvider();

        private void ShowValidationError(Control control, string message)
        {
            control.BackColor = Color.Pink;
            errorProvider.SetError(control, message);
        }

        private void ClearValidationError(Control control)
        {
            control.BackColor = SystemColors.Window;
            errorProvider.SetError(control, "");
        }

        private bool ValidateAllFields()
        {
            bool isValid = true;

            // Пример валидации для индекса
            if (!int.TryParse(postIndexTextBox.Text, out _))
            {
                ShowValidationError(postIndexTextBox, "Индекс должен быть числом");
                isValid = false;
            }
            else
            {
                ClearValidationError(postIndexTextBox);
            }

            // Добавьте проверки для других полей по необходимости
            // Например, обязательность заполнения
            if (string.IsNullOrWhiteSpace(countryTextBox.Text))
            {
                ShowValidationError(countryTextBox, "Введите страну");
                isValid = false;
            }
            else
            {
                ClearValidationError(countryTextBox);
            }

            // Аналогично для остальных полей...

            return isValid;
        }

        //private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        //{
        //if (ObjectOrientedPractics.View.Tabs.CustomersTab.customersListBox.SelectedIndex >= 0)
        //{
        //0 UpdateNameProperty(fullNameTextBox, 200, (value) =>
        //_currentCustomer.Fullname = value);
        //}
        //}

        private bool ValidateFields()
        {
            bool isValid = true;

            // Проверка индекса
            if (!int.TryParse(postIndexTextBox.Text, out _))
            {
                postIndexTextBox.BackColor = Color.Red;
                //postIndexTextBox.ToolTip = "Некорректный индекс";
                isValid = false;
            }
            else
            {
                postIndexTextBox.BackColor = SystemColors.Window;
                // postIndexTextBox.ToolTip = null;
            }

            // Аналогично для других полей при необходимости

            return isValid;
        }

        // Можно вызвать ValidateFields перед возвратом Address в геттере.
    }
}
