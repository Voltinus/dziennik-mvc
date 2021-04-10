using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikMVC.Models
{
    public class Klasa
    {
        public int Id_klasy { get; set; }
        public string nazwa { get; set; }
        public int Id_wychowawcy { get; set; }
        public virtual Nauczyciel Nauczyciel { get; set; }
        public virtual ICollection<Uczen> Uczniowie { get; set; }
        public virtual ICollection<Lekcja> Lekcje { get; set; }
        public virtual ICollection<Wydarzenie> Wydarzenie { get; set; }
    }
}
