using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikMVC.Models
{
    public class Konto
    {
        public int Id_konta { get; set; }
        public string login { get; set; }
        public string haslo { get; set; }

        public string email { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string adres { get; set; }
        public string pesel { get; set; }
        public int typ_uzytkownika { get; set; }
        public virtual Nauczyciel Nauczyciel { get; set; }
    }
}
