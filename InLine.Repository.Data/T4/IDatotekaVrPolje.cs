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
    
    public partial interface IDatotekaVrPolje
    {
       		
    		void Delete(Model.Data.Item.DatotekaVrPoljeItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.DatotekaVrPoljeItem item);
            								
    		void Insert(Model.Data.Item.DatotekaVrPoljeItem item);
    
    		ObjectResult<Model.Data.DatotekaVrPolje> InsertResult(Model.Data.Item.DatotekaVrPoljeItem item);
    										
    			
    		void Select(Nullable<long> ID_DatotekaVrPolje);
    
    			ObjectResult<Model.Data.DatotekaVrPolje> SelectResult(Nullable<long> ID_DatotekaVrPolje);
            				
    			
    		void Update(Model.Data.Item.DatotekaVrPoljeItem item);
    
    				
    		ObjectResult<Model.Data.DatotekaVrPolje> UpdateResult (Model.Data.Item.DatotekaVrPoljeItem item);
    							
    	
    	Model.Data.DatotekaVrPolje FindID(long id);
    	
    	//IEnumerable <Model.Data.DatotekaVrPolje> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.DatotekaVrPolje> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.DatotekaVrPolje> GetData(List<Model.Data.Field.DatotekaVrPolje> fields, List<Model.Data.Filter.DatotekaVrPolje>  filter, List<Model.Data.Sort.DatotekaVrPolje>  sort, long? start = null, long? count = null);
    
    }
    
}