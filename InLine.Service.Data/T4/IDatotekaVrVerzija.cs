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
    
    public partial interface IDatotekaVrVerzija
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.DatotekaVrVerzijaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.DatotekaVrVerzijaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.DatotekaVrVerzijaItem item);
    	IEnumerable<Model.Data.DatotekaVrVerzija> SelectResult(long? ID_DatotekaVrVerzija);
    	Model.Data.DatotekaVrVerzija InsertResult(Model.Data.Item.DatotekaVrVerzijaItem item);
    	Model.Data.DatotekaVrVerzija UpdateResult(Model.Data.Item.DatotekaVrVerzijaItem item);
    	int DeleteResult(Model.Data.Item.DatotekaVrVerzijaItem item);
    	
        Model.Data.DatotekaVrVerzija FindID(long id);
        //IEnumerable<Model.Data.DatotekaVrVerzija> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.DatotekaVrVerzija> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.DatotekaVrVerzija> GetData(List<Model.Data.Field.DatotekaVrVerzija> fields, List<Model.Data.Filter.DatotekaVrVerzija>  filter, List<Model.Data.Sort.DatotekaVrVerzija>  sort, long? start = null, long? count = null);
    }
}
