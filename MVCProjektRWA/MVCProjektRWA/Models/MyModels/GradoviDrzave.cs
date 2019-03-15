using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProjektRWA.Models.MyModels
{
    public class GradoviDrzave
    {
        public List<Drzava> Countries { get; set; }
        public List<Grad> Cities { get; set; }

        public GradoviDrzave()
        {
            Countries = new List<Drzava>();
            Cities = new List<Grad>();
        }
    }
}