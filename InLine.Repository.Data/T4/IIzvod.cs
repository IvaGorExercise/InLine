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
    
    public partial interface IIzvod
    {
       		
    		void Delete(Model.Data.Item.IzvodItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.IzvodItem item);
            								
    			
    		void Select(Nullable<long> ID_Izvod);
    
    			ObjectResult<Model.Data.Izvod> SelectResult(Nullable<long> ID_Izvod);
            				
    		void Insert(Model.Data.Item.IzvodItem item);
    
    		ObjectResult<Model.Data.Izvod> InsertResult(Model.Data.Item.IzvodItem item);
    										
    			
    		void Update(Model.Data.Item.IzvodItem item);
    
    				
    		ObjectResult<Model.Data.Izvod> UpdateResult (Model.Data.Item.IzvodItem item);
    							
    	
    	Model.Data.Izvod FindID(long id);
    	
    	//IEnumerable <Model.Data.Izvod> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.Izvod> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.Izvod> GetData(List<Model.Data.Field.Izvod> fields, List<Model.Data.Filter.Izvod>  filter, List<Model.Data.Sort.Izvod>  sort, long? start = null, long? count = null);
    
    }
    
}
