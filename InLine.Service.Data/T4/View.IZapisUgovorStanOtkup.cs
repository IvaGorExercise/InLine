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
    
    public partial interface IZapisUgovorStanOtkup
    {
    
        Model.Data.View.ZapisUgovorStanOtkup FindID(long id);
        //IEnumerable<Model.Data.View.ZapisUgovorStanOtkup> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.View.ZapisUgovorStanOtkup> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.View.ZapisUgovorStanOtkup> GetData(List<Model.Data.Field.View.ZapisUgovorStanOtkup> fields, List<Model.Data.Filter.View.ZapisUgovorStanOtkup>  filter, List<Model.Data.Sort.View.ZapisUgovorStanOtkup>  sort, long? start = null, long? count = null);
    }
}