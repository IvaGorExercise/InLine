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
    
    public partial class TemeljnicaSt
    {
    
        public long ID_TemeljnicaSt { get; set; }
        public long ID_Temeljnica { get; set; }
        public int RedniBroj { get; set; }
        public string KontniPlanStNaziv { get; set; }
        public DateTime Datum { get; set; }
        public decimal IznosDuguje { get; set; }
        public decimal IznosPotrazuje { get; set; }
        public string IDValuta { get; set; }
        public decimal IznosDugujeValuta { get; set; }
        public decimal IznosPotrazujeValuta { get; set; }
        public decimal Tecaj { get; set; }
        public long ID_KontniPlanSt { get; set; }
        public string Konto { get; set; }
    }
}