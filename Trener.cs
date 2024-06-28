namespace TreningiPersonalne
{
    public class Trener : Uzytkownik
    {
        public Trener(int id, string imie, string nazwisko)
        {
            Id = id;
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public override string ToString()
        {
            return $"{Id},{Imie},{Nazwisko}";
        }
    }
}