//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data.Item
{
    using System;
    using System.Collections.Generic;
    
    public partial class TecajItem 
    {
    
    	public TecajItem() {}
    	public TecajItem(long? id_Tecaj)
    	{
    		ID_Tecaj = id_Tecaj;
    	}
    
        public long? ID
    	{
    		get { return this.ID_Tecaj; }
    		set { this.ID_Tecaj = value; }
    	}
        public long? ID_Tecaj { get; set; }
        public long? ID_TecajListaSt { get; set; }
        public long? ID_TecajVr { get; set; }
        public decimal? Tecaj6 { get; set; }
    
    	public TecajItem(Model.Data.Tecaj item)
    	{
    	    this.ID_Tecaj = item.ID_Tecaj;
        this.ID_TecajListaSt = item.ID_TecajListaSt;
        this.ID_TecajVr = item.ID_TecajVr;
        this.Tecaj6 = item.Tecaj6;
    	}
    
    	public TecajItem(dynamic item)
    	{
    	    this.ID_Tecaj = item.ID_Tecaj;
        this.ID_TecajListaSt = item.ID_TecajListaSt;
        this.ID_TecajVr = item.ID_TecajVr;
        this.Tecaj6 = item.Tecaj6;
    	}
    }
}