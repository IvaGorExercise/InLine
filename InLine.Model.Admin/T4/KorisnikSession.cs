//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Admin
{
    using System;
    using System.Collections.Generic;
    
    public partial class KorisnikSession
    {
        public long ID
    	{
    		get { return this.ID_KorisnikSession; }
    		set { this.ID_KorisnikSession = value; }
    	}
        public long ID_KorisnikSession { get; set; }
        public long ID_Korisnik { get; set; }
        public string SessionID { get; set; }
        public DateTime? SessionDatum { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
    }
}
