//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data.Filter.View
{
    using InLine;
    
    public class ZapisUgovorStanOtkupAneks
    {
        public ZapisUgovorStanOtkupAneks()
        {
            this.Operator = ERelationalOperator.Equal;
        }
    
        public ZapisUgovorStanOtkupAneks(Model.Data.Field.View.ZapisUgovorStanOtkupAneks field, dynamic value, ERelationalOperator operator_ = ERelationalOperator.Equal, bool tip_ = false)
        {
            this.Field = field;
            this.Value = value;
            this.Operator = operator_;
    		this.Tip = tip_;
        }
    
        public Model.Data.Field.View.ZapisUgovorStanOtkupAneks Field { get; set; }
        public dynamic Value { get; set; }
        public ERelationalOperator Operator { get; set; }
    	public bool Tip { get; set; }
    }
}
