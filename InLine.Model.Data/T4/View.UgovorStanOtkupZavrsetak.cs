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
    
    public partial class UgovorStanOtkupZavrsetak
    {
    
        public long ID_UgovorStanOtkupZavrsetak { get; set; }
        public long ID_UgovorstanOtkup { get; set; }
        public int BrojUgovor { get; set; }
        public DateTime Datum { get; set; }
        public int? DokumentVrsta { get; set; }
        public int? DokumentGrupa { get; set; }
        public long? ID_DokumentVr { get; set; }
        public string Razlog { get; set; }
        public long? ID_Subjekt { get; set; }
        public decimal IznosJednokratno { get; set; }
        public decimal IznosUcesce { get; set; }
        public decimal IznosKamata { get; set; }
        public decimal IznosKredit { get; set; }
        public decimal IznosKamataRevalorizacija { get; set; }
        public decimal IznosKreditRevalorizacija { get; set; }
        public int? TemeljnicaGodina { get; set; }
        public int? TemeljnicaVrsta { get; set; }
        public int? TemeljnicaBroj { get; set; }
        public long? ID_Temeljnica { get; set; }
    }
}
