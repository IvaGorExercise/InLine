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
    
    public partial interface IDohodakPrimateljPrimitak
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.DohodakPrimateljPrimitakItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.DohodakPrimateljPrimitakItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.DohodakPrimateljPrimitakItem item);
    	IEnumerable<Model.Data.DohodakPrimateljPrimitak> SelectResult(long? ID_DohodakPrimateljPrimitak);
    	Model.Data.DohodakPrimateljPrimitak InsertResult(Model.Data.Item.DohodakPrimateljPrimitakItem item);
    	Model.Data.DohodakPrimateljPrimitak UpdateResult(Model.Data.Item.DohodakPrimateljPrimitakItem item);
    	int DeleteResult(Model.Data.Item.DohodakPrimateljPrimitakItem item);
    	
        Model.Data.DohodakPrimateljPrimitak FindID(long id);
        //IEnumerable<Model.Data.DohodakPrimateljPrimitak> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.DohodakPrimateljPrimitak> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.DohodakPrimateljPrimitak> GetData(List<Model.Data.Field.DohodakPrimateljPrimitak> fields, List<Model.Data.Filter.DohodakPrimateljPrimitak>  filter, List<Model.Data.Sort.DohodakPrimateljPrimitak>  sort, long? start = null, long? count = null);
    }
}
