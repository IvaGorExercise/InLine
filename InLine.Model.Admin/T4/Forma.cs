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
    
    public partial class Forma
    {
        public Forma()
        {
            this.FormaGrForma = new HashSet<FormaGrForma>();
            this.FormaGrXForma = new HashSet<FormaGrXForma>();
            this.FormaSt = new HashSet<FormaSt>();
            this.FormaVr = new HashSet<FormaVr>();
        }
    
        public int IDForma { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Napomena { get; set; }
    
        public virtual ICollection<FormaGrForma> FormaGrForma { get; set; }
        public virtual ICollection<FormaGrXForma> FormaGrXForma { get; set; }
        public virtual ICollection<FormaSt> FormaSt { get; set; }
        public virtual ICollection<FormaVr> FormaVr { get; set; }
    }
}