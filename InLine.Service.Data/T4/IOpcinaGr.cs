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
    
    public partial interface IOpcinaGr
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.OpcinaGrItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.OpcinaGrItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.OpcinaGrItem item);
    	IEnumerable<Model.Data.OpcinaGr> SelectResult(long? ID_OpcinaGr);
    	Model.Data.OpcinaGr InsertResult(Model.Data.Item.OpcinaGrItem item);
    	Model.Data.OpcinaGr UpdateResult(Model.Data.Item.OpcinaGrItem item);
    	int DeleteResult(Model.Data.Item.OpcinaGrItem item);
    	
        Model.Data.OpcinaGr FindID(long id);
        //IEnumerable<Model.Data.OpcinaGr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.OpcinaGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.OpcinaGr> GetData(List<Model.Data.Field.OpcinaGr> fields, List<Model.Data.Filter.OpcinaGr>  filter, List<Model.Data.Sort.OpcinaGr>  sort, long? start = null, long? count = null);
    }
}