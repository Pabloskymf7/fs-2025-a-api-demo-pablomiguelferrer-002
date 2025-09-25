using System.Text.Json;

namespace fs_2025_a_api_demo_pablomiguelferrer_002.Data
{
    public class BookData
    {
        public List<Models.Book> Books { get; private set; } = new List<Models.Book>();
        public BookData()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "bookdata.json");
            var jsonData = File.ReadAllText(filePath);
            Books = JsonSerializer.Deserialize<List<Models.Book>>(jsonData, options) ?? new List<Models.Book>();
        }
    }
}
