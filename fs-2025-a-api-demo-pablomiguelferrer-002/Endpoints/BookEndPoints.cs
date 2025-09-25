using fs_2025_a_api_demo_pablomiguelferrer_002.Data;

namespace fs_2025_a_api_demo_pablomiguelferrer_002
{
    public static class BookEndPoints
    {
        public static void AddBookEndPoint(this WebApplication app)
        {
            app.MapGet("/book", (BookData bookData) =>
            {
                return Results.Ok(bookData.Books);
            });

            app.MapGet("/book/{id:int}", (int id, BookData bookData) =>
            {
                var course = bookData.Books.FirstOrDefault(c => c.Id == id);
                return course is not null ? Results.Ok(course) : Results.NotFound();
            });
        }
    }
}
