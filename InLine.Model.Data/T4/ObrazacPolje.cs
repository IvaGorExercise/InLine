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
    
    public partial class ObrazacPolje
    {
    
        public long ID
    	{
    		get { return this.ID_ObrazacPolje; }
    		set { this.ID_ObrazacPolje = value; }
    	}
        public long ID_ObrazacPolje { get; set; }
        public long ID_Obrazac { get; set; }
        public int Redak { get; set; }
        public long ID_ObrazacVrPolje { get; set; }
        public Nullable<bool> ValueBit { get; set; }
        public string ValueString { get; set; }
        public int? ValueInt { get; set; }
        public Nullable<decimal> ValueMoney { get; set; }
        public DateTime? ValueDate { get; set; }
        public Nullable<System.TimeSpan> ValueTime { get; set; }
        public DateTime? ValueDateTime { get; set; }
        public Nullable<decimal> ValueDecimal { get; set; }
    
        public virtual Obrazac Obrazac { get; set; }
        public virtual ObrazacVrPolje ObrazacVrPolje { get; set; }
    }
}