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
    
    public partial interface IDatotekaIzvod2012A
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.DatotekaIzvod2012AItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.DatotekaIzvod2012AItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.DatotekaIzvod2012AItem item);
    	IEnumerable<Model.Data.DatotekaIzvod2012A> SelectResult(long? ID_DatotekaIzvod2012A);
    	Model.Data.DatotekaIzvod2012A InsertResult(Model.Data.Item.DatotekaIzvod2012AItem item);
    	Model.Data.DatotekaIzvod2012A UpdateResult(Model.Data.Item.DatotekaIzvod2012AItem item);
    	int DeleteResult(Model.Data.Item.DatotekaIzvod2012AItem item);
    	
        Model.Data.DatotekaIzvod2012A FindID(long id);
        //IEnumerable<Model.Data.DatotekaIzvod2012A> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.DatotekaIzvod2012A> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.DatotekaIzvod2012A> GetData(List<Model.Data.Field.DatotekaIzvod2012A> fields, List<Model.Data.Filter.DatotekaIzvod2012A>  filter, List<Model.Data.Sort.DatotekaIzvod2012A>  sort, long? start = null, long? count = null);
    }
}
