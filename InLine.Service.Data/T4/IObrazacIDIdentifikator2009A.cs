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
    
    public partial interface IObrazacIDIdentifikator2009A
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.ObrazacIDIdentifikator2009AItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.ObrazacIDIdentifikator2009AItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.ObrazacIDIdentifikator2009AItem item);
    	IEnumerable<Model.Data.ObrazacIDIdentifikator2009A> SelectResult(int? IDObrazacIDIdentifikator2009A);
    	Model.Data.ObrazacIDIdentifikator2009A InsertResult(Model.Data.Item.ObrazacIDIdentifikator2009AItem item);
    	Model.Data.ObrazacIDIdentifikator2009A UpdateResult(Model.Data.Item.ObrazacIDIdentifikator2009AItem item);
    	int DeleteResult(Model.Data.Item.ObrazacIDIdentifikator2009AItem item);
    	
        Model.Data.ObrazacIDIdentifikator2009A FindID(long id);
        //IEnumerable<Model.Data.ObrazacIDIdentifikator2009A> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.ObrazacIDIdentifikator2009A> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.ObrazacIDIdentifikator2009A> GetData(List<Model.Data.Field.ObrazacIDIdentifikator2009A> fields, List<Model.Data.Filter.ObrazacIDIdentifikator2009A>  filter, List<Model.Data.Sort.ObrazacIDIdentifikator2009A>  sort, long? start = null, long? count = null);
    }
}