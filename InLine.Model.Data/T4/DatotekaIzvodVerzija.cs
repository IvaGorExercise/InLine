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
    
    public partial class DatotekaIzvodVerzija
    {
    
        public DatotekaIzvodVerzija()
        {
    
            this.DatotekaIzvod = new HashSet<DatotekaIzvod>();
            this.DatotekaIzvodVerzijaTablica = new HashSet<DatotekaIzvodVerzijaTablica>();
        }
    
        public int IDDatotekaIzvodVerzija { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public string Opis { get; set; }
        public string Napomena { get; set; }
        public string OpisHTML { get; set; }
        public string NapomenaHTML { get; set; }
    
        public virtual ICollection<DatotekaIzvod> DatotekaIzvod { get; set; }
        public virtual ICollection<DatotekaIzvodVerzijaTablica> DatotekaIzvodVerzijaTablica { get; set; }
    }
}
