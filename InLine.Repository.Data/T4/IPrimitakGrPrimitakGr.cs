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
    
    public partial interface IPrimitakGrPrimitakGr
    {
       		
    		void Delete(Model.Data.Item.PrimitakGrPrimitakGrItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.PrimitakGrPrimitakGrItem item);
            								
    		void Insert(Model.Data.Item.PrimitakGrPrimitakGrItem item);
    
    		ObjectResult<Model.Data.PrimitakGrPrimitakGr> InsertResult(Model.Data.Item.PrimitakGrPrimitakGrItem item);
    										
    			
    		void Select(Nullable<long> ID_PrimitakGrPrimitakGr);
    
    			ObjectResult<Model.Data.PrimitakGrPrimitakGr> SelectResult(Nullable<long> ID_PrimitakGrPrimitakGr);
            				
    			
    		void Update(Model.Data.Item.PrimitakGrPrimitakGrItem item);
    
    				
    		ObjectResult<Model.Data.PrimitakGrPrimitakGr> UpdateResult (Model.Data.Item.PrimitakGrPrimitakGrItem item);
    							
    	
    	Model.Data.PrimitakGrPrimitakGr FindID(long id);
    	
    	//IEnumerable <Model.Data.PrimitakGrPrimitakGr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.PrimitakGrPrimitakGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.PrimitakGrPrimitakGr> GetData(List<Model.Data.Field.PrimitakGrPrimitakGr> fields, List<Model.Data.Filter.PrimitakGrPrimitakGr>  filter, List<Model.Data.Sort.PrimitakGrPrimitakGr>  sort, long? start = null, long? count = null);
    
    }
    
}
