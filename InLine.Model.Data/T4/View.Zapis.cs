//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data.View
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zapis
    {
    
        public long? ID_Zapis { get; set; }
        public int? IDZapisTablica { get; set; }
        public int? IDZapisVr { get; set; }
        public long? IDZapis { get; set; }
        public DateTime? VrijemeUpis { get; set; }
        public string UrudzbeniBroj { get; set; }
        public string Predmet { get; set; }
        public long? ID_Subjekt { get; set; }
        public long? ID_SubjektUpis { get; set; }
        public long? ID_Temeljnica { get; set; }
        public string Broj { get; set; }
        public DateTime? Datum { get; set; }
        public Nullable<System.TimeSpan> Vrijeme { get; set; }
        public string TablicaNaziv { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public Nullable<bool> Odabir { get; set; }
        public string DatumGodina { get; set; }
        public string VrijemeUpisString { get; set; }
        public string DatumString { get; set; }
    }
}
