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
    
    public partial class TablicaPoljeGrXTablicaPolje
    {
        public TablicaPoljeGrXTablicaPolje()
        {
            this.TablicaPoljeGrXTablicaPolje1 = new HashSet<TablicaPoljeGrXTablicaPolje>();
        }
    
        public long ID
    	{
    		get { return this.ID_TablicaPoljeGrXTablicaPolje; }
    		set { this.ID_TablicaPoljeGrXTablicaPolje = value; }
    	}
        public long ID_TablicaPoljeGrXTablicaPolje { get; set; }
        public long ID_TablicaPoljeGrX { get; set; }
        public bool TablicaKorisnik { get; set; }
        public string TablicaShema { get; set; }
        public string TablicaNaziv { get; set; }
        public string TablicaPoljeNaziv { get; set; }
        public long? ID_TablicaPoljeGrXTablicaPoljeNad { get; set; }
    
        public virtual TablicaPoljeGrX TablicaPoljeGrX { get; set; }
        public virtual TablicaPolje TablicaPolje { get; set; }
        public virtual ICollection<TablicaPoljeGrXTablicaPolje> TablicaPoljeGrXTablicaPolje1 { get; set; }
        public virtual TablicaPoljeGrXTablicaPolje TablicaPoljeGrXTablicaPolje2 { get; set; }
    }
}