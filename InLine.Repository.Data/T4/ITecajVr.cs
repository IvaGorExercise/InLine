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
    
    public partial interface ITecajVr
    {
       		
    		void Delete(Model.Data.Item.TecajVrItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.TecajVrItem item);
            								
    		void Insert(Model.Data.Item.TecajVrItem item);
    
    		ObjectResult<Model.Data.TecajVr> InsertResult(Model.Data.Item.TecajVrItem item);
    										
    			
    		void Select(Nullable<long> ID_TecajVr);
    
    			ObjectResult<Model.Data.TecajVr> SelectResult(Nullable<long> ID_TecajVr);
            				
    			
    		void Update(Model.Data.Item.TecajVrItem item);
    
    				
    		ObjectResult<Model.Data.TecajVr> UpdateResult (Model.Data.Item.TecajVrItem item);
    							
    	
    	Model.Data.TecajVr FindID(long id);
    	
    	//IEnumerable <Model.Data.TecajVr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.TecajVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.TecajVr> GetData(List<Model.Data.Field.TecajVr> fields, List<Model.Data.Filter.TecajVr>  filter, List<Model.Data.Sort.TecajVr>  sort, long? start = null, long? count = null);
    
    }
    
}