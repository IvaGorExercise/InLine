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
    
    public partial interface IPraznikPraviloPomak
    {
       		
    		void Delete(Model.Data.Item.PraznikPraviloPomakItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.PraznikPraviloPomakItem item);
            								
    		void Insert(Model.Data.Item.PraznikPraviloPomakItem item);
    
    		ObjectResult<Model.Data.PraznikPraviloPomak> InsertResult(Model.Data.Item.PraznikPraviloPomakItem item);
    										
    			
    		void Select(Nullable<long> ID_PraznikPraviloPomak);
    
    			ObjectResult<Model.Data.PraznikPraviloPomak> SelectResult(Nullable<long> ID_PraznikPraviloPomak);
            				
    			
    		void Update(Model.Data.Item.PraznikPraviloPomakItem item);
    
    				
    		ObjectResult<Model.Data.PraznikPraviloPomak> UpdateResult (Model.Data.Item.PraznikPraviloPomakItem item);
    							
    	
    	Model.Data.PraznikPraviloPomak FindID(long id);
    	
    	//IEnumerable <Model.Data.PraznikPraviloPomak> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.PraznikPraviloPomak> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.PraznikPraviloPomak> GetData(List<Model.Data.Field.PraznikPraviloPomak> fields, List<Model.Data.Filter.PraznikPraviloPomak>  filter, List<Model.Data.Sort.PraznikPraviloPomak>  sort, long? start = null, long? count = null);
    
    }
    
}