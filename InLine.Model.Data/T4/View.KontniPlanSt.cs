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
    
    public partial class KontniPlanSt
    {
    
        public long ID_KontniPlanSt { get; set; }
        public long ID_KontniPlan { get; set; }
        public string Konto { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public bool SaldoKonti { get; set; }
        public bool ZapisDopusteno { get; set; }
        public bool ZapisObavezno { get; set; }
        public bool SubjektDopusteno { get; set; }
        public bool SubjektObavezno { get; set; }
        public bool ObjektDopusteno { get; set; }
        public bool ObjektObavezno { get; set; }
        public bool DavanjeDopusteno { get; set; }
        public bool DavanjeObavezno { get; set; }
        public bool DugujeDopusteno { get; set; }
        public bool DugujeObavezno { get; set; }
        public bool PotrazujeDopusteno { get; set; }
        public bool PotrazujeObavezno { get; set; }
    }
}
