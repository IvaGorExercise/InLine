//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace InLine.Service.Data.View
{
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using InLine;
    
    public partial interface ITemeljnicaTemeljnicaVrGlavnaKnjiga
    {
    
        Model.Data.View.TemeljnicaTemeljnicaVrGlavnaKnjiga FindID(long id);
        //IEnumerable<Model.Data.View.TemeljnicaTemeljnicaVrGlavnaKnjiga> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.View.TemeljnicaTemeljnicaVrGlavnaKnjiga> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.View.TemeljnicaTemeljnicaVrGlavnaKnjiga> GetData(List<Model.Data.Field.View.TemeljnicaTemeljnicaVrGlavnaKnjiga> fields, List<Model.Data.Filter.View.TemeljnicaTemeljnicaVrGlavnaKnjiga>  filter, List<Model.Data.Sort.View.TemeljnicaTemeljnicaVrGlavnaKnjiga>  sort, long? start = null, long? count = null);
    }
}
