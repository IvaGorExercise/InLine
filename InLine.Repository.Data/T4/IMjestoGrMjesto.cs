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
    
    public partial interface IMjestoGrMjesto
    {
       		
    		void Delete(Model.Data.Item.MjestoGrMjestoItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.MjestoGrMjestoItem item);
            								
    		void Insert(Model.Data.Item.MjestoGrMjestoItem item);
    
    		ObjectResult<Model.Data.MjestoGrMjesto> InsertResult(Model.Data.Item.MjestoGrMjestoItem item);
    										
    			
    		void Select(Nullable<long> ID_MjestoGrMjesto);
    
    			ObjectResult<Model.Data.MjestoGrMjesto> SelectResult(Nullable<long> ID_MjestoGrMjesto);
            				
    			
    		void Update(Model.Data.Item.MjestoGrMjestoItem item);
    
    				
    		ObjectResult<Model.Data.MjestoGrMjesto> UpdateResult (Model.Data.Item.MjestoGrMjestoItem item);
    							
    	
    	Model.Data.MjestoGrMjesto FindID(long id);
    	
    	//IEnumerable <Model.Data.MjestoGrMjesto> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.MjestoGrMjesto> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.MjestoGrMjesto> GetData(List<Model.Data.Field.MjestoGrMjesto> fields, List<Model.Data.Filter.MjestoGrMjesto>  filter, List<Model.Data.Sort.MjestoGrMjesto>  sort, long? start = null, long? count = null);
    
    }
    
}