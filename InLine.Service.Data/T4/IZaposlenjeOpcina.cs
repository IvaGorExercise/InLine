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
    
    public partial interface IZaposlenjeOpcina
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.ZaposlenjeOpcinaItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.ZaposlenjeOpcinaItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.ZaposlenjeOpcinaItem item);
    	IEnumerable<Model.Data.ZaposlenjeOpcina> SelectResult(long? ID_ZaposlenjeOpcina);
    	Model.Data.ZaposlenjeOpcina InsertResult(Model.Data.Item.ZaposlenjeOpcinaItem item);
    	Model.Data.ZaposlenjeOpcina UpdateResult(Model.Data.Item.ZaposlenjeOpcinaItem item);
    	int DeleteResult(Model.Data.Item.ZaposlenjeOpcinaItem item);
    	
        Model.Data.ZaposlenjeOpcina FindID(long id);
        //IEnumerable<Model.Data.ZaposlenjeOpcina> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.ZaposlenjeOpcina> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.ZaposlenjeOpcina> GetData(List<Model.Data.Field.ZaposlenjeOpcina> fields, List<Model.Data.Filter.ZaposlenjeOpcina>  filter, List<Model.Data.Sort.ZaposlenjeOpcina>  sort, long? start = null, long? count = null);
    }
}