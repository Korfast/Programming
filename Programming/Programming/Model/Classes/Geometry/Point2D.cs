using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    // Класс для представления точки в двумерном пространстве
    public class Point2D
    {
        // Вещественное поле координата x
        private readonly double _x;
        // Вещественное поле координата y
        private readonly double _y;

        // Свойство для доступа к координате X (только для чтения)
        public double X => _x;

        // Свойство для доступа к координате Y (только для чтения)
        public double Y => _y;

        // Конструктор класса, который принимает значения координат
        public Point2D(double x, double y)
        {
            // Валидация принемаемых значений
            if (x < 0) throw new ArgumentOutOfRangeException(nameof(x), "X coordinate must be non-negative.");
            if (y < 0) throw new ArgumentOutOfRangeException(nameof(y), "Y coordinate must be non-negative.");

            // Присваивание значений полям
            _x = x; 
            _y = y;
        }

        // Конструктор, который использует приватные сеттеры для валидации
        /*public Point2D(double x, double y)
        {
            XCoordinate = x; // Используем приватный сеттер для проверки
            YCoordinate = y; // Используем приватный сеттер для проверки
        }

        // Приватные сеттеры для валидации значений
        private double XCoordinate
        {
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(X), "X coordinate must be non-negative.");
                _x = value;
            }
        }

        private double YCoordinate
        {
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(Y), "Y coordinate must be non-negative.");
                _y = value;
            }
        }*/
    }
}
