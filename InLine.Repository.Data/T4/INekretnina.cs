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
    
    public partial interface INekretnina
    {
       		
    		void Delete(Model.Data.Item.NekretninaItem item);
    
    			
    		ObjectResult<int?> DeleteResult(Model.Data.Item.NekretninaItem item);
            								
    		void Insert(Model.Data.Item.NekretninaItem item);
    
    		ObjectResult<Model.Data.Nekretnina> InsertResult(Model.Data.Item.NekretninaItem item);
    										
    			
    		void Select(Nullable<long> ID_Nekretnina);
    
    			ObjectResult<Model.Data.Nekretnina> SelectResult(Nullable<long> ID_Nekretnina);
            				
    			
    		void Update(Model.Data.Item.NekretninaItem item);
    
    				
    		ObjectResult<Model.Data.Nekretnina> UpdateResult (Model.Data.Item.NekretninaItem item);
    							
    	
    	Model.Data.Nekretnina FindID(long id);
    	
    	//IEnumerable <Model.Data.Nekretnina> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.Nekretnina> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.Nekretnina> GetData(List<Model.Data.Field.Nekretnina> fields, List<Model.Data.Filter.Nekretnina>  filter, List<Model.Data.Sort.Nekretnina>  sort, long? start = null, long? count = null);
    
    }
    
}