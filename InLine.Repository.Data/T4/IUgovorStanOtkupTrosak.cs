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
    
    public partial interface IUgovorStanOtkupTrosak
    {
       		
    		void Delete(Model.Data.Item.UgovorStanOtkupTrosakItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.UgovorStanOtkupTrosakItem item);
            								
    		void Insert(Model.Data.Item.UgovorStanOtkupTrosakItem item);
    
    		ObjectResult<Model.Data.UgovorStanOtkupTrosak> InsertResult(Model.Data.Item.UgovorStanOtkupTrosakItem item);
    										
    			
    		void Select(Nullable<long> ID_UgovorStanOtkupTrosak);
    
    			ObjectResult<Model.Data.UgovorStanOtkupTrosak> SelectResult(Nullable<long> ID_UgovorStanOtkupTrosak);
            				
    			
    		void Update(Model.Data.Item.UgovorStanOtkupTrosakItem item);
    
    				
    		ObjectResult<Model.Data.UgovorStanOtkupTrosak> UpdateResult (Model.Data.Item.UgovorStanOtkupTrosakItem item);
    							
    	
    	Model.Data.UgovorStanOtkupTrosak FindID(long id);
    	
    	//IEnumerable <Model.Data.UgovorStanOtkupTrosak> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.UgovorStanOtkupTrosak> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.UgovorStanOtkupTrosak> GetData(List<Model.Data.Field.UgovorStanOtkupTrosak> fields, List<Model.Data.Filter.UgovorStanOtkupTrosak>  filter, List<Model.Data.Sort.UgovorStanOtkupTrosak>  sort, long? start = null, long? count = null);
    
    }
    
}
