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
    
    public partial class BazaKorisnik
    {
        public long ID
    	{
    		get { return this.ID_BazaKorisnik; }
    		set { this.ID_BazaKorisnik = value; }
    	}
        public long ID_BazaKorisnik { get; set; }
        public long ID_Baza { get; set; }
        public long ID_Korisnik { get; set; }
        public string Korisnik { get; set; }
        public string Lozinka { get; set; }
    
        public virtual Baza Baza { get; set; }
        public virtual Korisnik Korisnik1 { get; set; }
    }
}
