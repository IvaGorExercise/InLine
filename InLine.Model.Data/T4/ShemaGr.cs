//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShemaGr
    {
    
        public ShemaGr()
        {
    
            this.ShemaGrShema = new HashSet<ShemaGrShema>();
            this.ShemaGrShemaGr = new HashSet<ShemaGrShemaGr>();
            this.ShemaGrShemaGr1 = new HashSet<ShemaGrShemaGr>();
        }
    
        public long ID
    	{
    		get { return this.ID_ShemaGr; }
    		set { this.ID_ShemaGr = value; }
    	}
        public long ID_ShemaGr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
        public virtual ICollection<ShemaGrShema> ShemaGrShema { get; set; }
        public virtual ICollection<ShemaGrShemaGr> ShemaGrShemaGr { get; set; }
        public virtual ICollection<ShemaGrShemaGr> ShemaGrShemaGr1 { get; set; }
    }
}
