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
    
    public partial interface IOperatorVremenski
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.OperatorVremenskiItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.OperatorVremenskiItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.OperatorVremenskiItem item);
    	IEnumerable<Model.Data.OperatorVremenski> SelectResult(string VremenskiOperator);
    	Model.Data.OperatorVremenski InsertResult(Model.Data.Item.OperatorVremenskiItem item);
    	Model.Data.OperatorVremenski UpdateResult(Model.Data.Item.OperatorVremenskiItem item);
    	int DeleteResult(Model.Data.Item.OperatorVremenskiItem item);
    	
        Model.Data.OperatorVremenski FindID(long id);
        //IEnumerable<Model.Data.OperatorVremenski> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.OperatorVremenski> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.OperatorVremenski> GetData(List<Model.Data.Field.OperatorVremenski> fields, List<Model.Data.Filter.OperatorVremenski>  filter, List<Model.Data.Sort.OperatorVremenski>  sort, long? start = null, long? count = null);
    }
}
