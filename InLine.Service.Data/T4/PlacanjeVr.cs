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
    using System.Web;
    using System.Data.Objects;
    
    public partial class PlacanjeVr : IPlacanjeVr
    {
    	#region Fields
    
    	Repository.Data.IPlacanjeVr _repository;
    	public Repository.Admin.IDozvoleZabranePoruke _admin;
    	Model.Admin.KorisnikData _korisnik_data;
    
        #endregion
    
    		
        #region Constructors
    
        public PlacanjeVr(Model.Admin.KorisnikData korisnik_data)
            : this(new Repository.Data.PlacanjeVr(korisnik_data.ConnString), new Repository.Admin.DozvoleZabranePoruke())
        { 
    	   _korisnik_data = korisnik_data;
    	}
    
        public PlacanjeVr(Repository.Data.IPlacanjeVr repository, Repository.Admin.IDozvoleZabranePoruke admin)
        {
            _repository = repository;
            _admin = admin;
        }
    		
        #endregion
    
    
    	#region Methods
    			
    	
    
    
    	public IEnumerable<Model.Data.PlacanjeVr> SelectResult(long? ID_PlacanjeVr)
        { 
            IEnumerable<Model.Data.PlacanjeVr> rezultat;
    
            try
            {
                rezultat = _repository.SelectResult(ID_PlacanjeVr);
            }
    
            catch (Exception ex)
            {
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);
    			InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, _korisnik_data);
                rezultat = null;
            }
    
            return rezultat;  
        }
    		
    
    	public IList<Model.Admin.StatusPoruka> Insert(Model.Data.Item.PlacanjeVrItem item)
    	{
    		IList<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();
    
    			try
    			{
    				_repository.Insert(item); 
    			}
    
    			catch (Exception ex)
    			{
    				Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);
    				InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, _korisnik_data);
    				poruke.Add(poruka);
    			}
    
    		return poruke;
    	}
    
    
    	public Model.Data.PlacanjeVr InsertResult(Model.Data.Item.PlacanjeVrItem item)
        { 
             Model.Data.PlacanjeVr rezultat;
    
            try
            {
                rezultat = _repository.InsertResult(item).FirstOrDefault();
            }
    
            catch (Exception ex)
            {
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);
    			InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, _korisnik_data);
                rezultat = null;
            }
    
            return rezultat;  
        }
    	
    
    
    	public IList<Model.Admin.StatusPoruka> Update(Model.Data.Item.PlacanjeVrItem item)
    	{
    		IList<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();
    
    			try
    			{
    				_repository.Update(item);
    			}
    
    			catch (Exception ex)
    			{
    				Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);
    				InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, _korisnik_data);
    				poruke.Add(poruka);
    			}
      
    
    		return poruke;
    	}
    
    
    	public Model.Data.PlacanjeVr UpdateResult(Model.Data.Item.PlacanjeVrItem item)
        { 
             Model.Data.PlacanjeVr rezultat;
    
            try
            {
                rezultat = _repository.UpdateResult(item).FirstOrDefault();
            }
    
            catch (Exception ex)
            {
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);
    			InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, _korisnik_data);
                rezultat = null;
            }
    
            return rezultat;  
        }
    		
    	public IList<Model.Admin.StatusPoruka> Delete(Model.Data.Item.PlacanjeVrItem item)
    	{
    		IList<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();
    
    			try
    			{
    				_repository.Delete(item);
    			}
    
    			catch (Exception ex)
    			{
    				Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);
    				InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, _korisnik_data);
    				poruke.Add(poruka);
    			}
     
    
    		return poruke;
    	}
    
    
    	public int DeleteResult(Model.Data.Item.PlacanjeVrItem item)
        { 
            int rezultat = 0;
    
            try
            {
                //rezultat = Convert.ToInt32(_repository.DeleteResult(item));
                 ObjectResult<Nullable<Int32>> totalRecordsCount_rezult = _repository.DeleteResult(item);
                 rezultat = Convert.ToInt32(totalRecordsCount_rezult.ElementAt(0));
            }
    
            catch (Exception ex)
            {
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);
    			InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, _korisnik_data);
            }
    
            return rezultat;  
        }
    
    		
        public Model.Data.PlacanjeVr FindID(long id)
        {
            Model.Data.PlacanjeVr rezultat;
    
            try
            {
                rezultat = _repository.FindID(id);
            }
    
            catch (Exception ex)
            {
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);
    			InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, _korisnik_data);
                rezultat = null;
            }
    
            return rezultat;  
        }
    	
    		
        //public IEnumerable<Model.Data.PlacanjeVr> GetGridData(string filter, string sort, long? start, long? count, bool customserach = false)
        //{
          //  IEnumerable<Model.Data.PlacanjeVr> rezultat;
    
          //  try
          //  {
            //    rezultat = _repository.GetGridData(filter, sort, start, count, customserach);
            //}
    
           // catch (Exception ex)
           // {
            //    Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);
             //   rezultat = null;
            //}
    
           // return rezultat;  
        //}
    
    	public IEnumerable<Model.Data.PlacanjeVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
        {
            IEnumerable<Model.Data.PlacanjeVr> rezultat;
    
            try
            {
                rezultat = _repository.GetGridData(filter, key, value, sort, start, count, customserach);
            }
    
            catch (Exception ex)
            {
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);
    			InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, _korisnik_data);
                rezultat = null;
            }
    
            return rezultat;  
        }
    		
    
        public long GetCount(string filter, string key, string value, bool customserach = false)
        {
            long rezultat;
    
            try
            {
                rezultat = _repository.GetCount(filter, key, value, customserach);
            }
    
            catch (Exception ex)
            {
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);
    			InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, _korisnik_data);
                rezultat = -1;
            }
    
            return rezultat;  
        }
    
    
    
    	public IEnumerable<Model.Data.PlacanjeVr> GetData(List<Model.Data.Field.PlacanjeVr> fields, List<Model.Data.Filter.PlacanjeVr>  filter, List<Model.Data.Sort.PlacanjeVr>  sort, long? start = null, long? count = null)
        {
            IEnumerable<Model.Data.PlacanjeVr> rezultat;
    
            try
            {
                rezultat = _repository.GetData(fields, filter, sort, start, count);
            }
    
            catch (Exception ex)
            {
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetException((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), _korisnik_data);
    			InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, _korisnik_data);
                rezultat = null;
            }
    
            return rezultat;  
        }
    
    
    	#endregion
    }
    
}
