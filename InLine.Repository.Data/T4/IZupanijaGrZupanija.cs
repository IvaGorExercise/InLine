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
    
    public partial interface IZupanijaGrZupanija
    {
       		
    		void Delete(Model.Data.Item.ZupanijaGrZupanijaItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.ZupanijaGrZupanijaItem item);
            								
    		void Insert(Model.Data.Item.ZupanijaGrZupanijaItem item);
    
    		ObjectResult<Model.Data.ZupanijaGrZupanija> InsertResult(Model.Data.Item.ZupanijaGrZupanijaItem item);
    										
    			
    		void Select(Nullable<long> ID_ZupanijaGrZupanija);
    
    			ObjectResult<Model.Data.ZupanijaGrZupanija> SelectResult(Nullable<long> ID_ZupanijaGrZupanija);
            				
    			
    		void Update(Model.Data.Item.ZupanijaGrZupanijaItem item);
    
    				
    		ObjectResult<Model.Data.ZupanijaGrZupanija> UpdateResult (Model.Data.Item.ZupanijaGrZupanijaItem item);
    							
    	
    	Model.Data.ZupanijaGrZupanija FindID(long id);
    	
    	//IEnumerable <Model.Data.ZupanijaGrZupanija> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.ZupanijaGrZupanija> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.ZupanijaGrZupanija> GetData(List<Model.Data.Field.ZupanijaGrZupanija> fields, List<Model.Data.Filter.ZupanijaGrZupanija>  filter, List<Model.Data.Sort.ZupanijaGrZupanija>  sort, long? start = null, long? count = null);
    
    }
    
}
