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
    
    public partial interface IHUBImportHUB
    {
       		
    		void Delete(Model.Data.Item.HUBImportHUBItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.HUBImportHUBItem item);
            								
    		void Insert(Model.Data.Item.HUBImportHUBItem item);
    
    		ObjectResult<Model.Data.HUBImportHUB> InsertResult(Model.Data.Item.HUBImportHUBItem item);
    										
    			
    		void Select(Nullable<long> ID_HUBImportHUB);
    
    			ObjectResult<Model.Data.HUBImportHUB> SelectResult(Nullable<long> ID_HUBImportHUB);
            				
    			
    		void Update(Model.Data.Item.HUBImportHUBItem item);
    
    				
    		ObjectResult<Model.Data.HUBImportHUB> UpdateResult (Model.Data.Item.HUBImportHUBItem item);
    							
    	
    	Model.Data.HUBImportHUB FindID(long id);
    	
    	//IEnumerable <Model.Data.HUBImportHUB> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.HUBImportHUB> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.HUBImportHUB> GetData(List<Model.Data.Field.HUBImportHUB> fields, List<Model.Data.Filter.HUBImportHUB>  filter, List<Model.Data.Sort.HUBImportHUB>  sort, long? start = null, long? count = null);
    
    }
    
}
