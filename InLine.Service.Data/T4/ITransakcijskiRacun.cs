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
    
    public partial interface ITransakcijskiRacun
    {
    	IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.TransakcijskiRacunItem item);
        IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.TransakcijskiRacunItem item);
        IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.TransakcijskiRacunItem item);
    	IEnumerable<Model.Data.TransakcijskiRacun> SelectResult(long? ID_TransakcijskiRacun);
    	Model.Data.TransakcijskiRacun InsertResult(Model.Data.Item.TransakcijskiRacunItem item);
    	Model.Data.TransakcijskiRacun UpdateResult(Model.Data.Item.TransakcijskiRacunItem item);
    	int DeleteResult(Model.Data.Item.TransakcijskiRacunItem item);
    	
        Model.Data.TransakcijskiRacun FindID(long id);
        //IEnumerable<Model.Data.TransakcijskiRacun> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false);
    	IEnumerable<Model.Data.TransakcijskiRacun> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false);
        long GetCount(string filter, string key, string value, bool customserach = false);
    	IEnumerable<Model.Data.TransakcijskiRacun> GetData(List<Model.Data.Field.TransakcijskiRacun> fields, List<Model.Data.Filter.TransakcijskiRacun>  filter, List<Model.Data.Sort.TransakcijskiRacun>  sort, long? start = null, long? count = null);
    }
}