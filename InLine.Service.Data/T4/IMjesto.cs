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
    
    public partial interface IMjesto
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.MjestoItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.MjestoItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.MjestoItem item);
    	IEnumerable<Model.Data.Mjesto> SelectResult(long? ID_Mjesto);
    	Model.Data.Mjesto InsertResult(Model.Data.Item.MjestoItem item);
    	Model.Data.Mjesto UpdateResult(Model.Data.Item.MjestoItem item);
    	int DeleteResult(Model.Data.Item.MjestoItem item);
    	
        Model.Data.Mjesto FindID(long id);
        //IEnumerable<Model.Data.Mjesto> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.Mjesto> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.Mjesto> GetData(List<Model.Data.Field.Mjesto> fields, List<Model.Data.Filter.Mjesto>  filter, List<Model.Data.Sort.Mjesto>  sort, long? start = null, long? count = null);
    }
}
