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
    
    public partial interface ISubjektGrSubjektGr
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.SubjektGrSubjektGrItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.SubjektGrSubjektGrItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.SubjektGrSubjektGrItem item);
    	IEnumerable<Model.Data.SubjektGrSubjektGr> SelectResult(long? ID_SubjektGrSubjektGr);
    	Model.Data.SubjektGrSubjektGr InsertResult(Model.Data.Item.SubjektGrSubjektGrItem item);
    	Model.Data.SubjektGrSubjektGr UpdateResult(Model.Data.Item.SubjektGrSubjektGrItem item);
    	int DeleteResult(Model.Data.Item.SubjektGrSubjektGrItem item);
    	
        Model.Data.SubjektGrSubjektGr FindID(long id);
        //IEnumerable<Model.Data.SubjektGrSubjektGr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.SubjektGrSubjektGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.SubjektGrSubjektGr> GetData(List<Model.Data.Field.SubjektGrSubjektGr> fields, List<Model.Data.Filter.SubjektGrSubjektGr>  filter, List<Model.Data.Sort.SubjektGrSubjektGr>  sort, long? start = null, long? count = null);
    }
}
