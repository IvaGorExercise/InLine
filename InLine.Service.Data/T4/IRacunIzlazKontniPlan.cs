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
    
    public partial interface IRacunIzlazKontniPlan
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.RacunIzlazKontniPlanItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.RacunIzlazKontniPlanItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.RacunIzlazKontniPlanItem item);
    	IEnumerable<Model.Data.RacunIzlazKontniPlan> SelectResult(long? ID_RacunIzlazKontniPlan);
    	Model.Data.RacunIzlazKontniPlan InsertResult(Model.Data.Item.RacunIzlazKontniPlanItem item);
    	Model.Data.RacunIzlazKontniPlan UpdateResult(Model.Data.Item.RacunIzlazKontniPlanItem item);
    	int DeleteResult(Model.Data.Item.RacunIzlazKontniPlanItem item);
    	
        Model.Data.RacunIzlazKontniPlan FindID(long id);
        //IEnumerable<Model.Data.RacunIzlazKontniPlan> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.RacunIzlazKontniPlan> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.RacunIzlazKontniPlan> GetData(List<Model.Data.Field.RacunIzlazKontniPlan> fields, List<Model.Data.Filter.RacunIzlazKontniPlan>  filter, List<Model.Data.Sort.RacunIzlazKontniPlan>  sort, long? start = null, long? count = null);
    }
}