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
    
    public partial interface IObrazacIPIdentifikator2005A
    {
       		
    		void Delete(Model.Data.Item.ObrazacIPIdentifikator2005AItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacIPIdentifikator2005AItem item);
            								
    		void Insert(Model.Data.Item.ObrazacIPIdentifikator2005AItem item);
    
    		ObjectResult<Model.Data.ObrazacIPIdentifikator2005A> InsertResult(Model.Data.Item.ObrazacIPIdentifikator2005AItem item);
    										
    			
    		void Select(Nullable<int> IDObrazacIPIdentifikator2005A);
    
    			ObjectResult<Model.Data.ObrazacIPIdentifikator2005A> SelectResult(Nullable<int> IDObrazacIPIdentifikator2005A);
            				
    			
    		void Update(Model.Data.Item.ObrazacIPIdentifikator2005AItem item);
    
    				
    		ObjectResult<Model.Data.ObrazacIPIdentifikator2005A> UpdateResult (Model.Data.Item.ObrazacIPIdentifikator2005AItem item);
    							
    	
    	Model.Data.ObrazacIPIdentifikator2005A FindID(long id);
    	
    	//IEnumerable <Model.Data.ObrazacIPIdentifikator2005A> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.ObrazacIPIdentifikator2005A> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.ObrazacIPIdentifikator2005A> GetData(List<Model.Data.Field.ObrazacIPIdentifikator2005A> fields, List<Model.Data.Filter.ObrazacIPIdentifikator2005A>  filter, List<Model.Data.Sort.ObrazacIPIdentifikator2005A>  sort, long? start = null, long? count = null);
    
    }
    
}
