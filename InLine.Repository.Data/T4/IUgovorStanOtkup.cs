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
    
    public partial interface IUgovorStanOtkup
    {
       		
    		void Delete(Model.Data.Item.UgovorStanOtkupItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.UgovorStanOtkupItem item);
            								
    		void Insert(Model.Data.Item.UgovorStanOtkupItem item);
    
    		ObjectResult<Model.Data.UgovorStanOtkup> InsertResult(Model.Data.Item.UgovorStanOtkupItem item);
    										
    			
    		void Select(Nullable<long> ID_UgovorStanOtkup);
    
    			ObjectResult<Model.Data.UgovorStanOtkup> SelectResult(Nullable<long> ID_UgovorStanOtkup);
            				
    			
    		void Update(Model.Data.Item.UgovorStanOtkupItem item);
    
    				
    		ObjectResult<Model.Data.UgovorStanOtkup> UpdateResult (Model.Data.Item.UgovorStanOtkupItem item);
    							
    	
    	Model.Data.UgovorStanOtkup FindID(long id);
    	
    	//IEnumerable <Model.Data.UgovorStanOtkup> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.UgovorStanOtkup> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.UgovorStanOtkup> GetData(List<Model.Data.Field.UgovorStanOtkup> fields, List<Model.Data.Filter.UgovorStanOtkup>  filter, List<Model.Data.Sort.UgovorStanOtkup>  sort, long? start = null, long? count = null);
    
    }
    
}
