using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikMVC.Models
{
    public class Nauczyciel
    {
        public int NauczycielId { get; set; }
        public int KontoId { get; set; }
        //public virtual Konto Konto { get; set; }
        //public virtual Klasa Klasa { get; set; }
        public virtual ICollection<Nauczanie> Nauczania { get; set; }
        public virtual ICollection<Ocena> Oceny { get; set; }
        public virtual ICollection<Wydarzenie> Wydarzenia { get; set; }
    }
}
