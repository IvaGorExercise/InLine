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
    
    public partial interface IKalendarGodinaDan
    {
       		
    		void Delete(Model.Data.Item.KalendarGodinaDanItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.KalendarGodinaDanItem item);
            								
    		void Insert(Model.Data.Item.KalendarGodinaDanItem item);
    
    		ObjectResult<Model.Data.KalendarGodinaDan> InsertResult(Model.Data.Item.KalendarGodinaDanItem item);
    										
    			
    		void Select(Nullable<int> GodinaDan);
    
    			ObjectResult<Model.Data.KalendarGodinaDan> SelectResult(Nullable<int> GodinaDan);
            				
    			
    		void Update(Model.Data.Item.KalendarGodinaDanItem item);
    
    				
    		ObjectResult<Model.Data.KalendarGodinaDan> UpdateResult (Model.Data.Item.KalendarGodinaDanItem item);
    							
    	
    	Model.Data.KalendarGodinaDan FindID(long id);
    	
    	//IEnumerable <Model.Data.KalendarGodinaDan> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.KalendarGodinaDan> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.KalendarGodinaDan> GetData(List<Model.Data.Field.KalendarGodinaDan> fields, List<Model.Data.Filter.KalendarGodinaDan>  filter, List<Model.Data.Sort.KalendarGodinaDan>  sort, long? start = null, long? count = null);
    
    }
    
}
