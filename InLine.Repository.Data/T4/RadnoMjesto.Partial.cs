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
    
    public partial class RadnoMjesto : CRUD.RadnoMjesto, IRadnoMjesto
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public RadnoMjesto(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.RadnoMjestoItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.RadnoMjestoItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.RadnoMjestoItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.RadnoMjesto> InsertResult(Model.Data.Item.RadnoMjestoItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_RadnoMjesto)
    			{
    				base.Select(ID_RadnoMjesto);
    			}
    
    					
    			public ObjectResult<Model.Data.RadnoMjesto> SelectResult (Nullable<long> ID_RadnoMjesto)
    			{
    				return base.SelectResult(ID_RadnoMjesto);
    			}
    										
    				
    			public void Update(Model.Data.Item.RadnoMjestoItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.RadnoMjesto> UpdateResult (Model.Data.Item.RadnoMjestoItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.RadnoMjesto FindID(long id)
           // {
              //  return _context.RadnoMjesto.SingleOrDefault(p => p.ID_RadnoMjesto == id);
            //}
    
    
    		public Model.Data.RadnoMjesto FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_RadnoMjesto", id.ToString());
    			querybilder.Append("SELECT * FROM " + "kad" + "." + "RadnoMjesto");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.RadnoMjesto>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.RadnoMjesto> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.RadnoMjesto
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.RadnoMjesto
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.RadnoMjesto.Where(filter).Count();
    
                else
                    return _context.RadnoMjesto.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.RadnoMjesto> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "kad" + "." + "RadnoMjesto";
    			string model = "InLine.Model.Data.RadnoMjesto";
    
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
                return _context.Database.SqlQuery<Model.Data.RadnoMjesto>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.RadnoMjesto";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "kad" + "." + "RadnoMjesto");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "kad" + "." + "RadnoMjesto");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "kad" + "." + "RadnoMjesto");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "kad" + "." + "RadnoMjesto");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "kad" + "." + "RadnoMjesto");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.RadnoMjesto>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.RadnoMjesto> GetData(List<Model.Data.Field.RadnoMjesto> fields, List<Model.Data.Filter.RadnoMjesto>  filter, List<Model.Data.Sort.RadnoMjesto>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "kad" + "." + "RadnoMjesto";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.RadnoMjesto>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}