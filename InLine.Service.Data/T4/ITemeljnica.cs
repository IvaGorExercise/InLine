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
    
    public partial interface ITemeljnica
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.TemeljnicaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.TemeljnicaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.TemeljnicaItem item);
    	IEnumerable<Model.Data.Temeljnica> SelectResult(long? ID_Temeljnica);
    	Model.Data.Temeljnica InsertResult(Model.Data.Item.TemeljnicaItem item);
    	Model.Data.Temeljnica UpdateResult(Model.Data.Item.TemeljnicaItem item);
    	int DeleteResult(Model.Data.Item.TemeljnicaItem item);
    	
        Model.Data.Temeljnica FindID(long id);
        //IEnumerable<Model.Data.Temeljnica> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.Temeljnica> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.Temeljnica> GetData(List<Model.Data.Field.Temeljnica> fields, List<Model.Data.Filter.Temeljnica>  filter, List<Model.Data.Sort.Temeljnica>  sort, long? start = null, long? count = null);
    }
}
