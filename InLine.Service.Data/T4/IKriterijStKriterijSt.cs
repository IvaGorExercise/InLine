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
    
    public partial interface IKriterijStKriterijSt
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.KriterijStKriterijStItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.KriterijStKriterijStItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.KriterijStKriterijStItem item);
    	IEnumerable<Model.Data.KriterijStKriterijSt> SelectResult(long? ID_KriterijStKriterijSt);
    	Model.Data.KriterijStKriterijSt InsertResult(Model.Data.Item.KriterijStKriterijStItem item);
    	Model.Data.KriterijStKriterijSt UpdateResult(Model.Data.Item.KriterijStKriterijStItem item);
    	int DeleteResult(Model.Data.Item.KriterijStKriterijStItem item);
    	
        Model.Data.KriterijStKriterijSt FindID(long id);
        //IEnumerable<Model.Data.KriterijStKriterijSt> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.KriterijStKriterijSt> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.KriterijStKriterijSt> GetData(List<Model.Data.Field.KriterijStKriterijSt> fields, List<Model.Data.Filter.KriterijStKriterijSt>  filter, List<Model.Data.Sort.KriterijStKriterijSt>  sort, long? start = null, long? count = null);
    }
}
