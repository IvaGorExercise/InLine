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
    
    public partial class KorisnikGrAkcijaGr
    {
        public long ID
    	{
    		get { return this.ID_KorisnikGrAkcijaGr; }
    		set { this.ID_KorisnikGrAkcijaGr = value; }
    	}
        public long ID_KorisnikGrAkcijaGr { get; set; }
        public long ID_KorisnikGr { get; set; }
        public long ID_AkcijaGr { get; set; }
    
        public virtual AkcijaGr AkcijaGr { get; set; }
        public virtual KorisnikGr KorisnikGr { get; set; }
    }
}
