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
    
    public partial interface ITemeljnicaSt
    {
       		
    		void Delete(Model.Data.Item.TemeljnicaStItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.TemeljnicaStItem item);
            								
    		void Insert(Model.Data.Item.TemeljnicaStItem item);
    
    		ObjectResult<Model.Data.TemeljnicaSt> InsertResult(Model.Data.Item.TemeljnicaStItem item);
    										
    			
    		void Select(Nullable<long> ID_TemeljnicaSt);
    
    			ObjectResult<Model.Data.TemeljnicaSt> SelectResult(Nullable<long> ID_TemeljnicaSt);
            				
    			
    		void Update(Model.Data.Item.TemeljnicaStItem item);
    
    				
    		ObjectResult<Model.Data.TemeljnicaSt> UpdateResult (Model.Data.Item.TemeljnicaStItem item);
    							
    	
    	Model.Data.TemeljnicaSt FindID(long id);
    	
    	//IEnumerable <Model.Data.TemeljnicaSt> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.TemeljnicaSt> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.TemeljnicaSt> GetData(List<Model.Data.Field.TemeljnicaSt> fields, List<Model.Data.Filter.TemeljnicaSt>  filter, List<Model.Data.Sort.TemeljnicaSt>  sort, long? start = null, long? count = null);
    
    }
    
}
