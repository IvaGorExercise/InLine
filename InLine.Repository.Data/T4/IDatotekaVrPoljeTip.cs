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
    
    public partial interface IDatotekaVrPoljeTip
    {
       		
    		void Delete(Model.Data.Item.DatotekaVrPoljeTipItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.DatotekaVrPoljeTipItem item);
            								
    		void Insert(Model.Data.Item.DatotekaVrPoljeTipItem item);
    
    		ObjectResult<Model.Data.DatotekaVrPoljeTip> InsertResult(Model.Data.Item.DatotekaVrPoljeTipItem item);
    										
    			
    		void Select(Nullable<long> ID_DatotekaVrPoljeTip);
    
    			ObjectResult<Model.Data.DatotekaVrPoljeTip> SelectResult(Nullable<long> ID_DatotekaVrPoljeTip);
            				
    			
    		void Update(Model.Data.Item.DatotekaVrPoljeTipItem item);
    
    				
    		ObjectResult<Model.Data.DatotekaVrPoljeTip> UpdateResult (Model.Data.Item.DatotekaVrPoljeTipItem item);
    							
    	
    	Model.Data.DatotekaVrPoljeTip FindID(long id);
    	
    	//IEnumerable <Model.Data.DatotekaVrPoljeTip> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.DatotekaVrPoljeTip> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.DatotekaVrPoljeTip> GetData(List<Model.Data.Field.DatotekaVrPoljeTip> fields, List<Model.Data.Filter.DatotekaVrPoljeTip>  filter, List<Model.Data.Sort.DatotekaVrPoljeTip>  sort, long? start = null, long? count = null);
    
    }
    
}
