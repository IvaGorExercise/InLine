//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Admin
{
    using System;
    using System.Collections.Generic;
    
    public partial class TablicaGrTablicaGr
    {
        public long ID
    	{
    		get { return this.ID_TablicaGrTablicaGr; }
    		set { this.ID_TablicaGrTablicaGr = value; }
    	}
        public long ID_TablicaGrTablicaGr { get; set; }
        public long ID_TablicaGr { get; set; }
        public long ID_TablicaGrNad { get; set; }
    
        public virtual TablicaGr TablicaGr { get; set; }
        public virtual TablicaGr TablicaGr1 { get; set; }
    }
}