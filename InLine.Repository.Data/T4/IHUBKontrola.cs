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
    
    public partial interface IHUBKontrola
    {
       		
    		void Delete(Model.Data.Item.HUBKontrolaItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.HUBKontrolaItem item);
            								
    		void Insert(Model.Data.Item.HUBKontrolaItem item);
    
    		ObjectResult<Model.Data.HUBKontrola> InsertResult(Model.Data.Item.HUBKontrolaItem item);
    										
    			
    		void Select(Nullable<int> IDHUBKontrola);
    
    			ObjectResult<Model.Data.HUBKontrola> SelectResult(Nullable<int> IDHUBKontrola);
            				
    			
    		void Update(Model.Data.Item.HUBKontrolaItem item);
    
    				
    		ObjectResult<Model.Data.HUBKontrola> UpdateResult (Model.Data.Item.HUBKontrolaItem item);
    							
    	
    	Model.Data.HUBKontrola FindID(long id);
    	
    	//IEnumerable <Model.Data.HUBKontrola> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.HUBKontrola> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.HUBKontrola> GetData(List<Model.Data.Field.HUBKontrola> fields, List<Model.Data.Filter.HUBKontrola>  filter, List<Model.Data.Sort.HUBKontrola>  sort, long? start = null, long? count = null);
    
    }
    
}
