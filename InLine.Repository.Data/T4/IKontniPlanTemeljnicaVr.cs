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
    
    public partial interface IKontniPlanTemeljnicaVr
    {
       		
    		void Delete(Model.Data.Item.KontniPlanTemeljnicaVrItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.KontniPlanTemeljnicaVrItem item);
            								
    		void Insert(Model.Data.Item.KontniPlanTemeljnicaVrItem item);
    
    		ObjectResult<Model.Data.KontniPlanTemeljnicaVr> InsertResult(Model.Data.Item.KontniPlanTemeljnicaVrItem item);
    										
    			
    		void Select(Nullable<long> ID_KontniPlanTemeljnicaVr);
    
    			ObjectResult<Model.Data.KontniPlanTemeljnicaVr> SelectResult(Nullable<long> ID_KontniPlanTemeljnicaVr);
            				
    			
    		void Update(Model.Data.Item.KontniPlanTemeljnicaVrItem item);
    
    				
    		ObjectResult<Model.Data.KontniPlanTemeljnicaVr> UpdateResult (Model.Data.Item.KontniPlanTemeljnicaVrItem item);
    							
    	
    	Model.Data.KontniPlanTemeljnicaVr FindID(long id);
    	
    	//IEnumerable <Model.Data.KontniPlanTemeljnicaVr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.KontniPlanTemeljnicaVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.KontniPlanTemeljnicaVr> GetData(List<Model.Data.Field.KontniPlanTemeljnicaVr> fields, List<Model.Data.Filter.KontniPlanTemeljnicaVr>  filter, List<Model.Data.Sort.KontniPlanTemeljnicaVr>  sort, long? start = null, long? count = null);
    
    }
    
}