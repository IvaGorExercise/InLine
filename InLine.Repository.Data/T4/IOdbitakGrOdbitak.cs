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
    
    public partial interface IOdbitakGrOdbitak
    {
       		
    		void Delete(Model.Data.Item.OdbitakGrOdbitakItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.OdbitakGrOdbitakItem item);
            								
    		void Insert(Model.Data.Item.OdbitakGrOdbitakItem item);
    
    		ObjectResult<Model.Data.OdbitakGrOdbitak> InsertResult(Model.Data.Item.OdbitakGrOdbitakItem item);
    										
    			
    		void Select(Nullable<long> ID_OdbitakGrOdbitak);
    
    			ObjectResult<Model.Data.OdbitakGrOdbitak> SelectResult(Nullable<long> ID_OdbitakGrOdbitak);
            				
    			
    		void Update(Model.Data.Item.OdbitakGrOdbitakItem item);
    
    				
    		ObjectResult<Model.Data.OdbitakGrOdbitak> UpdateResult (Model.Data.Item.OdbitakGrOdbitakItem item);
    							
    	
    	Model.Data.OdbitakGrOdbitak FindID(long id);
    	
    	//IEnumerable <Model.Data.OdbitakGrOdbitak> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.OdbitakGrOdbitak> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.OdbitakGrOdbitak> GetData(List<Model.Data.Field.OdbitakGrOdbitak> fields, List<Model.Data.Filter.OdbitakGrOdbitak>  filter, List<Model.Data.Sort.OdbitakGrOdbitak>  sort, long? start = null, long? count = null);
    
    }
    
}