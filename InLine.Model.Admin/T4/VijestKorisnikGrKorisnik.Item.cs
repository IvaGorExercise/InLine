//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Admin.Item
{
    using System;
    using System.Collections.Generic;
    
    public partial class VijestKorisnikGrKorisnikItem : Model.Admin.VijestKorisnikGrKorisnik
    {
    
    	public VijestKorisnikGrKorisnikItem() {}
    	public VijestKorisnikGrKorisnikItem(long id_VijestKorisnikGrKorisnik)
    	{
    		ID_VijestKorisnikGrKorisnik = id_VijestKorisnikGrKorisnik;
    	}
        public long ID
    	{
    		get { return this.ID_VijestKorisnikGrKorisnik; }
    		set { this.ID_VijestKorisnikGrKorisnik = value; }
    	}
        public long ID_VijestKorisnikGrKorisnik { get; set; }
        public long ID_VijestKorisnikGr { get; set; }
        public long ID_Korisnik { get; set; }
    }
}