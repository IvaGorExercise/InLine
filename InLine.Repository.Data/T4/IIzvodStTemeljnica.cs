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
    
    public partial interface IIzvodStTemeljnica
    {
       		
    		void Delete(Model.Data.Item.IzvodStTemeljnicaItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.IzvodStTemeljnicaItem item);
            								
    		void Insert(Model.Data.Item.IzvodStTemeljnicaItem item);
    
    		ObjectResult<Model.Data.IzvodStTemeljnica> InsertResult(Model.Data.Item.IzvodStTemeljnicaItem item);
    										
    			
    		void Select(Nullable<long> ID_IzvodStTemeljnica);
    
    			ObjectResult<Model.Data.IzvodStTemeljnica> SelectResult(Nullable<long> ID_IzvodStTemeljnica);
            				
    			
    		void Update(Model.Data.Item.IzvodStTemeljnicaItem item);
    
    				
    		ObjectResult<Model.Data.IzvodStTemeljnica> UpdateResult (Model.Data.Item.IzvodStTemeljnicaItem item);
    							
    	
    	Model.Data.IzvodStTemeljnica FindID(long id);
    	
    	//IEnumerable <Model.Data.IzvodStTemeljnica> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.IzvodStTemeljnica> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.IzvodStTemeljnica> GetData(List<Model.Data.Field.IzvodStTemeljnica> fields, List<Model.Data.Filter.IzvodStTemeljnica>  filter, List<Model.Data.Sort.IzvodStTemeljnica>  sort, long? start = null, long? count = null);
    
    }
    
}
