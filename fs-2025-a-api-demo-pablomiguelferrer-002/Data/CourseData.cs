using System.Text.Json;

namespace fs_2025_a_api_demo_pablomiguelferrer_002.Data
{
    public class CourseData
    {
        public List<Models.CourseModel> Courses { get; private set; } = new List<Models.CourseModel>();
        public CourseData()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            
            string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "courses.json");
            var jsonData = File.ReadAllText(filePath);
            Courses = JsonSerializer.Deserialize<List<Models.CourseModel>>(jsonData, options) ?? new List<Models.CourseModel>();
        }
    }
}
