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
    
    public partial interface IPrimitakGr
    {
       		
    		void Delete(Model.Data.Item.PrimitakGrItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.PrimitakGrItem item);
            								
    		void Insert(Model.Data.Item.PrimitakGrItem item);
    
    		ObjectResult<Model.Data.PrimitakGr> InsertResult(Model.Data.Item.PrimitakGrItem item);
    										
    			
    		void Select(Nullable<long> ID_PrimitakGr);
    
    			ObjectResult<Model.Data.PrimitakGr> SelectResult(Nullable<long> ID_PrimitakGr);
            				
    			
    		void Update(Model.Data.Item.PrimitakGrItem item);
    
    				
    		ObjectResult<Model.Data.PrimitakGr> UpdateResult (Model.Data.Item.PrimitakGrItem item);
    							
    	
    	Model.Data.PrimitakGr FindID(long id);
    	
    	//IEnumerable <Model.Data.PrimitakGr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.PrimitakGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.PrimitakGr> GetData(List<Model.Data.Field.PrimitakGr> fields, List<Model.Data.Filter.PrimitakGr>  filter, List<Model.Data.Sort.PrimitakGr>  sort, long? start = null, long? count = null);
    
    }
    
}