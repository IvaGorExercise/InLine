//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data.Filter
{
    using InLine;
    
    public class PraznikPraviloVr
    {
        public PraznikPraviloVr()
        {
            this.Operator = ERelationalOperator.Equal;
        }
    
        public PraznikPraviloVr(Model.Data.Field.PraznikPraviloVr field, dynamic value, ERelationalOperator operator_ = ERelationalOperator.Equal, bool tip_ = false)
        {
            this.Field = field;
            this.Value = value;
            this.Operator = operator_;
    		this.Tip = tip_;
        }
    
        public Model.Data.Field.PraznikPraviloVr Field { get; set; }
        public dynamic Value { get; set; }
        public ERelationalOperator Operator { get; set; }
    	public bool Tip { get; set; }
    }
}