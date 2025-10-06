using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Класс, представляющий время.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Поле для хранения часов.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Поле для хранения минут.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Поле для хранения секунд.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задаёт часы (от 0 до 23).
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт минуты (от 0 до 59).
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт секунды (от 0 до 59).
        /// </summary>
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

        /// <summary>
        /// Конструктор с параметрами для инициализации времени.
        /// </summary>
        /// <param name="hours">Часы (от 0 до 23).</param>
        /// <param name="minutes">Минуты (от 0 до 59).</param>
        /// <param name="seconds">Секунды (от 0 до 59).</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Конструктор без параметров. Создает объект со значениями по умолчанию.
        /// </summary>
        public Time() { }
    }
}
