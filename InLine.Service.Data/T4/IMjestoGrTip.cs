//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace InLine.Service.Data
{
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using InLine;
    
    public partial interface IMjestoGrTip
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.MjestoGrTipItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.MjestoGrTipItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.MjestoGrTipItem item);
    	IEnumerable<Model.Data.MjestoGrTip> SelectResult(long? ID_MjestoGrTip);
    	Model.Data.MjestoGrTip InsertResult(Model.Data.Item.MjestoGrTipItem item);
    	Model.Data.MjestoGrTip UpdateResult(Model.Data.Item.MjestoGrTipItem item);
    	int DeleteResult(Model.Data.Item.MjestoGrTipItem item);
    	
        Model.Data.MjestoGrTip FindID(long id);
        //IEnumerable<Model.Data.MjestoGrTip> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.MjestoGrTip> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.MjestoGrTip> GetData(List<Model.Data.Field.MjestoGrTip> fields, List<Model.Data.Filter.MjestoGrTip>  filter, List<Model.Data.Sort.MjestoGrTip>  sort, long? start = null, long? count = null);
    }
}
