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
    
    public partial interface IKnjigaOS
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.KnjigaOSItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.KnjigaOSItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.KnjigaOSItem item);
    	IEnumerable<Model.Data.KnjigaOS> SelectResult(long? ID_KnjigaOS);
    	Model.Data.KnjigaOS InsertResult(Model.Data.Item.KnjigaOSItem item);
    	Model.Data.KnjigaOS UpdateResult(Model.Data.Item.KnjigaOSItem item);
    	int DeleteResult(Model.Data.Item.KnjigaOSItem item);
    	
        Model.Data.KnjigaOS FindID(long id);
        //IEnumerable<Model.Data.KnjigaOS> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.KnjigaOS> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.KnjigaOS> GetData(List<Model.Data.Field.KnjigaOS> fields, List<Model.Data.Filter.KnjigaOS>  filter, List<Model.Data.Sort.KnjigaOS>  sort, long? start = null, long? count = null);
    }
}
