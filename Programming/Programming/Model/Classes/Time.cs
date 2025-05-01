using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    // Класс Время
    public class Time
    {
        // Целочисленное поле Часы
        private int _hours;
        // Целочисленное поле Минуты
        private int _minutes;
        // Целочисленное поле Секунды
        private int _seconds;

        // Свойство для доступа к часам
        public int Hours
        {
            get { return _hours; }
            set
            {
                if (value < 0 || value > 23)
                    throw new ArgumentException("Часы должны быть от 0 до 23.");
                _hours = value;
            }
        }

        // Свойство для доступа к минутам
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentException("Минуты должны быть от 0 до 59.");
                _minutes = value;
            }
        }

        // Свойство для доступа к секундам
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentException("Секунды должны быть от 0 до 59.");
                _seconds = value;
            }
        }

        // Конструктор с параметрами
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        // Конструктор без параметров
        public Time() { }
    }
}
