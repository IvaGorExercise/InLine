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
    
    public partial interface IDokumentGr
    {
       		
    		void Delete(Model.Data.Item.DokumentGrItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.DokumentGrItem item);
            								
    		void Insert(Model.Data.Item.DokumentGrItem item);
    
    		ObjectResult<Model.Data.DokumentGr> InsertResult(Model.Data.Item.DokumentGrItem item);
    										
    			
    		void Select(Nullable<int> IDDokumentGr);
    
    			ObjectResult<Model.Data.DokumentGr> SelectResult(Nullable<int> IDDokumentGr);
            				
    			
    		void Update(Model.Data.Item.DokumentGrItem item);
    
    				
    		ObjectResult<Model.Data.DokumentGr> UpdateResult (Model.Data.Item.DokumentGrItem item);
    							
    	
    	Model.Data.DokumentGr FindID(long id);
    	
    	//IEnumerable <Model.Data.DokumentGr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.DokumentGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.DokumentGr> GetData(List<Model.Data.Field.DokumentGr> fields, List<Model.Data.Filter.DokumentGr>  filter, List<Model.Data.Sort.DokumentGr>  sort, long? start = null, long? count = null);
    
    }
    
}
