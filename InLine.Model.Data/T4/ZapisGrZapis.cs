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
    
    public partial class ZapisGrZapis
    {
    
        public long ID
    	{
    		get { return this.ID_ZapisGrZapis; }
    		set { this.ID_ZapisGrZapis = value; }
    	}
        public long ID_ZapisGrZapis { get; set; }
        public long ID_ZapisGr { get; set; }
        public long ID_Zapis { get; set; }
    
        public virtual Zapis Zapis { get; set; }
        public virtual ZapisGr ZapisGr { get; set; }
    }
}