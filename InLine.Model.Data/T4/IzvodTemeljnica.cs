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
    
    public partial class IzvodTemeljnica
    {
    
        public long ID
    	{
    		get { return this.ID_IzvodTemeljnica; }
    		set { this.ID_IzvodTemeljnica = value; }
    	}
        public long ID_IzvodTemeljnica { get; set; }
        public long? ID_Izvod { get; set; }
        public decimal IznosDuguje { get; set; }
        public decimal IznosPotrazuje { get; set; }
        public decimal SaldoStaro { get; set; }
        public decimal SaldoNovo { get; set; }
        public string TemeljnicaStatus { get; set; }
        public int? TemeljnicaGodina { get; set; }
        public int? TemeljnicaVrsta { get; set; }
        public int? TemeljnicaBroj { get; set; }
        public long? ID_Temeljnica { get; set; }
    
        public virtual Temeljnica Temeljnica { get; set; }
        public virtual Izvod Izvod { get; set; }
    }
}