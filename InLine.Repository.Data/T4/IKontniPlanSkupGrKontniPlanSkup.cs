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
    
    public partial interface IKontniPlanSkupGrKontniPlanSkup
    {
       		
    		void Delete(Model.Data.Item.KontniPlanSkupGrKontniPlanSkupItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.KontniPlanSkupGrKontniPlanSkupItem item);
            								
    		void Insert(Model.Data.Item.KontniPlanSkupGrKontniPlanSkupItem item);
    
    		ObjectResult<Model.Data.KontniPlanSkupGrKontniPlanSkup> InsertResult(Model.Data.Item.KontniPlanSkupGrKontniPlanSkupItem item);
    										
    			
    		void Select(Nullable<long> ID_KontniPlanSkupGrKontniPlanSkup);
    
    			ObjectResult<Model.Data.KontniPlanSkupGrKontniPlanSkup> SelectResult(Nullable<long> ID_KontniPlanSkupGrKontniPlanSkup);
            				
    			
    		void Update(Model.Data.Item.KontniPlanSkupGrKontniPlanSkupItem item);
    
    				
    		ObjectResult<Model.Data.KontniPlanSkupGrKontniPlanSkup> UpdateResult (Model.Data.Item.KontniPlanSkupGrKontniPlanSkupItem item);
    							
    	
    	Model.Data.KontniPlanSkupGrKontniPlanSkup FindID(long id);
    	
    	//IEnumerable <Model.Data.KontniPlanSkupGrKontniPlanSkup> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.KontniPlanSkupGrKontniPlanSkup> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.KontniPlanSkupGrKontniPlanSkup> GetData(List<Model.Data.Field.KontniPlanSkupGrKontniPlanSkup> fields, List<Model.Data.Filter.KontniPlanSkupGrKontniPlanSkup>  filter, List<Model.Data.Sort.KontniPlanSkupGrKontniPlanSkup>  sort, long? start = null, long? count = null);
    
    }
    
}
