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
    
    public partial interface IUgovorStanOtkupAneks
    {
    
        Model.Data.View.UgovorStanOtkupAneks FindID(long id);
        //IEnumerable<Model.Data.View.UgovorStanOtkupAneks> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.View.UgovorStanOtkupAneks> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.View.UgovorStanOtkupAneks> GetData(List<Model.Data.Field.View.UgovorStanOtkupAneks> fields, List<Model.Data.Filter.View.UgovorStanOtkupAneks>  filter, List<Model.Data.Sort.View.UgovorStanOtkupAneks>  sort, long? start = null, long? count = null);
    }
}