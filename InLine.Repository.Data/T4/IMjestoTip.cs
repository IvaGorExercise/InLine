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
    
    public partial interface IMjestoTip
    {
       		
    		void Delete(Model.Data.Item.MjestoTipItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.MjestoTipItem item);
            								
    		void Insert(Model.Data.Item.MjestoTipItem item);
    
    		ObjectResult<Model.Data.MjestoTip> InsertResult(Model.Data.Item.MjestoTipItem item);
    										
    			
    		void Select(Nullable<long> ID_MjestoTip);
    
    			ObjectResult<Model.Data.MjestoTip> SelectResult(Nullable<long> ID_MjestoTip);
            				
    			
    		void Update(Model.Data.Item.MjestoTipItem item);
    
    				
    		ObjectResult<Model.Data.MjestoTip> UpdateResult (Model.Data.Item.MjestoTipItem item);
    							
    	
    	Model.Data.MjestoTip FindID(long id);
    	
    	//IEnumerable <Model.Data.MjestoTip> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.MjestoTip> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.MjestoTip> GetData(List<Model.Data.Field.MjestoTip> fields, List<Model.Data.Filter.MjestoTip>  filter, List<Model.Data.Sort.MjestoTip>  sort, long? start = null, long? count = null);
    
    }
    
}
