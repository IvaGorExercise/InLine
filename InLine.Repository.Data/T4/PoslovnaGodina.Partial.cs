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
    
    public partial class PoslovnaGodina : CRUD.PoslovnaGodina, IPoslovnaGodina
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public PoslovnaGodina(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.PoslovnaGodinaItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.PoslovnaGodinaItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.PoslovnaGodinaItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.PoslovnaGodina> InsertResult(Model.Data.Item.PoslovnaGodinaItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_PoslovnaGodina)
    			{
    				base.Select(ID_PoslovnaGodina);
    			}
    
    					
    			public ObjectResult<Model.Data.PoslovnaGodina> SelectResult (Nullable<long> ID_PoslovnaGodina)
    			{
    				return base.SelectResult(ID_PoslovnaGodina);
    			}
    										
    				
    			public void Update(Model.Data.Item.PoslovnaGodinaItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.PoslovnaGodina> UpdateResult (Model.Data.Item.PoslovnaGodinaItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.PoslovnaGodina FindID(long id)
           // {
              //  return _context.PoslovnaGodina.SingleOrDefault(p => p.ID_PoslovnaGodina == id);
            //}
    
    
    		public Model.Data.PoslovnaGodina FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_PoslovnaGodina", id.ToString());
    			querybilder.Append("SELECT * FROM " + "mat" + "." + "PoslovnaGodina");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.PoslovnaGodina>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.PoslovnaGodina> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.PoslovnaGodina
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.PoslovnaGodina
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.PoslovnaGodina.Where(filter).Count();
    
                else
                    return _context.PoslovnaGodina.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.PoslovnaGodina> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "mat" + "." + "PoslovnaGodina";
    			string model = "InLine.Model.Data.PoslovnaGodina";
    
    			if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    }
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                      filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;   
                }
    
    
                query = Repository.Data.Helper.QueryBulider.CreateQuerySelect(entity, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.PoslovnaGodina>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.PoslovnaGodina";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "mat" + "." + "PoslovnaGodina");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "mat" + "." + "PoslovnaGodina");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "mat" + "." + "PoslovnaGodina");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "mat" + "." + "PoslovnaGodina");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "mat" + "." + "PoslovnaGodina");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.PoslovnaGodina>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.PoslovnaGodina> GetData(List<Model.Data.Field.PoslovnaGodina> fields, List<Model.Data.Filter.PoslovnaGodina>  filter, List<Model.Data.Sort.PoslovnaGodina>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "mat" + "." + "PoslovnaGodina";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.PoslovnaGodina>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
