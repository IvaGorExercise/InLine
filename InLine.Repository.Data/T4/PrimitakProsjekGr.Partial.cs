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
    
    public partial class PrimitakProsjekGr : CRUD.PrimitakProsjekGr, IPrimitakProsjekGr
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public PrimitakProsjekGr(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.PrimitakProsjekGrItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.PrimitakProsjekGrItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.PrimitakProsjekGrItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.PrimitakProsjekGr> InsertResult(Model.Data.Item.PrimitakProsjekGrItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_PrimitakProsjekGr)
    			{
    				base.Select(ID_PrimitakProsjekGr);
    			}
    
    					
    			public ObjectResult<Model.Data.PrimitakProsjekGr> SelectResult (Nullable<long> ID_PrimitakProsjekGr)
    			{
    				return base.SelectResult(ID_PrimitakProsjekGr);
    			}
    										
    				
    			public void Update(Model.Data.Item.PrimitakProsjekGrItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.PrimitakProsjekGr> UpdateResult (Model.Data.Item.PrimitakProsjekGrItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.PrimitakProsjekGr FindID(long id)
           // {
              //  return _context.PrimitakProsjekGr.SingleOrDefault(p => p.ID_PrimitakProsjekGr == id);
            //}
    
    
    		public Model.Data.PrimitakProsjekGr FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_PrimitakProsjekGr", id.ToString());
    			querybilder.Append("SELECT * FROM " + "doh" + "." + "PrimitakProsjekGr");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.PrimitakProsjekGr>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.PrimitakProsjekGr> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.PrimitakProsjekGr
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.PrimitakProsjekGr
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.PrimitakProsjekGr.Where(filter).Count();
    
                else
                    return _context.PrimitakProsjekGr.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.PrimitakProsjekGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "doh" + "." + "PrimitakProsjekGr";
    			string model = "InLine.Model.Data.PrimitakProsjekGr";
    
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
                return _context.Database.SqlQuery<Model.Data.PrimitakProsjekGr>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.PrimitakProsjekGr";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "doh" + "." + "PrimitakProsjekGr");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "doh" + "." + "PrimitakProsjekGr");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "doh" + "." + "PrimitakProsjekGr");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "doh" + "." + "PrimitakProsjekGr");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "doh" + "." + "PrimitakProsjekGr");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.PrimitakProsjekGr>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.PrimitakProsjekGr> GetData(List<Model.Data.Field.PrimitakProsjekGr> fields, List<Model.Data.Filter.PrimitakProsjekGr>  filter, List<Model.Data.Sort.PrimitakProsjekGr>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "doh" + "." + "PrimitakProsjekGr";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.PrimitakProsjekGr>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
