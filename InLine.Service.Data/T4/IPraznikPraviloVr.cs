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
    
    public partial interface IPraznikPraviloVr
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.PraznikPraviloVrItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.PraznikPraviloVrItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.PraznikPraviloVrItem item);
    	IEnumerable<Model.Data.PraznikPraviloVr> SelectResult(long? ID_PraznikPraviloVr);
    	Model.Data.PraznikPraviloVr InsertResult(Model.Data.Item.PraznikPraviloVrItem item);
    	Model.Data.PraznikPraviloVr UpdateResult(Model.Data.Item.PraznikPraviloVrItem item);
    	int DeleteResult(Model.Data.Item.PraznikPraviloVrItem item);
    	
        Model.Data.PraznikPraviloVr FindID(long id);
        //IEnumerable<Model.Data.PraznikPraviloVr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.PraznikPraviloVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.PraznikPraviloVr> GetData(List<Model.Data.Field.PraznikPraviloVr> fields, List<Model.Data.Filter.PraznikPraviloVr>  filter, List<Model.Data.Sort.PraznikPraviloVr>  sort, long? start = null, long? count = null);
    }
}