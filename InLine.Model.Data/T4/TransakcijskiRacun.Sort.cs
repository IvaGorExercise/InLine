//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data.Sort
{
    using InLine;
    
    public class TransakcijskiRacun
    {
        public TransakcijskiRacun()
        {   
        }
    
        public TransakcijskiRacun(Model.Data.Field.TransakcijskiRacun field, bool descending = false)
        {
            this.Field = field;
            this.Descending = descending;
        }
    
        public Model.Data.Field.TransakcijskiRacun Field { get; set; }
        public bool Descending { get; set; }
    }
}