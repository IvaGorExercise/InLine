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
    
    public partial interface IShema
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.ShemaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.ShemaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.ShemaItem item);
    	IEnumerable<Model.Data.Shema> SelectResult(long? ID_Shema);
    	Model.Data.Shema InsertResult(Model.Data.Item.ShemaItem item);
    	Model.Data.Shema UpdateResult(Model.Data.Item.ShemaItem item);
    	int DeleteResult(Model.Data.Item.ShemaItem item);
    	
        Model.Data.Shema FindID(long id);
        //IEnumerable<Model.Data.Shema> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.Shema> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.Shema> GetData(List<Model.Data.Field.Shema> fields, List<Model.Data.Filter.Shema>  filter, List<Model.Data.Sort.Shema>  sort, long? start = null, long? count = null);
    }
}
