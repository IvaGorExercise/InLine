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
    
    public partial interface IDokumentVrDetalj
    {
    
        Model.Data.View.DokumentVrDetalj FindID(long id);
        //IEnumerable<Model.Data.View.DokumentVrDetalj> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.View.DokumentVrDetalj> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.View.DokumentVrDetalj> GetData(List<Model.Data.Field.View.DokumentVrDetalj> fields, List<Model.Data.Filter.View.DokumentVrDetalj>  filter, List<Model.Data.Sort.View.DokumentVrDetalj>  sort, long? start = null, long? count = null);
    }
}
