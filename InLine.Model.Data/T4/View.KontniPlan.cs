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
    
    public partial class KontniPlan
    {
    
        public int AnalitikaOd { get; set; }
        public long ID_KontniPlan { get; set; }
        public long ID_PoslovnaGodina { get; set; }
        public int Godina { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string IDValuta { get; set; }
        public long ID_PoslovniSubjekt { get; set; }
        public long ID_Subjekt { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
    }
}
