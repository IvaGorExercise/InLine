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
    
    public partial interface IPoslovniSubjekt
    {
       		
    		void Delete(Model.Data.Item.PoslovniSubjektItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.PoslovniSubjektItem item);
            								
    		void Insert(Model.Data.Item.PoslovniSubjektItem item);
    
    		ObjectResult<Model.Data.PoslovniSubjekt> InsertResult(Model.Data.Item.PoslovniSubjektItem item);
    										
    			
    		void Select(Nullable<long> ID_PoslovniSubjekt);
    
    			ObjectResult<Model.Data.PoslovniSubjekt> SelectResult(Nullable<long> ID_PoslovniSubjekt);
            				
    			
    		void Update(Model.Data.Item.PoslovniSubjektItem item);
    
    				
    		ObjectResult<Model.Data.PoslovniSubjekt> UpdateResult (Model.Data.Item.PoslovniSubjektItem item);
    							
    	
    	Model.Data.PoslovniSubjekt FindID(long id);
    	
    	//IEnumerable <Model.Data.PoslovniSubjekt> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.PoslovniSubjekt> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.PoslovniSubjekt> GetData(List<Model.Data.Field.PoslovniSubjekt> fields, List<Model.Data.Filter.PoslovniSubjekt>  filter, List<Model.Data.Sort.PoslovniSubjekt>  sort, long? start = null, long? count = null);
    
    }
    
}
