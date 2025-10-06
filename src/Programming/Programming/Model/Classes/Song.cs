using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Класс, представляющий песню.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Поле для хранения названия песни.
        /// </summary>
        private string _title;

        /// <summary>
        /// Поле для хранения исполнителя.
        /// </summary>
        private string _artist;

        /// <summary>
        /// Поле для хранения продолжительности песни в минутах.
        /// </summary>
        private double _duration;

        /// <summary>
        /// Поле для хранения жанра.
        /// </summary>
        private string _genre;

        /// <summary>
        /// Возвращает и задаёт название песни.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// Возвращает и задаёт исполнителя.
        /// </summary>
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        /// <summary>
        /// Возвращает и задаёт продолжительность песни в минутах. Проверяет, что значение положительно.
        /// </summary>
        public double Duration
        {
            get { return _duration; }
            set
            {
                // Используем метод из Validator для проверки положительности продолжительности
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт жанр песни.
        /// </summary>
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        /// <summary>
        /// Конструктор с параметрами для инициализации всех свойств.
        /// </summary>
        /// <param name="title">Название песни.</param>
        /// <param name="artist">Исполнитель.</param>
        /// <param name="duration">Продолжительность в минутах.</param>
        /// <param name="genre">Жанр.</param>
        public Song(string title, string artist, double duration, string genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
        }

        /// <summary>
        /// Конструктор без параметров. Создает объект с пустыми значениями.
        /// </summary>
        public Song() { }
    }
}
