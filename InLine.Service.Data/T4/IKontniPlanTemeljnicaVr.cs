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
    
    public partial interface IKontniPlanTemeljnicaVr
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.KontniPlanTemeljnicaVrItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.KontniPlanTemeljnicaVrItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.KontniPlanTemeljnicaVrItem item);
    	IEnumerable<Model.Data.KontniPlanTemeljnicaVr> SelectResult(long? ID_KontniPlanTemeljnicaVr);
    	Model.Data.KontniPlanTemeljnicaVr InsertResult(Model.Data.Item.KontniPlanTemeljnicaVrItem item);
    	Model.Data.KontniPlanTemeljnicaVr UpdateResult(Model.Data.Item.KontniPlanTemeljnicaVrItem item);
    	int DeleteResult(Model.Data.Item.KontniPlanTemeljnicaVrItem item);
    	
        Model.Data.KontniPlanTemeljnicaVr FindID(long id);
        //IEnumerable<Model.Data.KontniPlanTemeljnicaVr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.KontniPlanTemeljnicaVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.KontniPlanTemeljnicaVr> GetData(List<Model.Data.Field.KontniPlanTemeljnicaVr> fields, List<Model.Data.Filter.KontniPlanTemeljnicaVr>  filter, List<Model.Data.Sort.KontniPlanTemeljnicaVr>  sort, long? start = null, long? count = null);
    }
}
