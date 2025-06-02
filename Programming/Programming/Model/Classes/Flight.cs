using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Класс, представляющий рейс самолета.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Поле для хранения пункта вылета.
        /// </summary>
        private string _departurePoint;

        /// <summary>
        /// Поле для хранения пункта назначения.
        /// </summary>
        private string _destinationPoint;

        /// <summary>
        /// Поле для хранения времени полета в минутах.
        /// </summary>
        private int _flightTimeInMinutes;

        /// <summary>
        /// Возвращает и задаёт пункт вылета.
        /// </summary>
        public string DeparturePoint
        {
            get { return _departurePoint; }
            set { _departurePoint = value; }
        }

        /// <summary>
        /// Возвращает и задаёт пункт назначения.
        /// </summary>
        public string DestinationPoint
        {
            get { return _destinationPoint; }
            set { _destinationPoint = value; }
        }

        /// <summary>
        /// Возвращает и задаёт время полёта в минутах. Проверяет, что значение положительно.
        /// </summary>
        public int FlightTimeInMinutes
        {
            get { return _flightTimeInMinutes; }
            set
            {
                // Используем метод из Validator для проверки положительности времени полёта
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeInMinutes));
                _flightTimeInMinutes = value;
            }
        }

        /// <summary>
        /// Конструктор с параметрами для инициализации всех свойств рейса.
        /// </summary>
        /// <param name="departurePoint">Пункт вылета.</param>
        /// <param name="destinationPoint">Пункт назначения.</param>
        /// <param name="flightTimeInMinutes">Время полёта в минутах.</param>
        public Flight(string departurePoint, string destinationPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeInMinutes = flightTimeInMinutes;
        }

        /// <summary>
        /// Конструктор без параметров. Создает объект с пустыми значениями.
        /// </summary>
        public Flight() { }
    }
}
