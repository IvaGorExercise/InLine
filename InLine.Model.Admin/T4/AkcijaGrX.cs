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
    
    public partial class AkcijaGrX
    {
        public AkcijaGrX()
        {
            this.AkcijaGrXAkcija = new HashSet<AkcijaGrXAkcija>();
            this.AkcijaGrXAkcijaGrX = new HashSet<AkcijaGrXAkcijaGrX>();
            this.AkcijaGrXAkcijaGrX1 = new HashSet<AkcijaGrXAkcijaGrX>();
            this.KorisnikGrXAkcijaGrX = new HashSet<KorisnikGrXAkcijaGrX>();
        }
    
        public long ID
    	{
    		get { return this.ID_AkcijaGrX; }
    		set { this.ID_AkcijaGrX = value; }
    	}
        public long ID_AkcijaGrX { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Napomena { get; set; }
    
        public virtual ICollection<AkcijaGrXAkcija> AkcijaGrXAkcija { get; set; }
        public virtual ICollection<AkcijaGrXAkcijaGrX> AkcijaGrXAkcijaGrX { get; set; }
        public virtual ICollection<AkcijaGrXAkcijaGrX> AkcijaGrXAkcijaGrX1 { get; set; }
        public virtual ICollection<KorisnikGrXAkcijaGrX> KorisnikGrXAkcijaGrX { get; set; }
    }
}
