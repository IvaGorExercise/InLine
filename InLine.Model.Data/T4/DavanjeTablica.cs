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
    
    public partial class DavanjeTablica
    {
    
        public DavanjeTablica()
        {
    
            this.Davanje = new HashSet<Davanje>();
            this.DavanjeVrTablica = new HashSet<DavanjeVrTablica>();
        }
    
        public int IDDavanjeTablica { get; set; }
        public string TablicaShema { get; set; }
        public string TablicaNaziv { get; set; }
    
        public virtual ICollection<Davanje> Davanje { get; set; }
        public virtual Tablica Tablica { get; set; }
        public virtual ICollection<DavanjeVrTablica> DavanjeVrTablica { get; set; }
    }
}
