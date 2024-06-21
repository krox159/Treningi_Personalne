using System;

namespace TreningiPersonalne
{
    public class Trening
    {
        public int Id { get; set; }
        public int KlientId { get; set; }
        public int TrenerId { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan CzasTrwania { get; set; }

        public Trening(int id, int klientId, int trenerId, DateTime data, TimeSpan czasTrwania)
        {
            Id = id;
            KlientId = klientId;
            TrenerId = trenerId;
            Data = data;
            CzasTrwania = czasTrwania;
        }

        public override string ToString()
        {
            return $"{Id}: Klient {KlientId}, Trener {TrenerId}, Data: {Data}, Czas trwania: {CzasTrwania}";
        }
    }
}
