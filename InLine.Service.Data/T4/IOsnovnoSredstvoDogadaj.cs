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
    
    public partial interface IOsnovnoSredstvoDogadaj
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.OsnovnoSredstvoDogadajItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.OsnovnoSredstvoDogadajItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.OsnovnoSredstvoDogadajItem item);
    	IEnumerable<Model.Data.OsnovnoSredstvoDogadaj> SelectResult(int? IDOsnovnoSredstvoDogadaj);
    	Model.Data.OsnovnoSredstvoDogadaj InsertResult(Model.Data.Item.OsnovnoSredstvoDogadajItem item);
    	Model.Data.OsnovnoSredstvoDogadaj UpdateResult(Model.Data.Item.OsnovnoSredstvoDogadajItem item);
    	int DeleteResult(Model.Data.Item.OsnovnoSredstvoDogadajItem item);
    	
        Model.Data.OsnovnoSredstvoDogadaj FindID(long id);
        //IEnumerable<Model.Data.OsnovnoSredstvoDogadaj> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.OsnovnoSredstvoDogadaj> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.OsnovnoSredstvoDogadaj> GetData(List<Model.Data.Field.OsnovnoSredstvoDogadaj> fields, List<Model.Data.Filter.OsnovnoSredstvoDogadaj>  filter, List<Model.Data.Sort.OsnovnoSredstvoDogadaj>  sort, long? start = null, long? count = null);
    }
}
