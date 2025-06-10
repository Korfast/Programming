using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApp.Model
{
    /// <summary>
    /// Класс, представляющий фильм.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Поле для хранения названия фильма.
        /// </summary>
        private string _title;

        /// <summary>
        /// Поле для хранения продолжительности фильма в минутах.
        /// </summary>
        private int _durationInMinutes;

        /// <summary>
        /// Поле для хранения года выпуска.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Поле для хранения жанра.
        /// </summary>
        private string _genre;

        /// <summary>
        /// Поле для хранения рейтинга.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задаёт название фильма.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// Возвращает и задаёт продолжительность фильма в минутах. Значение должно быть в диапазоне от 1 до 300..
        /// </summary>
        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set
            {
                // Используем метод из Validator для проверки положительности продолжительности
                // В этом проекте максимальная продолжительность ограничена
                Validator.AssertValueInRange(value, 1, 300, nameof(DurationInMinutes));
                _durationInMinutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт год выпуска. Проверяет, что год в диапазоне от 1888 до текущего года.
        /// </summary>
        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                Validator.AssertValueInRange(value, 1888, DateTime.Now.Year, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт жанр фильма.
        /// </summary>
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        /// <summary>
        /// Возвращает и задаёт рейтинг фильма. Значение должно быть в диапазоне от 0 до 10.
        /// </summary>
        public double Rating
        {
            get { return _rating; }
            set
            {
                // Используем метод из Validator для проверки диапазона значения рейтинга
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Конструктор с параметрами для инициализации всех свойств.
        /// </summary>
        /// <param name="title">Название фильма.</param>
        /// <param name="durationInMinutes">Продолжительность в минутах.</param>
        /// <param name="releaseYear">Год выпуска.</param>
        /// <param name="genre">Жанр.</param>
        /// <param name="rating">Рейтинг.</param>
        public Movie(string title, int durationInMinutes, int releaseYear, string genre, double rating)
        {
            Title = title;
            DurationInMinutes = durationInMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Конструктор без параметров. Создает объект с пустыми значениями.
        /// </summary>
        public Movie() { }
    }
}
