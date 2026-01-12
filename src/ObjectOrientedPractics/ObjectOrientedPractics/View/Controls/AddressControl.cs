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

        /// <summary>
        /// Возвращает и задает адрес для отображения.
        /// </summary>
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

        /// <summary>
        /// Создает экземпляр <see cref="AddressControl"/>.
        /// </summary>
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

        /// <summary>
        /// Очищает все текстовые поля управления.
        /// </summary>
        public void ClearFields()
        {
            postIndexTextBox.Text = "";
            countryTextBox.Text = "";
            cityTextBox.Text = "";
            streetTextBox.Text = "";
            buildingTextBox.Text = "";
            apartmentTextBox.Text = "";

        }

        /// <summary>
        /// Обработчик изменения текста в поле почтового индекса.
        /// </summary>
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

        /// <summary>
        /// Обработчик изменения текста в поле страны.
        /// </summary>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;

            if (string.IsNullOrWhiteSpace(countryTextBox.Text))
            {
                if (string.IsNullOrWhiteSpace(countryTextBox.Text))
                {
                    _address.Country = ""; 
                    ClearValidationError(countryTextBox);
                    return;
                }
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

        /// <summary>
        /// Обработчик изменения текста в поле города.
        /// </summary>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;

            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                _address.City = "";
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

        /// <summary>
        /// Обработчик изменения текста в поле улицы.
        /// </summary>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;

            if (string.IsNullOrWhiteSpace(streetTextBox.Text))
            {
                _address.Street = "";
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

        /// <summary>
        /// Обработчик изменения текста в поле строения.
        /// </summary>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;

            if (string.IsNullOrWhiteSpace(buildingTextBox.Text))
            {
                _address.Building = "";
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

        /// <summary>
        /// Обработчик изменения текста в поле номера квартиры.
        /// </summary>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;

            if (string.IsNullOrWhiteSpace(apartmentTextBox.Text))
            {
                _address.Apartment = "";
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

        /// <summary>
        /// Объект для отображения ошибок валидации.
        /// </summary>
        private ErrorProvider errorProvider = new ErrorProvider();

        /// <summary>
        /// Визуализирует ошибку валидации для указанного контрола.
        /// </summary>
        /// <param name="control">Контрол, в котором возникла ошибка.</param>
        /// <param name="message">Сообщение об ошибке.</param>
        private void ShowValidationError(Control control, string message)
        {
            control.BackColor = Color.Pink;
            errorProvider.SetError(control, message);
        }

        /// <summary>
        /// Очищает визуализацию ошибки валидации для указанного контрола.
        /// </summary>
        /// <param name="control">Контрол, для которого нужно очистить ошибку.</param>
        private void ClearValidationError(Control control)
        {
            control.BackColor = SystemColors.Window;
            errorProvider.SetError(control, "");
        }

        /// <summary>
        /// Проводит полную валидацию всех полей адреса.
        /// </summary>
        /// <returns>True, если все поля валидны.</returns>
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

            return isValid;
        }

        /// <summary>
        /// Проводит базовую проверку полей (цветовая индикация).
        /// </summary>
        /// <returns>True, если поля соответствуют базовым требованиям.</returns>
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

            return isValid;
        }
    }
}
