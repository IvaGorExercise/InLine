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
    
    public partial interface IUgovorStanOtkupOpomena
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.UgovorStanOtkupOpomenaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.UgovorStanOtkupOpomenaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.UgovorStanOtkupOpomenaItem item);
    	IEnumerable<Model.Data.UgovorStanOtkupOpomena> SelectResult(long? ID_UgovorStanOtkupOpomena);
    	Model.Data.UgovorStanOtkupOpomena InsertResult(Model.Data.Item.UgovorStanOtkupOpomenaItem item);
    	Model.Data.UgovorStanOtkupOpomena UpdateResult(Model.Data.Item.UgovorStanOtkupOpomenaItem item);
    	int DeleteResult(Model.Data.Item.UgovorStanOtkupOpomenaItem item);
    	
        Model.Data.UgovorStanOtkupOpomena FindID(long id);
        //IEnumerable<Model.Data.UgovorStanOtkupOpomena> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.UgovorStanOtkupOpomena> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.UgovorStanOtkupOpomena> GetData(List<Model.Data.Field.UgovorStanOtkupOpomena> fields, List<Model.Data.Filter.UgovorStanOtkupOpomena>  filter, List<Model.Data.Sort.UgovorStanOtkupOpomena>  sort, long? start = null, long? count = null);
    }
}
