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
    
    public partial interface IOsnovnoSredstvoDnevnik
    {
       		
    		void Delete(Model.Data.Item.OsnovnoSredstvoDnevnikItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.OsnovnoSredstvoDnevnikItem item);
            								
    		void Insert(Model.Data.Item.OsnovnoSredstvoDnevnikItem item);
    
    		ObjectResult<Model.Data.OsnovnoSredstvoDnevnik> InsertResult(Model.Data.Item.OsnovnoSredstvoDnevnikItem item);
    										
    			
    		void Select(Nullable<long> ID_OsnovnoSredstvoDnevnik);
    
    			ObjectResult<Model.Data.OsnovnoSredstvoDnevnik> SelectResult(Nullable<long> ID_OsnovnoSredstvoDnevnik);
            				
    			
    		void Update(Model.Data.Item.OsnovnoSredstvoDnevnikItem item);
    
    				
    		ObjectResult<Model.Data.OsnovnoSredstvoDnevnik> UpdateResult (Model.Data.Item.OsnovnoSredstvoDnevnikItem item);
    							
    	
    	Model.Data.OsnovnoSredstvoDnevnik FindID(long id);
    	
    	//IEnumerable <Model.Data.OsnovnoSredstvoDnevnik> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.OsnovnoSredstvoDnevnik> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.OsnovnoSredstvoDnevnik> GetData(List<Model.Data.Field.OsnovnoSredstvoDnevnik> fields, List<Model.Data.Filter.OsnovnoSredstvoDnevnik>  filter, List<Model.Data.Sort.OsnovnoSredstvoDnevnik>  sort, long? start = null, long? count = null);
    
    }
    
}
