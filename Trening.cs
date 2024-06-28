using System;

namespace TreningiPersonalne
{
    public class Trening : DataICzas
    {
        public int Id { get; set; }
        public int KlientId { get; set; }
        public int TrenerId { get; set; }
        public string KlientImieNazwisko { get; set; }
        public string TrenerImieNazwisko { get; set; }

        public Trening(int id, int klientId, int trenerId, DateTime dataGodzina, TimeSpan czasTrwania, string klientImieNazwisko, string trenerImieNazwisko)
        {
           
            Id = id;
            KlientId = klientId;
            TrenerId = trenerId;
            DataGodzina = dataGodzina;
            CzasTrwania = czasTrwania;
            KlientImieNazwisko = klientImieNazwisko;
            TrenerImieNazwisko = trenerImieNazwisko;
        }

        public override string ToString()
        {
            return $"{Id},{KlientId},{TrenerId},{DataGodzina},{CzasTrwania},{KlientImieNazwisko},{TrenerImieNazwisko}";
        }
    }
}