//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LangSoft.SolarSystem.API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<double> Mass { get; set; }
        public string MassUnit { get; set; }
        public Nullable<double> SolarDistance { get; set; }
        public string SolarDistanceUnit { get; set; }
        public Nullable<double> Diameter { get; set; }
        public string DiameterUnit { get; set; }
        public Nullable<int> NoOf_Moons { get; set; }
        public string ImageUrl { get; set; }
    }
}