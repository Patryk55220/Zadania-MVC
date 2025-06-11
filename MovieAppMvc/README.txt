MovieAppMvc

Aplikacja internetowa napisana w ASP.NET Core MVC, pozwalająca na przeglądanie, dodawanie i zarządzanie filmami.

##  Funkcjonalności

-  Wyświetlanie listy filmów
-  Dodawanie nowych filmów do bazy danych
-  Szczegóły filmu
-  Obsługa bazy danych SQLite
-  Prosty interfejs graficzny (Razor Views)

## 🛠️ Technologie

- ASP.NET Core MVC (.NET 9)
- Entity Framework Core
- SQLite
- Visual Studio 2022

##  Jak uruchomić projekt

1. Otwórz projekt w Visual Studio
2. W konsoli **Package Manager Console** lub terminalu uruchom:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   dotnet run
