using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TreningiPersonalne
{
    public class BazaDanych
    {
        public List<Klient> Klienci { get; } = new List<Klient>();
        public List<Trener> Trenerzy { get; } = new List<Trener>();
        public List<Trening> Treningi { get; } = new List<Trening>();

        public void DodajKlienta(Klient klient)
        {
            Klienci.Add(klient);
        }

        public void DodajTrenera(Trener trener)
        {
            Trenerzy.Add(trener);
        }

        public void DodajTrening(Trening trening)
        {
            Treningi.Add(trening);
        }

        public void UsunTrenera(int id)
        {
            Trenerzy.RemoveAll(t => t.Id == id);
        }

        public void UsunTrening(int id)
        {
            Treningi.RemoveAll(t => t.Id == id);
        }
    }
}
