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
    
    public partial interface IDrzavaRadna
    {
       		
    		void Delete(Model.Data.Item.DrzavaRadnaItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.DrzavaRadnaItem item);
            								
    		void Insert(Model.Data.Item.DrzavaRadnaItem item);
    
    		ObjectResult<Model.Data.DrzavaRadna> InsertResult(Model.Data.Item.DrzavaRadnaItem item);
    										
    			
    		void Select(Nullable<long> ID_Drzava);
    
    			ObjectResult<Model.Data.DrzavaRadna> SelectResult(Nullable<long> ID_Drzava);
            				
    			
    		void Update(Model.Data.Item.DrzavaRadnaItem item);
    
    				
    		ObjectResult<Model.Data.DrzavaRadna> UpdateResult (Model.Data.Item.DrzavaRadnaItem item);
    							
    	
    	Model.Data.DrzavaRadna FindID(long id);
    	
    	//IEnumerable <Model.Data.DrzavaRadna> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.DrzavaRadna> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.DrzavaRadna> GetData(List<Model.Data.Field.DrzavaRadna> fields, List<Model.Data.Filter.DrzavaRadna>  filter, List<Model.Data.Sort.DrzavaRadna>  sort, long? start = null, long? count = null);
    
    }
    
}
