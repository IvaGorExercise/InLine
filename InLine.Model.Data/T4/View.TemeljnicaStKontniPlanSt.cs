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
    
    public partial class TemeljnicaStKontniPlanSt
    {
    
        public long? ID_KontniPlanSt { get; set; }
        public string Naziv { get; set; }
        public long? ID_Temeljnica { get; set; }
        public long? ID_TemeljnicaVr { get; set; }
        public long? ID_GlavnaKnjiga { get; set; }
        public long ID_KontniPlan { get; set; }
        public string Konto { get; set; }
        public int SaldoKonti { get; set; }
        public int Zapis { get; set; }
        public int Subjekt { get; set; }
        public int Objekt { get; set; }
        public int Davanje { get; set; }
        public int AnalitikaOd { get; set; }
    }
}
