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
    
    public partial interface IDavanjePDVVr
    {
       		
    		void Delete(Model.Data.Item.DavanjePDVVrItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.DavanjePDVVrItem item);
            								
    		void Insert(Model.Data.Item.DavanjePDVVrItem item);
    
    		ObjectResult<Model.Data.DavanjePDVVr> InsertResult(Model.Data.Item.DavanjePDVVrItem item);
    										
    			
    		void Select(Nullable<int> IDDavanjePDVVr);
    
    			ObjectResult<Model.Data.DavanjePDVVr> SelectResult(Nullable<int> IDDavanjePDVVr);
            				
    			
    		void Update(Model.Data.Item.DavanjePDVVrItem item);
    
    				
    		ObjectResult<Model.Data.DavanjePDVVr> UpdateResult (Model.Data.Item.DavanjePDVVrItem item);
    							
    	
    	Model.Data.DavanjePDVVr FindID(long id);
    	
    	//IEnumerable <Model.Data.DavanjePDVVr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.DavanjePDVVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.DavanjePDVVr> GetData(List<Model.Data.Field.DavanjePDVVr> fields, List<Model.Data.Filter.DavanjePDVVr>  filter, List<Model.Data.Sort.DavanjePDVVr>  sort, long? start = null, long? count = null);
    
    }
    
}