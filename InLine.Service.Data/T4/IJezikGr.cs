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
    
    public partial interface IJezikGr
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.JezikGrItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.JezikGrItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.JezikGrItem item);
    	IEnumerable<Model.Data.JezikGr> SelectResult(long? ID_JezikGr);
    	Model.Data.JezikGr InsertResult(Model.Data.Item.JezikGrItem item);
    	Model.Data.JezikGr UpdateResult(Model.Data.Item.JezikGrItem item);
    	int DeleteResult(Model.Data.Item.JezikGrItem item);
    	
        Model.Data.JezikGr FindID(long id);
        //IEnumerable<Model.Data.JezikGr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.JezikGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.JezikGr> GetData(List<Model.Data.Field.JezikGr> fields, List<Model.Data.Filter.JezikGr>  filter, List<Model.Data.Sort.JezikGr>  sort, long? start = null, long? count = null);
    }
}
