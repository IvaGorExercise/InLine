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
    
    public partial interface IStan
    {
       		
    		void Delete(Model.Data.Item.StanItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.StanItem item);
            								
    		void Insert(Model.Data.Item.StanItem item);
    
    		ObjectResult<Model.Data.Stan> InsertResult(Model.Data.Item.StanItem item);
    										
    			
    		void Select(Nullable<long> ID_Stan);
    
    			ObjectResult<Model.Data.Stan> SelectResult(Nullable<long> ID_Stan);
            				
    			
    		void Update(Model.Data.Item.StanItem item);
    
    				
    		ObjectResult<Model.Data.Stan> UpdateResult (Model.Data.Item.StanItem item);
    							
    	
    	Model.Data.Stan FindID(long id);
    	
    	//IEnumerable <Model.Data.Stan> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.Stan> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.Stan> GetData(List<Model.Data.Field.Stan> fields, List<Model.Data.Filter.Stan>  filter, List<Model.Data.Sort.Stan>  sort, long? start = null, long? count = null);
    
    }
    
}
