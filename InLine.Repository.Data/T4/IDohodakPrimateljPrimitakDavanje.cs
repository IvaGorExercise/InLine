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
    
    public partial interface IDohodakPrimateljPrimitakDavanje
    {
       		
    		void Delete(Model.Data.Item.DohodakPrimateljPrimitakDavanjeItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.DohodakPrimateljPrimitakDavanjeItem item);
            								
    		void Insert(Model.Data.Item.DohodakPrimateljPrimitakDavanjeItem item);
    
    		ObjectResult<Model.Data.DohodakPrimateljPrimitakDavanje> InsertResult(Model.Data.Item.DohodakPrimateljPrimitakDavanjeItem item);
    										
    			
    		void Select(Nullable<long> ID_DohodakPrimateljPrimitakDavanje);
    
    			ObjectResult<Model.Data.DohodakPrimateljPrimitakDavanje> SelectResult(Nullable<long> ID_DohodakPrimateljPrimitakDavanje);
            				
    			
    		void Update(Model.Data.Item.DohodakPrimateljPrimitakDavanjeItem item);
    
    				
    		ObjectResult<Model.Data.DohodakPrimateljPrimitakDavanje> UpdateResult (Model.Data.Item.DohodakPrimateljPrimitakDavanjeItem item);
    							
    	
    	Model.Data.DohodakPrimateljPrimitakDavanje FindID(long id);
    	
    	//IEnumerable <Model.Data.DohodakPrimateljPrimitakDavanje> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.DohodakPrimateljPrimitakDavanje> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.DohodakPrimateljPrimitakDavanje> GetData(List<Model.Data.Field.DohodakPrimateljPrimitakDavanje> fields, List<Model.Data.Filter.DohodakPrimateljPrimitakDavanje>  filter, List<Model.Data.Sort.DohodakPrimateljPrimitakDavanje>  sort, long? start = null, long? count = null);
    
    }
    
}
