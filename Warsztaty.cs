using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreningiPersonalne
{
    public class Warsztaty : DataICzas
    {
        public string TrenerImieNazwisko { get; set; }
        public Warsztaty(string daneTrenera, DateTime data, TimeSpan czas)
        {
            this.DataGodzina = data;
            this.CzasTrwania = czas;
            this.TrenerImieNazwisko = daneTrenera;
        }

    }
}
