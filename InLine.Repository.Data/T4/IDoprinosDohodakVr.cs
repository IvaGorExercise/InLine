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
    
    public partial interface IDoprinosDohodakVr
    {
       		
    		void Delete(Model.Data.Item.DoprinosDohodakVrItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.DoprinosDohodakVrItem item);
            								
    		void Insert(Model.Data.Item.DoprinosDohodakVrItem item);
    
    		ObjectResult<Model.Data.DoprinosDohodakVr> InsertResult(Model.Data.Item.DoprinosDohodakVrItem item);
    										
    			
    		void Select(Nullable<long> ID_DoprinosDohodakVr);
    
    			ObjectResult<Model.Data.DoprinosDohodakVr> SelectResult(Nullable<long> ID_DoprinosDohodakVr);
            				
    			
    		void Update(Model.Data.Item.DoprinosDohodakVrItem item);
    
    				
    		ObjectResult<Model.Data.DoprinosDohodakVr> UpdateResult (Model.Data.Item.DoprinosDohodakVrItem item);
    							
    	
    	Model.Data.DoprinosDohodakVr FindID(long id);
    	
    	//IEnumerable <Model.Data.DoprinosDohodakVr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.DoprinosDohodakVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.DoprinosDohodakVr> GetData(List<Model.Data.Field.DoprinosDohodakVr> fields, List<Model.Data.Filter.DoprinosDohodakVr>  filter, List<Model.Data.Sort.DoprinosDohodakVr>  sort, long? start = null, long? count = null);
    
    }
    
}
