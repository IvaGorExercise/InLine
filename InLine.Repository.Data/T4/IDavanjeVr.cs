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
    
    public partial interface IDavanjeVr
    {
       		
    		void Delete(Model.Data.Item.DavanjeVrItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.DavanjeVrItem item);
            								
    		void Insert(Model.Data.Item.DavanjeVrItem item);
    
    		ObjectResult<Model.Data.DavanjeVr> InsertResult(Model.Data.Item.DavanjeVrItem item);
    										
    			
    		void Select(Nullable<int> IDDavanjeVr);
    
    			ObjectResult<Model.Data.DavanjeVr> SelectResult(Nullable<int> IDDavanjeVr);
            				
    			
    		void Update(Model.Data.Item.DavanjeVrItem item);
    
    				
    		ObjectResult<Model.Data.DavanjeVr> UpdateResult (Model.Data.Item.DavanjeVrItem item);
    							
    	
    	Model.Data.DavanjeVr FindID(long id);
    	
    	//IEnumerable <Model.Data.DavanjeVr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.DavanjeVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.DavanjeVr> GetData(List<Model.Data.Field.DavanjeVr> fields, List<Model.Data.Filter.DavanjeVr>  filter, List<Model.Data.Sort.DavanjeVr>  sort, long? start = null, long? count = null);
    
    }
    
}