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
    
    public partial interface ISubjektFunkcija
    {
       		
    		void Delete(Model.Data.Item.SubjektFunkcijaItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.SubjektFunkcijaItem item);
            								
    		void Insert(Model.Data.Item.SubjektFunkcijaItem item);
    
    		ObjectResult<Model.Data.SubjektFunkcija> InsertResult(Model.Data.Item.SubjektFunkcijaItem item);
    										
    			
    		void Select(Nullable<int> IDSubjektFunkcija);
    
    			ObjectResult<Model.Data.SubjektFunkcija> SelectResult(Nullable<int> IDSubjektFunkcija);
            				
    			
    		void Update(Model.Data.Item.SubjektFunkcijaItem item);
    
    				
    		ObjectResult<Model.Data.SubjektFunkcija> UpdateResult (Model.Data.Item.SubjektFunkcijaItem item);
    							
    	
    	Model.Data.SubjektFunkcija FindID(long id);
    	
    	//IEnumerable <Model.Data.SubjektFunkcija> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.SubjektFunkcija> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.SubjektFunkcija> GetData(List<Model.Data.Field.SubjektFunkcija> fields, List<Model.Data.Filter.SubjektFunkcija>  filter, List<Model.Data.Sort.SubjektFunkcija>  sort, long? start = null, long? count = null);
    
    }
    
}
