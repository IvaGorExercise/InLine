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
    
    public partial interface IKontniPlanSkupGrKontniPlanSkup
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.KontniPlanSkupGrKontniPlanSkupItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.KontniPlanSkupGrKontniPlanSkupItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.KontniPlanSkupGrKontniPlanSkupItem item);
    	IEnumerable<Model.Data.KontniPlanSkupGrKontniPlanSkup> SelectResult(long? ID_KontniPlanSkupGrKontniPlanSkup);
    	Model.Data.KontniPlanSkupGrKontniPlanSkup InsertResult(Model.Data.Item.KontniPlanSkupGrKontniPlanSkupItem item);
    	Model.Data.KontniPlanSkupGrKontniPlanSkup UpdateResult(Model.Data.Item.KontniPlanSkupGrKontniPlanSkupItem item);
    	int DeleteResult(Model.Data.Item.KontniPlanSkupGrKontniPlanSkupItem item);
    	
        Model.Data.KontniPlanSkupGrKontniPlanSkup FindID(long id);
        //IEnumerable<Model.Data.KontniPlanSkupGrKontniPlanSkup> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.KontniPlanSkupGrKontniPlanSkup> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.KontniPlanSkupGrKontniPlanSkup> GetData(List<Model.Data.Field.KontniPlanSkupGrKontniPlanSkup> fields, List<Model.Data.Filter.KontniPlanSkupGrKontniPlanSkup>  filter, List<Model.Data.Sort.KontniPlanSkupGrKontniPlanSkup>  sort, long? start = null, long? count = null);
    }
}
