using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TreningiPersonalne
{
    public class KlientPoliHerm : UzytkownikPoliHerm
    {
        public string NazwaUzytkownika { get; }


        public KlientPoliHerm(int id, string nazwaUzytkownika, string imie, string nazwisko, string haslo)
        {
            this.UstawId(id);
            NazwaUzytkownika = nazwaUzytkownika;
            this.UstawImie(imie);
            this.UstawNazwisko(nazwisko);
            this.UstawHaslo(haslo);
        }

        public override string ToString()
        {
            return $"{this.PobierzId()},{NazwaUzytkownika},{this.PobierzImie()},{this.PobierzNazwisko()},{this.PobierzHaslo()}";
        }
    }
}
