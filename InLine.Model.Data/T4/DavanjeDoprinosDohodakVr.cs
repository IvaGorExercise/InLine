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
    
    public partial class DavanjeDoprinosDohodakVr
    {
    
        public DavanjeDoprinosDohodakVr()
        {
    
            this.DoprinosDohodakVr = new HashSet<DoprinosDohodakVr>();
            this.DavanjeDoprinosDohodak = new HashSet<DavanjeDoprinosDohodak>();
        }
    
        public int IDDavanjeDoprinosDohodakVr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
        public virtual ICollection<DoprinosDohodakVr> DoprinosDohodakVr { get; set; }
        public virtual ICollection<DavanjeDoprinosDohodak> DavanjeDoprinosDohodak { get; set; }
    }
}
