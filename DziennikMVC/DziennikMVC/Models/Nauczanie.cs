using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikMVC.Models
{
    public class Nauczanie
    {
        public int NauczanieId { get; set; }
        public int PrzedmiotId { get; set; }
        public int NauczycielId { get; set; }
        //public virtual Przedmiot Przedmiot { get; set; }
        //public virtual Nauczyciel Nauczyciel { get; set; }
        public virtual ICollection<Lekcja> Lekcje { get; set; }
    }
}
