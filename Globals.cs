using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreningiPersonalne
{
    public static class Globals
    {
        public static BazaDanych bazaDanych;
        public static int klientIdCounter = 0;
        public static int trenerIdCounter = 0;
        public static int treningIdCounter = 0;

        //Operacje DB
        public static void WczytajBazeDanychKlientow()
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

        public static void WczytajBazeDanychTrenerow()
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

        public static void WczytajBazeDanychTreningi()
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

        public static void ZnajdzNajwyzszeIdTrenera()
        {
            int? maxDBId = null;
            if (bazaDanych.Trenerzy.AsEnumerable().Any())
                maxDBId = bazaDanych.Trenerzy.AsEnumerable().Max(t => t.Id);
            if (maxDBId != null)
            {
                trenerIdCounter = (int)maxDBId;
            }
        }

        public static void ZnajdzNajwyzszeIdKlienta()
        {
            int? maxDBId = null;
            if (bazaDanych.Klienci.AsEnumerable().Any())
                maxDBId = bazaDanych.Klienci.AsEnumerable().Max(t => t.Id);
            if (maxDBId != null)
            {
                klientIdCounter = (int)maxDBId;
            }
        }

        public static void ZnajdzNajwyzszeIdTreningu()
        {
            int? maxDBId = null;
            if (bazaDanych.Treningi.AsEnumerable().Any())
                maxDBId = bazaDanych.Treningi.AsEnumerable().Max(t => t.Id);
            if (maxDBId != null)
            {
                treningIdCounter = (int)maxDBId;
            }
        }
        public static void UsunTrenera(int trainerindex)
        {

            Globals.bazaDanych.UsunTrenera(trainerindex);
            AktualizujBazeTrenerow();

        }

        private static void AktualizujBazeTrenerow()
        {
            File.WriteAllText("trenerzy.txt", string.Empty);
            foreach (var trener in Globals.bazaDanych.Trenerzy)
            {
                using (StreamWriter writetext = File.AppendText("trenerzy.txt"))
                {
                    writetext.WriteLine(trener);
                }
            }

        }

        public static void AnulujTreningMenedzer(int trainingindex)
        {

            Globals.bazaDanych.UsunTrening(trainingindex);
                AktualizujBazeTreningow();
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

        public static void WczytajBazeDanych() {
            Globals.WczytajBazeDanychKlientow();
            Globals.WczytajBazeDanychTrenerow();
            Globals.WczytajBazeDanychTreningi();
            Globals.ZnajdzNajwyzszeIdKlienta();
            Globals.ZnajdzNajwyzszeIdTrenera();
            Globals.ZnajdzNajwyzszeIdTreningu();
        }

    }
}
