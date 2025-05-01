using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    // Класс Рейс
    public class Flight
    {
        // Строковое поле Пункт Вылета
        private string _departurePoint;
        // Строковое поле Пункт назначения
        private string _destinationPoint;
        // Целочисленное поле Время полета в минутах
        private int _flightTimeInMinutes;

        // Свойство для доступа к пункту вылета
        public string DeparturePoint
        {
            get { return _departurePoint; }
            set { _departurePoint = value; }
        }

        // Свойство для доступа к пункту назначения
        public string DestinationPoint
        {
            get { return _destinationPoint; }
            set { _destinationPoint = value; }
        }

        // Свойство для доступа к времени полёта
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

        // Конструктор с параметрами
        public Flight(string departurePoint, string destinationPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeInMinutes = flightTimeInMinutes;
        }

        // Конструктор без параметров
        public Flight() { }
    }
}
