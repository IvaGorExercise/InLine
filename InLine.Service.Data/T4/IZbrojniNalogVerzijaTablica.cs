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
    
    public partial interface IZbrojniNalogVerzijaTablica
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.ZbrojniNalogVerzijaTablicaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.ZbrojniNalogVerzijaTablicaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.ZbrojniNalogVerzijaTablicaItem item);
    	IEnumerable<Model.Data.ZbrojniNalogVerzijaTablica> SelectResult(int? IDZbrojniNalogVerzijaTablica);
    	Model.Data.ZbrojniNalogVerzijaTablica InsertResult(Model.Data.Item.ZbrojniNalogVerzijaTablicaItem item);
    	Model.Data.ZbrojniNalogVerzijaTablica UpdateResult(Model.Data.Item.ZbrojniNalogVerzijaTablicaItem item);
    	int DeleteResult(Model.Data.Item.ZbrojniNalogVerzijaTablicaItem item);
    	
        Model.Data.ZbrojniNalogVerzijaTablica FindID(long id);
        //IEnumerable<Model.Data.ZbrojniNalogVerzijaTablica> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.ZbrojniNalogVerzijaTablica> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.ZbrojniNalogVerzijaTablica> GetData(List<Model.Data.Field.ZbrojniNalogVerzijaTablica> fields, List<Model.Data.Filter.ZbrojniNalogVerzijaTablica>  filter, List<Model.Data.Sort.ZbrojniNalogVerzijaTablica>  sort, long? start = null, long? count = null);
    }
}
