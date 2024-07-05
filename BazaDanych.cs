using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreningiPersonalne
{
    public class BazaDanych
    {
        //nie herm
        public List<Klient> Klienci { get; } = new List<Klient>();
        public List<Trener> Trenerzy { get; } = new List<Trener>();
        public List<Trening> Treningi { get; } = new List<Trening>();


        //herm
        private List<KlientPoliHerm> KlienciHerm { get; } = new List<KlientPoliHerm>();
        private List<TrenerPoliHerm> TrenerzyHerm { get; } = new List<TrenerPoliHerm>();

        //private List<Trening> TreningiHerm { get; } = new List<Trening>();

        //nie herm
        public void DodajKlienta(Klient klient)
        {
            if (!Klienci.AsEnumerable().Any(k => k.Id == klient.Id))
                Klienci.Add(klient);
        }

        public void DodajTrenera(Trener trener)
        {
            if (!Trenerzy.AsEnumerable().Any(k => k.Id == trener.Id))
                Trenerzy.Add(trener);
        }

        public void DodajTrening(Trening trening)
        {
            if (!Treningi.AsEnumerable().Any(k => k.Id == trening.Id))
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

        //herm

        public void DodajKlienta(KlientPoliHerm klient)
        {
            if (!Klienci.AsEnumerable().Any(k => k.Id == klient.PobierzId()))
                KlienciHerm.Add(klient);
        }

        public void DodajTrenera(TrenerPoliHerm trener)
        {
            if (!Trenerzy.AsEnumerable().Any(k => k.Id == trener.PobierzId()))
                TrenerzyHerm.Add(trener);
        }

        public List<KlientPoliHerm> PobierzKlientow()
        {
            return this.KlienciHerm;
        }


        public List<TrenerPoliHerm> PobierzTrenerow()
        {
            return this.TrenerzyHerm;
        }
    }
}
