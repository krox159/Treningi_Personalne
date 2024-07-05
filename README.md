# Treningi Personalne

## Opis

Ta aplikacja to system do zarz�dzania treningami personalnymi, kt�ry umo�liwia rejestracj� i logowanie klient�w, zarz�dzanie trenerami oraz harmonogramowanie trening�w. Zosta�a ona napisana w j�zyku C# i wykorzystuje WPF do interfejsu u�ytkownika.

## Funkcje

- Rejestracja i logowanie klient�w.
- Logowanie mened�er�w.
- Dodawanie i usuwanie trener�w.
- Dodawanie, przegl�danie i usuwanie trening�w.

## Instalacja

1. Sklonuj repozytorium lub pobierz pliki �r�d�owe.
2. Otw�rz projekt w Visual Studio.
3. Zbuduj projekt, wybieraj�c opcj� `Build` > `Build Solution`.
4. Uruchom aplikacj�, wybieraj�c opcj� `Debug` > `Start Debugging`.

## Pliki bazy danych

Aplikacja korzysta z trzech plik�w tekstowych do przechowywania danych:

- `klienci.txt` - zawiera dane klient�w.
- `trenerzy.txt` - zawiera dane trener�w.
- `treningi.txt` - zawiera dane trening�w.

## Struktura Projektu

### G��wne klasy

#### MainWindow.xaml.cs

G��wne okno aplikacji, zawieraj�ce przyciski do logowania mened�er�w, rejestracji klient�w, logowania klient�w oraz zamykania aplikacji.

#### BazaDanych.cs

Klasa przechowuj�ca listy klient�w, trener�w oraz trening�w. Zawiera metody do dodawania, usuwania i aktualizowania danych. Pola dla hermetycznych klient�w i trener�w.

#### Globals.cs

Klasa statyczna zawieraj�ca globalne zmienne i metody do operacji na bazie danych, takie jak wczytywanie danych z plik�w oraz aktualizowanie plik�w po zmianach.

#### Uzytkownik.cs

Klasa bazowa dla Klient�w i Trener�w, zawieraj�ca wsp�lne w�a�ciwo�ci takie jak Id, Imi�, Nazwisko i Has�o.

### Klient i Mened�er

#### Klient.cs

Klasa reprezentuj�ca klienta, dziedzicz�ca po klasie Uzytkownik.

#### Manager.cs

Klasa reprezentuj�ca mened�era, dziedzicz�ca po klasie Uzytkownik.

### Trener i Trening

#### Trener.cs

Klasa reprezentuj�ca trenera, dziedzicz�ca po klasie Uzytkownik.

#### Trening.cs

Klasa reprezentuj�ca trening, dziedzicz�ca po klasie DataICzas. Zawiera dodatkowe w�a�ciwo�ci takie jak Id, KlientId, TrenerId, KlientImieNazwisko oraz TrenerImieNazwisko.

#### TrenerPoliHerm.cs

Hermetyzacja p�l trenera.

####  UzytkownikPoliHerm.cs

Hermetyzacja p�l u�ytkownika.

####  KlientPoliHerm.cs

Hermetyzacja p�l klienta.

####  ShowTrainings.xaml.cs

Polimorfizm. Poka� treningi - dla klienta tylko jego, dla managera wszystkie.



## U�ywanie aplikacji

### Logowanie mened�era

1. Kliknij przycisk "Logowanie mened�era".
2. Wprowad� has�o mened�era (domy�lne has�o to "123").
3. Po zalogowaniu mened�er mo�e zarz�dza� trenerami, przegl�da� i usuwa� treningi.

### Rejestracja klienta

1. Kliknij przycisk "Rejestracja klienta".
2. Wprowad� wymagane dane: Nazwa u�ytkownika, Imi�, Nazwisko, Has�o.
3. Po naci�ni�ciu klawisza Enter klient zostanie zarejestrowany.

### Logowanie klienta

1. Kliknij przycisk "Logowanie klienta".
2. Wprowad� nazw� u�ytkownika oraz has�o.
3. Po zalogowaniu klient mo�e przegl�da�, rejestrowa� oraz usuwa� swoje treningi.

### Dodawanie trenera

1. Mened�er musi by� zalogowany.
2. Kliknij przycisk "Dodaj trenera".
3. Wprowad� imi� i nazwisko trenera.
4. Po naci�ni�ciu klawisza Enter trener zostanie dodany.

### Przegl�danie i usuwanie trener�w

1. Mened�er musi by� zalogowany.
2. Kliknij przycisk "Poka� trener�w" aby przegl�da� list� trener�w.
3. Kliknij przycisk "Usu� trenera" aby usun�� wybranego trenera.

### Przegl�danie i usuwanie trening�w

1. Mened�er musi by� zalogowany lub klient musi by� zalogowany.
2. Kliknij przycisk "Poka� treningi" aby przegl�da� list� trening�w.
3. Kliknij przycisk "Usu� trening" aby usun�� wybrany trening.

## Uwagi

- Upewnij si�, �e pliki `klienci.txt`, `trenerzy.txt` oraz `treningi.txt` znajduj� si� w tym samym katalogu co plik wykonywalny aplikacji.
- Domy�lne has�o mened�era to "123". Mo�na je zmieni� w kodzie �r�d�owym klasy Manager.

---

## Autorzy
- Marta Maro�
- Wojciech Ca�ka