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
    
    public partial interface ISubjektVezaVr
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.SubjektVezaVrItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.SubjektVezaVrItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.SubjektVezaVrItem item);
    	IEnumerable<Model.Data.SubjektVezaVr> SelectResult(long? ID_SubjektVezaVr);
    	Model.Data.SubjektVezaVr InsertResult(Model.Data.Item.SubjektVezaVrItem item);
    	Model.Data.SubjektVezaVr UpdateResult(Model.Data.Item.SubjektVezaVrItem item);
    	int DeleteResult(Model.Data.Item.SubjektVezaVrItem item);
    	
        Model.Data.SubjektVezaVr FindID(long id);
        //IEnumerable<Model.Data.SubjektVezaVr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.SubjektVezaVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.SubjektVezaVr> GetData(List<Model.Data.Field.SubjektVezaVr> fields, List<Model.Data.Filter.SubjektVezaVr>  filter, List<Model.Data.Sort.SubjektVezaVr>  sort, long? start = null, long? count = null);
    }
}
