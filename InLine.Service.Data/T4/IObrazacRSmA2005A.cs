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
    
    public partial interface IObrazacRSmA2005A
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.ObrazacRSmA2005AItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.ObrazacRSmA2005AItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.ObrazacRSmA2005AItem item);
    	IEnumerable<Model.Data.ObrazacRSmA2005A> SelectResult(long? ID_ObrazacRSmA2005A);
    	Model.Data.ObrazacRSmA2005A InsertResult(Model.Data.Item.ObrazacRSmA2005AItem item);
    	Model.Data.ObrazacRSmA2005A UpdateResult(Model.Data.Item.ObrazacRSmA2005AItem item);
    	int DeleteResult(Model.Data.Item.ObrazacRSmA2005AItem item);
    	
        Model.Data.ObrazacRSmA2005A FindID(long id);
        //IEnumerable<Model.Data.ObrazacRSmA2005A> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.ObrazacRSmA2005A> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.ObrazacRSmA2005A> GetData(List<Model.Data.Field.ObrazacRSmA2005A> fields, List<Model.Data.Filter.ObrazacRSmA2005A>  filter, List<Model.Data.Sort.ObrazacRSmA2005A>  sort, long? start = null, long? count = null);
    }
}