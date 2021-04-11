using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikMVC.Models
{
    public class Ocena
    {
        public int OcenaId { get; set; }
        public string ocena { get; set; }
        public string opis_oceny { get; set; }
        public int czy_koncowa { get; set; }
        public DateTimeOffset data { get; set; }
        public int UczenId { get; set; }
        public int NauczycielId { get; set; }
        public int PrzedmiotId { get; set; }
        //public virtual Uczen Uczen { get; set; }
        //public virtual Nauczyciel Nauczyciel { get; set; }
        //public virtual Przedmiot Przedmiot { get; set; }
    }
}
