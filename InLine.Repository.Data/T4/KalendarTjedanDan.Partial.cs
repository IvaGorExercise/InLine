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
    
    public partial class KalendarTjedanDan : CRUD.KalendarTjedanDan, IKalendarTjedanDan
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public KalendarTjedanDan(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.KalendarTjedanDanItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.KalendarTjedanDanItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.KalendarTjedanDanItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.KalendarTjedanDan> InsertResult(Model.Data.Item.KalendarTjedanDanItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<int> TjedanDan)
    			{
    				base.Select(TjedanDan);
    			}
    
    					
    			public ObjectResult<Model.Data.KalendarTjedanDan> SelectResult (Nullable<int> TjedanDan)
    			{
    				return base.SelectResult(TjedanDan);
    			}
    										
    				
    			public void Update(Model.Data.Item.KalendarTjedanDanItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.KalendarTjedanDan> UpdateResult (Model.Data.Item.KalendarTjedanDanItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    		public Model.Data.KalendarTjedanDan FindID(long id)
            {
                return null;
            }
    		
    
    
    		public IEnumerable <Model.Data.KalendarTjedanDan> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.KalendarTjedanDan
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.KalendarTjedanDan
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.KalendarTjedanDan.Where(filter).Count();
    
                else
                    return _context.KalendarTjedanDan.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.KalendarTjedanDan> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "sis" + "." + "KalendarTjedanDan";
    			string model = "InLine.Model.Data.KalendarTjedanDan";
    
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
                return _context.Database.SqlQuery<Model.Data.KalendarTjedanDan>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.KalendarTjedanDan";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "sis" + "." + "KalendarTjedanDan");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "sis" + "." + "KalendarTjedanDan");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "sis" + "." + "KalendarTjedanDan");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "sis" + "." + "KalendarTjedanDan");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "sis" + "." + "KalendarTjedanDan");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.KalendarTjedanDan>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.KalendarTjedanDan> GetData(List<Model.Data.Field.KalendarTjedanDan> fields, List<Model.Data.Filter.KalendarTjedanDan>  filter, List<Model.Data.Sort.KalendarTjedanDan>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "sis" + "." + "KalendarTjedanDan";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.KalendarTjedanDan>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
