using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    // Класс Фильм
    public class Movie
    {
        // Строковое поле Название
        private string _title;
        // Целочисленное поле Продолжительность в минутах
        private int _durationInMinutes;
        // Целочисленное поле Год выпуска
        private int _releaseYear;
        // Строковое поле Жанр
        private string _genre;
        // Вещественное поле Рейтинг
        private double _rating;

        // Свойство для доступа к названию
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        // Свойство для доступа к продолжительности
        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set
            {
                // Используем метод из Validator для проверки положительности продолжительности времени в минутах
                Validator.AssertOnPositiveValue(value, nameof(DurationInMinutes));
                _durationInMinutes = value;
            }
        }

        // Свойство для доступа к году выпуска
        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                // В задании сказано от 1900 года, но первый фильм вышел в 1888 году
                if (value < 1888 || value > DateTime.Now.Year)
                    throw new ArgumentException("Год выпуска должен быть от 1888 до текущего года.");
                _releaseYear = value;
            }
        }

        // Свойство для доступа к жанру
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        // Свойство для доступа к рейтингу
        public double Rating
        {
            get { return _rating; }
            set
            {
                // Используем метод из Validator для проверки 
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }

        // Конструктор с параметрами
        public Movie(string title, int durationInMinutes, int releaseYear, string genre, double rating)
        {
            Title = title;
            DurationInMinutes = durationInMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        // Конструктор без параметров
        public Movie() { }
    }
}
