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
    
    public partial interface IRacunIzlaz
    {
       		
    		void Delete(Model.Data.Item.RacunIzlazItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.RacunIzlazItem item);
            								
    		void Insert(Model.Data.Item.RacunIzlazItem item);
    
    		ObjectResult<Model.Data.RacunIzlaz> InsertResult(Model.Data.Item.RacunIzlazItem item);
    										
    			
    		void Select(Nullable<long> ID_RacunIzlaz);
    
    			ObjectResult<Model.Data.RacunIzlaz> SelectResult(Nullable<long> ID_RacunIzlaz);
            				
    			
    		void Update(Model.Data.Item.RacunIzlazItem item);
    
    				
    		ObjectResult<Model.Data.RacunIzlaz> UpdateResult (Model.Data.Item.RacunIzlazItem item);
    							
    	
    	Model.Data.RacunIzlaz FindID(long id);
    	
    	//IEnumerable <Model.Data.RacunIzlaz> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.RacunIzlaz> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.RacunIzlaz> GetData(List<Model.Data.Field.RacunIzlaz> fields, List<Model.Data.Filter.RacunIzlaz>  filter, List<Model.Data.Sort.RacunIzlaz>  sort, long? start = null, long? count = null);
    
    }
    
}
