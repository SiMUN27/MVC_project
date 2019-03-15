using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCProjektRWA.Models.MyModels
{
    public class Kategorija
    {
        public int IDKategorija { get; set; }
        [Display(Name="Naziv kategorije")]
        public string Naziv { get; set; }
    }
}