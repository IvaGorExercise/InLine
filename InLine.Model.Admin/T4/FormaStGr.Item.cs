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
    
    public partial class FormaStGrItem : Model.Admin.FormaStGr
    {
    
    	public FormaStGrItem() {}
    	public FormaStGrItem(long id_FormaStGr)
    	{
    		ID_FormaStGr = id_FormaStGr;
    	}
        public long ID
    	{
    		get { return this.ID_FormaStGr; }
    		set { this.ID_FormaStGr = value; }
    	}
        public long ID_FormaStGr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Napomena { get; set; }
    }
}
