namespace TreningiPersonalne
{
    public class Klient : Uzytkownik
    {
        public string NazwaUzytkownika { get; }


        public Klient(int id, string nazwaUzytkownika, string imie, string nazwisko, string haslo)
        {
            Id = id;
            NazwaUzytkownika = nazwaUzytkownika;
            Imie = imie;
            Nazwisko = nazwisko;
            Haslo = haslo;
        }

        public override string ToString()
        {
            return $"{Id},{NazwaUzytkownika},{Imie},{Nazwisko},{Haslo}";
        }
    }
}