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
    
    public partial interface IIzvodStTemeljnica
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.IzvodStTemeljnicaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.IzvodStTemeljnicaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.IzvodStTemeljnicaItem item);
    	IEnumerable<Model.Data.IzvodStTemeljnica> SelectResult(long? ID_IzvodStTemeljnica);
    	Model.Data.IzvodStTemeljnica InsertResult(Model.Data.Item.IzvodStTemeljnicaItem item);
    	Model.Data.IzvodStTemeljnica UpdateResult(Model.Data.Item.IzvodStTemeljnicaItem item);
    	int DeleteResult(Model.Data.Item.IzvodStTemeljnicaItem item);
    	
        Model.Data.IzvodStTemeljnica FindID(long id);
        //IEnumerable<Model.Data.IzvodStTemeljnica> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.IzvodStTemeljnica> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.IzvodStTemeljnica> GetData(List<Model.Data.Field.IzvodStTemeljnica> fields, List<Model.Data.Filter.IzvodStTemeljnica>  filter, List<Model.Data.Sort.IzvodStTemeljnica>  sort, long? start = null, long? count = null);
    }
}
