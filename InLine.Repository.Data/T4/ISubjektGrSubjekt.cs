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
    
    public partial interface ISubjektGrSubjekt
    {
       		
    		void Delete(Model.Data.Item.SubjektGrSubjektItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.SubjektGrSubjektItem item);
            								
    		void Insert(Model.Data.Item.SubjektGrSubjektItem item);
    
    		ObjectResult<Model.Data.SubjektGrSubjekt> InsertResult(Model.Data.Item.SubjektGrSubjektItem item);
    										
    			
    		void Select(Nullable<long> ID_SubjektGrSubjekt);
    
    			ObjectResult<Model.Data.SubjektGrSubjekt> SelectResult(Nullable<long> ID_SubjektGrSubjekt);
            				
    			
    		void Update(Model.Data.Item.SubjektGrSubjektItem item);
    
    				
    		ObjectResult<Model.Data.SubjektGrSubjekt> UpdateResult (Model.Data.Item.SubjektGrSubjektItem item);
    							
    	
    	Model.Data.SubjektGrSubjekt FindID(long id);
    	
    	//IEnumerable <Model.Data.SubjektGrSubjekt> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.SubjektGrSubjekt> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.SubjektGrSubjekt> GetData(List<Model.Data.Field.SubjektGrSubjekt> fields, List<Model.Data.Filter.SubjektGrSubjekt>  filter, List<Model.Data.Sort.SubjektGrSubjekt>  sort, long? start = null, long? count = null);
    
    }
    
}
