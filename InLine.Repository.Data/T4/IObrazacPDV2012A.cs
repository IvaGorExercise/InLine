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
    
    public partial interface IObrazacPDV2012A
    {
       		
    		void Delete(Model.Data.Item.ObrazacPDV2012AItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacPDV2012AItem item);
            								
    		void Insert(Model.Data.Item.ObrazacPDV2012AItem item);
    
    		ObjectResult<Model.Data.ObrazacPDV2012A> InsertResult(Model.Data.Item.ObrazacPDV2012AItem item);
    										
    			
    		void Select(Nullable<long> ID_ObrazacPDV2012A);
    
    			ObjectResult<Model.Data.ObrazacPDV2012A> SelectResult(Nullable<long> ID_ObrazacPDV2012A);
            				
    			
    		void Update(Model.Data.Item.ObrazacPDV2012AItem item);
    
    				
    		ObjectResult<Model.Data.ObrazacPDV2012A> UpdateResult (Model.Data.Item.ObrazacPDV2012AItem item);
    							
    	
    	Model.Data.ObrazacPDV2012A FindID(long id);
    	
    	//IEnumerable <Model.Data.ObrazacPDV2012A> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.ObrazacPDV2012A> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.ObrazacPDV2012A> GetData(List<Model.Data.Field.ObrazacPDV2012A> fields, List<Model.Data.Filter.ObrazacPDV2012A>  filter, List<Model.Data.Sort.ObrazacPDV2012A>  sort, long? start = null, long? count = null);
    
    }
    
}
