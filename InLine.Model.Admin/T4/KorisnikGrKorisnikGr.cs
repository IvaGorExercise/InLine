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
    
    public partial class KorisnikGrKorisnikGr
    {
        public long ID
    	{
    		get { return this.ID_KorisnikGrKorisnikGr; }
    		set { this.ID_KorisnikGrKorisnikGr = value; }
    	}
        public long ID_KorisnikGrKorisnikGr { get; set; }
        public long ID_KorisnikGr { get; set; }
        public long ID_KorisnikGrNad { get; set; }
    
        public virtual KorisnikGr KorisnikGr { get; set; }
        public virtual KorisnikGr KorisnikGr1 { get; set; }
    }
}
