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
    
    public class ObrazacPolje
    {
        public ObrazacPolje()
        {   
        }
    
        public ObrazacPolje(Model.Data.Field.ObrazacPolje field, bool descending = false)
        {
            this.Field = field;
            this.Descending = descending;
        }
    
        public Model.Data.Field.ObrazacPolje Field { get; set; }
        public bool Descending { get; set; }
    }
}
