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
    
    public partial interface IHUBDokumentIzvor2013A
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.HUBDokumentIzvor2013AItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.HUBDokumentIzvor2013AItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.HUBDokumentIzvor2013AItem item);
    	IEnumerable<Model.Data.HUBDokumentIzvor2013A> SelectResult(int? IDHUBDokumentIzvor2013A);
    	Model.Data.HUBDokumentIzvor2013A InsertResult(Model.Data.Item.HUBDokumentIzvor2013AItem item);
    	Model.Data.HUBDokumentIzvor2013A UpdateResult(Model.Data.Item.HUBDokumentIzvor2013AItem item);
    	int DeleteResult(Model.Data.Item.HUBDokumentIzvor2013AItem item);
    	
        Model.Data.HUBDokumentIzvor2013A FindID(long id);
        //IEnumerable<Model.Data.HUBDokumentIzvor2013A> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.HUBDokumentIzvor2013A> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.HUBDokumentIzvor2013A> GetData(List<Model.Data.Field.HUBDokumentIzvor2013A> fields, List<Model.Data.Filter.HUBDokumentIzvor2013A>  filter, List<Model.Data.Sort.HUBDokumentIzvor2013A>  sort, long? start = null, long? count = null);
    }
}
