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
    
    public partial interface IZapisVr
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.ZapisVrItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.ZapisVrItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.ZapisVrItem item);
    	IEnumerable<Model.Data.ZapisVr> SelectResult(int? IDZapisVr);
    	Model.Data.ZapisVr InsertResult(Model.Data.Item.ZapisVrItem item);
    	Model.Data.ZapisVr UpdateResult(Model.Data.Item.ZapisVrItem item);
    	int DeleteResult(Model.Data.Item.ZapisVrItem item);
    	
        Model.Data.ZapisVr FindID(long id);
        //IEnumerable<Model.Data.ZapisVr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.ZapisVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.ZapisVr> GetData(List<Model.Data.Field.ZapisVr> fields, List<Model.Data.Filter.ZapisVr>  filter, List<Model.Data.Sort.ZapisVr>  sort, long? start = null, long? count = null);
    }
}
