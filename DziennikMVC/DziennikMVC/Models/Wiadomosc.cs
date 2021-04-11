using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikMVC.Models
{
    public class Wiadomosc
    {
        public int WiadomoscId { get; set; }
        public string tytul { get; set; }
        public string tresc { get; set; }
        public DateTimeOffset data_wyslania { get; set; }
        public int czy_odczytana { get; set; }
        public string NadawcaId { get; set; }
        public string OdbiorcaId { get; set; }
        public virtual Konto Nadawca { get; set; }
        public virtual Konto Odbiorca { get; set; }
    }
}
