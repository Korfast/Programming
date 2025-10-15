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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab  : UserControl
    {
        private List<Item> _items = new List<Item>();
        private Item _currentItem;

        public ItemsTab()
        {
            InitializeComponent();
        }

        private void PopulateItemsListBox()
        {
            itemsListBox.Items.Clear();

            foreach (Item item in _items)
            {
                itemsListBox.Items.Add($"Товар {item.Id}");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            // Создаем и добавляем новый случайный товар
            _items.Add(ItemFactory.Randomize(0, 100000));

            // Обновляем список отображения
            PopulateItemsListBox();

            // Устанавливаем последний добавленный элемент как выбранный
            itemsListBox.SelectedIndex = itemsListBox.Items.Count - 1;
            // Обновляем текущий выбранный товар
            _currentItem = _items[itemsListBox.SelectedIndex];
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = itemsListBox.SelectedIndex;

            // Проверка, что что-то выбрано
            if (selectedIndex >= 0 && selectedIndex < _items.Count)
            {
                // Удаляем выбранный элемент
                _items.RemoveAt(selectedIndex);

                // Обновляем отображение списка
                PopulateItemsListBox();

                // Обновляем выбранный индекс
                if (_items.Count > 0)
                {
                    // Если есть элементы после удаления,
                    // выбираем последний или первый
                    int newIndex = Math.Min(selectedIndex, _items.Count - 1);
                    itemsListBox.SelectedIndex = newIndex;
                    _currentItem = _items[newIndex];
                    UpdateItemFiledsTextBoxes();
                }
                else
                {
                    // Если список пуст, очищаем текущие поля
                    _currentItem = null;
                    idTextBox.Text = "";
                    costTextBox.Text = "";
                    nameTextBox.Text = "";
                    descriptionTextBox.Text = "";

                    // Так же обновляем цвет боксов информации
                    costTextBox.BackColor = SystemColors.Window;
                    nameTextBox.BackColor = SystemColors.Window;
                    descriptionTextBox.BackColor = SystemColors.Window;
                }
            }
        }

        /// <summary>
        /// Обновляет свойства ограничений целых чисел из TextBox.
        /// </summary>
        /// <param name="updateAction">Делегат для обновления свойства.
        /// </param>
        /// <param name="textBox">Текстовое поле для ввода значения.</param>
        private void UpdateIntLimitsProperty
            (Action<int> updateAction, System.Windows.Forms.TextBox textBox)
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

        private void UpdateItemNameProperty
            (System.Windows.Forms.TextBox textBox,
            int length, Action<string> updateAction)
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

        private void ItemsListBox_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex >= 0)
            {
                _currentItem = _items[itemsListBox.SelectedIndex];
                UpdateItemFiledsTextBoxes();
            }
        }

        private void UpdateItemFiledsTextBoxes()
        {
            idTextBox.Text = _currentItem.Id.ToString();
            costTextBox.Text = _currentItem.Cost.ToString();
            nameTextBox.Text = _currentItem.Name;
            descriptionTextBox.Text = _currentItem.Info;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex >= 0)
            {
                UpdateIntLimitsProperty((value) 
                    => _currentItem.Cost = value, costTextBox);
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex >= 0)
            {
                UpdateItemNameProperty(nameTextBox, 200, (value)
                    => _currentItem.Name = value);
            }
        }

        private void DescriptionTextBox_TextChanged
            (object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex >= 0)
            {
                UpdateItemNameProperty(descriptionTextBox, 1000, (value)
                    => _currentItem.Info = value);
            }
        }
    }
}
