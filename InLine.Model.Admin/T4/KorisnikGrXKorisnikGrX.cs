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
    
    public partial class KorisnikGrXKorisnikGrX
    {
        public long ID
    	{
    		get { return this.ID_KorisnikGrXKorisnikGrX; }
    		set { this.ID_KorisnikGrXKorisnikGrX = value; }
    	}
        public long ID_KorisnikGrXKorisnikGrX { get; set; }
        public long ID_KorisnikGrX { get; set; }
        public long ID_KorisnikGrXNad { get; set; }
    
        public virtual KorisnikGrX KorisnikGrX { get; set; }
        public virtual KorisnikGrX KorisnikGrX1 { get; set; }
    }
}
