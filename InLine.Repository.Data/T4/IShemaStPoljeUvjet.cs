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
    
    public partial interface IShemaStPoljeUvjet
    {
       		
    		void Delete(Model.Data.Item.ShemaStPoljeUvjetItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.ShemaStPoljeUvjetItem item);
            								
    		void Insert(Model.Data.Item.ShemaStPoljeUvjetItem item);
    
    		ObjectResult<Model.Data.ShemaStPoljeUvjet> InsertResult(Model.Data.Item.ShemaStPoljeUvjetItem item);
    										
    			
    		void Select(Nullable<long> ID_ShemaStPoljeUvjet);
    
    			ObjectResult<Model.Data.ShemaStPoljeUvjet> SelectResult(Nullable<long> ID_ShemaStPoljeUvjet);
            				
    			
    		void Update(Model.Data.Item.ShemaStPoljeUvjetItem item);
    
    				
    		ObjectResult<Model.Data.ShemaStPoljeUvjet> UpdateResult (Model.Data.Item.ShemaStPoljeUvjetItem item);
    							
    	
    	Model.Data.ShemaStPoljeUvjet FindID(long id);
    	
    	//IEnumerable <Model.Data.ShemaStPoljeUvjet> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.ShemaStPoljeUvjet> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.ShemaStPoljeUvjet> GetData(List<Model.Data.Field.ShemaStPoljeUvjet> fields, List<Model.Data.Filter.ShemaStPoljeUvjet>  filter, List<Model.Data.Sort.ShemaStPoljeUvjet>  sort, long? start = null, long? count = null);
    
    }
    
}
