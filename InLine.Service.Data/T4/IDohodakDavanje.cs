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
    
    public partial interface IDohodakDavanje
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.DohodakDavanjeItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.DohodakDavanjeItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.DohodakDavanjeItem item);
    	IEnumerable<Model.Data.DohodakDavanje> SelectResult(long? ID_DohodakDavanje);
    	Model.Data.DohodakDavanje InsertResult(Model.Data.Item.DohodakDavanjeItem item);
    	Model.Data.DohodakDavanje UpdateResult(Model.Data.Item.DohodakDavanjeItem item);
    	int DeleteResult(Model.Data.Item.DohodakDavanjeItem item);
    	
        Model.Data.DohodakDavanje FindID(long id);
        //IEnumerable<Model.Data.DohodakDavanje> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.DohodakDavanje> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.DohodakDavanje> GetData(List<Model.Data.Field.DohodakDavanje> fields, List<Model.Data.Filter.DohodakDavanje>  filter, List<Model.Data.Sort.DohodakDavanje>  sort, long? start = null, long? count = null);
    }
}
