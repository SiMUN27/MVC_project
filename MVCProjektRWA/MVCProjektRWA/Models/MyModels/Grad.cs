using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCProjektRWA.Models.MyModels
{
    public class Grad
    {
        public int IDGrad { get; set; }
        [Required]
        public string Naziv { get; set; }
        public int DrzavaID { get; set; }
    }
}