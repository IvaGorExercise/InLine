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
    
    public partial class TablicaPoljeGr
    {
        public TablicaPoljeGr()
        {
            this.KorisnikGrTablicaPoljeGr = new HashSet<KorisnikGrTablicaPoljeGr>();
            this.LicencaTablicaPoljeGr = new HashSet<LicencaTablicaPoljeGr>();
            this.TablicaPoljeGrTablicaPolje = new HashSet<TablicaPoljeGrTablicaPolje>();
            this.TablicaPoljeGrTablicaPoljeGr = new HashSet<TablicaPoljeGrTablicaPoljeGr>();
            this.TablicaPoljeGrTablicaPoljeGr1 = new HashSet<TablicaPoljeGrTablicaPoljeGr>();
        }
    
        public long ID
    	{
    		get { return this.ID_TablicaPoljeGr; }
    		set { this.ID_TablicaPoljeGr = value; }
    	}
        public long ID_TablicaPoljeGr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
        public virtual ICollection<KorisnikGrTablicaPoljeGr> KorisnikGrTablicaPoljeGr { get; set; }
        public virtual ICollection<LicencaTablicaPoljeGr> LicencaTablicaPoljeGr { get; set; }
        public virtual ICollection<TablicaPoljeGrTablicaPolje> TablicaPoljeGrTablicaPolje { get; set; }
        public virtual ICollection<TablicaPoljeGrTablicaPoljeGr> TablicaPoljeGrTablicaPoljeGr { get; set; }
        public virtual ICollection<TablicaPoljeGrTablicaPoljeGr> TablicaPoljeGrTablicaPoljeGr1 { get; set; }
    }
}
