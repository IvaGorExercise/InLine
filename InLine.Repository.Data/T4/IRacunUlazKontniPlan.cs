//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace InLine.Repository.Data
{
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Diagnostics;
    using System.Data.Objects;
    using InLine;
    
    public partial interface IRacunUlazKontniPlan
    {
       		
    		void Delete(Model.Data.Item.RacunUlazKontniPlanItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.RacunUlazKontniPlanItem item);
            								
    		void Insert(Model.Data.Item.RacunUlazKontniPlanItem item);
    
    		ObjectResult<Model.Data.RacunUlazKontniPlan> InsertResult(Model.Data.Item.RacunUlazKontniPlanItem item);
    										
    			
    		void Select(Nullable<long> ID_RacunUlazKontniPlan);
    
    			ObjectResult<Model.Data.RacunUlazKontniPlan> SelectResult(Nullable<long> ID_RacunUlazKontniPlan);
            				
    			
    		void Update(Model.Data.Item.RacunUlazKontniPlanItem item);
    
    				
    		ObjectResult<Model.Data.RacunUlazKontniPlan> UpdateResult (Model.Data.Item.RacunUlazKontniPlanItem item);
    							
    	
    	Model.Data.RacunUlazKontniPlan FindID(long id);
    	
    	//IEnumerable <Model.Data.RacunUlazKontniPlan> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.RacunUlazKontniPlan> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.RacunUlazKontniPlan> GetData(List<Model.Data.Field.RacunUlazKontniPlan> fields, List<Model.Data.Filter.RacunUlazKontniPlan>  filter, List<Model.Data.Sort.RacunUlazKontniPlan>  sort, long? start = null, long? count = null);
    
    }
    
}
