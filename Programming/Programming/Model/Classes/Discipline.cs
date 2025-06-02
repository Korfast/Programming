using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Класс, представляющий учебную дисциплину.
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Поле для хранения названия дисциплины.
        /// </summary>
        private string _name;

        /// <summary>
        /// Поле для хранения количества кредитов.
        /// </summary>
        private int _credits;

        /// <summary>
        /// Поле для хранения имени преподавателя.
        /// </summary>
        private string _instructor;

        /// <summary>
        /// Поле для хранения семестра.
        /// </summary>
        private string _semester;

        /// <summary>
        /// Возвращает и задаёт название дисциплины.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Возвращает и задаёт количество кредитов. Проверяет, что значение положительно.
        /// </summary>
        public int Credits
        {
            get { return _credits; }
            set
            {
                // Используем метод из Validator для проверки положительности кредитов.
                Validator.AssertOnPositiveValue(value, nameof(Credits));
                _credits = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя преподавателя.
        /// </summary>
        public string Instructor
        {
            get { return _instructor; }
            set { _instructor = value; }
        }

        /// <summary>
        /// Возвращает и задаёт семестр.
        /// </summary>
        public string Semester
        {
            get { return _semester; }
            set { _semester = value; }
        }

        /// <summary>
        /// Конструктор с параметрами для инициализации всех свойств.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="credits">Количество кредитов.</param>
        /// <param name="instructor">Имя преподавателя.</param>
        /// <param name="semester">Семестр.</param>
        public Discipline(string name, int credits, string instructor, string semester)
        {
            Name = name;
            Credits = credits;
            Instructor = instructor;
            Semester = semester;
        }

        /// <summary>
        /// Конструктор без параметров. Создает объект с пустыми значениями.
        /// </summary>
        public Discipline() { }
    }
}
