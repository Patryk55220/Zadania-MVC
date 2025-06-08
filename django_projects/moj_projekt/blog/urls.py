from django.urls import path
from . import views

urlpatterns = [
    path('', views.home, name='home'),          # <- to działa
    path('add/', views.add_post, name='add_post'),  # <- TO JEST KLUCZ
]
