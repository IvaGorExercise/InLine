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
    
    public partial interface IUlica
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.UlicaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.UlicaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.UlicaItem item);
    	IEnumerable<Model.Data.Ulica> SelectResult(long? ID_Ulica);
    	Model.Data.Ulica InsertResult(Model.Data.Item.UlicaItem item);
    	Model.Data.Ulica UpdateResult(Model.Data.Item.UlicaItem item);
    	int DeleteResult(Model.Data.Item.UlicaItem item);
    	
        Model.Data.Ulica FindID(long id);
        //IEnumerable<Model.Data.Ulica> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.Ulica> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.Ulica> GetData(List<Model.Data.Field.Ulica> fields, List<Model.Data.Filter.Ulica>  filter, List<Model.Data.Sort.Ulica>  sort, long? start = null, long? count = null);
    }
}
