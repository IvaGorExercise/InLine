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
    
    public partial interface ISubjektVr
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.SubjektVrItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.SubjektVrItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.SubjektVrItem item);
    	IEnumerable<Model.Data.SubjektVr> SelectResult(int? IDSubjektVr);
    	Model.Data.SubjektVr InsertResult(Model.Data.Item.SubjektVrItem item);
    	Model.Data.SubjektVr UpdateResult(Model.Data.Item.SubjektVrItem item);
    	int DeleteResult(Model.Data.Item.SubjektVrItem item);
    	
        Model.Data.SubjektVr FindID(long id);
        //IEnumerable<Model.Data.SubjektVr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.SubjektVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.SubjektVr> GetData(List<Model.Data.Field.SubjektVr> fields, List<Model.Data.Filter.SubjektVr>  filter, List<Model.Data.Sort.SubjektVr>  sort, long? start = null, long? count = null);
    }
}
