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
        // Статичное поле объект класса Random
        private static Random _random = new Random();
        // Целочисленное поле Id
        private readonly int _id;
        // Вещественное поле Длина
        private double _length; 
        // Вещественное поле Ширина
        private double _width;
        // Поле Центр типа Point2D
        private readonly Point2D _center;
        // Строковое поле Цвет
        private string _color;
        // Целочисленное поле Количество существующих объектов класса Прямоугольник
        private static int _allRectanglesCount;

        // Свойство для доступа к Id
        public int Id => _id;

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

        // Свойство для доступа к центру прямоугольника
        public Point2D Center => _center;

        // Свойство для доступа к цвету
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        // Свойство возвращающее значение поля _allRectanglesCount
        public static int AllRectanglesCount()
        {
            return _allRectanglesCount;
        }

        // Конструктор с параметрами
        public Rectangle(double length, double width, string color)
        {
            
            _id = _allRectanglesCount;
            Length = length;
            Width = width;
            _center = new Point2D(_random.Next(10, 360), _random.Next(10,390));
            Color = color;

            // Счётчик объектов класса Прямоугольник
            _allRectanglesCount++;
        }

        // Конструктор без параметров
        public Rectangle() { }
    }
}
