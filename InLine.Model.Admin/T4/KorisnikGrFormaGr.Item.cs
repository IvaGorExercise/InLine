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
    
    public partial class KorisnikGrFormaGrItem : Model.Admin.KorisnikGrFormaGr
    {
    
    	public KorisnikGrFormaGrItem() {}
    	public KorisnikGrFormaGrItem(long id_KorisnikGrFormaGr)
    	{
    		ID_KorisnikGrFormaGr = id_KorisnikGrFormaGr;
    	}
        public long ID
    	{
    		get { return this.ID_KorisnikGrFormaGr; }
    		set { this.ID_KorisnikGrFormaGr = value; }
    	}
        public long ID_KorisnikGrFormaGr { get; set; }
        public long ID_KorisnikGr { get; set; }
        public long ID_FormaGr { get; set; }
    }
}
