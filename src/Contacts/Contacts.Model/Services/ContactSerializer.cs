using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Contacts.Model.Services
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
        /// Полный путь к файлу, используемому для сохранения и загрузки.
        /// </summary>
        public string FilePath
        {
            get { return _filePath; }
        }

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
        /// Сохраняет список контактов в файл.
        /// </summary>
        /// <param name="contacts">Список контактов для сохранения.</param>
        public void SaveAll(List<Contact> contacts)
        {
            try
            {
                // Создаём директорию, если она не существует
                string directory = Path.GetDirectoryName(_filePath);
                Directory.CreateDirectory(directory);

                string json = JsonConvert.SerializeObject(contacts, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Не удалось сохранить список контактов.", ex);
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
                throw new InvalidOperationException("Не удалось загрузить контакт.", ex);
            }
        }

        /// <summary>
        /// Загружает список контактов из файла.
        /// </summary>
        /// <returns>Список контактов, загруженных из файла. Если файл отсутствует или повреждён, возвращает пустой список.</returns>
        public List<Contact> LoadAll()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    return new List<Contact>();
                }

                string json = File.ReadAllText(_filePath);
                List<Contact> contacts = JsonConvert.DeserializeObject<List<Contact>>(json);
                return contacts ?? new List<Contact>();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Не удалось загрузить список контактов.", ex);
            }
        }
    }
}
