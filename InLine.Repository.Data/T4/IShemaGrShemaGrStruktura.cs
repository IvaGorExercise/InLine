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
    
    public partial interface IShemaGrShemaGrStruktura
    {
       		
    		void Delete(Model.Data.Item.ShemaGrShemaGrStrukturaItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.ShemaGrShemaGrStrukturaItem item);
            								
    		void Insert(Model.Data.Item.ShemaGrShemaGrStrukturaItem item);
    
    		ObjectResult<Model.Data.ShemaGrShemaGrStruktura> InsertResult(Model.Data.Item.ShemaGrShemaGrStrukturaItem item);
    										
    			
    		void Select(Nullable<long> ID_ShemaGrShemaGrStruktura);
    
    			ObjectResult<Model.Data.ShemaGrShemaGrStruktura> SelectResult(Nullable<long> ID_ShemaGrShemaGrStruktura);
            				
    			
    		void Update(Model.Data.Item.ShemaGrShemaGrStrukturaItem item);
    
    				
    		ObjectResult<Model.Data.ShemaGrShemaGrStruktura> UpdateResult (Model.Data.Item.ShemaGrShemaGrStrukturaItem item);
    							
    	
    	Model.Data.ShemaGrShemaGrStruktura FindID(long id);
    	
    	//IEnumerable <Model.Data.ShemaGrShemaGrStruktura> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.ShemaGrShemaGrStruktura> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.ShemaGrShemaGrStruktura> GetData(List<Model.Data.Field.ShemaGrShemaGrStruktura> fields, List<Model.Data.Filter.ShemaGrShemaGrStruktura>  filter, List<Model.Data.Sort.ShemaGrShemaGrStruktura>  sort, long? start = null, long? count = null);
    
    }
    
}
