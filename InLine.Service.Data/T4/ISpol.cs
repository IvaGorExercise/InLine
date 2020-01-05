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
    
    public partial interface ISpol
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.SpolItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.SpolItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.SpolItem item);
    	IEnumerable<Model.Data.Spol> SelectResult(string IDSpol);
    	Model.Data.Spol InsertResult(Model.Data.Item.SpolItem item);
    	Model.Data.Spol UpdateResult(Model.Data.Item.SpolItem item);
    	int DeleteResult(Model.Data.Item.SpolItem item);
    	
        Model.Data.Spol FindID(long id);
        //IEnumerable<Model.Data.Spol> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.Spol> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.Spol> GetData(List<Model.Data.Field.Spol> fields, List<Model.Data.Filter.Spol>  filter, List<Model.Data.Sort.Spol>  sort, long? start = null, long? count = null);
    }
}
