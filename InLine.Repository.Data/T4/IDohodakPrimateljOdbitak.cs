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
    
    public partial interface IDohodakPrimateljOdbitak
    {
       		
    		void Delete(Model.Data.Item.DohodakPrimateljOdbitakItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.DohodakPrimateljOdbitakItem item);
            								
    		void Insert(Model.Data.Item.DohodakPrimateljOdbitakItem item);
    
    		ObjectResult<Model.Data.DohodakPrimateljOdbitak> InsertResult(Model.Data.Item.DohodakPrimateljOdbitakItem item);
    										
    			
    		void Select(Nullable<long> ID_DohodakPrimateljOdbitak);
    
    			ObjectResult<Model.Data.DohodakPrimateljOdbitak> SelectResult(Nullable<long> ID_DohodakPrimateljOdbitak);
            				
    			
    		void Update(Model.Data.Item.DohodakPrimateljOdbitakItem item);
    
    				
    		ObjectResult<Model.Data.DohodakPrimateljOdbitak> UpdateResult (Model.Data.Item.DohodakPrimateljOdbitakItem item);
    							
    	
    	Model.Data.DohodakPrimateljOdbitak FindID(long id);
    	
    	//IEnumerable <Model.Data.DohodakPrimateljOdbitak> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.DohodakPrimateljOdbitak> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.DohodakPrimateljOdbitak> GetData(List<Model.Data.Field.DohodakPrimateljOdbitak> fields, List<Model.Data.Filter.DohodakPrimateljOdbitak>  filter, List<Model.Data.Sort.DohodakPrimateljOdbitak>  sort, long? start = null, long? count = null);
    
    }
    
}
