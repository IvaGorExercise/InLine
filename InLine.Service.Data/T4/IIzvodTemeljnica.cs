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
    
    public partial interface IIzvodTemeljnica
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.IzvodTemeljnicaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.IzvodTemeljnicaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.IzvodTemeljnicaItem item);
    	IEnumerable<Model.Data.IzvodTemeljnica> SelectResult(long? ID_IzvodTemeljnica);
    	Model.Data.IzvodTemeljnica InsertResult(Model.Data.Item.IzvodTemeljnicaItem item);
    	Model.Data.IzvodTemeljnica UpdateResult(Model.Data.Item.IzvodTemeljnicaItem item);
    	int DeleteResult(Model.Data.Item.IzvodTemeljnicaItem item);
    	
        Model.Data.IzvodTemeljnica FindID(long id);
        //IEnumerable<Model.Data.IzvodTemeljnica> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.IzvodTemeljnica> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.IzvodTemeljnica> GetData(List<Model.Data.Field.IzvodTemeljnica> fields, List<Model.Data.Filter.IzvodTemeljnica>  filter, List<Model.Data.Sort.IzvodTemeljnica>  sort, long? start = null, long? count = null);
    }
}
