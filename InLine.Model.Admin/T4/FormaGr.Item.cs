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
    
    public partial class FormaGrItem : Model.Admin.FormaGr
    {
    
    	public FormaGrItem() {}
    	public FormaGrItem(long id_FormaGr)
    	{
    		ID_FormaGr = id_FormaGr;
    	}
        public long ID
    	{
    		get { return this.ID_FormaGr; }
    		set { this.ID_FormaGr = value; }
    	}
        public long ID_FormaGr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Napomena { get; set; }
    }
}