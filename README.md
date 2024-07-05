# Treningi Personalne

## Opis

Ta aplikacja to system do zarządzania treningami personalnymi, który umożliwia rejestrację i logowanie klientów, zarządzanie trenerami oraz harmonogramowanie treningów. Została ona napisana w języku C# i wykorzystuje WPF do interfejsu użytkownika.

## Funkcje

- Rejestracja i logowanie klientów.
- Logowanie menedżerów.
- Dodawanie i usuwanie trenerów.
- Dodawanie, przeglądanie i usuwanie treningów.

## Instalacja

1. Sklonuj repozytorium lub pobierz pliki źródłowe.
2. Otwórz projekt w Visual Studio.
3. Zbuduj projekt, wybierając opcję `Build` > `Build Solution`.
4. Uruchom aplikację, wybierając opcję `Debug` > `Start Debugging`.

## Pliki bazy danych

Aplikacja korzysta z trzech plików tekstowych do przechowywania danych:

- `klienci.txt` - zawiera dane klientów.
- `trenerzy.txt` - zawiera dane trenerów.
- `treningi.txt` - zawiera dane treningów.

## Struktura Projektu

### Główne klasy

#### MainWindow.xaml.cs

Główne okno aplikacji, zawierające przyciski do logowania menedżerów, rejestracji klientów, logowania klientów oraz zamykania aplikacji.

![Zrzut ekranu 2024-07-05 185053](https://github.com/krox159/Treningi_Personalne/assets/148622295/4102b03d-92be-4a37-8ff7-689f83c0d2a9)

#### BazaDanych.cs

Klasa przechowująca listy klientów, trenerów oraz treningów. Zawiera metody do dodawania, usuwania i aktualizowania danych. Pola dla hermetycznych klientów i trenerów.

#### Globals.cs

Klasa statyczna zawierająca globalne zmienne i metody do operacji na bazie danych, takie jak wczytywanie danych z plików oraz aktualizowanie plików po zmianach.

#### Uzytkownik.cs

Klasa bazowa dla Klientów i Trenerów, zawierająca wspólne właściwości takie jak Id, Imię, Nazwisko i Hasło.

### Klient i Menedżer

#### Klient.cs

Klasa reprezentująca klienta, dziedzicząca po klasie Uzytkownik.

#### Manager.cs

Klasa reprezentująca menedżera, dziedzicząca po klasie Uzytkownik.

### Trener i Trening

#### Trener.cs

Klasa reprezentująca trenera, dziedzicząca po klasie Uzytkownik.

#### Trening.cs

Klasa reprezentująca trening, dziedzicząca po klasie DataICzas. Zawiera dodatkowe właściwości takie jak Id, KlientId, TrenerId, KlientImieNazwisko oraz TrenerImieNazwisko.

#### TrenerPoliHerm.cs

Hermetyzacja pól trenera.

####  UzytkownikPoliHerm.cs

Hermetyzacja pól użytkownika.

####  KlientPoliHerm.cs

Hermetyzacja pól klienta.

####  ShowTrainings.xaml.cs

Polimorfizm. Pokaż treningi - dla klienta tylko jego, dla managera wszystkie.



## Używanie aplikacji

### Logowanie menedżera

1. Kliknij przycisk "Logowanie menedżera".

![Zrzut ekranu 2024-07-05 185434](https://github.com/krox159/Treningi_Personalne/assets/148622295/5501fc07-f059-4682-86a6-417c585a1338)
  
3. Wprowadź hasło menedżera (domyślne hasło to "123").
4. Po zalogowaniu menedżer może zarządzać trenerami, przeglądać i usuwać treningi.

### Rejestracja klienta

1. Kliknij przycisk "Rejestracja klienta".
2. Wprowadź wymagane dane: Nazwa użytkownika, Imię, Nazwisko, Hasło.
3. Po naciśnięciu klawisza Enter klient zostanie zarejestrowany.

### Logowanie klienta

1. Kliknij przycisk "Logowanie klienta".
2. Wprowadź nazwę użytkownika oraz hasło.
3. Po zalogowaniu klient może przeglądać, rejestrować oraz usuwać swoje treningi.

### Dodawanie trenera

1. Menedżer musi być zalogowany.
2. Kliknij przycisk "Dodaj trenera".
3. Wprowadź imię i nazwisko trenera.
4. Po naciśnięciu klawisza Enter trener zostanie dodany.

### Przeglądanie i usuwanie trenerów

1. Menedżer musi być zalogowany.
2. Kliknij przycisk "Pokaż trenerów" aby przeglądać listę trenerów.
3. Kliknij przycisk "Usuń trenera" aby usunąć wybranego trenera.

### Przeglądanie i usuwanie treningów

1. Menedżer musi być zalogowany lub klient musi być zalogowany.
2. Kliknij przycisk "Pokaż treningi" aby przeglądać listę treningów.
3. Kliknij przycisk "Usuń trening" aby usunąć wybrany trening.

## Uwagi

- Upewnij się, że pliki `klienci.txt`, `trenerzy.txt` oraz `treningi.txt` znajdują się w tym samym katalogu co plik wykonywalny aplikacji.
- Domyślne hasło menedżera to "123". Można je zmienić w kodzie źródłowym klasy Manager.

---

## Autorzy
- Marta Maroń
- Wojciech Całka
