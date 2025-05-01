using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    // Класс Песня
    public class Song
    {
        // Строковое поле Название
        private string _title;
        // Строковое поле Исполнитель
        private string _artist;
        // Вещественное поле Продолжительность
        private double _duration;
        // Строковое поле Жанр
        private string _genre;

        // Свойство для доступа к названию
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        // Свойство для доступа к исполнителю
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        // Свойство для доступа к продолжительности
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

        // Свойство для доступа к жанру
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        // Конструктор с параметрами
        public Song(string title, string artist, double duration, string genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
        }

        // Конструктор без параметров
        public Song() { }
    }
}
