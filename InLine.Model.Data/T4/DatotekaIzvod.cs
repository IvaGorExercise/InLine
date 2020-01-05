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
    
    public partial class DatotekaIzvod
    {
    
        public DatotekaIzvod()
        {
    
            this.DatotekaIzvod2012A = new HashSet<DatotekaIzvod2012A>();
            this.DatotekaIzvodGr2012A = new HashSet<DatotekaIzvodGr2012A>();
            this.DatotekaIzvodSt2012A = new HashSet<DatotekaIzvodSt2012A>();
        }
    
        public long ID
    	{
    		get { return this.ID_DatotekaIzvod; }
    		set { this.ID_DatotekaIzvod = value; }
    	}
        public long ID_DatotekaIzvod { get; set; }
        public long ID_Zapis { get; set; }
        public long ID_IzvodPosiljatelj { get; set; }
        public DateTime Datum { get; set; }
        public int RedniBroj { get; set; }
        public int IDDatotekaIzvodVerzija { get; set; }
        public string DatotekaNaziv { get; set; }
        public string Datoteka { get; set; }
    
        public virtual DatotekaIzvodVerzija DatotekaIzvodVerzija { get; set; }
        public virtual IzvodPosiljatelj IzvodPosiljatelj { get; set; }
        public virtual Zapis Zapis { get; set; }
        public virtual ICollection<DatotekaIzvod2012A> DatotekaIzvod2012A { get; set; }
        public virtual ICollection<DatotekaIzvodGr2012A> DatotekaIzvodGr2012A { get; set; }
        public virtual ICollection<DatotekaIzvodSt2012A> DatotekaIzvodSt2012A { get; set; }
    }
}