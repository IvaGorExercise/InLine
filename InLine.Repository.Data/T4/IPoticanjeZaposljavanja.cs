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
    
    public partial interface IPoticanjeZaposljavanja
    {
       		
    		void Delete(Model.Data.Item.PoticanjeZaposljavanjaItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.PoticanjeZaposljavanjaItem item);
            								
    		void Insert(Model.Data.Item.PoticanjeZaposljavanjaItem item);
    
    		ObjectResult<Model.Data.PoticanjeZaposljavanja> InsertResult(Model.Data.Item.PoticanjeZaposljavanjaItem item);
    										
    			
    		void Select(Nullable<int> IDPoticanjeZaposljavanja);
    
    			ObjectResult<Model.Data.PoticanjeZaposljavanja> SelectResult(Nullable<int> IDPoticanjeZaposljavanja);
            				
    			
    		void Update(Model.Data.Item.PoticanjeZaposljavanjaItem item);
    
    				
    		ObjectResult<Model.Data.PoticanjeZaposljavanja> UpdateResult (Model.Data.Item.PoticanjeZaposljavanjaItem item);
    							
    	
    	Model.Data.PoticanjeZaposljavanja FindID(long id);
    	
    	//IEnumerable <Model.Data.PoticanjeZaposljavanja> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.PoticanjeZaposljavanja> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.PoticanjeZaposljavanja> GetData(List<Model.Data.Field.PoticanjeZaposljavanja> fields, List<Model.Data.Filter.PoticanjeZaposljavanja>  filter, List<Model.Data.Sort.PoticanjeZaposljavanja>  sort, long? start = null, long? count = null);
    
    }
    
}