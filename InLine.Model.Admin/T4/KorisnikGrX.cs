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
    
    public partial class KorisnikGrX
    {
        public KorisnikGrX()
        {
            this.KorisnikGrXAkcijaGrX = new HashSet<KorisnikGrXAkcijaGrX>();
            this.KorisnikGrXFormaGrX = new HashSet<KorisnikGrXFormaGrX>();
            this.KorisnikGrXFormaStGrX = new HashSet<KorisnikGrXFormaStGrX>();
            this.KorisnikGrXKorisnik = new HashSet<KorisnikGrXKorisnik>();
            this.KorisnikGrXKorisnikGrX = new HashSet<KorisnikGrXKorisnikGrX>();
            this.KorisnikGrXKorisnikGrX1 = new HashSet<KorisnikGrXKorisnikGrX>();
            this.KorisnikGrXReportGrX = new HashSet<KorisnikGrXReportGrX>();
            this.KorisnikGrXReportStGrX = new HashSet<KorisnikGrXReportStGrX>();
            this.KorisnikGrXTablicaGrX = new HashSet<KorisnikGrXTablicaGrX>();
            this.KorisnikGrXTablicaPoljeGrX = new HashSet<KorisnikGrXTablicaPoljeGrX>();
        }
    
        public long ID
    	{
    		get { return this.ID_KorisnikGrX; }
    		set { this.ID_KorisnikGrX = value; }
    	}
        public long ID_KorisnikGrX { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Napomena { get; set; }
    
        public virtual ICollection<KorisnikGrXAkcijaGrX> KorisnikGrXAkcijaGrX { get; set; }
        public virtual ICollection<KorisnikGrXFormaGrX> KorisnikGrXFormaGrX { get; set; }
        public virtual ICollection<KorisnikGrXFormaStGrX> KorisnikGrXFormaStGrX { get; set; }
        public virtual ICollection<KorisnikGrXKorisnik> KorisnikGrXKorisnik { get; set; }
        public virtual ICollection<KorisnikGrXKorisnikGrX> KorisnikGrXKorisnikGrX { get; set; }
        public virtual ICollection<KorisnikGrXKorisnikGrX> KorisnikGrXKorisnikGrX1 { get; set; }
        public virtual ICollection<KorisnikGrXReportGrX> KorisnikGrXReportGrX { get; set; }
        public virtual ICollection<KorisnikGrXReportStGrX> KorisnikGrXReportStGrX { get; set; }
        public virtual ICollection<KorisnikGrXTablicaGrX> KorisnikGrXTablicaGrX { get; set; }
        public virtual ICollection<KorisnikGrXTablicaPoljeGrX> KorisnikGrXTablicaPoljeGrX { get; set; }
    }
}