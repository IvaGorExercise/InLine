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
    
    public partial interface ISubjektTablica
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.SubjektTablicaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.SubjektTablicaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.SubjektTablicaItem item);
    	IEnumerable<Model.Data.SubjektTablica> SelectResult(int? IDSubjektTablica);
    	Model.Data.SubjektTablica InsertResult(Model.Data.Item.SubjektTablicaItem item);
    	Model.Data.SubjektTablica UpdateResult(Model.Data.Item.SubjektTablicaItem item);
    	int DeleteResult(Model.Data.Item.SubjektTablicaItem item);
    	
        Model.Data.SubjektTablica FindID(long id);
        //IEnumerable<Model.Data.SubjektTablica> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.SubjektTablica> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.SubjektTablica> GetData(List<Model.Data.Field.SubjektTablica> fields, List<Model.Data.Filter.SubjektTablica>  filter, List<Model.Data.Sort.SubjektTablica>  sort, long? start = null, long? count = null);
    }
}
