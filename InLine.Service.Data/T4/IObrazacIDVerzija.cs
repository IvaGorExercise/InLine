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
    
    public partial interface IObrazacIDVerzija
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.ObrazacIDVerzijaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.ObrazacIDVerzijaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.ObrazacIDVerzijaItem item);
    	IEnumerable<Model.Data.ObrazacIDVerzija> SelectResult(int? IDObrazacIDVerzija);
    	Model.Data.ObrazacIDVerzija InsertResult(Model.Data.Item.ObrazacIDVerzijaItem item);
    	Model.Data.ObrazacIDVerzija UpdateResult(Model.Data.Item.ObrazacIDVerzijaItem item);
    	int DeleteResult(Model.Data.Item.ObrazacIDVerzijaItem item);
    	
        Model.Data.ObrazacIDVerzija FindID(long id);
        //IEnumerable<Model.Data.ObrazacIDVerzija> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.ObrazacIDVerzija> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.ObrazacIDVerzija> GetData(List<Model.Data.Field.ObrazacIDVerzija> fields, List<Model.Data.Filter.ObrazacIDVerzija>  filter, List<Model.Data.Sort.ObrazacIDVerzija>  sort, long? start = null, long? count = null);
    }
}
