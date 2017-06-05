using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Langsoft.SolarSystem.Models
{
    public class SsPlanetDetails
    {
        /// <summary>
        /// The name of this Planet.
        /// </summary>
        [DisplayName("Name: ")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// The mass of this Planet.
        /// </summary>
        [DisplayName("Mass: ")]
        public string Mass
        {
            get;
            set;
        }

        /// <summary>
        /// The solar distance of this Planet.
        /// </summary>
        [DisplayName("Distance from Sun: ")]
        public string SolarDistance
        {
            get;
            set;
        }

        /// <summary>
        /// The diameter of this Planet.
        /// </summary>
        [DisplayName("Diameter: ")]
        public string Diameter
        {
            get;
            set;
        }

        /// <summary>
        /// The number of moons for this Planet.
        /// </summary>
        [DisplayName("Number of Moons: ")]
        public string NoOfMoons
        {
            get;
            set;
        }

        /// <summary>
        /// The image URL of this Planet.
        /// </summary>
        public string ImageUrl
        {
            get;
            set;
        }
    }
}