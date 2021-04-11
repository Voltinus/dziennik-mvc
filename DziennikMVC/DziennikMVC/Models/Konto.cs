using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikMVC.Models
{
    public class Konto:IdentityUser
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string adres { get; set; }
        public string pesel { get; set; }
        //public int NauczycielId { get; set; }
        //public int UczenId { get; set; }
        public virtual Nauczyciel Nauczyciel { get; set; }
        public virtual Uczen Uczen { get; set; }
        
        public virtual ICollection<Wiadomosc> Wiadomosci_odebrane { get; set; }
        public virtual ICollection<Wiadomosc> Wiadomosci_wyslane { get; set; }
    }
}
