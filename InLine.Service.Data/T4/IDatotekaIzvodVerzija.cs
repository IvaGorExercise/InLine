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
    
    public partial interface IDatotekaIzvodVerzija
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.DatotekaIzvodVerzijaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.DatotekaIzvodVerzijaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.DatotekaIzvodVerzijaItem item);
    	IEnumerable<Model.Data.DatotekaIzvodVerzija> SelectResult(int? IDDatotekaIzvodVerzija);
    	Model.Data.DatotekaIzvodVerzija InsertResult(Model.Data.Item.DatotekaIzvodVerzijaItem item);
    	Model.Data.DatotekaIzvodVerzija UpdateResult(Model.Data.Item.DatotekaIzvodVerzijaItem item);
    	int DeleteResult(Model.Data.Item.DatotekaIzvodVerzijaItem item);
    	
        Model.Data.DatotekaIzvodVerzija FindID(long id);
        //IEnumerable<Model.Data.DatotekaIzvodVerzija> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.DatotekaIzvodVerzija> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.DatotekaIzvodVerzija> GetData(List<Model.Data.Field.DatotekaIzvodVerzija> fields, List<Model.Data.Filter.DatotekaIzvodVerzija>  filter, List<Model.Data.Sort.DatotekaIzvodVerzija>  sort, long? start = null, long? count = null);
    }
}
