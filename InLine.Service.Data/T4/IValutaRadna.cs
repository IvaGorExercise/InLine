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
    
    public partial interface IValutaRadna
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.ValutaRadnaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.ValutaRadnaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.ValutaRadnaItem item);
    	IEnumerable<Model.Data.ValutaRadna> SelectResult(long? ID_Valuta);
    	Model.Data.ValutaRadna InsertResult(Model.Data.Item.ValutaRadnaItem item);
    	Model.Data.ValutaRadna UpdateResult(Model.Data.Item.ValutaRadnaItem item);
    	int DeleteResult(Model.Data.Item.ValutaRadnaItem item);
    	
        Model.Data.ValutaRadna FindID(long id);
        //IEnumerable<Model.Data.ValutaRadna> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.ValutaRadna> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.ValutaRadna> GetData(List<Model.Data.Field.ValutaRadna> fields, List<Model.Data.Filter.ValutaRadna>  filter, List<Model.Data.Sort.ValutaRadna>  sort, long? start = null, long? count = null);
    }
}