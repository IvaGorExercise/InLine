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
    
    public partial interface IOdbitakGr
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.OdbitakGrItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.OdbitakGrItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.OdbitakGrItem item);
    	IEnumerable<Model.Data.OdbitakGr> SelectResult(long? ID_OdbitakGr);
    	Model.Data.OdbitakGr InsertResult(Model.Data.Item.OdbitakGrItem item);
    	Model.Data.OdbitakGr UpdateResult(Model.Data.Item.OdbitakGrItem item);
    	int DeleteResult(Model.Data.Item.OdbitakGrItem item);
    	
        Model.Data.OdbitakGr FindID(long id);
        //IEnumerable<Model.Data.OdbitakGr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.OdbitakGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.OdbitakGr> GetData(List<Model.Data.Field.OdbitakGr> fields, List<Model.Data.Filter.OdbitakGr>  filter, List<Model.Data.Sort.OdbitakGr>  sort, long? start = null, long? count = null);
    }
}
