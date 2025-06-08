using Microsoft.EntityFrameworkCore;
using MovieAppMvc.Models;

var builder = WebApplication.CreateBuilder(args);

// Dodaj us³ugi do kontenera
builder.Services.AddControllersWithViews();

// Dodaj DbContext z SQLite
builder.Services.AddDbContext<MovieContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MovieContext")));

var app = builder.Build();

// Skonfiguruj potok ¿¹dañ HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // produkcyjne ustawienie bezpieczeñstwa
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Domyœlna trasa
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
