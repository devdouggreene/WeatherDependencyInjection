using WeatherExerciseDependencyInjection.Interfaces;
using WeatherExerciseDependencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IWeatherLogic, WeatherLogic>();
builder.Services.AddSingleton<IDougsTest, DougsTest>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
