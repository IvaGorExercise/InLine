//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace InLine.Service.Data
{
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using InLine;
    
    public partial interface IHUBVerzijaTablica
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.HUBVerzijaTablicaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.HUBVerzijaTablicaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.HUBVerzijaTablicaItem item);
    	IEnumerable<Model.Data.HUBVerzijaTablica> SelectResult(int? IDHUBVerzijaTablica);
    	Model.Data.HUBVerzijaTablica InsertResult(Model.Data.Item.HUBVerzijaTablicaItem item);
    	Model.Data.HUBVerzijaTablica UpdateResult(Model.Data.Item.HUBVerzijaTablicaItem item);
    	int DeleteResult(Model.Data.Item.HUBVerzijaTablicaItem item);
    	
        Model.Data.HUBVerzijaTablica FindID(long id);
        //IEnumerable<Model.Data.HUBVerzijaTablica> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.HUBVerzijaTablica> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.HUBVerzijaTablica> GetData(List<Model.Data.Field.HUBVerzijaTablica> fields, List<Model.Data.Filter.HUBVerzijaTablica>  filter, List<Model.Data.Sort.HUBVerzijaTablica>  sort, long? start = null, long? count = null);
    }
}