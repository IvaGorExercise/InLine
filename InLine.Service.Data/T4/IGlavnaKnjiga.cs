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
    
    public partial interface IGlavnaKnjiga
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.GlavnaKnjigaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.GlavnaKnjigaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.GlavnaKnjigaItem item);
    	IEnumerable<Model.Data.GlavnaKnjiga> SelectResult(long? ID_GlavnaKnjiga);
    	Model.Data.GlavnaKnjiga InsertResult(Model.Data.Item.GlavnaKnjigaItem item);
    	Model.Data.GlavnaKnjiga UpdateResult(Model.Data.Item.GlavnaKnjigaItem item);
    	int DeleteResult(Model.Data.Item.GlavnaKnjigaItem item);
    	
        Model.Data.GlavnaKnjiga FindID(long id);
        //IEnumerable<Model.Data.GlavnaKnjiga> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.GlavnaKnjiga> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.GlavnaKnjiga> GetData(List<Model.Data.Field.GlavnaKnjiga> fields, List<Model.Data.Filter.GlavnaKnjiga>  filter, List<Model.Data.Sort.GlavnaKnjiga>  sort, long? start = null, long? count = null);
    }
}
