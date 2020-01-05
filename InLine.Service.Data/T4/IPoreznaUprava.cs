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
    
    public partial interface IPoreznaUprava
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.PoreznaUpravaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.PoreznaUpravaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.PoreznaUpravaItem item);
    	IEnumerable<Model.Data.PoreznaUprava> SelectResult(long? ID_PoreznaUprava);
    	Model.Data.PoreznaUprava InsertResult(Model.Data.Item.PoreznaUpravaItem item);
    	Model.Data.PoreznaUprava UpdateResult(Model.Data.Item.PoreznaUpravaItem item);
    	int DeleteResult(Model.Data.Item.PoreznaUpravaItem item);
    	
        Model.Data.PoreznaUprava FindID(long id);
        //IEnumerable<Model.Data.PoreznaUprava> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.PoreznaUprava> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.PoreznaUprava> GetData(List<Model.Data.Field.PoreznaUprava> fields, List<Model.Data.Filter.PoreznaUprava>  filter, List<Model.Data.Sort.PoreznaUprava>  sort, long? start = null, long? count = null);
    }
}
