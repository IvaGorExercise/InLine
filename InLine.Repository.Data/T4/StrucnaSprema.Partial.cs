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
    
    public partial class StrucnaSprema : CRUD.StrucnaSprema, IStrucnaSprema
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public StrucnaSprema(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.StrucnaSpremaItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.StrucnaSpremaItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.StrucnaSpremaItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.StrucnaSprema> InsertResult(Model.Data.Item.StrucnaSpremaItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_StrucnaSprema)
    			{
    				base.Select(ID_StrucnaSprema);
    			}
    
    					
    			public ObjectResult<Model.Data.StrucnaSprema> SelectResult (Nullable<long> ID_StrucnaSprema)
    			{
    				return base.SelectResult(ID_StrucnaSprema);
    			}
    										
    				
    			public void Update(Model.Data.Item.StrucnaSpremaItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.StrucnaSprema> UpdateResult (Model.Data.Item.StrucnaSpremaItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.StrucnaSprema FindID(long id)
           // {
              //  return _context.StrucnaSprema.SingleOrDefault(p => p.ID_StrucnaSprema == id);
            //}
    
    
    		public Model.Data.StrucnaSprema FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_StrucnaSprema", id.ToString());
    			querybilder.Append("SELECT * FROM " + "kad" + "." + "StrucnaSprema");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.StrucnaSprema>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.StrucnaSprema> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.StrucnaSprema
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.StrucnaSprema
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.StrucnaSprema.Where(filter).Count();
    
                else
                    return _context.StrucnaSprema.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.StrucnaSprema> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "kad" + "." + "StrucnaSprema";
    			string model = "InLine.Model.Data.StrucnaSprema";
    
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
                return _context.Database.SqlQuery<Model.Data.StrucnaSprema>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.StrucnaSprema";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "kad" + "." + "StrucnaSprema");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "kad" + "." + "StrucnaSprema");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "kad" + "." + "StrucnaSprema");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "kad" + "." + "StrucnaSprema");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "kad" + "." + "StrucnaSprema");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.StrucnaSprema>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.StrucnaSprema> GetData(List<Model.Data.Field.StrucnaSprema> fields, List<Model.Data.Filter.StrucnaSprema>  filter, List<Model.Data.Sort.StrucnaSprema>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "kad" + "." + "StrucnaSprema";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.StrucnaSprema>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}