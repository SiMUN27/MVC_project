using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCProjektRWA.Models.MyModels
{
    public class KreditnaKartica
    {
        public int IDKreditnaKartica { get; set; }
        [Display(Name = "Tip kartice")]
        public string TipKartice { get; set; }
        [Display(Name = "Broj kartice")]
        public string BrojKartice { get; set; }
        [Display(Name = "Mjesec isteka")]
        public byte IstekMjesec { get; set; }
        [Display(Name = "Godina isteka")]
        public short IstekGodina { get; set; }
    }
}