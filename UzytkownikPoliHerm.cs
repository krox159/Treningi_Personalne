using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreningiPersonalne
{
    public class UzytkownikPoliHerm
    {
        private int Id { get; set; }

        private string Imie { get; set; }
        private string Nazwisko { get; set; }
        private string Haslo { get; set; }


        public int PobierzId()
        { 
        
            return Id;
        }

        public void UstawId(int id) 
        {

            this.Id = Globals.klientIdCounter++;
                this.Id = id;
        }

        public string PobierzImie()
        {
            return Imie;
        }

        public void UstawImie(string imie)
        {
            this.Imie = imie;
        }

        public string PobierzNazwisko()
        {
            return Nazwisko;
        }
       public void UstawNazwisko(string nazwisko)
        {
            this.Nazwisko = nazwisko;
        }

        public string PobierzHaslo()
        {
            return Haslo;
        }

        public void UstawHaslo(string haslo)
        {
            if (haslo.Length > 6)
            {
                this.Haslo = haslo;

            }

            else this.Haslo = "domyslnehaslo";

        }
    }
}
