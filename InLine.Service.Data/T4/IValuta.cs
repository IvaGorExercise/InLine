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
    
    public partial interface IValuta
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.ValutaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.ValutaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.ValutaItem item);
    	IEnumerable<Model.Data.Valuta> SelectResult(string IDValuta);
    	Model.Data.Valuta InsertResult(Model.Data.Item.ValutaItem item);
    	Model.Data.Valuta UpdateResult(Model.Data.Item.ValutaItem item);
    	int DeleteResult(Model.Data.Item.ValutaItem item);
    	
        Model.Data.Valuta FindID(long id);
        //IEnumerable<Model.Data.Valuta> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.Valuta> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.Valuta> GetData(List<Model.Data.Field.Valuta> fields, List<Model.Data.Filter.Valuta>  filter, List<Model.Data.Sort.Valuta>  sort, long? start = null, long? count = null);
    }
}
