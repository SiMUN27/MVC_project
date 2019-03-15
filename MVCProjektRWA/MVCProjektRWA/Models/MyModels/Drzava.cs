using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCProjektRWA.Models.MyModels
{
    public class Drzava
    {
        public int IDDrzava{ get; set; }

        [Required(ErrorMessage = "{0} je obavezan.")]
        [DataType(DataType.Text)]
        public string Naziv { get; set; }
    }
}