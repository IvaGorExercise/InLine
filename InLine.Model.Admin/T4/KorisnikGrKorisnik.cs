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
    
    public partial class KorisnikGrKorisnik
    {
        public KorisnikGrKorisnik()
        {
            this.KorisnikGrKorisnik1 = new HashSet<KorisnikGrKorisnik>();
        }
    
        public long ID
    	{
    		get { return this.ID_KorisnikGrKorisnik; }
    		set { this.ID_KorisnikGrKorisnik = value; }
    	}
        public long ID_KorisnikGrKorisnik { get; set; }
        public long ID_KorisnikGr { get; set; }
        public long ID_Korisnik { get; set; }
        public long? ID_KorisnikGrKorisnikNad { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual KorisnikGr KorisnikGr { get; set; }
        public virtual ICollection<KorisnikGrKorisnik> KorisnikGrKorisnik1 { get; set; }
        public virtual KorisnikGrKorisnik KorisnikGrKorisnik2 { get; set; }
    }
}