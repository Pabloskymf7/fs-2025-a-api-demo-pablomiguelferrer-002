using fs_2025_a_api_demo_pablomiguelferrer_002;
using fs_2025_a_api_demo_pablomiguelferrer_002.Endpoints;
using fs_2025_a_api_demo_pablomiguelferrer_002.Startup;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.AddDependencies();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
app.AddWeatherEndPoint();
app.AddBookEndPoint();
app.AddRootEndPoint();
app.AddCourseEndPoint();


internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
