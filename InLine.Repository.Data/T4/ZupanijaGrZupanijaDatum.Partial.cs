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
    
    public partial class ZupanijaGrZupanijaDatum : CRUD.ZupanijaGrZupanijaDatum, IZupanijaGrZupanijaDatum
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public ZupanijaGrZupanijaDatum(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ZupanijaGrZupanijaDatumItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ZupanijaGrZupanijaDatumItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.ZupanijaGrZupanijaDatumItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.ZupanijaGrZupanijaDatum> InsertResult(Model.Data.Item.ZupanijaGrZupanijaDatumItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ZupanijaGrZupanijaDatum)
    			{
    				base.Select(ID_ZupanijaGrZupanijaDatum);
    			}
    
    					
    			public ObjectResult<Model.Data.ZupanijaGrZupanijaDatum> SelectResult (Nullable<long> ID_ZupanijaGrZupanijaDatum)
    			{
    				return base.SelectResult(ID_ZupanijaGrZupanijaDatum);
    			}
    										
    				
    			public void Update(Model.Data.Item.ZupanijaGrZupanijaDatumItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.ZupanijaGrZupanijaDatum> UpdateResult (Model.Data.Item.ZupanijaGrZupanijaDatumItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.ZupanijaGrZupanijaDatum FindID(long id)
           // {
              //  return _context.ZupanijaGrZupanijaDatum.SingleOrDefault(p => p.ID_ZupanijaGrZupanijaDatum == id);
            //}
    
    
    		public Model.Data.ZupanijaGrZupanijaDatum FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_ZupanijaGrZupanijaDatum", id.ToString());
    			querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrZupanijaDatum");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.ZupanijaGrZupanijaDatum>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.ZupanijaGrZupanijaDatum> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.ZupanijaGrZupanijaDatum
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.ZupanijaGrZupanijaDatum
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.ZupanijaGrZupanijaDatum.Where(filter).Count();
    
                else
                    return _context.ZupanijaGrZupanijaDatum.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.ZupanijaGrZupanijaDatum> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "sbj" + "." + "ZupanijaGrZupanijaDatum";
    			string model = "InLine.Model.Data.ZupanijaGrZupanijaDatum";
    
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
                return _context.Database.SqlQuery<Model.Data.ZupanijaGrZupanijaDatum>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.ZupanijaGrZupanijaDatum";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrZupanijaDatum");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrZupanijaDatum");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrZupanijaDatum");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrZupanijaDatum");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrZupanijaDatum");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.ZupanijaGrZupanijaDatum>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.ZupanijaGrZupanijaDatum> GetData(List<Model.Data.Field.ZupanijaGrZupanijaDatum> fields, List<Model.Data.Filter.ZupanijaGrZupanijaDatum>  filter, List<Model.Data.Sort.ZupanijaGrZupanijaDatum>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "sbj" + "." + "ZupanijaGrZupanijaDatum";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.ZupanijaGrZupanijaDatum>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
