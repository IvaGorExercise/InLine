//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace InLine.Repository.Data.View
{
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Diagnostics;
    using System.Data.Objects;
    using InLine;
    
    public partial interface IUgovorStanOtkupObrokPreplata
    {
       
    	Model.Data.View.UgovorStanOtkupObrokPreplata FindID(long id);
    	
    	//IEnumerable <Model.Data.View.UgovorStanOtkupObrokPreplata> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable <Model.Data.View.UgovorStanOtkupObrokPreplata> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
    	
    	long GetCount(string filter, string key, string value, bool customserach = false);
    
    	IEnumerable <Model.Data.View.UgovorStanOtkupObrokPreplata> GetData(List<Model.Data.Field.View.UgovorStanOtkupObrokPreplata> fields, List<Model.Data.Filter.View.UgovorStanOtkupObrokPreplata>  filter, List<Model.Data.Sort.View.UgovorStanOtkupObrokPreplata>  sort, long? start = null, long? count = null);
    
    }
    
}
