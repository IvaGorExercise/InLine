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
    
    public partial interface IUgovorStanOtkupObrokPreplata
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.UgovorStanOtkupObrokPreplataItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.UgovorStanOtkupObrokPreplataItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.UgovorStanOtkupObrokPreplataItem item);
    	IEnumerable<Model.Data.UgovorStanOtkupObrokPreplata> SelectResult(long? ID_UgovorStanOtkupObrokPreplata);
    	Model.Data.UgovorStanOtkupObrokPreplata InsertResult(Model.Data.Item.UgovorStanOtkupObrokPreplataItem item);
    	Model.Data.UgovorStanOtkupObrokPreplata UpdateResult(Model.Data.Item.UgovorStanOtkupObrokPreplataItem item);
    	int DeleteResult(Model.Data.Item.UgovorStanOtkupObrokPreplataItem item);
    	
        Model.Data.UgovorStanOtkupObrokPreplata FindID(long id);
        //IEnumerable<Model.Data.UgovorStanOtkupObrokPreplata> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.UgovorStanOtkupObrokPreplata> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.UgovorStanOtkupObrokPreplata> GetData(List<Model.Data.Field.UgovorStanOtkupObrokPreplata> fields, List<Model.Data.Filter.UgovorStanOtkupObrokPreplata>  filter, List<Model.Data.Sort.UgovorStanOtkupObrokPreplata>  sort, long? start = null, long? count = null);
    }
}