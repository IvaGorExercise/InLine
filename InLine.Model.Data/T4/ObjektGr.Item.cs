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
    
    public partial class ObjektGrItem 
    {
    
    	public ObjektGrItem() {}
    	public ObjektGrItem(long? id_ObjektGr)
    	{
    		ID_ObjektGr = id_ObjektGr;
    	}
    
        public long? ID
    	{
    		get { return this.ID_ObjektGr; }
    		set { this.ID_ObjektGr = value; }
    	}
        public long? ID_ObjektGr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
    	public ObjektGrItem(Model.Data.ObjektGr item)
    	{
    	    this.ID_ObjektGr = item.ID_ObjektGr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    
    	public ObjektGrItem(dynamic item)
    	{
    	    this.ID_ObjektGr = item.ID_ObjektGr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    }
}