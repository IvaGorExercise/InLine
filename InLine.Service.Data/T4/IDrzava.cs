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
    
    public partial interface IDrzava
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.DrzavaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.DrzavaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.DrzavaItem item);
    	IEnumerable<Model.Data.Drzava> SelectResult(string IDDrzava);
    	Model.Data.Drzava InsertResult(Model.Data.Item.DrzavaItem item);
    	Model.Data.Drzava UpdateResult(Model.Data.Item.DrzavaItem item);
    	int DeleteResult(Model.Data.Item.DrzavaItem item);
    	
        Model.Data.Drzava FindID(long id);
        //IEnumerable<Model.Data.Drzava> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.Drzava> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.Drzava> GetData(List<Model.Data.Field.Drzava> fields, List<Model.Data.Filter.Drzava>  filter, List<Model.Data.Sort.Drzava>  sort, long? start = null, long? count = null);
    }
}
