# System Trening�w Personalnych

## Opis
Jest to aplikacja konsolowa napisana w j�zyku C# s�u��ca do zarz�dzania treningami personalnymi. Aplikacja pozwala mened�erom dodawa� i usuwa� trener�w, przegl�da� list� trener�w oraz trening�w, a tak�e anulowa� treningi. Klienci mog� rejestrowa� si�, logowa�, zapisywa� si� na treningi, odwo�ywa� je oraz przegl�da� swoje rezerwacje.

## Funkcje
### Mened�er
- Logowanie- has�o: 123
- Dodawanie trenera
- Usuwanie trenera
- Wy�wietlanie listy trener�w
- Wy�wietlanie listy trening�w
- Anulowanie treningu

### Klient
- Rejestracja
- Logowanie
- Zapisywanie si� na trening
- Odwo�ywanie treningu
- Wy�wietlanie swoich rezerwacji

## Struktura Projektu
- Program.cs - g��wny plik programu, zawiera logik� aplikacji.
- BazaDanych.cs - klasa zarz�dzaj�ca przechowywaniem danych o klientach, trenerach i treningach.
- Klient.cs - klasa reprezentuj�ca klienta.
- Trener.cs - klasa reprezentuj�ca trenera.
- Trening.cs - klasa reprezentuj�ca trening.

## Pliki Danych
- klienci.txt - plik przechowuj�cy dane klient�w.
- trenerzy.txt - plik przechowuj�cy dane trener�w.
- treningi.txt - plik przechowuj�cy dane trening�w.

## Instrukcje U�ytkowania
### Uruchomienie
1. Skompiluj program oraz uruchom aplikacj�.

### Logowanie jako Mened�er
1. Wybierz opcj� "Logowanie jako mened�er".
2. Wprowad� has�o.

### Dodawanie Trenera
1. Po zalogowaniu jako mened�er wybierz opcj� "Dodaj trenera".
2. Podaj imi� i nazwisko trenera.

### Usuwanie Trenera
1. Po zalogowaniu jako mened�er wybierz opcj� "Usu� trenera".
2. Podaj ID trenera do usuni�cia.

### Wy�wietlanie Listy Trener�w
1. Po zalogowaniu jako mened�er wybierz opcj� "Wy�wietl list� trener�w".

### Wy�wietlanie Listy Trening�w
1. Po zalogowaniu jako mened�er wybierz opcj� "Wy�wietl list� trening�w".

### Anulowanie Treningu
1. Po zalogowaniu jako mened�er wybierz opcj� "Anuluj trening".
2. Podaj ID treningu do anulowania.

### Rejestracja Klienta
1. Wybierz opcj� "Rejestracja klienta".
2. Podaj unikaln� nazw� u�ytkownika, imi�, nazwisko i has�o.

### Logowanie jako Klient
1. Wybierz opcj� "Logowanie jako klient".
2. Podaj nazw� u�ytkownika i has�o.

### Zapisywanie si� na Trening
1. Po zalogowaniu jako klient wybierz opcj� "Zapisz si� na trening".
2. Podaj ID trenera, dat�, godzin� i czas trwania treningu.

### Odwo�ywanie Treningu
1. Po zalogowaniu jako klient wybierz opcj� "Odwo�aj trening".
2. Podaj ID treningu do odwo�ania.

### Wy�wietlanie Rezerwacji
1. Po zalogowaniu jako klient wybierz opcj� "Wy�wietl swoje rezerwacje".

## Autorzy
- Wojciech Ca�ka
- Marta Maro�