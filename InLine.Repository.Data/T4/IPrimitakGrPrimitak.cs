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
    
    public partial interface IPrimitakGrPrimitak
    {
       		
    		void Delete(Model.Data.Item.PrimitakGrPrimitakItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.PrimitakGrPrimitakItem item);
            								
    		void Insert(Model.Data.Item.PrimitakGrPrimitakItem item);
    
    		ObjectResult<Model.Data.PrimitakGrPrimitak> InsertResult(Model.Data.Item.PrimitakGrPrimitakItem item);
    										
    			
    		void Select(Nullable<long> ID_PrimitakGrPrimitak);
    
    			ObjectResult<Model.Data.PrimitakGrPrimitak> SelectResult(Nullable<long> ID_PrimitakGrPrimitak);
            				
    			
    		void Update(Model.Data.Item.PrimitakGrPrimitakItem item);
    
    				
    		ObjectResult<Model.Data.PrimitakGrPrimitak> UpdateResult (Model.Data.Item.PrimitakGrPrimitakItem item);
    							
    	
    	Model.Data.PrimitakGrPrimitak FindID(long id);
    	
    	//IEnumerable <Model.Data.PrimitakGrPrimitak> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.PrimitakGrPrimitak> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.PrimitakGrPrimitak> GetData(List<Model.Data.Field.PrimitakGrPrimitak> fields, List<Model.Data.Filter.PrimitakGrPrimitak>  filter, List<Model.Data.Sort.PrimitakGrPrimitak>  sort, long? start = null, long? count = null);
    
    }
    
}