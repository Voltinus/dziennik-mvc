using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikMVC.Models
{
    public class Przedmiot
    {
        public int PrzedmiotId { get; set; }
        public string nazwa { get; set; }
        public string dziedzina { get; set; }
        public virtual ICollection<Nauczanie> Nauczania { get; set; }
        public virtual ICollection<Ocena> Oceny { get; set; }
        public virtual ICollection<Wydarzenie> Wydarzenia { get; set; }
    }
}
