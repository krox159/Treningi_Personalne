public class Klient
{
    public int Id { get; }
    public string NazwaUzytkownika { get; }
    public string Imie { get; }
    public string Nazwisko { get; }
    public string Haslo { get; }

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