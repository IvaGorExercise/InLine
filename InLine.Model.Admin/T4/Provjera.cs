//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Admin
{
    using System;
    using System.Collections.Generic;
    
    public partial class Provjera
    {
        public int ID
    	{
    		get { return this.ID_Provjera; }
    		set { this.ID_Provjera = value; }
    	}
        public int ID_Provjera { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string Poruka { get; set; }
    }
}
