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
    
    public partial class HUBModelPodatak2013A
    {
    
        public HUBModelPodatak2013A()
        {
    
            this.HUBKontrolaModelPodatak2013A = new HashSet<HUBKontrolaModelPodatak2013A>();
        }
    
        public int IDHUBModelPodatak2013A { get; set; }
        public int IDHUBModel2013A { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public bool Fiksni { get; set; }
        public int? ZnamenkaMin { get; set; }
        public int? ZnamenkaMax { get; set; }
        public bool KontrolaZajedno { get; set; }
        public int? PozicijaMin { get; set; }
        public int? PozicijaMax { get; set; }
        public bool Koristi { get; set; }
        public Nullable<bool> ImaKontrola { get; set; }
    
        public virtual ICollection<HUBKontrolaModelPodatak2013A> HUBKontrolaModelPodatak2013A { get; set; }
        public virtual HUBModel2013A HUBModel2013A { get; set; }
    }
}
