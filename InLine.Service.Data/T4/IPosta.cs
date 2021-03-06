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
    
    public partial interface IPosta
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.PostaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.PostaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.PostaItem item);
    	IEnumerable<Model.Data.Posta> SelectResult(long? ID_Posta);
    	Model.Data.Posta InsertResult(Model.Data.Item.PostaItem item);
    	Model.Data.Posta UpdateResult(Model.Data.Item.PostaItem item);
    	int DeleteResult(Model.Data.Item.PostaItem item);
    	
        Model.Data.Posta FindID(long id);
        //IEnumerable<Model.Data.Posta> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.Posta> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.Posta> GetData(List<Model.Data.Field.Posta> fields, List<Model.Data.Filter.Posta>  filter, List<Model.Data.Sort.Posta>  sort, long? start = null, long? count = null);
    }
}
