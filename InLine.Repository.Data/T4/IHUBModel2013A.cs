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
    
    public partial interface IHUBModel2013A
    {
       		
    		void Delete(Model.Data.Item.HUBModel2013AItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.HUBModel2013AItem item);
            								
    		void Insert(Model.Data.Item.HUBModel2013AItem item);
    
    		ObjectResult<Model.Data.HUBModel2013A> InsertResult(Model.Data.Item.HUBModel2013AItem item);
    										
    			
    		void Select(Nullable<int> IDHUBModel2013A);
    
    			ObjectResult<Model.Data.HUBModel2013A> SelectResult(Nullable<int> IDHUBModel2013A);
            				
    			
    		void Update(Model.Data.Item.HUBModel2013AItem item);
    
    				
    		ObjectResult<Model.Data.HUBModel2013A> UpdateResult (Model.Data.Item.HUBModel2013AItem item);
    							
    	
    	Model.Data.HUBModel2013A FindID(long id);
    	
    	//IEnumerable <Model.Data.HUBModel2013A> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.HUBModel2013A> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.HUBModel2013A> GetData(List<Model.Data.Field.HUBModel2013A> fields, List<Model.Data.Filter.HUBModel2013A>  filter, List<Model.Data.Sort.HUBModel2013A>  sort, long? start = null, long? count = null);
    
    }
    
}
