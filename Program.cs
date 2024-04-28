using System;
using System.Collections.Generic;

namespace TreningPersonalny
{
    class Trener
    {
        public string Imie { get; set; }
        public string Specjalizacja { get; set; }

        public Trener(string imie, string specjalizacja)
        {
            Imie = imie;
            Specjalizacja = specjalizacja;
        }
    }

    class Trening
    {
        public DateTime Data {  get; set; }
        public Trener Trener { get; set; }

        public Trening (DateTime data, Trener trener)
        {
            Data = data;
            Trener = trener;
        }
    }
    class Program
    {
        static List<Trening> listaTreningow=new List<Trening> ();

        public static void WyswietlTrenerow()
        {
            Console.WriteLine("Nasi trenerzy:");
            Console.WriteLine("1) Andrzej Popiełuszko - trening siłowy");
            Console.WriteLine("2) Gienia Nowak - trenining funkcjonalny");
            Console.WriteLine("3) Marcin Pośpiech - stretching");
        }

        public static void ZapiszNaTrening(DateTime data, Trener trener)
        {
            listaTreningow.Add(new Trening(data, trener));
            Console.WriteLine("Zapisano na trening z trenerem " + trener.Imie + " na " + data.ToShortDateString());
        }

        static void Main(string[] args)
        {
            bool zakoncz = false;

            while (!zakoncz)
            {
                
                Console.WriteLine("TWÓJ TRENING PERSONALNY!");
                Console.WriteLine("Wybierz opcję:");
                Console.WriteLine("1. Poznaj naszych trenerów.");
                Console.WriteLine("2. Zapisz się na trening.");
                Console.WriteLine("3. Wyjdź z aplikacji.");

                string opcja = Console.ReadLine();
                switch (opcja)
                {
                    case "1": WyswietlTrenerow(); break;
                    case "2":
                         Console.WriteLine("Podaj datę treningu (RRRR-MM-DD):");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime dataTreningu))
                        {
                            Console.WriteLine("Wybierz trenera (wskaż numer):");
                            WyswietlTrenerow();
                            int numerTrenera=int.Parse(Console.ReadLine());
                            Trener trener=null;
                            switch (numerTrenera)
                            {
                                case 1: trener = new Trener("Andrzej Popiełuszko", "Trening siłowy"); break;
                                case 2: trener = new Trener("Gienia Nowak", "Trenining funkcjonalny"); break;
                                case 3: trener = new Trener("Marcin Pośpiech", "Stretching"); break;
                                default:
                                    Console.WriteLine("Nieprawidłowy numer trenera.");
                                    break;
                            }
                            if (trener != null)
                                ZapiszNaTrening(dataTreningu, trener);
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowy format daty.");
                        }
                        break;
                    case "3":
                        zakoncz = true;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja.");
                        break;
                }
            }
        }
    }
}