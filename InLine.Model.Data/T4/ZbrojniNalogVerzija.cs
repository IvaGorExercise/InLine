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
    
    public partial class ZbrojniNalogVerzija
    {
    
        public ZbrojniNalogVerzija()
        {
    
            this.ZbrojniNalog = new HashSet<ZbrojniNalog>();
            this.ZbrojniNalogVerzijaTablica = new HashSet<ZbrojniNalogVerzijaTablica>();
        }
    
        public int IDZbrojniNalogVerzija { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public string Opis { get; set; }
        public string Napomena { get; set; }
        public string OpisHTML { get; set; }
        public string NapomenaHTML { get; set; }
    
        public virtual ICollection<ZbrojniNalog> ZbrojniNalog { get; set; }
        public virtual ICollection<ZbrojniNalogVerzijaTablica> ZbrojniNalogVerzijaTablica { get; set; }
    }
}
