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
    
    public partial interface IObrazacIDVerzija
    {
       		
    		void Delete(Model.Data.Item.ObrazacIDVerzijaItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacIDVerzijaItem item);
            								
    		void Insert(Model.Data.Item.ObrazacIDVerzijaItem item);
    
    		ObjectResult<Model.Data.ObrazacIDVerzija> InsertResult(Model.Data.Item.ObrazacIDVerzijaItem item);
    										
    			
    		void Select(Nullable<int> IDObrazacIDVerzija);
    
    			ObjectResult<Model.Data.ObrazacIDVerzija> SelectResult(Nullable<int> IDObrazacIDVerzija);
            				
    			
    		void Update(Model.Data.Item.ObrazacIDVerzijaItem item);
    
    				
    		ObjectResult<Model.Data.ObrazacIDVerzija> UpdateResult (Model.Data.Item.ObrazacIDVerzijaItem item);
    							
    	
    	Model.Data.ObrazacIDVerzija FindID(long id);
    	
    	//IEnumerable <Model.Data.ObrazacIDVerzija> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.ObrazacIDVerzija> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.ObrazacIDVerzija> GetData(List<Model.Data.Field.ObrazacIDVerzija> fields, List<Model.Data.Filter.ObrazacIDVerzija>  filter, List<Model.Data.Sort.ObrazacIDVerzija>  sort, long? start = null, long? count = null);
    
    }
    
}
