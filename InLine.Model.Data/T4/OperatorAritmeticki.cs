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
    
    public partial class OperatorAritmeticki
    {
    
        public OperatorAritmeticki()
        {
    
            this.ShemaStPolje = new HashSet<ShemaStPolje>();
        }
    
        public string AritmetickiOperator { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
        public virtual ICollection<ShemaStPolje> ShemaStPolje { get; set; }
    }
}
