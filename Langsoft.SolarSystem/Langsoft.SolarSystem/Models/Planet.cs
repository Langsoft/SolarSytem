using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Langsoft.SolarSystem.Models
{
    [DataContract]
    public class Planet
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Nullable<double> Mass { get; set; }
        [DataMember]
        public string MassUnit { get; set; }
        [DataMember]
        public Nullable<double> SolarDistance { get; set; }
        [DataMember]
        public string SolarDistanceUnit { get; set; }
        [DataMember]
        public Nullable<double> Diameter { get; set; }
        [DataMember]
        public string DiameterUnit { get; set; }
        [DataMember]
        public Nullable<int> NoOf_Moons { get; set; }
        [DataMember]
        public string ImageUrl { get; set; }
    }
}