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
    
    public partial interface IObveznicaJavnogDuga
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.ObveznicaJavnogDugaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.ObveznicaJavnogDugaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.ObveznicaJavnogDugaItem item);
    	IEnumerable<Model.Data.ObveznicaJavnogDuga> SelectResult(long? ID_ObveznicaJavnogDuga);
    	Model.Data.ObveznicaJavnogDuga InsertResult(Model.Data.Item.ObveznicaJavnogDugaItem item);
    	Model.Data.ObveznicaJavnogDuga UpdateResult(Model.Data.Item.ObveznicaJavnogDugaItem item);
    	int DeleteResult(Model.Data.Item.ObveznicaJavnogDugaItem item);
    	
        Model.Data.ObveznicaJavnogDuga FindID(long id);
        //IEnumerable<Model.Data.ObveznicaJavnogDuga> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.ObveznicaJavnogDuga> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.ObveznicaJavnogDuga> GetData(List<Model.Data.Field.ObveznicaJavnogDuga> fields, List<Model.Data.Filter.ObveznicaJavnogDuga>  filter, List<Model.Data.Sort.ObveznicaJavnogDuga>  sort, long? start = null, long? count = null);
    }
}