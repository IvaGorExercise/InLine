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
    
    public partial interface ISubjektVrTablica
    {
       		
    		void Delete(Model.Data.Item.SubjektVrTablicaItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.SubjektVrTablicaItem item);
            								
    		void Insert(Model.Data.Item.SubjektVrTablicaItem item);
    
    		ObjectResult<Model.Data.SubjektVrTablica> InsertResult(Model.Data.Item.SubjektVrTablicaItem item);
    										
    			
    		void Select(Nullable<int> IDSubjektVr);
    
    			ObjectResult<Model.Data.SubjektVrTablica> SelectResult(Nullable<int> IDSubjektVr);
            				
    			
    		void Update(Model.Data.Item.SubjektVrTablicaItem item);
    
    				
    		ObjectResult<Model.Data.SubjektVrTablica> UpdateResult (Model.Data.Item.SubjektVrTablicaItem item);
    							
    	
    	Model.Data.SubjektVrTablica FindID(long id);
    	
    	//IEnumerable <Model.Data.SubjektVrTablica> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.SubjektVrTablica> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.SubjektVrTablica> GetData(List<Model.Data.Field.SubjektVrTablica> fields, List<Model.Data.Filter.SubjektVrTablica>  filter, List<Model.Data.Sort.SubjektVrTablica>  sort, long? start = null, long? count = null);
    
    }
    
}