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
    
    public partial class PlacanjeVrItem 
    {
    
    	public PlacanjeVrItem() {}
    	public PlacanjeVrItem(long? id_PlacanjeVr)
    	{
    		ID_PlacanjeVr = id_PlacanjeVr;
    	}
    
        public long? ID
    	{
    		get { return this.ID_PlacanjeVr; }
    		set { this.ID_PlacanjeVr = value; }
    	}
        public long? ID_PlacanjeVr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
    
    	public PlacanjeVrItem(Model.Data.PlacanjeVr item)
    	{
    	    this.ID_PlacanjeVr = item.ID_PlacanjeVr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
    	}
    
    	public PlacanjeVrItem(dynamic item)
    	{
    	    this.ID_PlacanjeVr = item.ID_PlacanjeVr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
    	}
    }
}
