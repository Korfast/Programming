using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    // Клас Кольцо
    internal class Ring
    {
        // Поле Центр типа Point2D
        private Point2D _center;
        // Поле Внешний радиус
        private double _outerRadius; 
        // Поле Внутренний радиус
        private double _innerRadius;

        // Свойство для доступа к центру кольца
        public Point2D Center
        {
            get { return _center; }
            set { _center = value; }
        }

        // Свойство для доступа к внешнему радиусу с валидацией
        public double OuterRadius
        {
            get { return _outerRadius; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(OuterRadius), "Outer radius must be a positive number.");
                if (value < InnerRadius)
                    throw new ArgumentException("Outer radius cannot be less than inner radius.");
                _outerRadius = value;
            }
        }

        // Свойство для доступа к внутреннему радиусу с валидацией
        public double InnerRadius
        {
            get { return _innerRadius; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(InnerRadius), "Inner radius must be a positive number.");
                if (value > OuterRadius)
                    throw new ArgumentException("Inner radius cannot be greater than outer radius.");
                _innerRadius = value;
            }
        }

        // Конструктор класса Ring
        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }

        // Свойство для вычисления площади кольца
        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(OuterRadius, 2) - Math.Pow(InnerRadius, 2));
            }
        }

        // Конструктор без параметров
        public Ring() { }
    }
}
