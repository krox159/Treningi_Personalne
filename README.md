# Treningi Personalne

## Opis

Ta aplikacja to system do zarz¹dzania treningami personalnymi, który umo¿liwia rejestracjê i logowanie klientów, zarz¹dzanie trenerami oraz harmonogramowanie treningów. Zosta³a ona napisana w jêzyku C# i wykorzystuje WPF do interfejsu u¿ytkownika.

## Funkcje

- Rejestracja i logowanie klientów.
- Logowanie mened¿erów.
- Dodawanie i usuwanie trenerów.
- Dodawanie, przegl¹danie i usuwanie treningów.

## Instalacja

1. Sklonuj repozytorium lub pobierz pliki Ÿród³owe.
2. Otwórz projekt w Visual Studio.
3. Zbuduj projekt, wybieraj¹c opcjê `Build` > `Build Solution`.
4. Uruchom aplikacjê, wybieraj¹c opcjê `Debug` > `Start Debugging`.

## Pliki bazy danych

Aplikacja korzysta z trzech plików tekstowych do przechowywania danych:

- `klienci.txt` - zawiera dane klientów.
- `trenerzy.txt` - zawiera dane trenerów.
- `treningi.txt` - zawiera dane treningów.

## Struktura Projektu

### G³ówne klasy

#### MainWindow.xaml.cs

G³ówne okno aplikacji, zawieraj¹ce przyciski do logowania mened¿erów, rejestracji klientów, logowania klientów oraz zamykania aplikacji.

#### BazaDanych.cs

Klasa przechowuj¹ca listy klientów, trenerów oraz treningów. Zawiera metody do dodawania, usuwania i aktualizowania danych. Pola dla hermetycznych klientów i trenerów.

#### Globals.cs

Klasa statyczna zawieraj¹ca globalne zmienne i metody do operacji na bazie danych, takie jak wczytywanie danych z plików oraz aktualizowanie plików po zmianach.

#### Uzytkownik.cs

Klasa bazowa dla Klientów i Trenerów, zawieraj¹ca wspólne w³aœciwoœci takie jak Id, Imiê, Nazwisko i Has³o.

### Klient i Mened¿er

#### Klient.cs

Klasa reprezentuj¹ca klienta, dziedzicz¹ca po klasie Uzytkownik.

#### Manager.cs

Klasa reprezentuj¹ca mened¿era, dziedzicz¹ca po klasie Uzytkownik.

### Trener i Trening

#### Trener.cs

Klasa reprezentuj¹ca trenera, dziedzicz¹ca po klasie Uzytkownik.

#### Trening.cs

Klasa reprezentuj¹ca trening, dziedzicz¹ca po klasie DataICzas. Zawiera dodatkowe w³aœciwoœci takie jak Id, KlientId, TrenerId, KlientImieNazwisko oraz TrenerImieNazwisko.

#### TrenerPoliHerm.cs

Hermetyzacja pól trenera.

####  UzytkownikPoliHerm.cs

Hermetyzacja pól u¿ytkownika.

####  KlientPoliHerm.cs

Hermetyzacja pól klienta.

####  ShowTrainings.xaml.cs

Polimorfizm. Poka¿ treningi - dla klienta tylko jego, dla managera wszystkie.



## U¿ywanie aplikacji

### Logowanie mened¿era

1. Kliknij przycisk "Logowanie mened¿era".
2. WprowadŸ has³o mened¿era (domyœlne has³o to "123").
3. Po zalogowaniu mened¿er mo¿e zarz¹dzaæ trenerami, przegl¹daæ i usuwaæ treningi.

### Rejestracja klienta

1. Kliknij przycisk "Rejestracja klienta".
2. WprowadŸ wymagane dane: Nazwa u¿ytkownika, Imiê, Nazwisko, Has³o.
3. Po naciœniêciu klawisza Enter klient zostanie zarejestrowany.

### Logowanie klienta

1. Kliknij przycisk "Logowanie klienta".
2. WprowadŸ nazwê u¿ytkownika oraz has³o.
3. Po zalogowaniu klient mo¿e przegl¹daæ, rejestrowaæ oraz usuwaæ swoje treningi.

### Dodawanie trenera

1. Mened¿er musi byæ zalogowany.
2. Kliknij przycisk "Dodaj trenera".
3. WprowadŸ imiê i nazwisko trenera.
4. Po naciœniêciu klawisza Enter trener zostanie dodany.

### Przegl¹danie i usuwanie trenerów

1. Mened¿er musi byæ zalogowany.
2. Kliknij przycisk "Poka¿ trenerów" aby przegl¹daæ listê trenerów.
3. Kliknij przycisk "Usuñ trenera" aby usun¹æ wybranego trenera.

### Przegl¹danie i usuwanie treningów

1. Mened¿er musi byæ zalogowany lub klient musi byæ zalogowany.
2. Kliknij przycisk "Poka¿ treningi" aby przegl¹daæ listê treningów.
3. Kliknij przycisk "Usuñ trening" aby usun¹æ wybrany trening.

## Uwagi

- Upewnij siê, ¿e pliki `klienci.txt`, `trenerzy.txt` oraz `treningi.txt` znajduj¹ siê w tym samym katalogu co plik wykonywalny aplikacji.
- Domyœlne has³o mened¿era to "123". Mo¿na je zmieniæ w kodzie Ÿród³owym klasy Manager.

---

## Autorzy
- Marta Maroñ
- Wojciech Ca³ka