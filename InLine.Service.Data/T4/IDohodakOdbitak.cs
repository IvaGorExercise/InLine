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
    
    public partial interface IDohodakOdbitak
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.DohodakOdbitakItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.DohodakOdbitakItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.DohodakOdbitakItem item);
    	IEnumerable<Model.Data.DohodakOdbitak> SelectResult(long? ID_DohodakOdbitak);
    	Model.Data.DohodakOdbitak InsertResult(Model.Data.Item.DohodakOdbitakItem item);
    	Model.Data.DohodakOdbitak UpdateResult(Model.Data.Item.DohodakOdbitakItem item);
    	int DeleteResult(Model.Data.Item.DohodakOdbitakItem item);
    	
        Model.Data.DohodakOdbitak FindID(long id);
        //IEnumerable<Model.Data.DohodakOdbitak> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.DohodakOdbitak> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.DohodakOdbitak> GetData(List<Model.Data.Field.DohodakOdbitak> fields, List<Model.Data.Filter.DohodakOdbitak>  filter, List<Model.Data.Sort.DohodakOdbitak>  sort, long? start = null, long? count = null);
    }
}