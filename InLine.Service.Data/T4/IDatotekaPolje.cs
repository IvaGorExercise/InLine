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
    
    public partial interface IDatotekaPolje
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.DatotekaPoljeItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.DatotekaPoljeItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.DatotekaPoljeItem item);
    	IEnumerable<Model.Data.DatotekaPolje> SelectResult(long? ID_DatotekaPolje);
    	Model.Data.DatotekaPolje InsertResult(Model.Data.Item.DatotekaPoljeItem item);
    	Model.Data.DatotekaPolje UpdateResult(Model.Data.Item.DatotekaPoljeItem item);
    	int DeleteResult(Model.Data.Item.DatotekaPoljeItem item);
    	
        Model.Data.DatotekaPolje FindID(long id);
        //IEnumerable<Model.Data.DatotekaPolje> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.DatotekaPolje> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.DatotekaPolje> GetData(List<Model.Data.Field.DatotekaPolje> fields, List<Model.Data.Filter.DatotekaPolje>  filter, List<Model.Data.Sort.DatotekaPolje>  sort, long? start = null, long? count = null);
    }
}
