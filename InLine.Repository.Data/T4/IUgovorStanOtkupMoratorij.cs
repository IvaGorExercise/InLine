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
    
    public partial interface IUgovorStanOtkupMoratorij
    {
       		
    		void Delete(Model.Data.Item.UgovorStanOtkupMoratorijItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.UgovorStanOtkupMoratorijItem item);
            								
    		void Insert(Model.Data.Item.UgovorStanOtkupMoratorijItem item);
    
    		ObjectResult<Model.Data.UgovorStanOtkupMoratorij> InsertResult(Model.Data.Item.UgovorStanOtkupMoratorijItem item);
    										
    			
    		void Select(Nullable<long> ID_UgovorStanOtkupMoratorij);
    
    			ObjectResult<Model.Data.UgovorStanOtkupMoratorij> SelectResult(Nullable<long> ID_UgovorStanOtkupMoratorij);
            				
    			
    		void Update(Model.Data.Item.UgovorStanOtkupMoratorijItem item);
    
    				
    		ObjectResult<Model.Data.UgovorStanOtkupMoratorij> UpdateResult (Model.Data.Item.UgovorStanOtkupMoratorijItem item);
    							
    	
    	Model.Data.UgovorStanOtkupMoratorij FindID(long id);
    	
    	//IEnumerable <Model.Data.UgovorStanOtkupMoratorij> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.UgovorStanOtkupMoratorij> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.UgovorStanOtkupMoratorij> GetData(List<Model.Data.Field.UgovorStanOtkupMoratorij> fields, List<Model.Data.Filter.UgovorStanOtkupMoratorij>  filter, List<Model.Data.Sort.UgovorStanOtkupMoratorij>  sort, long? start = null, long? count = null);
    
    }
    
}