using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCProjektRWA.Models.MyModels
{
    public class Kupac
    {
        public int IDKupac { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "{0} mora imati barem {2} znakova.", MinimumLength = 3)]
        public string Ime { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "{0} mora imati barem {2} znakova.", MinimumLength = 3)]
        public string Prezime { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "{0} mora imati barem {2} znakova.", MinimumLength = 10)]
        public string Telefon { get; set; }
        [Required]
        [Display(Name = "Grad")]
        public int GradID { get; set; }
        //public string PunoIme { get { return Ime + " " + Prezime; } }
    }
}