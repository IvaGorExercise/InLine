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
    
    public partial interface IHUB
    {
       		
    		void Delete(Model.Data.Item.HUBItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.HUBItem item);
            								
    		void Insert(Model.Data.Item.HUBItem item);
    
    		ObjectResult<Model.Data.HUB> InsertResult(Model.Data.Item.HUBItem item);
    										
    			
    		void Select(Nullable<long> ID_HUB);
    
    			ObjectResult<Model.Data.HUB> SelectResult(Nullable<long> ID_HUB);
            				
    			
    		void Update(Model.Data.Item.HUBItem item);
    
    				
    		ObjectResult<Model.Data.HUB> UpdateResult (Model.Data.Item.HUBItem item);
    							
    	
    	Model.Data.HUB FindID(long id);
    	
    	//IEnumerable <Model.Data.HUB> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.HUB> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.HUB> GetData(List<Model.Data.Field.HUB> fields, List<Model.Data.Filter.HUB>  filter, List<Model.Data.Sort.HUB>  sort, long? start = null, long? count = null);
    
    }
    
}
