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
    
    public partial interface IOpcinaGrOpcinaDatum
    {
       		
    		void Delete(Model.Data.Item.OpcinaGrOpcinaDatumItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.OpcinaGrOpcinaDatumItem item);
            								
    		void Insert(Model.Data.Item.OpcinaGrOpcinaDatumItem item);
    
    		ObjectResult<Model.Data.OpcinaGrOpcinaDatum> InsertResult(Model.Data.Item.OpcinaGrOpcinaDatumItem item);
    										
    			
    		void Select(Nullable<long> ID_OpcinaGrOpcinaDatum);
    
    			ObjectResult<Model.Data.OpcinaGrOpcinaDatum> SelectResult(Nullable<long> ID_OpcinaGrOpcinaDatum);
            				
    			
    		void Update(Model.Data.Item.OpcinaGrOpcinaDatumItem item);
    
    				
    		ObjectResult<Model.Data.OpcinaGrOpcinaDatum> UpdateResult (Model.Data.Item.OpcinaGrOpcinaDatumItem item);
    							
    	
    	Model.Data.OpcinaGrOpcinaDatum FindID(long id);
    	
    	//IEnumerable <Model.Data.OpcinaGrOpcinaDatum> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.OpcinaGrOpcinaDatum> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.OpcinaGrOpcinaDatum> GetData(List<Model.Data.Field.OpcinaGrOpcinaDatum> fields, List<Model.Data.Filter.OpcinaGrOpcinaDatum>  filter, List<Model.Data.Sort.OpcinaGrOpcinaDatum>  sort, long? start = null, long? count = null);
    
    }
    
}
