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
    
    public partial class TablicaGr
    {
        public TablicaGr()
        {
            this.KorisnikGrTablicaGr = new HashSet<KorisnikGrTablicaGr>();
            this.LicencaTablicaGr = new HashSet<LicencaTablicaGr>();
            this.TablicaGrTablica = new HashSet<TablicaGrTablica>();
            this.TablicaGrTablicaGr = new HashSet<TablicaGrTablicaGr>();
            this.TablicaGrTablicaGr1 = new HashSet<TablicaGrTablicaGr>();
        }
    
        public long ID
    	{
    		get { return this.ID_TablicaGr; }
    		set { this.ID_TablicaGr = value; }
    	}
        public long ID_TablicaGr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
        public virtual ICollection<KorisnikGrTablicaGr> KorisnikGrTablicaGr { get; set; }
        public virtual ICollection<LicencaTablicaGr> LicencaTablicaGr { get; set; }
        public virtual ICollection<TablicaGrTablica> TablicaGrTablica { get; set; }
        public virtual ICollection<TablicaGrTablicaGr> TablicaGrTablicaGr { get; set; }
        public virtual ICollection<TablicaGrTablicaGr> TablicaGrTablicaGr1 { get; set; }
    }
}
