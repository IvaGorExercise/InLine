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
    
    public partial class KorisnikGrXAkcijaGrX
    {
        public long ID
    	{
    		get { return this.ID_KorisnikGrXAkcijaGrX; }
    		set { this.ID_KorisnikGrXAkcijaGrX = value; }
    	}
        public long ID_KorisnikGrXAkcijaGrX { get; set; }
        public long ID_KorisnikGrX { get; set; }
        public long ID_AkcijaGrX { get; set; }
    
        public virtual AkcijaGrX AkcijaGrX { get; set; }
        public virtual KorisnikGrX KorisnikGrX { get; set; }
    }
}
