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
    
    public partial interface IPoslovniSubjekt
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.PoslovniSubjektItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.PoslovniSubjektItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.PoslovniSubjektItem item);
    	IEnumerable<Model.Data.PoslovniSubjekt> SelectResult(long? ID_PoslovniSubjekt);
    	Model.Data.PoslovniSubjekt InsertResult(Model.Data.Item.PoslovniSubjektItem item);
    	Model.Data.PoslovniSubjekt UpdateResult(Model.Data.Item.PoslovniSubjektItem item);
    	int DeleteResult(Model.Data.Item.PoslovniSubjektItem item);
    	
        Model.Data.PoslovniSubjekt FindID(long id);
        //IEnumerable<Model.Data.PoslovniSubjekt> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.PoslovniSubjekt> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.PoslovniSubjekt> GetData(List<Model.Data.Field.PoslovniSubjekt> fields, List<Model.Data.Filter.PoslovniSubjekt>  filter, List<Model.Data.Sort.PoslovniSubjekt>  sort, long? start = null, long? count = null);
    }
}
