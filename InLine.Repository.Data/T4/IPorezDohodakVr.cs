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
    
    public partial interface IPorezDohodakVr
    {
       		
    		void Delete(Model.Data.Item.PorezDohodakVrItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.PorezDohodakVrItem item);
            								
    		void Insert(Model.Data.Item.PorezDohodakVrItem item);
    
    		ObjectResult<Model.Data.PorezDohodakVr> InsertResult(Model.Data.Item.PorezDohodakVrItem item);
    										
    			
    		void Select(Nullable<long> ID_PorezDohodakVr);
    
    			ObjectResult<Model.Data.PorezDohodakVr> SelectResult(Nullable<long> ID_PorezDohodakVr);
            				
    			
    		void Update(Model.Data.Item.PorezDohodakVrItem item);
    
    				
    		ObjectResult<Model.Data.PorezDohodakVr> UpdateResult (Model.Data.Item.PorezDohodakVrItem item);
    							
    	
    	Model.Data.PorezDohodakVr FindID(long id);
    	
    	//IEnumerable <Model.Data.PorezDohodakVr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.PorezDohodakVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.PorezDohodakVr> GetData(List<Model.Data.Field.PorezDohodakVr> fields, List<Model.Data.Filter.PorezDohodakVr>  filter, List<Model.Data.Sort.PorezDohodakVr>  sort, long? start = null, long? count = null);
    
    }
    
}
