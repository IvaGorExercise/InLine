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
    
    public partial class TablicaGrXItem : Model.Admin.TablicaGrX
    {
    
    	public TablicaGrXItem() {}
    	public TablicaGrXItem(long id_TablicaGrX)
    	{
    		ID_TablicaGrX = id_TablicaGrX;
    	}
        public long ID
    	{
    		get { return this.ID_TablicaGrX; }
    		set { this.ID_TablicaGrX = value; }
    	}
        public long ID_TablicaGrX { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    }
}
