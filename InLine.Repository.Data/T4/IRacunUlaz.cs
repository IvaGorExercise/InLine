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
    
    public partial interface IRacunUlaz
    {
       		
    		void Delete(Model.Data.Item.RacunUlazItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.RacunUlazItem item);
            								
    		void Insert(Model.Data.Item.RacunUlazItem item);
    
    		ObjectResult<Model.Data.RacunUlaz> InsertResult(Model.Data.Item.RacunUlazItem item);
    										
    			
    		void Select(Nullable<long> ID_RacunUlaz);
    
    			ObjectResult<Model.Data.RacunUlaz> SelectResult(Nullable<long> ID_RacunUlaz);
            				
    			
    		void Update(Model.Data.Item.RacunUlazItem item);
    
    				
    		ObjectResult<Model.Data.RacunUlaz> UpdateResult (Model.Data.Item.RacunUlazItem item);
    							
    	
    	Model.Data.RacunUlaz FindID(long id);
    	
    	//IEnumerable <Model.Data.RacunUlaz> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.RacunUlaz> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.RacunUlaz> GetData(List<Model.Data.Field.RacunUlaz> fields, List<Model.Data.Filter.RacunUlaz>  filter, List<Model.Data.Sort.RacunUlaz>  sort, long? start = null, long? count = null);
    
    }
    
}
