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
    
    public partial interface IDatotekaIzvod
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.DatotekaIzvodItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.DatotekaIzvodItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.DatotekaIzvodItem item);
    	IEnumerable<Model.Data.DatotekaIzvod> SelectResult(long? ID_DatotekaIzvod);
    	Model.Data.DatotekaIzvod InsertResult(Model.Data.Item.DatotekaIzvodItem item);
    	Model.Data.DatotekaIzvod UpdateResult(Model.Data.Item.DatotekaIzvodItem item);
    	int DeleteResult(Model.Data.Item.DatotekaIzvodItem item);
    	
        Model.Data.DatotekaIzvod FindID(long id);
        //IEnumerable<Model.Data.DatotekaIzvod> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.DatotekaIzvod> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.DatotekaIzvod> GetData(List<Model.Data.Field.DatotekaIzvod> fields, List<Model.Data.Filter.DatotekaIzvod>  filter, List<Model.Data.Sort.DatotekaIzvod>  sort, long? start = null, long? count = null);
    }
}
