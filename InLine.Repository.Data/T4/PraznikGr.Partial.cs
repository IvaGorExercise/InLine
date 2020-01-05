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
    
    public partial class PraznikGr : CRUD.PraznikGr, IPraznikGr
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public PraznikGr(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.PraznikGrItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.PraznikGrItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.PraznikGrItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.PraznikGr> InsertResult(Model.Data.Item.PraznikGrItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_PraznikGr)
    			{
    				base.Select(ID_PraznikGr);
    			}
    
    					
    			public ObjectResult<Model.Data.PraznikGr> SelectResult (Nullable<long> ID_PraznikGr)
    			{
    				return base.SelectResult(ID_PraznikGr);
    			}
    										
    				
    			public void Update(Model.Data.Item.PraznikGrItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.PraznikGr> UpdateResult (Model.Data.Item.PraznikGrItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.PraznikGr FindID(long id)
           // {
              //  return _context.PraznikGr.SingleOrDefault(p => p.ID_PraznikGr == id);
            //}
    
    
    		public Model.Data.PraznikGr FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_PraznikGr", id.ToString());
    			querybilder.Append("SELECT * FROM " + "kal" + "." + "PraznikGr");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.PraznikGr>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.PraznikGr> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.PraznikGr
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.PraznikGr
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.PraznikGr.Where(filter).Count();
    
                else
                    return _context.PraznikGr.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.PraznikGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "kal" + "." + "PraznikGr";
    			string model = "InLine.Model.Data.PraznikGr";
    
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
                return _context.Database.SqlQuery<Model.Data.PraznikGr>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.PraznikGr";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "kal" + "." + "PraznikGr");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "kal" + "." + "PraznikGr");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "kal" + "." + "PraznikGr");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "kal" + "." + "PraznikGr");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "kal" + "." + "PraznikGr");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.PraznikGr>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.PraznikGr> GetData(List<Model.Data.Field.PraznikGr> fields, List<Model.Data.Filter.PraznikGr>  filter, List<Model.Data.Sort.PraznikGr>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "kal" + "." + "PraznikGr";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.PraznikGr>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
