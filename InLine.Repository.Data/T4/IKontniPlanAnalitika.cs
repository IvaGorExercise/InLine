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
    
    public partial interface IKontniPlanAnalitika
    {
       		
    		void Delete(Model.Data.Item.KontniPlanAnalitikaItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.KontniPlanAnalitikaItem item);
            								
    		void Insert(Model.Data.Item.KontniPlanAnalitikaItem item);
    
    		ObjectResult<Model.Data.KontniPlanAnalitika> InsertResult(Model.Data.Item.KontniPlanAnalitikaItem item);
    										
    			
    		void Select(Nullable<long> ID_KontniPlanAnalitika);
    
    			ObjectResult<Model.Data.KontniPlanAnalitika> SelectResult(Nullable<long> ID_KontniPlanAnalitika);
            				
    			
    		void Update(Model.Data.Item.KontniPlanAnalitikaItem item);
    
    				
    		ObjectResult<Model.Data.KontniPlanAnalitika> UpdateResult (Model.Data.Item.KontniPlanAnalitikaItem item);
    							
    	
    	Model.Data.KontniPlanAnalitika FindID(long id);
    	
    	//IEnumerable <Model.Data.KontniPlanAnalitika> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.KontniPlanAnalitika> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.KontniPlanAnalitika> GetData(List<Model.Data.Field.KontniPlanAnalitika> fields, List<Model.Data.Filter.KontniPlanAnalitika>  filter, List<Model.Data.Sort.KontniPlanAnalitika>  sort, long? start = null, long? count = null);
    
    }
    
}
