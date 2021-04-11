using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikMVC.Models
{
    public class Uczen
    {
        public int UczenId { get; set; }
        public int KlasaId { get; set; }
        public int KontoId { get; set; }
        //public virtual Klasa Klasa { get; set; }
        //public virtual Konto Konto { get; set; }
        public virtual ICollection<Ocena> Oceny {get;set;}
        public virtual ICollection<Obecnosc> Obecnosci { get; set; }
    }
}
