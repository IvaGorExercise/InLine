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
    
    public partial interface IMjestoGr
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.MjestoGrItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.MjestoGrItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.MjestoGrItem item);
    	IEnumerable<Model.Data.MjestoGr> SelectResult(long? ID_MjestoGr);
    	Model.Data.MjestoGr InsertResult(Model.Data.Item.MjestoGrItem item);
    	Model.Data.MjestoGr UpdateResult(Model.Data.Item.MjestoGrItem item);
    	int DeleteResult(Model.Data.Item.MjestoGrItem item);
    	
        Model.Data.MjestoGr FindID(long id);
        //IEnumerable<Model.Data.MjestoGr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.MjestoGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.MjestoGr> GetData(List<Model.Data.Field.MjestoGr> fields, List<Model.Data.Filter.MjestoGr>  filter, List<Model.Data.Sort.MjestoGr>  sort, long? start = null, long? count = null);
    }
}