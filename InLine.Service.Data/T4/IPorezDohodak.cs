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
    
    public partial interface IPorezDohodak
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.PorezDohodakItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.PorezDohodakItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.PorezDohodakItem item);
    	IEnumerable<Model.Data.PorezDohodak> SelectResult(long? ID_PorezDohodak);
    	Model.Data.PorezDohodak InsertResult(Model.Data.Item.PorezDohodakItem item);
    	Model.Data.PorezDohodak UpdateResult(Model.Data.Item.PorezDohodakItem item);
    	int DeleteResult(Model.Data.Item.PorezDohodakItem item);
    	
        Model.Data.PorezDohodak FindID(long id);
        //IEnumerable<Model.Data.PorezDohodak> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.PorezDohodak> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.PorezDohodak> GetData(List<Model.Data.Field.PorezDohodak> fields, List<Model.Data.Filter.PorezDohodak>  filter, List<Model.Data.Sort.PorezDohodak>  sort, long? start = null, long? count = null);
    }
}