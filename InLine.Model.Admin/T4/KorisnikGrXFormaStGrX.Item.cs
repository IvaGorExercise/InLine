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
    
    public partial class KorisnikGrXFormaStGrXItem : Model.Admin.KorisnikGrXFormaStGrX
    {
    
    	public KorisnikGrXFormaStGrXItem() {}
    	public KorisnikGrXFormaStGrXItem(long id_KorisnikGrXFormaStGrX)
    	{
    		ID_KorisnikGrXFormaStGrX = id_KorisnikGrXFormaStGrX;
    	}
        public long ID
    	{
    		get { return this.ID_KorisnikGrXFormaStGrX; }
    		set { this.ID_KorisnikGrXFormaStGrX = value; }
    	}
        public long ID_KorisnikGrXFormaStGrX { get; set; }
        public long ID_KorisnikGrX { get; set; }
        public long ID_FormaStGrX { get; set; }
    }
}