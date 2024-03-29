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
    
    public partial class OdbitakGrOdbitakGr : CRUD.OdbitakGrOdbitakGr, IOdbitakGrOdbitakGr
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public OdbitakGrOdbitakGr(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.OdbitakGrOdbitakGrItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.OdbitakGrOdbitakGrItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.OdbitakGrOdbitakGrItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.OdbitakGrOdbitakGr> InsertResult(Model.Data.Item.OdbitakGrOdbitakGrItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_OdbitakGrOdbitakGr)
    			{
    				base.Select(ID_OdbitakGrOdbitakGr);
    			}
    
    					
    			public ObjectResult<Model.Data.OdbitakGrOdbitakGr> SelectResult (Nullable<long> ID_OdbitakGrOdbitakGr)
    			{
    				return base.SelectResult(ID_OdbitakGrOdbitakGr);
    			}
    										
    				
    			public void Update(Model.Data.Item.OdbitakGrOdbitakGrItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.OdbitakGrOdbitakGr> UpdateResult (Model.Data.Item.OdbitakGrOdbitakGrItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.OdbitakGrOdbitakGr FindID(long id)
           // {
              //  return _context.OdbitakGrOdbitakGr.SingleOrDefault(p => p.ID_OdbitakGrOdbitakGr == id);
            //}
    
    
    		public Model.Data.OdbitakGrOdbitakGr FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_OdbitakGrOdbitakGr", id.ToString());
    			querybilder.Append("SELECT * FROM " + "doh" + "." + "OdbitakGrOdbitakGr");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.OdbitakGrOdbitakGr>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.OdbitakGrOdbitakGr> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.OdbitakGrOdbitakGr
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.OdbitakGrOdbitakGr
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.OdbitakGrOdbitakGr.Where(filter).Count();
    
                else
                    return _context.OdbitakGrOdbitakGr.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.OdbitakGrOdbitakGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "doh" + "." + "OdbitakGrOdbitakGr";
    			string model = "InLine.Model.Data.OdbitakGrOdbitakGr";
    
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
                return _context.Database.SqlQuery<Model.Data.OdbitakGrOdbitakGr>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.OdbitakGrOdbitakGr";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "doh" + "." + "OdbitakGrOdbitakGr");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "doh" + "." + "OdbitakGrOdbitakGr");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "doh" + "." + "OdbitakGrOdbitakGr");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "doh" + "." + "OdbitakGrOdbitakGr");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "doh" + "." + "OdbitakGrOdbitakGr");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.OdbitakGrOdbitakGr>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.OdbitakGrOdbitakGr> GetData(List<Model.Data.Field.OdbitakGrOdbitakGr> fields, List<Model.Data.Filter.OdbitakGrOdbitakGr>  filter, List<Model.Data.Sort.OdbitakGrOdbitakGr>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "doh" + "." + "OdbitakGrOdbitakGr";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.OdbitakGrOdbitakGr>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
