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
    
    public partial interface IZapisGrZapisGr
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.ZapisGrZapisGrItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.ZapisGrZapisGrItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.ZapisGrZapisGrItem item);
    	IEnumerable<Model.Data.ZapisGrZapisGr> SelectResult(long? ID_ZapisGrZapisGr);
    	Model.Data.ZapisGrZapisGr InsertResult(Model.Data.Item.ZapisGrZapisGrItem item);
    	Model.Data.ZapisGrZapisGr UpdateResult(Model.Data.Item.ZapisGrZapisGrItem item);
    	int DeleteResult(Model.Data.Item.ZapisGrZapisGrItem item);
    	
        Model.Data.ZapisGrZapisGr FindID(long id);
        //IEnumerable<Model.Data.ZapisGrZapisGr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.ZapisGrZapisGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.ZapisGrZapisGr> GetData(List<Model.Data.Field.ZapisGrZapisGr> fields, List<Model.Data.Filter.ZapisGrZapisGr>  filter, List<Model.Data.Sort.ZapisGrZapisGr>  sort, long? start = null, long? count = null);
    }
}
