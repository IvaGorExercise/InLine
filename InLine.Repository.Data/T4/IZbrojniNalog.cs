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
    
    public partial interface IZbrojniNalog
    {
       		
    		void Delete(Model.Data.Item.ZbrojniNalogItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.ZbrojniNalogItem item);
            								
    		void Insert(Model.Data.Item.ZbrojniNalogItem item);
    
    		ObjectResult<Model.Data.ZbrojniNalog> InsertResult(Model.Data.Item.ZbrojniNalogItem item);
    										
    			
    		void Select(Nullable<long> ID_ZbrojniNalog);
    
    			ObjectResult<Model.Data.ZbrojniNalog> SelectResult(Nullable<long> ID_ZbrojniNalog);
            				
    			
    		void Update(Model.Data.Item.ZbrojniNalogItem item);
    
    				
    		ObjectResult<Model.Data.ZbrojniNalog> UpdateResult (Model.Data.Item.ZbrojniNalogItem item);
    							
    	
    	Model.Data.ZbrojniNalog FindID(long id);
    	
    	//IEnumerable <Model.Data.ZbrojniNalog> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.ZbrojniNalog> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.ZbrojniNalog> GetData(List<Model.Data.Field.ZbrojniNalog> fields, List<Model.Data.Filter.ZbrojniNalog>  filter, List<Model.Data.Sort.ZbrojniNalog>  sort, long? start = null, long? count = null);
    
    }
    
}
