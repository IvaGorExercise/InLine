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
    
    public partial interface IOpcinaTip
    {
       		
    		void Delete(Model.Data.Item.OpcinaTipItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.OpcinaTipItem item);
            								
    		void Insert(Model.Data.Item.OpcinaTipItem item);
    
    		ObjectResult<Model.Data.OpcinaTip> InsertResult(Model.Data.Item.OpcinaTipItem item);
    										
    			
    		void Select(Nullable<long> ID_OpcinaTip);
    
    			ObjectResult<Model.Data.OpcinaTip> SelectResult(Nullable<long> ID_OpcinaTip);
            				
    			
    		void Update(Model.Data.Item.OpcinaTipItem item);
    
    				
    		ObjectResult<Model.Data.OpcinaTip> UpdateResult (Model.Data.Item.OpcinaTipItem item);
    							
    	
    	Model.Data.OpcinaTip FindID(long id);
    	
    	//IEnumerable <Model.Data.OpcinaTip> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.OpcinaTip> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.OpcinaTip> GetData(List<Model.Data.Field.OpcinaTip> fields, List<Model.Data.Filter.OpcinaTip>  filter, List<Model.Data.Sort.OpcinaTip>  sort, long? start = null, long? count = null);
    
    }
    
}
