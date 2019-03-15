using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProjektRWA.Models.MyModels
{
    public class Stavka
    {
        public int IDStavka { get; set; }
        [Display(Name = "Količina")]
        public short Kolicina { get; set; }
        [Display(Name = "Cijena po komadu")]
        public decimal CijenaPoKomadu { get; set; }
        [Display(Name = "Popust")]
        public decimal Popust { get; set; }
        [Display(Name = "Ukupna cijena")]
        public decimal UkupnaCijena { get; set; }
        public Proizvod Proizvod { get; set; }
        public Potkategorija Potkategorija { get; set; }
        public Kategorija Kategorija { get; set; }
    }
}