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
    
    public partial interface ITecajListaSt
    {
       		
    		void Delete(Model.Data.Item.TecajListaStItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.TecajListaStItem item);
            								
    		void Insert(Model.Data.Item.TecajListaStItem item);
    
    		ObjectResult<Model.Data.TecajListaSt> InsertResult(Model.Data.Item.TecajListaStItem item);
    										
    			
    		void Select(Nullable<long> ID_TecajListaSt);
    
    			ObjectResult<Model.Data.TecajListaSt> SelectResult(Nullable<long> ID_TecajListaSt);
            				
    			
    		void Update(Model.Data.Item.TecajListaStItem item);
    
    				
    		ObjectResult<Model.Data.TecajListaSt> UpdateResult (Model.Data.Item.TecajListaStItem item);
    							
    	
    	Model.Data.TecajListaSt FindID(long id);
    	
    	//IEnumerable <Model.Data.TecajListaSt> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.TecajListaSt> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.TecajListaSt> GetData(List<Model.Data.Field.TecajListaSt> fields, List<Model.Data.Filter.TecajListaSt>  filter, List<Model.Data.Sort.TecajListaSt>  sort, long? start = null, long? count = null);
    
    }
    
}