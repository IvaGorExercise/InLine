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
    
    public partial interface IObjektGrObjektGr
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.ObjektGrObjektGrItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.ObjektGrObjektGrItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.ObjektGrObjektGrItem item);
    	IEnumerable<Model.Data.ObjektGrObjektGr> SelectResult(long? ID_ObjektGrObjektGr);
    	Model.Data.ObjektGrObjektGr InsertResult(Model.Data.Item.ObjektGrObjektGrItem item);
    	Model.Data.ObjektGrObjektGr UpdateResult(Model.Data.Item.ObjektGrObjektGrItem item);
    	int DeleteResult(Model.Data.Item.ObjektGrObjektGrItem item);
    	
        Model.Data.ObjektGrObjektGr FindID(long id);
        //IEnumerable<Model.Data.ObjektGrObjektGr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.ObjektGrObjektGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.ObjektGrObjektGr> GetData(List<Model.Data.Field.ObjektGrObjektGr> fields, List<Model.Data.Filter.ObjektGrObjektGr>  filter, List<Model.Data.Sort.ObjektGrObjektGr>  sort, long? start = null, long? count = null);
    }
}