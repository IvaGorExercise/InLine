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
    
    public partial class TemeljnicaVrVr : CRUD.TemeljnicaVrVr, ITemeljnicaVrVr
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public TemeljnicaVrVr(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.TemeljnicaVrVrItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.TemeljnicaVrVrItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.TemeljnicaVrVrItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.TemeljnicaVrVr> InsertResult(Model.Data.Item.TemeljnicaVrVrItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<int> IDTemeljnicaVrVr)
    			{
    				base.Select(IDTemeljnicaVrVr);
    			}
    
    					
    			public ObjectResult<Model.Data.TemeljnicaVrVr> SelectResult (Nullable<int> IDTemeljnicaVrVr)
    			{
    				return base.SelectResult(IDTemeljnicaVrVr);
    			}
    										
    				
    			public void Update(Model.Data.Item.TemeljnicaVrVrItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.TemeljnicaVrVr> UpdateResult (Model.Data.Item.TemeljnicaVrVrItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    		public Model.Data.TemeljnicaVrVr FindID(long id)
            {
                return null;
            }
    		
    
    
    		public IEnumerable <Model.Data.TemeljnicaVrVr> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.TemeljnicaVrVr
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.TemeljnicaVrVr
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.TemeljnicaVrVr.Where(filter).Count();
    
                else
                    return _context.TemeljnicaVrVr.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.TemeljnicaVrVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "sis" + "." + "TemeljnicaVrVr";
    			string model = "InLine.Model.Data.TemeljnicaVrVr";
    
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
                return _context.Database.SqlQuery<Model.Data.TemeljnicaVrVr>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.TemeljnicaVrVr";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "sis" + "." + "TemeljnicaVrVr");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "sis" + "." + "TemeljnicaVrVr");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "sis" + "." + "TemeljnicaVrVr");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "sis" + "." + "TemeljnicaVrVr");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "sis" + "." + "TemeljnicaVrVr");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.TemeljnicaVrVr>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.TemeljnicaVrVr> GetData(List<Model.Data.Field.TemeljnicaVrVr> fields, List<Model.Data.Filter.TemeljnicaVrVr>  filter, List<Model.Data.Sort.TemeljnicaVrVr>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "sis" + "." + "TemeljnicaVrVr";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.TemeljnicaVrVr>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
