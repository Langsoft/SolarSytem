using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Langsoft.SolarSystem.Models
{
    public class ssPlanetVM
    {
        public SsPlanet ssPlanet { get; set; }
        public List<SsPlanet> ssPlanetsObj { get; set; }
        public string Status
        {

            get
            {
                if (ssPlanetsObj.Count > 0)
                {
                    return "block";
                }
                else
                {
                    return "none";
                }

            }
        }//This will help us to handle the view logic

    }
}