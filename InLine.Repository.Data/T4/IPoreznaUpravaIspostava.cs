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
    
    public partial interface IPoreznaUpravaIspostava
    {
       		
    		void Delete(Model.Data.Item.PoreznaUpravaIspostavaItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.PoreznaUpravaIspostavaItem item);
            								
    		void Insert(Model.Data.Item.PoreznaUpravaIspostavaItem item);
    
    		ObjectResult<Model.Data.PoreznaUpravaIspostava> InsertResult(Model.Data.Item.PoreznaUpravaIspostavaItem item);
    										
    			
    		void Select(Nullable<long> ID_PoreznaUpravaIspostava);
    
    			ObjectResult<Model.Data.PoreznaUpravaIspostava> SelectResult(Nullable<long> ID_PoreznaUpravaIspostava);
            				
    			
    		void Update(Model.Data.Item.PoreznaUpravaIspostavaItem item);
    
    				
    		ObjectResult<Model.Data.PoreznaUpravaIspostava> UpdateResult (Model.Data.Item.PoreznaUpravaIspostavaItem item);
    							
    	
    	Model.Data.PoreznaUpravaIspostava FindID(long id);
    	
    	//IEnumerable <Model.Data.PoreznaUpravaIspostava> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.PoreznaUpravaIspostava> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.PoreznaUpravaIspostava> GetData(List<Model.Data.Field.PoreznaUpravaIspostava> fields, List<Model.Data.Filter.PoreznaUpravaIspostava>  filter, List<Model.Data.Sort.PoreznaUpravaIspostava>  sort, long? start = null, long? count = null);
    
    }
    
}
