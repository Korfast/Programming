using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    // Класс Прямоугольник
    public class Rectangle
    {
        // Вещественное поле Длина
        private double _length; 
        // Вещественное поле Ширина
        private double _width; 
        // Строковое поле Цвет
        private string _color;

        // Свойство для доступа к длине
        public double Length
        {
            get { return _length; }
            set
            {
                // Используем метод из Validator для проверки положительности длины
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        // Свойство для доступа к ширине
        public double Width
        {
            get { return _width; }
            set
            {
                // Используем метод из Validator для проверки положительности ширины
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        // Свойство для доступа к цвету
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        // Конструктор с параметрами
        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

        // Конструктор без параметров
        public Rectangle() { }
    }
}
