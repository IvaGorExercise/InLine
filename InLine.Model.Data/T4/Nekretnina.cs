//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nekretnina
    {
    
        public Nekretnina()
        {
    
            this.Lokacija = new HashSet<Lokacija>();
        }
    
        public long ID
    	{
    		get { return this.ID_Nekretnina; }
    		set { this.ID_Nekretnina = value; }
    	}
        public long ID_Nekretnina { get; set; }
        public long? ID_Objekt { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
        public virtual ICollection<Lokacija> Lokacija { get; set; }
        public virtual Objekt Objekt { get; set; }
    }
}