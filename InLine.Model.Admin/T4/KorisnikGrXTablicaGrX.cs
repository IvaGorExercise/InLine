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
    
    public partial class KorisnikGrXTablicaGrX
    {
        public long ID
    	{
    		get { return this.ID_KorisnikGrXTablicaGrX; }
    		set { this.ID_KorisnikGrXTablicaGrX = value; }
    	}
        public long ID_KorisnikGrXTablicaGrX { get; set; }
        public long ID_KorisnikGrX { get; set; }
        public long ID_TablicaGrX { get; set; }
    
        public virtual KorisnikGrX KorisnikGrX { get; set; }
        public virtual TablicaGrX TablicaGrX { get; set; }
    }
}
