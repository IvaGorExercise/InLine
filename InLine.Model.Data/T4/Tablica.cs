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
    
    public partial class Tablica
    {
    
        public Tablica()
        {
    
            this.DatotekaIzvodVerzijaTablica = new HashSet<DatotekaIzvodVerzijaTablica>();
            this.DavanjeTablica = new HashSet<DavanjeTablica>();
            this.HUBVerzijaTablica = new HashSet<HUBVerzijaTablica>();
            this.IzvodVerzijaTablica = new HashSet<IzvodVerzijaTablica>();
            this.ObjektTablica = new HashSet<ObjektTablica>();
            this.ObrazacIDVerzijaTablica = new HashSet<ObrazacIDVerzijaTablica>();
            this.SubjektTablica = new HashSet<SubjektTablica>();
            this.TablicaPolje = new HashSet<TablicaPolje>();
            this.ZapisTablica = new HashSet<ZapisTablica>();
            this.ZbrojniNalogVerzijaTablica = new HashSet<ZbrojniNalogVerzijaTablica>();
        }
    
        public string TablicaShema { get; set; }
        public string TablicaNaziv { get; set; }
        public string Tip { get; set; }
        public string Labela { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string Opis { get; set; }
    
        public virtual ICollection<DatotekaIzvodVerzijaTablica> DatotekaIzvodVerzijaTablica { get; set; }
        public virtual ICollection<DavanjeTablica> DavanjeTablica { get; set; }
        public virtual ICollection<HUBVerzijaTablica> HUBVerzijaTablica { get; set; }
        public virtual ICollection<IzvodVerzijaTablica> IzvodVerzijaTablica { get; set; }
        public virtual ICollection<ObjektTablica> ObjektTablica { get; set; }
        public virtual ICollection<ObrazacIDVerzijaTablica> ObrazacIDVerzijaTablica { get; set; }
        public virtual ICollection<SubjektTablica> SubjektTablica { get; set; }
        public virtual ICollection<TablicaPolje> TablicaPolje { get; set; }
        public virtual ICollection<ZapisTablica> ZapisTablica { get; set; }
        public virtual ICollection<ZbrojniNalogVerzijaTablica> ZbrojniNalogVerzijaTablica { get; set; }
    }
}
