//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DohodakPrimateljIsplataRacun
    {
    
        public long ID
    	{
    		get { return this.ID_DohodakPrimateljIsplataRacun; }
    		set { this.ID_DohodakPrimateljIsplataRacun = value; }
    	}
        public long ID_DohodakPrimateljIsplataRacun { get; set; }
        public long ID_DohodakPrimatelj { get; set; }
        public long ID_SubjektRacun { get; set; }
        public decimal Iznos { get; set; }
    
        public virtual DohodakPrimatelj DohodakPrimatelj { get; set; }
        public virtual SubjektRacun SubjektRacun { get; set; }
    }
}