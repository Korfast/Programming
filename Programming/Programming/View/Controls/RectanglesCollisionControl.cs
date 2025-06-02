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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming.View.Controls
{
    /// <summary>
    /// Пользовательский контроль для отображения и проверки столкновений прямоугольников.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Массив прямоугольников.
        /// </summary>
        private Model.Rectangle[] _rectangles = new Model.Rectangle[0];

        /// <summary>
        /// Текущий выбранный прямоугольник.
        /// </summary>
        private Model.Rectangle _currentRectangle;

        /// <summary>
        /// Список панелей, представляющих прямоугольники.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Конструктор, инициализирующий компонент и список прямоугольников.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();
            InitializeRectanglesListBox5();
        }

        /// <summary>
        /// Инициализация списка и панелей для отображения прямоугольников.
        /// </summary>
        private void InitializeRectanglesListBox5()
        {
            // Заполняем список элементов
            PopulateRectanglesListBox5();

            // Создаем панели для каждого прямоугольника
            foreach (var rectangle in _rectangles)
            {
                Panel rectanglePanel = CreateRectanglePanel(rectangle);

                // Добавляем панель на контрол
                RectanglesPanel5.Controls.Add(rectanglePanel);

                // Добавляем панель в список для дальнейшего управления
                _rectanglePanels.Add(rectanglePanel);
            }

            // Обновляем цвета панелей в зависимости от столкновений
            FindCollisions();
        }

        /// <summary>
        /// Заполняет ListBox информацией о текущих прямоугольниках.
        /// </summary>
        private void PopulateRectanglesListBox5()
        {
            RectanglesListBox5.Items.Clear();

            foreach (var rectangle in _rectangles)
            {
                RectanglesListBox5.Items.Add($"{rectangle.Id}: (X={rectangle.Center.X}; Y={rectangle.Center.Y}; L={rectangle.Length}; W={rectangle.Width})");
            }
        }

        /// <summary>
        /// Проверяет столкновения между всеми парами прямоугольников и обновляет цвет панелей.
        /// </summary>
        private void FindCollisions()
        {
            // Устанавливаем все панели в зеленый цвет по умолчанию
            foreach (Panel panel in _rectanglePanels)
            {
                panel.BackColor = AppColors.LightGreen;
            }

            // Перебираем все пары прямоугольников для проверки столкновений
            for (int i = 0; i < _rectangles.Length - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Length; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        // Если есть столкновение, окрашиваем панели в красный
                        _rectanglePanels[i].BackColor = AppColors.LightPink;
                        _rectanglePanels[j].BackColor = AppColors.LightPink;
                    }
                }
            }
        }

        /// <summary>
        /// Валидирует введенное значение и обновляет соответствующее свойство прямоугольника.
        /// </summary>
        /// <param name="updateAction">Действие по обновлению свойства.</param>
        /// <param name="textBox">Текстовое поле для ввода значения.</param>
        private void ValidateAndUpdateProperty(Action<int> updateAction, System.Windows.Forms.TextBox textBox)
        {
            try
            {
                int value = int.Parse(textBox.Text);
                updateAction(value);
                textBox.BackColor = SystemColors.Window;

                // После успешного обновления перерисовываем панели
                if (_currentRectangle != null)
                {
                    RecreateRectanglePanels();
                }
            }
            catch
            {
                // В случае ошибки выделяем поле розовым цветом
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Создает панель, представляющую прямоугольник.
        /// </summary>
        /// <param name="rectangle">Объект прямоугольника.</param>
        /// <returns>Созданная панель с размерами и позицией, соответствующими прямоугольнику.</returns>
        private Panel CreateRectanglePanel(Model.Rectangle rectangle)
        {
            Panel rectanglePanel = new Panel();

            int x = Convert.ToInt32(rectangle.Center.X - rectangle.Width / 2);
            int y = Convert.ToInt32(rectangle.Center.Y - rectangle.Length / 2);

            rectanglePanel.Location = new Point(x, y);
            rectanglePanel.Size = new Size(Convert.ToInt32(rectangle.Width), Convert.ToInt32(rectangle.Length));
            rectanglePanel.BackColor = AppColors.LightGreen;

            return rectanglePanel;
        }

        /// <summary>
        /// Обновляет текстовые поля информацией о текущем выбранном прямоугольнике.
        /// </summary>
        private void UpdateRectangleFiledsTextBoxes5()
        {
            IdTextBox5.Text = _currentRectangle.Id.ToString();
            XTextBox5.Text = _currentRectangle.Center.X.ToString();
            YTextBox5.Text = _currentRectangle.Center.Y.ToString();
            LengthTextBox5.Text = _currentRectangle.Length.ToString();
            WidthTextBox5.Text = _currentRectangle.Width.ToString();
        }


        /// <summary>
        /// Обработчик события нажатия на кнопку добавления нового прямоугольника.
        /// Создает случайный прямоугольник, добавляет его в список, обновляет интерфейс и проверяет столкновения.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddRectangleButton5_Click(object sender, EventArgs e)
        {
            // Создаем копию текущего списка прямоугольников
            List<Model.Rectangle> _rectanglesList = _rectangles.ToList();

            // Создаем и добавляем новый случайный прямоугольник
            _rectanglesList.Add(RectangleFactory.Randomize(10, 100));
            // Обновляем массив прямоугольников
            _rectangles = _rectanglesList.ToArray();

            // Обновляем список отображения
            PopulateRectanglesListBox5();

            // Устанавливаем последний добавленный элемент как выбранный
            RectanglesListBox5.SelectedIndex = RectanglesListBox5.Items.Count - 1;
            // Обновляем текущий выбранный прямоугольник
            _currentRectangle = _rectangles[RectanglesListBox5.SelectedIndex];

            // Создаем панель для нового прямоугольника
            Panel rectanglePanel = CreateRectanglePanel(_currentRectangle);

            // Добавляем панель на основной контейнер
            RectanglesPanel5.Controls.Add(rectanglePanel);

            // Добавляем панель в список для дальнейшего управления
            _rectanglePanels.Add(rectanglePanel);

            // Проверяем столкновения и обновляем цвета панелей
            FindCollisions();
        }

        /// <summary>
        /// Обработчик события удаления выбранного прямоугольника.
        /// Удаляет выбранный прямоугольник из списка, интерфейса и обновляет столкновения.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void DeleteRectangleButton5_Click(object sender, EventArgs e)
        {
            int selectedIndex = RectanglesListBox5.SelectedIndex;
            if (selectedIndex == -1)
                return; // Нет выбранного элемента

            // Удаляем из массива прямоугольников
            _rectangles = _rectangles.Where((rect, index) => index != selectedIndex).ToArray();

            // Удаляем из ListBox
            RectanglesListBox5.Items.RemoveAt(selectedIndex);

            // Удаляем соответствующую панель
            if (_rectanglePanels.Count > selectedIndex)
            {
                Panel panelToRemove = _rectanglePanels[selectedIndex];
                RectanglesPanel5.Controls.Remove(panelToRemove);
                _rectanglePanels.RemoveAt(selectedIndex);
                panelToRemove.Dispose();
            }

            // Обновляем текущий выбранный элемент после удаления
            if (RectanglesListBox5.Items.Count > 0)
            {
                int newIndex = Math.Min(selectedIndex, RectanglesListBox5.Items.Count - 1);
                RectanglesListBox5.SelectedIndex = newIndex;
                _currentRectangle = _rectangles[newIndex];
                UpdateRectangleFiledsTextBoxes5();
            }

            // Обновляем цвета панелей после удаления
            FindCollisions();
        }

        /// <summary>
        /// Очищает поля отображения информации о выбранном прямоугольнике.
        /// </summary>
        private void ClearRectangleInfo()
        {
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
        }

        /// <summary>
        /// Обновляет информацию о текущем выбранном прямоугольнике в текстовых полях.
        /// </summary>
        /// <param name="rectangle">Объект прямоугольника для отображения.</param>
        private void UpdateRectangleInfo(Model.Rectangle rectangle)
        {
            if (rectangle == null)
                return;

            // Обновляем текущий выбранный прямоугольник
            _currentRectangle = rectangle;

            // Обновляем поля с информацией о нем
            UpdateRectangleFiledsTextBoxes5();
        }

        /// <summary>
        /// Обработчик изменения выбранного элемента в списке прямоугольников.
        /// Обновляет отображение информации о выбранном объекте.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void RectanglesListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox5.SelectedIndex >= 0)
            {
                _currentRectangle = _rectangles[RectanglesListBox5.SelectedIndex];
                UpdateRectangleFiledsTextBoxes5();
            }
            else
            {
                _currentRectangle = null;
                ClearRectangleInfo();
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле длины. Валидирует ввод и обновляет свойство.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void LengthTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox5.SelectedIndex >= 0)
            {
                ValidateAndUpdateProperty((value) => _currentRectangle.Length = value, LengthTextBox5);
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле ширины. Валидирует ввод и обновляет свойство.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void WidthTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox5.SelectedIndex >= 0)
            {
                ValidateAndUpdateProperty((value) => _currentRectangle.Width = value, WidthTextBox5);
            }
        }

        /// <summary>
        /// Пересоздает панели для всех прямоугольников после изменений их свойств или структуры.
        /// Удаляет старые панели и создает новые.
        /// </summary>
        private void RecreateRectanglePanels()
        {
            // Удаляем старые панели из контейнера и очищаем список
            foreach (Panel panel in _rectanglePanels)
            {
                if (panel.Parent != null)
                    panel.Parent.Controls.Remove(panel);
                panel.Dispose();
            }
            _rectanglePanels.Clear();

            // Создаем новые панели для каждого прямоугольника
            foreach (Model.Rectangle rectangle in _rectangles)
            {
                Panel newPanel = CreateRectanglePanel(rectangle);
                _rectanglePanels.Add(newPanel);
                RectanglesPanel5.Controls.Add(newPanel);
            }

            // Проверяем столкновения и обновляем цвета панелей
            FindCollisions();
        }
    }
}
