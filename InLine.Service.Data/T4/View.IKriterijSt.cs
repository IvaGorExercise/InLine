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
    
    public partial interface IKriterijSt
    {
    
        Model.Data.View.KriterijSt FindID(long id);
        //IEnumerable<Model.Data.View.KriterijSt> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.View.KriterijSt> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.View.KriterijSt> GetData(List<Model.Data.Field.View.KriterijSt> fields, List<Model.Data.Filter.View.KriterijSt>  filter, List<Model.Data.Sort.View.KriterijSt>  sort, long? start = null, long? count = null);
    }
}
