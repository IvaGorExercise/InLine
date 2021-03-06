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
    
    public partial interface IRoba
    {
       		
    		void Delete(Model.Data.Item.RobaItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.RobaItem item);
            								
    		void Insert(Model.Data.Item.RobaItem item);
    
    		ObjectResult<Model.Data.Roba> InsertResult(Model.Data.Item.RobaItem item);
    										
    			
    		void Select(Nullable<long> ID_Roba);
    
    			ObjectResult<Model.Data.Roba> SelectResult(Nullable<long> ID_Roba);
            				
    			
    		void Update(Model.Data.Item.RobaItem item);
    
    				
    		ObjectResult<Model.Data.Roba> UpdateResult (Model.Data.Item.RobaItem item);
    							
    	
    	Model.Data.Roba FindID(long id);
    	
    	//IEnumerable <Model.Data.Roba> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.Roba> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.Roba> GetData(List<Model.Data.Field.Roba> fields, List<Model.Data.Filter.Roba>  filter, List<Model.Data.Sort.Roba>  sort, long? start = null, long? count = null);
    
    }
    
}
