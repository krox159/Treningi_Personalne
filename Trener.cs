using System;

namespace TreningiPersonalne
{
    public class Trener
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public Trener(int id, string imie, string nazwisko)
        {
            Id = id;
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public override string ToString()
        {
            return $"{Id}: {Imie} {Nazwisko}";
        }
    }
}