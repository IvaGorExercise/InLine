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
    
    public partial class DohodakPrimateljPrimitakDavanjeItem 
    {
    
    	public DohodakPrimateljPrimitakDavanjeItem() {}
    	public DohodakPrimateljPrimitakDavanjeItem(long? id_DohodakPrimateljPrimitakDavanje)
    	{
    		ID_DohodakPrimateljPrimitakDavanje = id_DohodakPrimateljPrimitakDavanje;
    	}
    
        public long? ID
    	{
    		get { return this.ID_DohodakPrimateljPrimitakDavanje; }
    		set { this.ID_DohodakPrimateljPrimitakDavanje = value; }
    	}
        public long? ID_DohodakPrimateljPrimitakDavanje { get; set; }
        public long? ID_DohodakPrimateljPrimitak { get; set; }
        public long? ID_Davanje { get; set; }
    
    	public DohodakPrimateljPrimitakDavanjeItem(Model.Data.DohodakPrimateljPrimitakDavanje item)
    	{
    	    this.ID_DohodakPrimateljPrimitakDavanje = item.ID_DohodakPrimateljPrimitakDavanje;
        this.ID_DohodakPrimateljPrimitak = item.ID_DohodakPrimateljPrimitak;
        this.ID_Davanje = item.ID_Davanje;
    	}
    
    	public DohodakPrimateljPrimitakDavanjeItem(dynamic item)
    	{
    	    this.ID_DohodakPrimateljPrimitakDavanje = item.ID_DohodakPrimateljPrimitakDavanje;
        this.ID_DohodakPrimateljPrimitak = item.ID_DohodakPrimateljPrimitak;
        this.ID_Davanje = item.ID_Davanje;
    	}
    }
}