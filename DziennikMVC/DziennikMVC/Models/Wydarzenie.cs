using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikMVC.Models
{
    public class Wydarzenie
    {
        public int WydarzenieId { get; set; }
        public string nazwa { get; set; }
        public string opis { get; set; }
        public DateTimeOffset data { get; set; }
        public int KlasaId { get; set; }
        public int? NauczycielId { get; set; }
        public int PrzedmiotId { get; set; }
        //public virtual Klasa Klasa { get; set; }
        //public virtual Przedmiot Przedmiot { get; set; }

    }
}
