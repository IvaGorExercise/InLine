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
    
    public partial interface IKnjigaURAPDV
    {
       		
    		void Delete(Model.Data.Item.KnjigaURAPDVItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.KnjigaURAPDVItem item);
            								
    		void Insert(Model.Data.Item.KnjigaURAPDVItem item);
    
    		ObjectResult<Model.Data.KnjigaURAPDV> InsertResult(Model.Data.Item.KnjigaURAPDVItem item);
    										
    			
    		void Select(Nullable<long> ID_KnjigaURAPDV);
    
    			ObjectResult<Model.Data.KnjigaURAPDV> SelectResult(Nullable<long> ID_KnjigaURAPDV);
            				
    			
    		void Update(Model.Data.Item.KnjigaURAPDVItem item);
    
    				
    		ObjectResult<Model.Data.KnjigaURAPDV> UpdateResult (Model.Data.Item.KnjigaURAPDVItem item);
    							
    	
    	Model.Data.KnjigaURAPDV FindID(long id);
    	
    	//IEnumerable <Model.Data.KnjigaURAPDV> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.KnjigaURAPDV> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.KnjigaURAPDV> GetData(List<Model.Data.Field.KnjigaURAPDV> fields, List<Model.Data.Filter.KnjigaURAPDV>  filter, List<Model.Data.Sort.KnjigaURAPDV>  sort, long? start = null, long? count = null);
    
    }
    
}
