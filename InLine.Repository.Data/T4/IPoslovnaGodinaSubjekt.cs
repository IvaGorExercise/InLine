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
    
    public partial interface IPoslovnaGodinaSubjekt
    {
       		
    		void Delete(Model.Data.Item.PoslovnaGodinaSubjektItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.PoslovnaGodinaSubjektItem item);
            								
    		void Insert(Model.Data.Item.PoslovnaGodinaSubjektItem item);
    
    		ObjectResult<Model.Data.PoslovnaGodinaSubjekt> InsertResult(Model.Data.Item.PoslovnaGodinaSubjektItem item);
    										
    			
    		void Select(Nullable<long> ID_PoslovnaGodinaSubjekt);
    
    			ObjectResult<Model.Data.PoslovnaGodinaSubjekt> SelectResult(Nullable<long> ID_PoslovnaGodinaSubjekt);
            				
    			
    		void Update(Model.Data.Item.PoslovnaGodinaSubjektItem item);
    
    				
    		ObjectResult<Model.Data.PoslovnaGodinaSubjekt> UpdateResult (Model.Data.Item.PoslovnaGodinaSubjektItem item);
    							
    	
    	Model.Data.PoslovnaGodinaSubjekt FindID(long id);
    	
    	//IEnumerable <Model.Data.PoslovnaGodinaSubjekt> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.PoslovnaGodinaSubjekt> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.PoslovnaGodinaSubjekt> GetData(List<Model.Data.Field.PoslovnaGodinaSubjekt> fields, List<Model.Data.Filter.PoslovnaGodinaSubjekt>  filter, List<Model.Data.Sort.PoslovnaGodinaSubjekt>  sort, long? start = null, long? count = null);
    
    }
    
}
