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
    
    public partial class TablicaPoljeGrXItem : Model.Admin.TablicaPoljeGrX
    {
    
    	public TablicaPoljeGrXItem() {}
    	public TablicaPoljeGrXItem(long id_TablicaPoljeGrX)
    	{
    		ID_TablicaPoljeGrX = id_TablicaPoljeGrX;
    	}
        public long ID
    	{
    		get { return this.ID_TablicaPoljeGrX; }
    		set { this.ID_TablicaPoljeGrX = value; }
    	}
        public long ID_TablicaPoljeGrX { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    }
}
