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
    public partial class RectanglesInfarmationUserControl : UserControl
    {
        // Массив прямоугольников
        private Model.Rectangle[] _rectangles;
        // Текущий прямоугольник
        private Model.Rectangle _currentRectangle;

        public RectanglesInfarmationUserControl()
        {
            InitializeComponent();
            InitializeRectangles();
            PopulateRectanglesListBox();
        }

        private void InitializeRectangles()
        {
            _rectangles = new Model.Rectangle[5];

            for (int i = 0; i < _rectangles.Length; i++)
            {
                // Создание прямоугольника с помощью класса RectangleFactory
                _rectangles[i] = RectangleFactory.Randomize(10, 100);
            }
        }

        private void PopulateRectanglesListBox()
        {
            // Очистка списка перед добавлением новых элементов
            RectanglesListBox.Items.Clear();

            foreach (var rectangle in _rectangles)
            {
                // Добавление имени в нужном формате
                RectanglesListBox.Items.Add($"Rectangle {rectangle.Id}");
            }
        }

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
                    textBox.BackColor = AppColors.LightPink;
                }
            }
            catch
            {
                // Обработка возможных исключений при обновлении свойства
                textBox.BackColor = AppColors.LightPink;
            }
        }

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
                    textBox.BackColor = AppColors.LightPink;
                }
            }
            catch
            {
                // Обработка возможных исключений при обновлении свойства
                textBox.BackColor = AppColors.LightPink;
            }
        }

        private void UpdateEnumTypeProperty<EnumType>(TextBox textBox, Action<string> updateAction) where EnumType : struct, Enum
        {

            try
            {
                // Проверяет является ли текст текстбокса элементом перечисления
                string value = textBox.Text;
                if (Enum.TryParse(value.Trim(), true, out EnumType result))
                {
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
                textBox.BackColor = AppColors.LightPink;
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0)
            {
                _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
                UpdateRectangleFiledsTextBoxes();
            }
        }

        private void UpdateRectangleFiledsTextBoxes()
        {
            IdTextBox.Text = _currentRectangle.Id.ToString();
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) => _currentRectangle.Length = value, LengthTextBox);
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) => _currentRectangle.Width = value, WidthTextBox);
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0)
            {
                UpdateEnumTypeProperty<Model.Color>(ColorTextBox, (value) => _currentRectangle.Color = value);
            }
        }

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
                    // Обновляем максимальную ширину
                    maxWidth = _rectangles[i].Width;
                    // Обновляем индекс
                    maxIndex = i;
                }
            }

            // Возвращаем индекс прямоугольника с максимальной шириной
            return maxIndex;
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth();
            RectanglesListBox.SelectedIndex = index;
        }

        private void UpdateRectangleInfo(Model.Rectangle rectangle)
        {
            if (rectangle == null)
                return;

            // Обновляем текущий выбранный прямоугольник
            _currentRectangle = rectangle;

            // Обновляем отображение в текстовых полях
            UpdateRectangleFiledsTextBoxes();
            //UpdateRectangleFiledsTextBoxes5();
        }

        private void ClearRectangleInfo()
        {
            // Приведение изменяемых свойств текстбоксов к начальному состоянию

            /*
            IdTextBox5.Text = "";
            IdTextBox5.BackColor = SystemColors.Control;

            XTextBox5.Text = "";
            XTextBox5.BackColor = SystemColors.Control;

            YTextBox5.Text = "";
            YTextBox5.BackColor = SystemColors.Control;

            LengthTextBox5.Text = "";
            LengthTextBox5.BackColor = SystemColors.Window;

            WidthTextBox5.Text = "";
            WidthTextBox5.BackColor = SystemColors.Window;
            */

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
