using fs_2025_a_api_demo_pablomiguelferrer_002.Data; 
namespace fs_2025_a_api_demo_pablomiguelferrer_002
{
    public static class CourseEndPoints
    {
        public static void AddCourseEndPoint(this WebApplication app)
        {
            app.MapGet("/courses", (CourseData courseData) =>
            {
                return Results.Ok(courseData.Courses);
            });

            app.MapGet("/courses/{id:int}", (int id, CourseData courseData) =>
            {
                var course = courseData.Courses.FirstOrDefault(c => c.Id == id);
                return course is not null ? Results.Ok(course) : Results.NotFound();
            });
        }
    }
}
