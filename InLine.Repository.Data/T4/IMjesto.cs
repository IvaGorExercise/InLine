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
    
    public partial interface IMjesto
    {
       		
    		void Delete(Model.Data.Item.MjestoItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.MjestoItem item);
            								
    		void Insert(Model.Data.Item.MjestoItem item);
    
    		ObjectResult<Model.Data.Mjesto> InsertResult(Model.Data.Item.MjestoItem item);
    										
    			
    		void Select(Nullable<long> ID_Mjesto);
    
    			ObjectResult<Model.Data.Mjesto> SelectResult(Nullable<long> ID_Mjesto);
            				
    			
    		void Update(Model.Data.Item.MjestoItem item);
    
    				
    		ObjectResult<Model.Data.Mjesto> UpdateResult (Model.Data.Item.MjestoItem item);
    							
    	
    	Model.Data.Mjesto FindID(long id);
    	
    	//IEnumerable <Model.Data.Mjesto> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.Mjesto> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.Mjesto> GetData(List<Model.Data.Field.Mjesto> fields, List<Model.Data.Filter.Mjesto>  filter, List<Model.Data.Sort.Mjesto>  sort, long? start = null, long? count = null);
    
    }
    
}