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
    
    public partial interface IObrazacVrPolje
    {
       		
    		void Delete(Model.Data.Item.ObrazacVrPoljeItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacVrPoljeItem item);
            								
    		void Insert(Model.Data.Item.ObrazacVrPoljeItem item);
    
    		ObjectResult<Model.Data.ObrazacVrPolje> InsertResult(Model.Data.Item.ObrazacVrPoljeItem item);
    										
    			
    		void Select(Nullable<long> ID_ObrazacVrPolje);
    
    			ObjectResult<Model.Data.ObrazacVrPolje> SelectResult(Nullable<long> ID_ObrazacVrPolje);
            				
    			
    		void Update(Model.Data.Item.ObrazacVrPoljeItem item);
    
    				
    		ObjectResult<Model.Data.ObrazacVrPolje> UpdateResult (Model.Data.Item.ObrazacVrPoljeItem item);
    							
    	
    	Model.Data.ObrazacVrPolje FindID(long id);
    	
    	//IEnumerable <Model.Data.ObrazacVrPolje> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.ObrazacVrPolje> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.ObrazacVrPolje> GetData(List<Model.Data.Field.ObrazacVrPolje> fields, List<Model.Data.Filter.ObrazacVrPolje>  filter, List<Model.Data.Sort.ObrazacVrPolje>  sort, long? start = null, long? count = null);
    
    }
    
}
