using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreningiPersonalne
{
    public class TrenerPoliHerm : UzytkownikPoliHerm
    {
        public TrenerPoliHerm(int id, string imie, string nazwisko)
        {
            this.UstawId(id);
            this.UstawImie(imie);
            this.UstawNazwisko(nazwisko);
        }

        public override string ToString()
        {
            return $"{this.PobierzId()},{this.PobierzImie()},{this.PobierzNazwisko()}";
        }
    }
}

