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
    
    public partial class OsnovnoSredstvoDnevnik : CRUD.OsnovnoSredstvoDnevnik, IOsnovnoSredstvoDnevnik
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public OsnovnoSredstvoDnevnik(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.OsnovnoSredstvoDnevnikItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.OsnovnoSredstvoDnevnikItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.OsnovnoSredstvoDnevnikItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.OsnovnoSredstvoDnevnik> InsertResult(Model.Data.Item.OsnovnoSredstvoDnevnikItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_OsnovnoSredstvoDnevnik)
    			{
    				base.Select(ID_OsnovnoSredstvoDnevnik);
    			}
    
    					
    			public ObjectResult<Model.Data.OsnovnoSredstvoDnevnik> SelectResult (Nullable<long> ID_OsnovnoSredstvoDnevnik)
    			{
    				return base.SelectResult(ID_OsnovnoSredstvoDnevnik);
    			}
    										
    				
    			public void Update(Model.Data.Item.OsnovnoSredstvoDnevnikItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.OsnovnoSredstvoDnevnik> UpdateResult (Model.Data.Item.OsnovnoSredstvoDnevnikItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.OsnovnoSredstvoDnevnik FindID(long id)
           // {
              //  return _context.OsnovnoSredstvoDnevnik.SingleOrDefault(p => p.ID_OsnovnoSredstvoDnevnik == id);
            //}
    
    
    		public Model.Data.OsnovnoSredstvoDnevnik FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_OsnovnoSredstvoDnevnik", id.ToString());
    			querybilder.Append("SELECT * FROM " + "osn" + "." + "OsnovnoSredstvoDnevnik");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.OsnovnoSredstvoDnevnik>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.OsnovnoSredstvoDnevnik> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.OsnovnoSredstvoDnevnik
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.OsnovnoSredstvoDnevnik
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.OsnovnoSredstvoDnevnik.Where(filter).Count();
    
                else
                    return _context.OsnovnoSredstvoDnevnik.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.OsnovnoSredstvoDnevnik> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "osn" + "." + "OsnovnoSredstvoDnevnik";
    			string model = "InLine.Model.Data.OsnovnoSredstvoDnevnik";
    
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
                return _context.Database.SqlQuery<Model.Data.OsnovnoSredstvoDnevnik>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.OsnovnoSredstvoDnevnik";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "osn" + "." + "OsnovnoSredstvoDnevnik");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "osn" + "." + "OsnovnoSredstvoDnevnik");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "osn" + "." + "OsnovnoSredstvoDnevnik");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "osn" + "." + "OsnovnoSredstvoDnevnik");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "osn" + "." + "OsnovnoSredstvoDnevnik");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.OsnovnoSredstvoDnevnik>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.OsnovnoSredstvoDnevnik> GetData(List<Model.Data.Field.OsnovnoSredstvoDnevnik> fields, List<Model.Data.Filter.OsnovnoSredstvoDnevnik>  filter, List<Model.Data.Sort.OsnovnoSredstvoDnevnik>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "osn" + "." + "OsnovnoSredstvoDnevnik";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.OsnovnoSredstvoDnevnik>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}