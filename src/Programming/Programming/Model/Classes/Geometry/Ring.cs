using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Класс, представляющий кольцо с внутренним и внешним радиусами и центром.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Поле для хранения центра кольца типа Point2D.
        /// </summary>
        private Point2D _center;

        /// <summary>
        /// Поле для хранения внешнего радиуса.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Поле для хранения внутреннего радиуса.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Возвращает и задаёт центр кольца.
        /// </summary>
        public Point2D Center
        {
            get { return _center; }
            set { _center = value; }
        }

        /// <summary>
        /// Возвращает и задаёт внешний радиус с валидацией.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт внутренний радиус с валидацией.
        /// </summary>
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

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(OuterRadius, 2) - Math.Pow(InnerRadius, 2));
            }
        }

        ///<summary> 
        /// Конструктор класса Ring с параметрами.
        /// </summary>
        ///<param name="center">Центр кольца типа Point2D.</param>
        ///<param name="outerRadius">Внешний радиус.</param>
        ///<param name="innerRadius">Внутренний радиус.</param> 
        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }

        ///<summary> 
        /// Конструктор без параметров. Инициализирует кольцо по умолчанию.
        /// </summary> 
        public Ring() { }
    }
}
