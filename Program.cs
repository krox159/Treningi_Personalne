using System;
using System.Collections.Specialized;
using System.Reflection;


namespace TreningiPersonalne
{
    class Program
    {
        private static BazaDanych bazaDanych;
        private static int klientIdCounter = 0;
        private static int trenerIdCounter = 0;
        private static int treningIdCounter = 0;
        private const string MenedzerHaslo = "123";

        static void Main(string[] args)
        {
            bazaDanych = new BazaDanych();
            while (true)
            {
                WczytajBazeDanychKlientow();
                WczytajBazeDanychTrenerow();
                WczytajBazeDanychTreningi();

                ZnajdzNajwyzszeIdKlienta();
                ZnajdzNajwyzszeIdTrenera();
                ZnajdzNajwyzszeIdTreningu();

                Console.Clear();
                Console.WriteLine("Witaj w systemie treningów personalnych!");
                Console.WriteLine("1. Logowanie jako menedżer");
                Console.WriteLine("2. Rejestracja klienta");
                Console.WriteLine("3. Logowanie jako klient");
                Console.WriteLine("4. Wyjście");

                var wybor = Console.ReadLine();
                Console.Clear();
                switch (wybor)
                {
                    case "1":
                        LogowanieMenedzera();
                        break;
                    case "2":
                        RejestracjaKlienta();
                        break;
                    case "3":
                        LogowanieKlienta();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                        break;
                }
            }
        }

        private static void LogowanieMenedzera()
        {
            Console.Write("Podaj hasło: ");
            var haslo = Console.ReadLine();
            Console.Clear();
            if (haslo == MenedzerHaslo)
            {
                PanelMenedzera();
            }
            else
            {
                Console.WriteLine("Nieprawidłowe hasło.");
            }
        }

        private static void PanelMenedzera()
        {
            while (true)
            {
                Console.WriteLine("Panel menedżera:");
                Console.WriteLine("1. Dodaj trenera");
                Console.WriteLine("2. Usuń trenera");
                Console.WriteLine("3. Wyświetl listę trenerów");
                Console.WriteLine("4. Wyświetl listę treningów");
                Console.WriteLine("5. Anuluj trening");
                Console.WriteLine("6. Wyloguj");

                var wybor = Console.ReadLine();
                Console.Clear();
                switch (wybor)
                {
                    case "1":
                        DodajTrenera();
                        break;
                    case "2":
                        UsunTrenera();
                        break;
                    case "3":
                        WyswietlListeTrenerow();
                        break;
                    case "4":
                        WyswietlListeTreningow();
                        break;
                    case "5":
                        AnulujTreningMenedzer();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                        break;
                }
            }
        }

        private static void DodajTrenera()
        {
            Console.Write("Podaj imię trenera: ");
            var imie = Console.ReadLine();
            Console.Write("Podaj nazwisko trenera: ");
            var nazwisko = Console.ReadLine();

            trenerIdCounter++;
            var trener = new Trener(trenerIdCounter, imie, nazwisko);
            bazaDanych.DodajTrenera(trener);
            using (StreamWriter writetext = File.AppendText("trenerzy.txt"))
            {
                writetext.WriteLine(trener);
            }
            Console.Clear();
            Console.WriteLine("Dodano trenera.");
        }

        private static void UsunTrenera()
        {
            WyswietlListeTrenerow();
            Console.Write("Podaj ID trenera do usunięcia: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                bazaDanych.UsunTrenera(id);
                AktualizujBazeTrenerow();
                Console.Clear();
                Console.WriteLine("Usunięto trenera.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowe ID.");
            }
        }

        private static void WyswietlListeTrenerow()
        {
            Console.WriteLine("Lista trenerów:");
            foreach (var trener in bazaDanych.Trenerzy)
            {
                Console.WriteLine(trener);
            }
        }

        private static void WyswietlListeTreningow()
        {
            Console.WriteLine("Lista treningów:");
            foreach (var trening in bazaDanych.Treningi)
            {
                Console.WriteLine(trening);
            }
        }

        private static void AnulujTreningMenedzer()
        {
            WyswietlListeTreningow();
            Console.Write("Podaj ID treningu do anulowania: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                bazaDanych.UsunTrening(id);
                AktualizujBazeTreningow();
                Console.Clear();
                Console.WriteLine("Anulowano trening.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowe ID.");
            }
        }

        private static void RejestracjaKlienta()
        {
            Console.Write("Podaj unikalną nazwę użytkownika: ");
            var nazwaUzytkownika = Console.ReadLine();

            if (bazaDanych.Klienci.Exists(k => k.NazwaUzytkownika == nazwaUzytkownika))
            {
                Console.WriteLine("Nazwa użytkownika już istnieje. Spróbuj ponownie.");
                return;
            }

            Console.Write("Podaj imię: ");
            var imie = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            var nazwisko = Console.ReadLine();
            Console.Write("Podaj hasło: ");
            var haslo = Console.ReadLine();

            klientIdCounter++;
            var klient = new Klient(klientIdCounter, nazwaUzytkownika, imie, nazwisko, haslo);
            bazaDanych.DodajKlienta(klient);
            using (StreamWriter writetext = File.AppendText("klienci.txt"))
            {
                writetext.WriteLine(klient);
            }
            Console.Clear();
            Console.WriteLine("Zarejestrowano klienta.");
        }

        private static void LogowanieKlienta()
        {
            Console.Write("Podaj nazwę użytkownika: ");
            var nazwaUzytkownika = Console.ReadLine();

            var klient = bazaDanych.Klienci.Find(k => k.NazwaUzytkownika == nazwaUzytkownika);
            if (klient != null)
            {
                Console.Write("Podaj hasło: ");
                var haslo = Console.ReadLine();
                Console.Clear();
                if (klient.Haslo == haslo)
                {
                    PanelKlienta(klient);
                }
                else
                {
                    Console.WriteLine("Nieprawidłowe hasło.");
                }
            }
            else
            {
                Console.WriteLine("Nie znaleziono klienta o podanej nazwie użytkownika.");
            }
        }

        private static void PanelKlienta(Klient klient)
        {
            while (true)
            {
                Console.WriteLine($"Panel klienta: {klient.Imie} {klient.Nazwisko}");
                Console.WriteLine("1. Zapisz się na trening");
                Console.WriteLine("2. Odwołaj trening");
                Console.WriteLine("3. Wyświetl swoje rezerwacje");
                Console.WriteLine("4. Wyloguj");

                var wybor = Console.ReadLine();
                Console.Clear();
                switch (wybor)
                {
                    case "1":
                        ZapiszNaTrening(klient);
                        break;
                    case "2":
                        OdwolajTrening(klient);
                        break;
                    case "3":
                        WyswietlRezerwacjeKlienta(klient);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                        break;
                }
            }
        }

        private static void ZapiszNaTrening(Klient klient)
        {
            WyswietlListeTrenerow();
            Console.Write("Podaj ID trenera: ");
            if (int.TryParse(Console.ReadLine(), out int trenerId) && bazaDanych.Trenerzy.Exists(t => t.Id == trenerId))
            {
                var trener = bazaDanych.Trenerzy.Find(t => t.Id == trenerId);
                Console.Write("Podaj datę (yyyy-mm-dd): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime data))
                {
                    Console.Write("Podaj godzinę (hh:mm): ");
                    if (TimeSpan.TryParse(Console.ReadLine(), out TimeSpan godzina))
                    {
                        Console.Write("Podaj czas trwania (hh:mm): ");
                        if (TimeSpan.TryParse(Console.ReadLine(), out TimeSpan czasTrwania))
                        {
                            treningIdCounter++;
                            var trening = new Trening(treningIdCounter, klient.Id, trenerId, data + godzina, czasTrwania, $"{klient.Imie} {klient.Nazwisko}", $"{trener.Imie} {trener.Nazwisko}");
                            bazaDanych.DodajTrening(trening);
                            using (StreamWriter writetext = File.AppendText("treningi.txt"))
                            {
                                writetext.WriteLine(trening);
                            }
                            Console.Clear();
                            Console.WriteLine("Zarezerwowano trening.");
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowy czas trwania.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowa godzina.");
                    }
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa data.");
                }
            }
            else
            {
                Console.WriteLine("Nie znaleziono trenera o podanym ID.");
            }
        }


        private static void OdwolajTrening(Klient klient)
        {
            WyswietlRezerwacjeKlienta(klient);
            Console.Write("Podaj ID treningu do odwołania: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var trening = bazaDanych.Treningi.Find(t => t.Id == id && t.KlientId == klient.Id);
                if (trening != null)
                {
                    bazaDanych.UsunTrening(id);
                    AktualizujBazeTreningow();
                    Console.Clear();
                    Console.WriteLine("Odwołano trening.");
                }
                else
                {
                    Console.WriteLine("Nie znaleziono treningu o podanym ID.");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowe ID.");
            }
        }

        private static void WyswietlRezerwacjeKlienta(Klient klient)
        {
            Console.WriteLine("Twoje rezerwacje:");
            foreach (var trening in bazaDanych.Treningi)
            {
                if (trening.KlientId == klient.Id)
                {
                    Console.WriteLine(trening);
                }

            }
        }
        private static void WczytajBazeDanychKlientow()
        {
            using (StreamReader readtext = new StreamReader("klienci.txt"))
            {
                string readText = readtext.ReadToEnd();
                var modelStrings = readText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string s in modelStrings)
                {
                    var props = s.Split(',');
                    if (!String.IsNullOrEmpty(s))
                    {
                        Klient klient = new Klient(Convert.ToInt32(props[0]), props[1], props[2], props[3], props[4]);
                        bazaDanych.DodajKlienta(klient);
                    }
                }
            }
        }

        private static void WczytajBazeDanychTrenerow()
        {
            using (StreamReader readtext = new StreamReader("trenerzy.txt"))
            {
                string readText = readtext.ReadToEnd();
                var modelStrings = readText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string s in modelStrings)
                {
                    var props = s.Split(',');
                    if (!String.IsNullOrEmpty(s))
                    {
                        Trener trener = new Trener(Convert.ToInt32(props[0]), props[1], props[2]);
                        bazaDanych.DodajTrenera(trener);
                    }
                }
            }
        }

        private static void WczytajBazeDanychTreningi()
        {
            using (StreamReader readtext = new StreamReader("treningi.txt"))
            {
                string readText = readtext.ReadToEnd();
                var modelStrings = readText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string s in modelStrings)
                {
                    var props = s.Split(',');
                    if (!String.IsNullOrEmpty(s))
                    {
                        int id = Convert.ToInt32(props[0]);
                        int klientId = Convert.ToInt32(props[1]);
                        int trenerId = Convert.ToInt32(props[2]);
                        DateTime dataGodzina = Convert.ToDateTime(props[3]);
                        TimeSpan czasTrwania = TimeSpan.Parse(props[4]);
                        string klientImieNazwisko = props[5];
                        string trenerImieNazwisko = props[6];

                        Trening trening = new Trening(id, klientId, trenerId, dataGodzina, czasTrwania, klientImieNazwisko, trenerImieNazwisko);
                        bazaDanych.DodajTrening(trening);
                    }
                }
            }
        }


        private static void ZnajdzNajwyzszeIdTrenera()
        {
            int? maxDBId = null;
            if (bazaDanych.Trenerzy.AsEnumerable().Any())
                maxDBId = bazaDanych.Trenerzy.AsEnumerable().Max(t => t.Id);
            if (maxDBId != null)
            {
                trenerIdCounter = (int)maxDBId;
            }
        }

        private static void ZnajdzNajwyzszeIdKlienta()
        {
            int? maxDBId = null;
            if (bazaDanych.Klienci.AsEnumerable().Any())
                maxDBId = bazaDanych.Klienci.AsEnumerable().Max(t => t.Id);
            if (maxDBId != null)
            {
                klientIdCounter = (int)maxDBId;
            }
        }

        private static void ZnajdzNajwyzszeIdTreningu()
        {
            int? maxDBId = null;
            if (bazaDanych.Treningi.AsEnumerable().Any())
                maxDBId = bazaDanych.Treningi.AsEnumerable().Max(t => t.Id);
            if (maxDBId != null)
            {
                treningIdCounter = (int)maxDBId;
            }
        }

        private static void AktualizujBazeTrenerow()
        {
            File.WriteAllText("trenerzy.txt", string.Empty);
            foreach (var trener in bazaDanych.Trenerzy)
            {
                using (StreamWriter writetext = File.AppendText("trenerzy.txt"))
                {
                    writetext.WriteLine(trener);
                }
            }

        }

        private static void AktualizujBazeTreningow()
        {
            File.WriteAllText("treningi.txt", string.Empty);
            foreach (var trening in bazaDanych.Treningi)
            {
                using (StreamWriter writetext = File.AppendText("treningi.txt"))
                {
                    writetext.WriteLine(trening);
                }
            }

        }
    }
}

