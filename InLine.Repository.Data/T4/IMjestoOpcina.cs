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
    
    public partial interface IMjestoOpcina
    {
       		
    		void Delete(Model.Data.Item.MjestoOpcinaItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.MjestoOpcinaItem item);
            								
    		void Insert(Model.Data.Item.MjestoOpcinaItem item);
    
    		ObjectResult<Model.Data.MjestoOpcina> InsertResult(Model.Data.Item.MjestoOpcinaItem item);
    										
    			
    		void Select(Nullable<long> ID_MjestoOpcina);
    
    			ObjectResult<Model.Data.MjestoOpcina> SelectResult(Nullable<long> ID_MjestoOpcina);
            				
    			
    		void Update(Model.Data.Item.MjestoOpcinaItem item);
    
    				
    		ObjectResult<Model.Data.MjestoOpcina> UpdateResult (Model.Data.Item.MjestoOpcinaItem item);
    							
    	
    	Model.Data.MjestoOpcina FindID(long id);
    	
    	//IEnumerable <Model.Data.MjestoOpcina> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.MjestoOpcina> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.MjestoOpcina> GetData(List<Model.Data.Field.MjestoOpcina> fields, List<Model.Data.Filter.MjestoOpcina>  filter, List<Model.Data.Sort.MjestoOpcina>  sort, long? start = null, long? count = null);
    
    }
    
}
