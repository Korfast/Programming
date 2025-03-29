using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    // Класс Дисциплина
    public class Discipline
    {
        // Строковое поле Название
        private string _name;
        // Целочисленное поле Кредиты
        private int _credits;
        // Строковое поле Преподаватель
        private string _instructor;
        // Строковое поле Семестр
        private string _semester;

        // Свойство для доступа к названию
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Свойство для доступа к кредитам
        public int Credits
        {
            get { return _credits; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Количество кредитов не может быть отрицательным.");
                _credits = value;
            }
        }

        // Свойство для доступа к преподавателю
        public string Instructor
        {
            get { return _instructor; }
            set { _instructor = value; }
        }

        // Свойство для доступа к семестру
        public string Semester
        {
            get { return _semester; }
            set { _semester = value; }
        }

        // Конструктор с параметрами
        public Discipline(string name, int credits, string instructor, string semester)
        {
            Name = name;
            Credits = credits;
            Instructor = instructor;
            Semester = semester;
        }

        // Конструктор без параметров
        public Discipline() { }
    }
}
