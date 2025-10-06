using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Класс, представляющий прямоугольник.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Статичное поле, содержащее объект класса Random для генерации случайных чисел.
        /// </summary>
        private static readonly Random _random = new Random();

        /// <summary>
        /// Уникальный идентификатор прямоугольника.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Центр прямоугольника, представленный точкой Point2D.
        /// </summary>
        private readonly Point2D _center;

        /// <summary>
        /// Цвет прямоугольника.
        /// </summary>
        private string _color;

        /// <summary>
        /// Общее количество созданных объектов класса Rectangle.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Возвращает уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Возвращает и задаёт длину прямоугольника. Значение должно быть положительным.
        /// </summary>
        public double Length
        {
            get { return _length; }
            set
            {
                // Проверка на положительное значение
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт ширину прямоугольника. Значение должно быть положительным.
        /// </summary>
        public double Width
        {
            get { return _width; }
            set
            {
                // Проверка на положительное значение
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает центр прямоугольника в виде объекта Point2D.
        /// </summary>
        public Point2D Center => _center;

        /// <summary>
        /// Возвращает и задаёт цвет прямоугольника.
        /// </summary>
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        ///<summary> 
        /// Возвращает общее количество созданных объектов класса Rectangle.
        /// </summary>
        public static int AllRectanglesCount()
        {
            return _allRectanglesCount;
        }

        ///<summary> 
        /// Конструктор с параметрами для создания нового экземпляра Rectangle.
        /// </summary>
        ///<param name="length">Длина прямоугольника. Должна быть положительной.</param>
        ///<param name="width">Ширина прямоугольника. Должна быть положительной.</param>
        ///<param name="color">Цвет прямоугольника.</param> 
        public Rectangle(double length, double width, string color)
        {
            // Установка уникального ID на основе текущего количества объектов
            _id = _allRectanglesCount;

            // Инициализация свойств с проверками
            Length = length;
            Width = width;

            // Создание центра в случайных координатах в диапазоне [20, 350) для X и [20, 380) для Y
            _center = new Point2D(_random.Next(20, 350), _random.Next(20, 380));

            // Установка цвета
            Color = color;

            // Увеличение счетчика созданных объектов
            _allRectanglesCount++;
        }

        ///<summary>Конструктор без параметров.</ summary >
        public Rectangle() { }
    }
}
