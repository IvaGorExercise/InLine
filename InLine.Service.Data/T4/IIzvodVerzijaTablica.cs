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
    
    public partial interface IIzvodVerzijaTablica
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.IzvodVerzijaTablicaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.IzvodVerzijaTablicaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.IzvodVerzijaTablicaItem item);
    	IEnumerable<Model.Data.IzvodVerzijaTablica> SelectResult(int? IDIzvodVerzija,int? IDIzvodVerzijaTablica);
    	Model.Data.IzvodVerzijaTablica InsertResult(Model.Data.Item.IzvodVerzijaTablicaItem item);
    	Model.Data.IzvodVerzijaTablica UpdateResult(Model.Data.Item.IzvodVerzijaTablicaItem item);
    	int DeleteResult(Model.Data.Item.IzvodVerzijaTablicaItem item);
    	
        Model.Data.IzvodVerzijaTablica FindID(long id);
        //IEnumerable<Model.Data.IzvodVerzijaTablica> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.IzvodVerzijaTablica> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.IzvodVerzijaTablica> GetData(List<Model.Data.Field.IzvodVerzijaTablica> fields, List<Model.Data.Filter.IzvodVerzijaTablica>  filter, List<Model.Data.Sort.IzvodVerzijaTablica>  sort, long? start = null, long? count = null);
    }
}
