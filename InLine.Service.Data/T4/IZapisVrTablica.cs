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
    
    public partial interface IZapisVrTablica
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.ZapisVrTablicaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.ZapisVrTablicaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.ZapisVrTablicaItem item);
    	IEnumerable<Model.Data.ZapisVrTablica> SelectResult(int? IDZapisVr,int? IDZapisTablica);
    	Model.Data.ZapisVrTablica InsertResult(Model.Data.Item.ZapisVrTablicaItem item);
    	Model.Data.ZapisVrTablica UpdateResult(Model.Data.Item.ZapisVrTablicaItem item);
    	int DeleteResult(Model.Data.Item.ZapisVrTablicaItem item);
    	
        Model.Data.ZapisVrTablica FindID(long id);
        //IEnumerable<Model.Data.ZapisVrTablica> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.ZapisVrTablica> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.ZapisVrTablica> GetData(List<Model.Data.Field.ZapisVrTablica> fields, List<Model.Data.Filter.ZapisVrTablica>  filter, List<Model.Data.Sort.ZapisVrTablica>  sort, long? start = null, long? count = null);
    }
}
