using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCProjektRWA.Models.MyModels
{
    public class Potkategorija
    {
        public int IDPotkategorija { get; set; }
        [Display(Name = "Naziv potkategorije")]
        public string Naziv { get; set; }
    }
}