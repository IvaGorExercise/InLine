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
    
    public partial class KalendarTjedanDan
    {
    
        public KalendarTjedanDan()
        {
    
            this.PraznikPravilo = new HashSet<PraznikPravilo>();
            this.PraznikPraviloPomak = new HashSet<PraznikPraviloPomak>();
            this.PraznikPraviloPomak1 = new HashSet<PraznikPraviloPomak>();
        }
    
        public int TjedanDan { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
    
        public virtual ICollection<PraznikPravilo> PraznikPravilo { get; set; }
        public virtual ICollection<PraznikPraviloPomak> PraznikPraviloPomak { get; set; }
        public virtual ICollection<PraznikPraviloPomak> PraznikPraviloPomak1 { get; set; }
    }
}
