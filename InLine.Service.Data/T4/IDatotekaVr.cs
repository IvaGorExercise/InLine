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
    
    public partial interface IDatotekaVr
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.DatotekaVrItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.DatotekaVrItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.DatotekaVrItem item);
    	IEnumerable<Model.Data.DatotekaVr> SelectResult(long? ID_DatotekaVr);
    	Model.Data.DatotekaVr InsertResult(Model.Data.Item.DatotekaVrItem item);
    	Model.Data.DatotekaVr UpdateResult(Model.Data.Item.DatotekaVrItem item);
    	int DeleteResult(Model.Data.Item.DatotekaVrItem item);
    	
        Model.Data.DatotekaVr FindID(long id);
        //IEnumerable<Model.Data.DatotekaVr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.DatotekaVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.DatotekaVr> GetData(List<Model.Data.Field.DatotekaVr> fields, List<Model.Data.Filter.DatotekaVr>  filter, List<Model.Data.Sort.DatotekaVr>  sort, long? start = null, long? count = null);
    }
}