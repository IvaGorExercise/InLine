//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Admin.Item
{
    using System;
    using System.Collections.Generic;
    
    public partial class TablicaGrTablicaGrItem : Model.Admin.TablicaGrTablicaGr
    {
    
    	public TablicaGrTablicaGrItem() {}
    	public TablicaGrTablicaGrItem(long id_TablicaGrTablicaGr)
    	{
    		ID_TablicaGrTablicaGr = id_TablicaGrTablicaGr;
    	}
        public long ID
    	{
    		get { return this.ID_TablicaGrTablicaGr; }
    		set { this.ID_TablicaGrTablicaGr = value; }
    	}
        public long ID_TablicaGrTablicaGr { get; set; }
        public long ID_TablicaGr { get; set; }
        public long ID_TablicaGrNad { get; set; }
    }
}
