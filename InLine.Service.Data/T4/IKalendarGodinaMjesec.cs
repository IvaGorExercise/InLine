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
    
    public partial interface IKalendarGodinaMjesec
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.KalendarGodinaMjesecItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.KalendarGodinaMjesecItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.KalendarGodinaMjesecItem item);
    	IEnumerable<Model.Data.KalendarGodinaMjesec> SelectResult(int? Godina,int? Mjesec);
    	Model.Data.KalendarGodinaMjesec InsertResult(Model.Data.Item.KalendarGodinaMjesecItem item);
    	Model.Data.KalendarGodinaMjesec UpdateResult(Model.Data.Item.KalendarGodinaMjesecItem item);
    	int DeleteResult(Model.Data.Item.KalendarGodinaMjesecItem item);
    	
        Model.Data.KalendarGodinaMjesec FindID(long id);
        //IEnumerable<Model.Data.KalendarGodinaMjesec> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.KalendarGodinaMjesec> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.KalendarGodinaMjesec> GetData(List<Model.Data.Field.KalendarGodinaMjesec> fields, List<Model.Data.Filter.KalendarGodinaMjesec>  filter, List<Model.Data.Sort.KalendarGodinaMjesec>  sort, long? start = null, long? count = null);
    }
}
