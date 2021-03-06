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
    
    public partial interface IZapisVr
    {
       		
    		void Delete(Model.Data.Item.ZapisVrItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.ZapisVrItem item);
            								
    		void Insert(Model.Data.Item.ZapisVrItem item);
    
    		ObjectResult<Model.Data.ZapisVr> InsertResult(Model.Data.Item.ZapisVrItem item);
    										
    			
    		void Select(Nullable<int> IDZapisVr);
    
    			ObjectResult<Model.Data.ZapisVr> SelectResult(Nullable<int> IDZapisVr);
            				
    			
    		void Update(Model.Data.Item.ZapisVrItem item);
    
    				
    		ObjectResult<Model.Data.ZapisVr> UpdateResult (Model.Data.Item.ZapisVrItem item);
    							
    	
    	Model.Data.ZapisVr FindID(long id);
    	
    	//IEnumerable <Model.Data.ZapisVr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.ZapisVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.ZapisVr> GetData(List<Model.Data.Field.ZapisVr> fields, List<Model.Data.Filter.ZapisVr>  filter, List<Model.Data.Sort.ZapisVr>  sort, long? start = null, long? count = null);
    
    }
    
}
