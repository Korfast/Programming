using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, представляющий товар.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Статическое поле-счётчик для генерации уникальных Id.
        /// </summary>
        private static int _counter = 0;

        /// <summary>
        /// Целочисленное поле для хранения id (только для чтения).
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Поле для хранения названия товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Поле для хранения информации о товаре.
        /// </summary>
        private string _info;

        /// <summary>
        /// Поле для хранения цены товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Поле для хранения категории товара.
        /// </summary>
        private Category _category;

        /// <summary>
        /// Возвращает id товара.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает и задаёт название товара.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт описание товара.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength
                    (value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт стоимость товара.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                ValueValidator.AssertValueInRange
                    (value, 0, 100000, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт категорию товара.
        /// </summary>
        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        /// Конструктор с параметрами класса Item
        /// Инициализирует все свойства.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Информация о товаре.</param>
        /// <param name="cost">Цена товара.</param>
        /// <param name="category">Категория товара</param>
        public Item(string name, string info, double cost, Category category)
        {
            // Генерация уникального Id с помощью статического счётчика
            _id = _counter++;
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        /// <summary>
        /// Конструктор класса Item без параметров.
        /// Создает объект с пустыми значениями.
        /// </summary>>
        public Item()
        {
            _id = _counter++;
        }

        /// <inheritdoc />
        public object Clone()
        {
            // При клонировании товара создаем новый объект с теми же данными.
            // Id у клона будет новый, так как вызывается конструктор.
            return new Item(this.Name, this.Info, this.Cost, this.Category);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Item other)) return false;
            return Equals(other);
        }

        /// <inheritdoc />
        public bool Equals(Item other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            // Товары равны, если равны их названия, цена и категория
            return Name == other.Name &&
                   Cost == other.Cost &&
                   Category == other.Category;
        }

        /// <inheritdoc />
        public int CompareTo(Item other)
        {
            if (other == null) return 1;
            // Сравнение по стоимости (пункт 5 ТЗ)
            return Cost.CompareTo(other.Cost);
        }
    }
}