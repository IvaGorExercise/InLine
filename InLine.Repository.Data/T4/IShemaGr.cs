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
    
    public partial interface IShemaGr
    {
       		
    		void Delete(Model.Data.Item.ShemaGrItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.ShemaGrItem item);
            								
    		void Insert(Model.Data.Item.ShemaGrItem item);
    
    		ObjectResult<Model.Data.ShemaGr> InsertResult(Model.Data.Item.ShemaGrItem item);
    										
    			
    		void Select(Nullable<long> ID_ShemaGr);
    
    			ObjectResult<Model.Data.ShemaGr> SelectResult(Nullable<long> ID_ShemaGr);
            				
    			
    		void Update(Model.Data.Item.ShemaGrItem item);
    
    				
    		ObjectResult<Model.Data.ShemaGr> UpdateResult (Model.Data.Item.ShemaGrItem item);
    							
    	
    	Model.Data.ShemaGr FindID(long id);
    	
    	//IEnumerable <Model.Data.ShemaGr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.ShemaGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.ShemaGr> GetData(List<Model.Data.Field.ShemaGr> fields, List<Model.Data.Filter.ShemaGr>  filter, List<Model.Data.Sort.ShemaGr>  sort, long? start = null, long? count = null);
    
    }
    
}
