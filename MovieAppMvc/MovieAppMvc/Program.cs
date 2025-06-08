using Microsoft.EntityFrameworkCore;
using MovieAppMvc.Models;

var builder = WebApplication.CreateBuilder(args);

// Dodaj us�ugi do kontenera
builder.Services.AddControllersWithViews();

// Dodaj DbContext z SQLite
builder.Services.AddDbContext<MovieContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MovieContext")));

var app = builder.Build();

// Skonfiguruj potok ��da� HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // produkcyjne ustawienie bezpiecze�stwa
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Domy�lna trasa
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
