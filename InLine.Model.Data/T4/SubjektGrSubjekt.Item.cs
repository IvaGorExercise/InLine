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
    
    public partial class SubjektGrSubjektItem 
    {
    
    	public SubjektGrSubjektItem() {}
    	public SubjektGrSubjektItem(long? id_SubjektGrSubjekt)
    	{
    		ID_SubjektGrSubjekt = id_SubjektGrSubjekt;
    	}
    
        public long? ID
    	{
    		get { return this.ID_SubjektGrSubjekt; }
    		set { this.ID_SubjektGrSubjekt = value; }
    	}
        public long? ID_SubjektGrSubjekt { get; set; }
        public long? ID_SubjektGr { get; set; }
        public long? ID_Subjekt { get; set; }
    
    	public SubjektGrSubjektItem(Model.Data.SubjektGrSubjekt item)
    	{
    	    this.ID_SubjektGrSubjekt = item.ID_SubjektGrSubjekt;
        this.ID_SubjektGr = item.ID_SubjektGr;
        this.ID_Subjekt = item.ID_Subjekt;
    	}
    
    	public SubjektGrSubjektItem(dynamic item)
    	{
    	    this.ID_SubjektGrSubjekt = item.ID_SubjektGrSubjekt;
        this.ID_SubjektGr = item.ID_SubjektGr;
        this.ID_Subjekt = item.ID_Subjekt;
    	}
    }
}