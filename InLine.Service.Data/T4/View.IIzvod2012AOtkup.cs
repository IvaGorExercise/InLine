//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace InLine.Service.Data.View
{
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using InLine;
    
    public partial interface IIzvod2012AOtkup
    {
    
        Model.Data.View.Izvod2012AOtkup FindID(long id);
        //IEnumerable<Model.Data.View.Izvod2012AOtkup> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.View.Izvod2012AOtkup> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.View.Izvod2012AOtkup> GetData(List<Model.Data.Field.View.Izvod2012AOtkup> fields, List<Model.Data.Filter.View.Izvod2012AOtkup>  filter, List<Model.Data.Sort.View.Izvod2012AOtkup>  sort, long? start = null, long? count = null);
    }
}
