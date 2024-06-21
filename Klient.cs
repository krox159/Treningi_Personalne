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
        return $"ID: {Id}, Nazwa użytkownika: {NazwaUzytkownika}, Imię: {Imie}, Nazwisko: {Nazwisko}";
    }
}