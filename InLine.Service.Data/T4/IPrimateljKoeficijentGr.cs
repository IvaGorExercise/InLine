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
    
    public partial interface IPrimateljKoeficijentGr
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.PrimateljKoeficijentGrItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.PrimateljKoeficijentGrItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.PrimateljKoeficijentGrItem item);
    	IEnumerable<Model.Data.PrimateljKoeficijentGr> SelectResult(long? ID_PrimateljKoeficijentGr);
    	Model.Data.PrimateljKoeficijentGr InsertResult(Model.Data.Item.PrimateljKoeficijentGrItem item);
    	Model.Data.PrimateljKoeficijentGr UpdateResult(Model.Data.Item.PrimateljKoeficijentGrItem item);
    	int DeleteResult(Model.Data.Item.PrimateljKoeficijentGrItem item);
    	
        Model.Data.PrimateljKoeficijentGr FindID(long id);
        //IEnumerable<Model.Data.PrimateljKoeficijentGr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.PrimateljKoeficijentGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.PrimateljKoeficijentGr> GetData(List<Model.Data.Field.PrimateljKoeficijentGr> fields, List<Model.Data.Filter.PrimateljKoeficijentGr>  filter, List<Model.Data.Sort.PrimateljKoeficijentGr>  sort, long? start = null, long? count = null);
    }
}
