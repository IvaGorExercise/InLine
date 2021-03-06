//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Repository.Data.View
{
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Diagnostics;
    using System.Data.Objects;
    using InLine;
    
    public partial class GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt : CRUD.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt, View.IGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       
    	
    		//public Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt FindID(long id)
           // {
              //  return _context.VIEW_GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.SingleOrDefault(p => p.ID_GlavnaKnjiga == id);
            //}
    
    
    		public Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_GlavnaKnjiga", id.ToString());
    			querybilder.Append("SELECT * FROM " + "fik" + "." + "VIEW_GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.VIEW_GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.VIEW_GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.VIEW_GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.Where(filter).Count();
    
                else
                    return _context.VIEW_GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "fik" + "." + "VIEW_GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt";
    			string model = "InLine.Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt";
    
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
                return _context.Database.SqlQuery<Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "fik" + "." + "VIEW_GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "fik" + "." + "VIEW_GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "fik" + "." + "VIEW_GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "fik" + "." + "VIEW_GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "fik" + "." + "VIEW_GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> GetData(List<Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> fields, List<Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>  filter, List<Model.Data.Sort.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "fik" + "." + "VIEW_GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
