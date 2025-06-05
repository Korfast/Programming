using MoviesApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesApp.View.Controls
{
    public partial class MoviesUserControl : UserControl
    {
        private List<Movie> _movies = new List<Movie>();
        private readonly string _dataFilePath = "movies.csv";

        public MoviesUserControl()
        {
            InitializeComponent();
            FillGenreComboBox();
            LoadData();
        }
        /*
        private void LoadData()
        {
            if (File.Exists(_dataFilePath))
            {
                var json = File.ReadAllText(_dataFilePath);
                _movies = JsonSerializer.Deserialize<List<Movie>>(json);
                SortAndDisplayMovies();
            }
        }

        private void SaveData()
        {
            var json = JsonSerializer.Serialize(_movies);
            File.WriteAllText(_dataFilePath, json);
        }
        */

        public void SaveData()
        {
            List<string> lines = new List<string>();
            foreach (Movie movie in _movies)
            {
                // Создаем строку вида: Title,ReleaseYear,Genre,Rating,DurationInMinutes
                string line = $"{EscapeCsv(movie.Title)},{movie.ReleaseYear},{EscapeCsv(movie.Genre)},{movie.Rating},{movie.DurationInMinutes}";
                lines.Add(line);
            }
            File.WriteAllLines(_dataFilePath, lines);
        }

        // Вспомогательный метод для экранирования запятых и кавычек
        private string EscapeCsv(string field)
        {
            if (field.Contains(",") || field.Contains("\""))
            {
                // Экранируем кавычки
                field = field.Replace("\"", "\"\"");
                // Оборачиваем в кавычки
                return $"\"{field}\"";
            }
            return field;
        }

        private void LoadData()
        {
            if (File.Exists(_dataFilePath))
            {
                string[] lines = File.ReadAllLines(_dataFilePath);
                _movies.Clear();
                foreach (string line in lines)
                {
                    string[] parts = ParseCsvLine(line);
                    if (parts.Length == 5)
                    {
                        Movie movie = new Movie
                        {
                            Title = parts[0],
                            ReleaseYear = int.TryParse(parts[1], out int year) ? year : 0,
                            Genre = parts[2],
                            Rating = double.TryParse(parts[3], out double rating) ? rating : 0.0,
                            DurationInMinutes = int.TryParse(parts[4], out int duration) ? duration : 0
                        };
                        _movies.Add(movie);
                    }
                }
                SortAndDisplayMovies();
            }
        }

        // Простая парсилка строки CSV с учетом кавычек
        private string[] ParseCsvLine(string line)
        {
            List<string> result = new List<string>();
            bool inQuotes = false;
            StringBuilder currentField = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '\"')
                {
                    if (inQuotes && i + 1 < line.Length && line[i + 1] == '\"')
                    {
                        // Экранированная кавычка внутри поля
                        currentField.Append('\"');
                        i++;
                    }
                    else
                    {
                        inQuotes = !inQuotes;
                    }
                }
                else if (c == ',' && !inQuotes)
                {
                    result.Add(currentField.ToString());
                    currentField.Clear();
                }
                else
                {
                    currentField.Append(c);
                }
            }

            // добавляем последний элемент
            result.Add(currentField.ToString());

            return result.ToArray();
        }

        // Заполняем ComboBox значениями enum
        private void FillGenreComboBox()
        {
            GenreComboBox.DataSource = Enum.GetValues(typeof(MoviesApp.Model.Enums.Genre));
        }


        private void SortAndDisplayMovies()
        {
            _movies = _movies.OrderBy(m => m.Title).ToList();
            MoviesListBox.Items.Clear();
            foreach (Movie movie in _movies)
            { 
                MoviesListBox.Items.Add(movie);
            }
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedItem is Movie selectedMovie)
            { 
                DisplayMovieDetails(selectedMovie); 
            }
        }

        private void DisplayMovieDetails(Movie movie)
        {
            TitleTextBox.Text = movie.Title;
            ReleaseYearTextBox.Text = movie.ReleaseYear.ToString();
            GenreComboBox.SelectedItem = movie.Genre;
            RatingTextBox.Text = movie.Rating.ToString();
            DurationInMinutesTextBox.Text = movie.DurationInMinutes.ToString();
        }

        private void SaveChanges()
        {
            if (MoviesListBox.SelectedItem is Movie selectedMovie)
            {
                if (!ValidateInputs(out string error))
                {
                    MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                selectedMovie.Title = TitleTextBox.Text.Trim();
                selectedMovie.ReleaseYear = int.Parse(ReleaseYearTextBox.Text);
                selectedMovie.Genre = GenreComboBox.SelectedItem.ToString();
                selectedMovie.Rating = double.Parse(RatingTextBox.Text);
                selectedMovie.DurationInMinutes = int.Parse(DurationInMinutesTextBox.Text);

                SortAndDisplayMovies();

                // Обновляем выбранный элемент
                MoviesListBox.SelectedItem = selectedMovie;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Movie newMovie = new Movie();

            if (!ValidateInputs(out string error))
            {
                MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            newMovie.Title = TitleTextBox.Text.Trim();
            newMovie.ReleaseYear = int.Parse(ReleaseYearTextBox.Text);
            newMovie.Genre = GenreComboBox.SelectedItem.ToString();
            newMovie.Rating = double.Parse(RatingTextBox.Text);
            newMovie.DurationInMinutes = int.Parse(DurationInMinutesTextBox.Text);

            _movies.Add(newMovie);
            SortAndDisplayMovies();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedItem is Movie selectedMovie)
            {
                _movies.Remove(selectedMovie);
                SortAndDisplayMovies();

                // Очистка деталей
                ClearDetails();
            }
        }

        private void ClearDetails()
        {
            TitleTextBox.Clear();
            ReleaseYearTextBox.Clear();
            GenreComboBox.SelectedIndex = -1;
            RatingTextBox.Clear();
            DurationInMinutesTextBox.Clear();
        }

        private bool ValidateInputs(out string errorMessage)
        {
            errorMessage = "";
            bool isValid = true;

            // Название
            if (string.IsNullOrWhiteSpace(TitleTextBox.Text) || TitleTextBox.Text.Length > 100)
            {
                isValid = false;
                HighlightControl(TitleTextBox);
                errorMessage += "Некорректное название.\n";
            }
            else ResetHighlight(TitleTextBox);

            // Год выпуска
            if (!int.TryParse(ReleaseYearTextBox.Text, out int year) || year <= 0)
            {
                isValid = false;
                HighlightControl(ReleaseYearTextBox);
                errorMessage += "Некорректный год.\n";
            }
            else ResetHighlight(ReleaseYearTextBox);

            // Жанр - выбран ли?
            if (GenreComboBox.SelectedIndex == -1)
            {
                isValid = false;
                HighlightControl(GenreComboBox);
                errorMessage += "Выберите жанр.\n";
            }
            else ResetHighlight(GenreComboBox);

            // Рейтинг
            if (!double.TryParse(RatingTextBox.Text, out double rating) || rating < 0 || rating > 10)
            {
                isValid = false;
                HighlightControl(RatingTextBox);
                errorMessage += "Некорректный рейтинг.\n";
            }
            else ResetHighlight(RatingTextBox);

            // Продолжительность
            if (!int.TryParse(DurationInMinutesTextBox.Text, out int duration) || duration < 1 || duration > 300)
            {
                isValid = false;
                HighlightControl(DurationInMinutesTextBox);
                errorMessage += "Некорректная продолжительность.\n";
            }
            else ResetHighlight(DurationInMinutesTextBox);

            return isValid;
        }

        private void HighlightControl(Control control)
        {
            control.BackColor = Color.LightPink;
            control.Focus(); // Можно добавить подсказку через ToolTip
        }

        private void ResetHighlight(Control control)
        {
            control.BackColor = SystemColors.Window;
        }
    }
}
