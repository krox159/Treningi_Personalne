# System Treningów Personalnych

## Opis
Jest to aplikacja konsolowa napisana w jêzyku C# s³u¿¹ca do zarz¹dzania treningami personalnymi. Aplikacja pozwala mened¿erom dodawaæ i usuwaæ trenerów, przegl¹daæ listê trenerów oraz treningów, a tak¿e anulowaæ treningi. Klienci mog¹ rejestrowaæ siê, logowaæ, zapisywaæ siê na treningi, odwo³ywaæ je oraz przegl¹daæ swoje rezerwacje.

## Funkcje
### Mened¿er
- Logowanie- has³o: 123
- Dodawanie trenera
- Usuwanie trenera
- Wyœwietlanie listy trenerów
- Wyœwietlanie listy treningów
- Anulowanie treningu

### Klient
- Rejestracja
- Logowanie
- Zapisywanie siê na trening
- Odwo³ywanie treningu
- Wyœwietlanie swoich rezerwacji

## Struktura Projektu
- Program.cs - g³ówny plik programu, zawiera logikê aplikacji.
- BazaDanych.cs - klasa zarz¹dzaj¹ca przechowywaniem danych o klientach, trenerach i treningach.
- Klient.cs - klasa reprezentuj¹ca klienta.
- Trener.cs - klasa reprezentuj¹ca trenera.
- Trening.cs - klasa reprezentuj¹ca trening.

## Pliki Danych
- klienci.txt - plik przechowuj¹cy dane klientów.
- trenerzy.txt - plik przechowuj¹cy dane trenerów.
- treningi.txt - plik przechowuj¹cy dane treningów.

## Instrukcje U¿ytkowania
### Uruchomienie
1. Skompiluj program oraz uruchom aplikacjê.

### Logowanie jako Mened¿er
1. Wybierz opcjê "Logowanie jako mened¿er".
2. WprowadŸ has³o.

### Dodawanie Trenera
1. Po zalogowaniu jako mened¿er wybierz opcjê "Dodaj trenera".
2. Podaj imiê i nazwisko trenera.

### Usuwanie Trenera
1. Po zalogowaniu jako mened¿er wybierz opcjê "Usuñ trenera".
2. Podaj ID trenera do usuniêcia.

### Wyœwietlanie Listy Trenerów
1. Po zalogowaniu jako mened¿er wybierz opcjê "Wyœwietl listê trenerów".

### Wyœwietlanie Listy Treningów
1. Po zalogowaniu jako mened¿er wybierz opcjê "Wyœwietl listê treningów".

### Anulowanie Treningu
1. Po zalogowaniu jako mened¿er wybierz opcjê "Anuluj trening".
2. Podaj ID treningu do anulowania.

### Rejestracja Klienta
1. Wybierz opcjê "Rejestracja klienta".
2. Podaj unikaln¹ nazwê u¿ytkownika, imiê, nazwisko i has³o.

### Logowanie jako Klient
1. Wybierz opcjê "Logowanie jako klient".
2. Podaj nazwê u¿ytkownika i has³o.

### Zapisywanie siê na Trening
1. Po zalogowaniu jako klient wybierz opcjê "Zapisz siê na trening".
2. Podaj ID trenera, datê, godzinê i czas trwania treningu.

### Odwo³ywanie Treningu
1. Po zalogowaniu jako klient wybierz opcjê "Odwo³aj trening".
2. Podaj ID treningu do odwo³ania.

### Wyœwietlanie Rezerwacji
1. Po zalogowaniu jako klient wybierz opcjê "Wyœwietl swoje rezerwacje".

## Autorzy
- Wojciech Ca³ka
- Marta Maroñ