using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProjektRWA.Models.MyModels
{
    public class Racun
    {
        public int IDRacun { get; set; }
        [Display(Name = "Datum izdavanja")]
        public DateTime DatumIzdavanja { get; set; }
        [Display(Name = "Broj računa")]
        public string BrojRacuna { get; set; }
        [Display(Name = "Komentar")]
        public string Komentar { get; set; }
        public Komercijalist Komercijalist { get; set; }
        public KreditnaKartica KreditnaKartica { get; set; }
    }
}