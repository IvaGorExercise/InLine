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
    
    public partial interface IDohodakPrimateljIsplataGotovina
    {
       		
    		void Delete(Model.Data.Item.DohodakPrimateljIsplataGotovinaItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.DohodakPrimateljIsplataGotovinaItem item);
            								
    		void Insert(Model.Data.Item.DohodakPrimateljIsplataGotovinaItem item);
    
    		ObjectResult<Model.Data.DohodakPrimateljIsplataGotovina> InsertResult(Model.Data.Item.DohodakPrimateljIsplataGotovinaItem item);
    										
    			
    		void Select(Nullable<long> ID_DohodakPrimateljIsplataGotovina);
    
    			ObjectResult<Model.Data.DohodakPrimateljIsplataGotovina> SelectResult(Nullable<long> ID_DohodakPrimateljIsplataGotovina);
            				
    			
    		void Update(Model.Data.Item.DohodakPrimateljIsplataGotovinaItem item);
    
    				
    		ObjectResult<Model.Data.DohodakPrimateljIsplataGotovina> UpdateResult (Model.Data.Item.DohodakPrimateljIsplataGotovinaItem item);
    							
    	
    	Model.Data.DohodakPrimateljIsplataGotovina FindID(long id);
    	
    	//IEnumerable <Model.Data.DohodakPrimateljIsplataGotovina> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.DohodakPrimateljIsplataGotovina> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.DohodakPrimateljIsplataGotovina> GetData(List<Model.Data.Field.DohodakPrimateljIsplataGotovina> fields, List<Model.Data.Filter.DohodakPrimateljIsplataGotovina>  filter, List<Model.Data.Sort.DohodakPrimateljIsplataGotovina>  sort, long? start = null, long? count = null);
    
    }
    
}
