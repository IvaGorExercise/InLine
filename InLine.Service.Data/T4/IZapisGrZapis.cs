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
    
    public partial interface IZapisGrZapis
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.ZapisGrZapisItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.ZapisGrZapisItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.ZapisGrZapisItem item);
    	IEnumerable<Model.Data.ZapisGrZapis> SelectResult(long? ID_ZapisGrZapis);
    	Model.Data.ZapisGrZapis InsertResult(Model.Data.Item.ZapisGrZapisItem item);
    	Model.Data.ZapisGrZapis UpdateResult(Model.Data.Item.ZapisGrZapisItem item);
    	int DeleteResult(Model.Data.Item.ZapisGrZapisItem item);
    	
        Model.Data.ZapisGrZapis FindID(long id);
        //IEnumerable<Model.Data.ZapisGrZapis> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.ZapisGrZapis> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.ZapisGrZapis> GetData(List<Model.Data.Field.ZapisGrZapis> fields, List<Model.Data.Filter.ZapisGrZapis>  filter, List<Model.Data.Sort.ZapisGrZapis>  sort, long? start = null, long? count = null);
    }
}
