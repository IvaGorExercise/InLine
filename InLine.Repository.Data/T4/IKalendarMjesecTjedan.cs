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
    
    public partial interface IKalendarMjesecTjedan
    {
       		
    		void Delete(Model.Data.Item.KalendarMjesecTjedanItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.KalendarMjesecTjedanItem item);
            								
    		void Insert(Model.Data.Item.KalendarMjesecTjedanItem item);
    
    		ObjectResult<Model.Data.KalendarMjesecTjedan> InsertResult(Model.Data.Item.KalendarMjesecTjedanItem item);
    										
    			
    		void Select(Nullable<int> MjesecTjedan);
    
    			ObjectResult<Model.Data.KalendarMjesecTjedan> SelectResult(Nullable<int> MjesecTjedan);
            				
    			
    		void Update(Model.Data.Item.KalendarMjesecTjedanItem item);
    
    				
    		ObjectResult<Model.Data.KalendarMjesecTjedan> UpdateResult (Model.Data.Item.KalendarMjesecTjedanItem item);
    							
    	
    	Model.Data.KalendarMjesecTjedan FindID(long id);
    	
    	//IEnumerable <Model.Data.KalendarMjesecTjedan> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.KalendarMjesecTjedan> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.KalendarMjesecTjedan> GetData(List<Model.Data.Field.KalendarMjesecTjedan> fields, List<Model.Data.Filter.KalendarMjesecTjedan>  filter, List<Model.Data.Sort.KalendarMjesecTjedan>  sort, long? start = null, long? count = null);
    
    }
    
}