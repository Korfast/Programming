using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Пользовательский контроль для отображения и редактирования информации о прямоугольниках.
    /// </summary>
    public partial class RectanglesInfarmationUserControl : UserControl
    {
        /// <summary>
        /// Массив прямоугольников.
        /// </summary>
        private Model.Rectangle[] _rectangles;

        /// <summary>
        /// Текущий выбранный прямоугольник.
        /// </summary>
        private Model.Rectangle _currentRectangle;

        /// <summary>
        /// Инициализация нового экземпляра класса и подготовка данных.
        /// </summary>
        public RectanglesInfarmationUserControl()
        {
            InitializeComponent();
            InitializeRectangles();
            PopulateRectanglesListBox();
        }

        /// <summary>
        /// Инициализирует массив прямоугольников случайными значениями.
        /// </summary>
        private void InitializeRectangles()
        {
            _rectangles = new Model.Rectangle[5];

            for (int i = 0; i < _rectangles.Length; i++)
            {
                // Создание прямоугольника с помощью класса RectangleFactory
                _rectangles[i] = RectangleFactory.Randomize(10, 100);
            }
        }

        /// <summary>
        /// Заполняет ListBox названиями прямоугольников.
        /// </summary>
        private void PopulateRectanglesListBox()
        {
            // Очистка списка перед добавлением новых элементов
            RectanglesListBox.Items.Clear();

            foreach (var rectangle in _rectangles)
            {
                // Добавление имени в формате "Rectangle {Id}"
                RectanglesListBox.Items.Add($"Rectangle {rectangle.Id}");
            }
        }

        /// <summary>
        /// Обновляет свойства ограничений целых чисел из TextBox.
        /// </summary>
        /// <param name="updateAction">Делегат для обновления свойства.</param>
        /// <param name="textBox">Текстовое поле для ввода значения.</param>
        private void UpdateIntLimitsProperty(Action<int> updateAction, TextBox textBox)
        {
            try
            {
                if (int.TryParse(textBox.Text, out int value))
                {
                    // Попытка обновить свойство
                    updateAction(value);
                    textBox.BackColor = SystemColors.Window;
                }
                else
                {
                    // Не удалось преобразовать — выделяем поле
                    textBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch
            {
                // Обработка возможных исключений при обновлении свойства
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Обновляет свойства ограничений чисел с плавающей точкой из TextBox.
        /// </summary>
        /// <param name="updateAction">Делегат для обновления свойства.</param>
        /// <param name="textBox">Текстовое поле для ввода значения.</param>
        private void UpdateDoubleLimitsProperty(Action<double> updateAction, TextBox textBox)
        {
            try
            {
                if (double.TryParse(textBox.Text, out double value))
                {
                    // Попытка обновить свойство
                    updateAction(value);
                    textBox.BackColor = SystemColors.Window;
                }
                else
                {
                    // Не удалось преобразовать — выделяем поле
                    textBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch
            {
                // Обработка возможных исключений при обновлении свойства
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Обновляет свойство перечисления по имени, введенному в TextBox.
        /// </summary>
        /// <typeparam name="EnumType">Тип перечисления.</typeparam>
        /// <param name="textBox">Текстовое поле для ввода имени элемента enum.</param>
        /// <param name="updateAction">Делегат для обновления свойства.</param>
        private void UpdateEnumTypeProperty<EnumType>(TextBox textBox, Action<string> updateAction) where EnumType : struct, Enum
        {
            try
            {
                string value = textBox.Text.Trim();

                // Проверка, что строка не число
                if (double.TryParse(value, out _))
                {
                    throw new ArgumentException($"Invalid {typeof(EnumType).Name} name.");
                }

                // Проверка, что строка соответствует имени элемента enum
                if (Enum.IsDefined(typeof(EnumType), value))
                {
                    // Передача строки в делегат для обновления свойства
                    updateAction(value);
                    textBox.BackColor = SystemColors.Window;
                }
                else
                {
                    throw new ArgumentException($"Invalid {typeof(EnumType).Name} name.");
                }
            }
            catch
            {
                // В случае ошибки выделяем поле красным цветом
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик изменения выбранного элемента в ListBox.
        /// Обновляет текущий выбранный прямоугольник и отображает его данные.
        /// </summary>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0)
            {
                _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
                UpdateRectangleFiledsTextBoxes();
            }
        }

        /// <summary>
        /// Обновляет текстовые поля информацией о текущем выбранном прямоугольнике.
        /// </summary>
        private void UpdateRectangleFiledsTextBoxes()
        {
            IdTextBox.Text = _currentRectangle.Id.ToString();
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
        }

        /// <summary>
        /// Обработчик изменения текста в LengthTextBox. Обновляет длину текущего прямоугольника.
        /// </summary>
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) => _currentRectangle.Length = value, LengthTextBox);
            }
        }

        /// <summary>
        /// Обработчик изменения текста в WidthTextBox.Обновляет ширину текущего прямоугольника.
        /// </summary>
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) => _currentRectangle.Width = value, WidthTextBox);
            }
        }

        ///<summary>
        ///Обработчик изменения текста в ColorTextBox. Обновляет цвет текущего прямоугольника по имени.
        ///</summary>
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0)
            {
                UpdateEnumTypeProperty<Model.Color>(ColorTextBox, (value) => _currentRectangle.Color = value);
            }
        }

        ///<summary>
        ///Находит индекс прямоугольника с максимальной шириной.
        ///</summary>
        ///<returns>
        ///Индекс с максимальной шириной или -1 если массив пустой.
        ///</returns>
        private int FindRectangleWithMaxWidth()
        {
            // Проверка на пустой массив
            if (_rectangles.Length == 0)
            {
                // Возвращаем -1, если массив пустой
                return -1;
            }

            // Индекс прямоугольника с максимальной шириной
            int maxIndex = 0;
            // Начальная максимальная ширина
            double maxWidth = _rectangles[0].Width;

            for (int i = 1; i < _rectangles.Length; i++)
            {
                // Если текущая ширина больше максимальной
                if (_rectangles[i].Width > maxWidth)
                {
                    // Обновляем максимальную ширину и индекс
                    maxWidth = _rectangles[i].Width;
                    maxIndex = i;
                }
            }

            // Возвращаем индекс с максимальной шириной
            return maxIndex;
        }

        ///<summary>
        ///Обработчик кнопки поиска прямоугольника с максимальной шириной.
        ///</summary>
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth();
            RectanglesListBox.SelectedIndex = index;
        }

        ///<summary>
        ///Обновление информации о выбранном прямоугольнике.
        ///</summary>
        private void UpdateRectangleInfo(Model.Rectangle rectangle)
        {
            if (rectangle == null)
                return;

            // Обновляем текущий выбранный прямоугольник и отображение данных
            _currentRectangle = rectangle;
            UpdateRectangleFiledsTextBoxes();
            //UpdateRectangleFiledsTextBoxes5();
        }

        ///<summary>
        ///Очистка информации о прямоугольнике.
        ///</summary >
        private void ClearRectangleInfo()
        {
            // Очистка текстовых полей и сброс цвета фона

            IdTextBox.Text = "";
            IdTextBox.BackColor = SystemColors.Control;

            XTextBox.Text = "";
            XTextBox.BackColor = SystemColors.Control;

            YTextBox.Text = "";
            YTextBox.BackColor = SystemColors.Control;

            LengthTextBox.Text = "";
            LengthTextBox.BackColor = SystemColors.Window;

            WidthTextBox.Text = "";
            WidthTextBox.BackColor = SystemColors.Window;

            ColorTextBox.Text = "";
            ColorTextBox.BackColor = SystemColors.Window;
        }
    }
}
