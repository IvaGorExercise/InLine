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
    
    public partial interface IObrazacID1Verzija
    {
       		
    		void Delete(Model.Data.Item.ObrazacID1VerzijaItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacID1VerzijaItem item);
            								
    		void Insert(Model.Data.Item.ObrazacID1VerzijaItem item);
    
    		ObjectResult<Model.Data.ObrazacID1Verzija> InsertResult(Model.Data.Item.ObrazacID1VerzijaItem item);
    										
    			
    		void Select(Nullable<int> IDObrazacID1Verzija);
    
    			ObjectResult<Model.Data.ObrazacID1Verzija> SelectResult(Nullable<int> IDObrazacID1Verzija);
            				
    			
    		void Update(Model.Data.Item.ObrazacID1VerzijaItem item);
    
    				
    		ObjectResult<Model.Data.ObrazacID1Verzija> UpdateResult (Model.Data.Item.ObrazacID1VerzijaItem item);
    							
    	
    	Model.Data.ObrazacID1Verzija FindID(long id);
    	
    	//IEnumerable <Model.Data.ObrazacID1Verzija> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.ObrazacID1Verzija> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.ObrazacID1Verzija> GetData(List<Model.Data.Field.ObrazacID1Verzija> fields, List<Model.Data.Filter.ObrazacID1Verzija>  filter, List<Model.Data.Sort.ObrazacID1Verzija>  sort, long? start = null, long? count = null);
    
    }
    
}
