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
    
    public partial class PraznikGrItem 
    {
    
    	public PraznikGrItem() {}
    	public PraznikGrItem(long? id_PraznikGr)
    	{
    		ID_PraznikGr = id_PraznikGr;
    	}
    
        public long? ID
    	{
    		get { return this.ID_PraznikGr; }
    		set { this.ID_PraznikGr = value; }
    	}
        public long? ID_PraznikGr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
    
    	public PraznikGrItem(Model.Data.PraznikGr item)
    	{
    	    this.ID_PraznikGr = item.ID_PraznikGr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
    	}
    
    	public PraznikGrItem(dynamic item)
    	{
    	    this.ID_PraznikGr = item.ID_PraznikGr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
    	}
    }
}
