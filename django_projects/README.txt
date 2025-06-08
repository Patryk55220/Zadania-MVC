

Opis:
-----
To jest prosty projekt bloga stworzony w Django. Umożliwia przeglądanie oraz dodawanie postów.

Funkcje:
--------
✔ Wyświetlanie wszystkich postów na stronie głównej
✔ Dodawanie nowych postów przez formularz
✔ Dane zapisywane są w bazie SQLite
✔ Panel administracyjny Django do zarządzania postami

Wymagania:
----------
- Python 3.10+
- Django 5.x

Uruchomienie projektu:
-----------------------
1. Stwórz wirtualne środowisko (opcjonalnie):
   python -m venv env
   env\Scripts\activate

2. Zainstaluj Django:
   pip install django

3. W terminalu uruchom:
   python manage.py makemigrations
   python manage.py migrate
   python manage.py runserver

4. Otwórz w przeglądarce:
   http://127.0.0.1:8000/        ← strona główna bloga
   http://127.0.0.1:8000/admin/  ← panel administratora

Twórca:
Patryk Malimon 55220
