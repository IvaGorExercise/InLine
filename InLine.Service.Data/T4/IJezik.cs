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
    
    public partial interface IJezik
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.JezikItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.JezikItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.JezikItem item);
    	IEnumerable<Model.Data.Jezik> SelectResult(long? ID_Jezik);
    	Model.Data.Jezik InsertResult(Model.Data.Item.JezikItem item);
    	Model.Data.Jezik UpdateResult(Model.Data.Item.JezikItem item);
    	int DeleteResult(Model.Data.Item.JezikItem item);
    	
        Model.Data.Jezik FindID(long id);
        //IEnumerable<Model.Data.Jezik> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.Jezik> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.Jezik> GetData(List<Model.Data.Field.Jezik> fields, List<Model.Data.Filter.Jezik>  filter, List<Model.Data.Sort.Jezik>  sort, long? start = null, long? count = null);
    }
}
