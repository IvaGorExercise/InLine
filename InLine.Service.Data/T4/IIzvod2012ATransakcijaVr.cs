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
    
    public partial interface IIzvod2012ATransakcijaVr
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.Izvod2012ATransakcijaVrItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.Izvod2012ATransakcijaVrItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.Izvod2012ATransakcijaVrItem item);
    	IEnumerable<Model.Data.Izvod2012ATransakcijaVr> SelectResult(int? IDIzvod2012ATransakcijaVr);
    	Model.Data.Izvod2012ATransakcijaVr InsertResult(Model.Data.Item.Izvod2012ATransakcijaVrItem item);
    	Model.Data.Izvod2012ATransakcijaVr UpdateResult(Model.Data.Item.Izvod2012ATransakcijaVrItem item);
    	int DeleteResult(Model.Data.Item.Izvod2012ATransakcijaVrItem item);
    	
        Model.Data.Izvod2012ATransakcijaVr FindID(long id);
        //IEnumerable<Model.Data.Izvod2012ATransakcijaVr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.Izvod2012ATransakcijaVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.Izvod2012ATransakcijaVr> GetData(List<Model.Data.Field.Izvod2012ATransakcijaVr> fields, List<Model.Data.Filter.Izvod2012ATransakcijaVr>  filter, List<Model.Data.Sort.Izvod2012ATransakcijaVr>  sort, long? start = null, long? count = null);
    }
}