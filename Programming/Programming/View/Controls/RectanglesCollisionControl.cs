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
    public partial class RectanglesCollisionControl : UserControl
    {
        // Массив прямоугольников
        private Model.Rectangle[] _rectangles = new Model.Rectangle[0];
        // Текущий прямоугольник
        private Model.Rectangle _currentRectangle;
        // Список панелей
        private List<Panel> _rectanglePanels = new List<Panel>();

        public RectanglesCollisionControl()
        {
            InitializeComponent();
            InitializeRectanglesListBox5();
        }

        private void InitializeRectanglesListBox5()
        {
            // Добавляем все изначально существующие прямоугольники
            PopulateRectanglesListBox5();

            // Создаем для них панели через отдельную функцию
            foreach (var rectangle in _rectangles)
            {
                Panel rectanglePanel = CreateRectanglePanel(rectangle);

                // Добавляем панель на RectanglesPanel5
                RectanglesPanel5.Controls.Add(rectanglePanel);

                // Добавляем панель в список для дальнейшего управления
                _rectanglePanels.Add(rectanglePanel);
            }

            // Обновляем цвета панелей
            FindCollisions();
        }

        private void PopulateRectanglesListBox5()
        {
            // Очистка списка перед добавлением новых элементов
            RectanglesListBox5.Items.Clear();

            foreach (var rectangle in _rectangles)
            {
                // Добавление имени в нужном формате
                RectanglesListBox5.Items.Add($"{rectangle.Id}: (X={rectangle.Center.X}; " +
                    $"Y={rectangle.Center.Y}; L={rectangle.Length}; W={rectangle.Width})");
            }
        }

        private void FindCollisions()
        {

            // Перекрашиваем все панели в зеленый цвет
            foreach (Panel panel in _rectanglePanels)
            {
                panel.BackColor = System.Drawing.Color.LightGreen;
            }

            // Перебираем все пары прямоугольников
            for (int i = 0; i < _rectangles.Length - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Length; j++)
                {
                    // Проверка столкновения
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        // Перекрашиваем панели в красный цвет
                        _rectanglePanels[i].BackColor = System.Drawing.Color.LightPink;
                        _rectanglePanels[j].BackColor = System.Drawing.Color.LightPink;
                    }
                }
            }
        }

        private void ValidateAndUpdateProperty(Action<int> updateAction, System.Windows.Forms.TextBox textBox)
        {
            try
            {
                int value = int.Parse(textBox.Text);
                updateAction(value);
                textBox.BackColor = SystemColors.Window;

                // После успешного обновления перерисовываем панель и ищем пересечения
                if (_currentRectangle != null)
                {
                    RecreateRectanglePanels();
                }
            }
            catch
            {
                // Ошибка преобразования
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private Panel CreateRectanglePanel(Model.Rectangle rectangle)
        {
            // Создаем новый Panel
            Panel rectanglePanel = new Panel();

            // Вычисляем верхний левый угол так, чтобы центр совпадал с rectangle.Center
            int x = Convert.ToInt32(rectangle.Center.X - rectangle.Width / 2);
            int y = Convert.ToInt32(rectangle.Center.Y - rectangle.Length / 2);

            // Устанавливаем размеры и позицию панели согласно Rectangle
            rectanglePanel.Location = new Point(x, y);
            rectanglePanel.Size = new Size(Convert.ToInt32(rectangle.Width), Convert.ToInt32(rectangle.Length));

            // Назначаем цвет фона (прозрачный зеленый)
            rectanglePanel.BackColor = System.Drawing.Color.LightGreen;

            return rectanglePanel;
        }

        private void UpdateRectangleFiledsTextBoxes5()
        {
            IdTextBox5.Text = _currentRectangle.Id.ToString();
            XTextBox5.Text = _currentRectangle.Center.X.ToString();
            YTextBox5.Text = _currentRectangle.Center.Y.ToString();
            LengthTextBox5.Text = _currentRectangle.Length.ToString();
            WidthTextBox5.Text = _currentRectangle.Width.ToString();
        }

        private void AddRectangleButton5_Click(object sender, EventArgs e)
        {
            List<Model.Rectangle> _rectanglesList = _rectangles.ToList();

            // Создаём и добавляем новый прямоугольник в список
            _rectanglesList.Add(RectangleFactory.Randomize(10, 100));
            // Преобразуем список в массив
            _rectangles = _rectanglesList.ToArray();

            // Обновляем RectanglesListBox
            //PopulateRectanglesListBox();
            // Обновляем RectanglesListBox5
            PopulateRectanglesListBox5();

            // Задаём последний элемент списка как выбранный
            RectanglesListBox5.SelectedIndex = RectanglesListBox5.Items.Count - 1;
            // Задаём текущий прямоугольник 
            _currentRectangle = _rectangles[RectanglesListBox5.SelectedIndex];

            // Создаем панель через отдельную функцию
            Panel rectanglePanel = CreateRectanglePanel(_currentRectangle);

            // Добавляем панель на RectanglesPanel5
            RectanglesPanel5.Controls.Add(rectanglePanel);

            // Добавляем панель в список для дальнейшего управления
            _rectanglePanels.Add(rectanglePanel);

            //CheckTheCorrespondenceOfRectanglesAndPanelsElements();

            // Обновляем цвета панелей
            FindCollisions();
        }

        private void DeleteRectangleButton5_Click(object sender, EventArgs e)
        {
            // Проверяем, что есть выбранный элемент
            int selectedIndex = RectanglesListBox5.SelectedIndex;
            if (selectedIndex == -1)
            {
                // Ничего не выбрано, выходим
                return;
            }

            // Удаляем из списка _rectangles
            _rectangles = _rectangles.Where((rect, index) => index != selectedIndex).ToArray();

            // Удаляем из ListBox
            RectanglesListBox5.Items.RemoveAt(selectedIndex);

            // Обновляем RectanglesListBox
            //PopulateRectanglesListBox();

            // Удаляем соответствующую панель
            if (_rectanglePanels.Count > selectedIndex)
            {
                Panel panelToRemove = _rectanglePanels[selectedIndex];
                RectanglesPanel5.Controls.Remove(panelToRemove);
                _rectanglePanels.RemoveAt(selectedIndex);
                panelToRemove.Dispose();
            }

            // Обновляем текущий выбранный индекс
            if (RectanglesListBox5.Items.Count > 0)
            {
                RectanglesListBox5.SelectedIndex = Math.Min(selectedIndex, RectanglesListBox5.Items.Count - 1);
                _currentRectangle = _rectangles[RectanglesListBox5.SelectedIndex];
            }

            // Обновляем цвета панелей
            FindCollisions();
        }

        private void ClearRectangleInfo()
        {
            // Приведение изменяемых свойств текстбоксов к начальному состоянию

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

            /*
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
            */
        }

        private void UpdateRectangleInfo(Model.Rectangle rectangle)
        {
            if (rectangle == null)
                return;

            // Обновляем текущий выбранный прямоугольник
            _currentRectangle = rectangle;

            // Обновляем отображение в текстовых полях
            //UpdateRectangleFiledsTextBoxes();
            UpdateRectangleFiledsTextBoxes5();
        }

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

        private void LengthTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox5.SelectedIndex >= 0)
            {
                ValidateAndUpdateProperty((value) => _currentRectangle.Length = value, LengthTextBox5);
            }

        }

        private void WidthTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox5.SelectedIndex >= 0)
            {
                ValidateAndUpdateProperty((value) => _currentRectangle.Width = value, WidthTextBox5);
            }

        }

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
                // Добавляем панель в главный контейнер RectanglesPanel5
                RectanglesPanel5.Controls.Add(newPanel);

                // Добавляем панель в список для дальнейшего управления
                //_rectanglePanels.Add(newPanel);
            }

            // Обновляем цвета панелей
            FindCollisions();
        }

        private void CheckTheCorrespondenceOfRectanglesAndPanelsElements()
        {
            for (int i = 0; i < _rectangles.Length; i++)
            {
                Model.Rectangle rect = _rectangles[i];
                Panel panel = _rectanglePanels[i];

                // Проверка размеров
                bool sizeMatches = panel.Width == Convert.ToInt32(rect.Width) && panel.Height == Convert.ToInt32(rect.Length);

                // Проверка позиции (учитывая, что позиция — это центр)
                int expectedX = Convert.ToInt32(rect.Center.X - rect.Width / 2);
                int expectedY = Convert.ToInt32(rect.Center.Y - rect.Length / 2);
                bool positionMatches = panel.Location.X == expectedX && panel.Location.Y == expectedY;

                if (sizeMatches || positionMatches)
                {
                    Console.WriteLine($"Несовпадение в элементе {i}:");
                    if (sizeMatches)
                        Console.WriteLine($"  Размеры: панель ({panel.Width},{panel.Height}), ожидаемые ({rect.Width},{rect.Length})");
                    if (positionMatches)
                        Console.WriteLine($"  Позиция: панель ({panel.Location.X},{panel.Location.Y}), ожидаемая ({expectedX},{expectedY})  начальные {rect.Center.X}, {rect.Center.Y}");
                }
            }
        }
    }
}
