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
    
    public partial class HUBVerzijaTablica
    {
    
        public int IDHUBVerzija { get; set; }
        public int IDHUBVerzijaTablica { get; set; }
        public string TablicaShema { get; set; }
        public string TablicaNaziv { get; set; }
    
        public virtual HUBVerzija HUBVerzija { get; set; }
        public virtual Tablica Tablica { get; set; }
    }
}
