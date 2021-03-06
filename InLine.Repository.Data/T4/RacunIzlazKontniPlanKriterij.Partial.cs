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
    
    public partial class RacunIzlazKontniPlanKriterij : CRUD.RacunIzlazKontniPlanKriterij, IRacunIzlazKontniPlanKriterij
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public RacunIzlazKontniPlanKriterij(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.RacunIzlazKontniPlanKriterijItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.RacunIzlazKontniPlanKriterijItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.RacunIzlazKontniPlanKriterijItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.RacunIzlazKontniPlanKriterij> InsertResult(Model.Data.Item.RacunIzlazKontniPlanKriterijItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_RacunIzlazKontniPlanKriterij)
    			{
    				base.Select(ID_RacunIzlazKontniPlanKriterij);
    			}
    
    					
    			public ObjectResult<Model.Data.RacunIzlazKontniPlanKriterij> SelectResult (Nullable<long> ID_RacunIzlazKontniPlanKriterij)
    			{
    				return base.SelectResult(ID_RacunIzlazKontniPlanKriterij);
    			}
    										
    				
    			public void Update(Model.Data.Item.RacunIzlazKontniPlanKriterijItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.RacunIzlazKontniPlanKriterij> UpdateResult (Model.Data.Item.RacunIzlazKontniPlanKriterijItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.RacunIzlazKontniPlanKriterij FindID(long id)
           // {
              //  return _context.RacunIzlazKontniPlanKriterij.SingleOrDefault(p => p.ID_RacunIzlazKontniPlanKriterij == id);
            //}
    
    
    		public Model.Data.RacunIzlazKontniPlanKriterij FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_RacunIzlazKontniPlanKriterij", id.ToString());
    			querybilder.Append("SELECT * FROM " + "kom" + "." + "RacunIzlazKontniPlanKriterij");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.RacunIzlazKontniPlanKriterij>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.RacunIzlazKontniPlanKriterij> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.RacunIzlazKontniPlanKriterij
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.RacunIzlazKontniPlanKriterij
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.RacunIzlazKontniPlanKriterij.Where(filter).Count();
    
                else
                    return _context.RacunIzlazKontniPlanKriterij.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.RacunIzlazKontniPlanKriterij> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "kom" + "." + "RacunIzlazKontniPlanKriterij";
    			string model = "InLine.Model.Data.RacunIzlazKontniPlanKriterij";
    
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
                return _context.Database.SqlQuery<Model.Data.RacunIzlazKontniPlanKriterij>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.RacunIzlazKontniPlanKriterij";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "kom" + "." + "RacunIzlazKontniPlanKriterij");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "kom" + "." + "RacunIzlazKontniPlanKriterij");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "kom" + "." + "RacunIzlazKontniPlanKriterij");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "kom" + "." + "RacunIzlazKontniPlanKriterij");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "kom" + "." + "RacunIzlazKontniPlanKriterij");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.RacunIzlazKontniPlanKriterij>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.RacunIzlazKontniPlanKriterij> GetData(List<Model.Data.Field.RacunIzlazKontniPlanKriterij> fields, List<Model.Data.Filter.RacunIzlazKontniPlanKriterij>  filter, List<Model.Data.Sort.RacunIzlazKontniPlanKriterij>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "kom" + "." + "RacunIzlazKontniPlanKriterij";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.RacunIzlazKontniPlanKriterij>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
