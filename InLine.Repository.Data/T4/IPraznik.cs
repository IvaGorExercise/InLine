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
    
    public partial interface IPraznik
    {
       		
    		void Delete(Model.Data.Item.PraznikItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.PraznikItem item);
            								
    		void Insert(Model.Data.Item.PraznikItem item);
    
    		ObjectResult<Model.Data.Praznik> InsertResult(Model.Data.Item.PraznikItem item);
    										
    			
    		void Select(Nullable<long> ID_Praznik);
    
    			ObjectResult<Model.Data.Praznik> SelectResult(Nullable<long> ID_Praznik);
            				
    			
    		void Update(Model.Data.Item.PraznikItem item);
    
    				
    		ObjectResult<Model.Data.Praznik> UpdateResult (Model.Data.Item.PraznikItem item);
    							
    	
    	Model.Data.Praznik FindID(long id);
    	
    	//IEnumerable <Model.Data.Praznik> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.Praznik> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.Praznik> GetData(List<Model.Data.Field.Praznik> fields, List<Model.Data.Filter.Praznik>  filter, List<Model.Data.Sort.Praznik>  sort, long? start = null, long? count = null);
    
    }
    
}
