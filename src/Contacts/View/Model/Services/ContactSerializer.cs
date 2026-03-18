using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace View.Model.Services
{
    /// <summary>
    /// Предоставляет методы для сериализации 
    /// и десериализации контакта в JSON-файл.
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// Полный путь к файлу, 
        /// используемому для сохранения и загрузки контакта.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Инициализирует новый экземпляр ContactSerializer с путём по умолчанию.
        /// Путь по умолчанию: "Мои документы\Contacts\contacts.json".
        /// </summary>
        public ContactSerializer()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directory = Path.Combine(documentsPath, "Contacts");
            _filePath = Path.Combine(directory, "contacts.json");
        }

        /// <summary>
        /// Полный путь к файлу, используемому для сохранения и загрузки.
        /// </summary>
        public string FilePath
        {
            get { return _filePath; }
        }

        /// <summary>
        /// Сохраняет переданный контакт в файл.
        /// </summary>
        /// <param name="contact">Контакт для сохранения.</param>
        public void Save(Contact contact)
        {
            try
            {
                // Создаём директорию, если она не существует
                string directory = Path.GetDirectoryName(_filePath);
                Directory.CreateDirectory(directory);

                string json = JsonConvert.SerializeObject(contact, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                // Выбрасывает исключение
                throw new InvalidOperationException("Не удалось сохранить контакт.", ex);
            }
        }

        /// <summary>
        /// Загружает контакт из файла.
        /// </summary>
        /// <returns>Загруженный контакт или новый пустой контакт, если файл отсутствует.</returns>
        public Contact Load()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    return new Contact();
                }

                string json = File.ReadAllText(_filePath);
                Contact contact = JsonConvert.DeserializeObject<Contact>(json);
                if (contact != null)
                {
                    return contact;
                }
                else
                {
                    return new Contact();
                }
            }
            catch (Exception ex)
            {
                // Аналогично обрабатываем ошибку
                throw new InvalidOperationException("Не удалось загрузить контакт.", ex);
            }
        }
    }
}
