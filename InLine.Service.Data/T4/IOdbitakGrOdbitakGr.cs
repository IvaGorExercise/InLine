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
    
    public partial interface IOdbitakGrOdbitakGr
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.OdbitakGrOdbitakGrItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.OdbitakGrOdbitakGrItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.OdbitakGrOdbitakGrItem item);
    	IEnumerable<Model.Data.OdbitakGrOdbitakGr> SelectResult(long? ID_OdbitakGrOdbitakGr);
    	Model.Data.OdbitakGrOdbitakGr InsertResult(Model.Data.Item.OdbitakGrOdbitakGrItem item);
    	Model.Data.OdbitakGrOdbitakGr UpdateResult(Model.Data.Item.OdbitakGrOdbitakGrItem item);
    	int DeleteResult(Model.Data.Item.OdbitakGrOdbitakGrItem item);
    	
        Model.Data.OdbitakGrOdbitakGr FindID(long id);
        //IEnumerable<Model.Data.OdbitakGrOdbitakGr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.OdbitakGrOdbitakGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.OdbitakGrOdbitakGr> GetData(List<Model.Data.Field.OdbitakGrOdbitakGr> fields, List<Model.Data.Filter.OdbitakGrOdbitakGr>  filter, List<Model.Data.Sort.OdbitakGrOdbitakGr>  sort, long? start = null, long? count = null);
    }
}