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
    
    public partial interface IOsobaPrebivaliste
    {
       		
    		void Delete(Model.Data.Item.OsobaPrebivalisteItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.OsobaPrebivalisteItem item);
            								
    		void Insert(Model.Data.Item.OsobaPrebivalisteItem item);
    
    		ObjectResult<Model.Data.OsobaPrebivaliste> InsertResult(Model.Data.Item.OsobaPrebivalisteItem item);
    										
    			
    		void Select(Nullable<long> ID_OsobaPrebivaliste);
    
    			ObjectResult<Model.Data.OsobaPrebivaliste> SelectResult(Nullable<long> ID_OsobaPrebivaliste);
            				
    			
    		void Update(Model.Data.Item.OsobaPrebivalisteItem item);
    
    				
    		ObjectResult<Model.Data.OsobaPrebivaliste> UpdateResult (Model.Data.Item.OsobaPrebivalisteItem item);
    							
    	
    	Model.Data.OsobaPrebivaliste FindID(long id);
    	
    	//IEnumerable <Model.Data.OsobaPrebivaliste> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.OsobaPrebivaliste> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.OsobaPrebivaliste> GetData(List<Model.Data.Field.OsobaPrebivaliste> fields, List<Model.Data.Filter.OsobaPrebivaliste>  filter, List<Model.Data.Sort.OsobaPrebivaliste>  sort, long? start = null, long? count = null);
    
    }
    
}
