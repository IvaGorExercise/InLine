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
    
    public partial interface ITecaj
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.TecajItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.TecajItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.TecajItem item);
    	IEnumerable<Model.Data.Tecaj> SelectResult(long? ID_Tecaj);
    	Model.Data.Tecaj InsertResult(Model.Data.Item.TecajItem item);
    	Model.Data.Tecaj UpdateResult(Model.Data.Item.TecajItem item);
    	int DeleteResult(Model.Data.Item.TecajItem item);
    	
        Model.Data.Tecaj FindID(long id);
        //IEnumerable<Model.Data.Tecaj> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.Tecaj> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.Tecaj> GetData(List<Model.Data.Field.Tecaj> fields, List<Model.Data.Filter.Tecaj>  filter, List<Model.Data.Sort.Tecaj>  sort, long? start = null, long? count = null);
    }
}
