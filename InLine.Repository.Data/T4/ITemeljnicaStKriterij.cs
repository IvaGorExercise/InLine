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
    
    public partial interface ITemeljnicaStKriterij
    {
       		
    		void Delete(Model.Data.Item.TemeljnicaStKriterijItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.TemeljnicaStKriterijItem item);
            								
    		void Insert(Model.Data.Item.TemeljnicaStKriterijItem item);
    
    		ObjectResult<Model.Data.TemeljnicaStKriterij> InsertResult(Model.Data.Item.TemeljnicaStKriterijItem item);
    										
    			
    		void Select(Nullable<long> ID_TemeljnicaStKriterij);
    
    			ObjectResult<Model.Data.TemeljnicaStKriterij> SelectResult(Nullable<long> ID_TemeljnicaStKriterij);
            				
    			
    		void Update(Model.Data.Item.TemeljnicaStKriterijItem item);
    
    				
    		ObjectResult<Model.Data.TemeljnicaStKriterij> UpdateResult (Model.Data.Item.TemeljnicaStKriterijItem item);
    							
    	
    	Model.Data.TemeljnicaStKriterij FindID(long id);
    	
    	//IEnumerable <Model.Data.TemeljnicaStKriterij> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.TemeljnicaStKriterij> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.TemeljnicaStKriterij> GetData(List<Model.Data.Field.TemeljnicaStKriterij> fields, List<Model.Data.Filter.TemeljnicaStKriterij>  filter, List<Model.Data.Sort.TemeljnicaStKriterij>  sort, long? start = null, long? count = null);
    
    }
    
}
