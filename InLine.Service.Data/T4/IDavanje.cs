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
    
    public partial interface IDavanje
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.DavanjeItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.DavanjeItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.DavanjeItem item);
    	IEnumerable<Model.Data.Davanje> SelectResult(long? ID_Davanje);
    	Model.Data.Davanje InsertResult(Model.Data.Item.DavanjeItem item);
    	Model.Data.Davanje UpdateResult(Model.Data.Item.DavanjeItem item);
    	int DeleteResult(Model.Data.Item.DavanjeItem item);
    	
        Model.Data.Davanje FindID(long id);
        //IEnumerable<Model.Data.Davanje> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.Davanje> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.Davanje> GetData(List<Model.Data.Field.Davanje> fields, List<Model.Data.Filter.Davanje>  filter, List<Model.Data.Sort.Davanje>  sort, long? start = null, long? count = null);
    }
}
