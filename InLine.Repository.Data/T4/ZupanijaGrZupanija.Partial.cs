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
    
    public partial class ZupanijaGrZupanija : CRUD.ZupanijaGrZupanija, IZupanijaGrZupanija
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public ZupanijaGrZupanija(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ZupanijaGrZupanijaItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ZupanijaGrZupanijaItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.ZupanijaGrZupanijaItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.ZupanijaGrZupanija> InsertResult(Model.Data.Item.ZupanijaGrZupanijaItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ZupanijaGrZupanija)
    			{
    				base.Select(ID_ZupanijaGrZupanija);
    			}
    
    					
    			public ObjectResult<Model.Data.ZupanijaGrZupanija> SelectResult (Nullable<long> ID_ZupanijaGrZupanija)
    			{
    				return base.SelectResult(ID_ZupanijaGrZupanija);
    			}
    										
    				
    			public void Update(Model.Data.Item.ZupanijaGrZupanijaItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.ZupanijaGrZupanija> UpdateResult (Model.Data.Item.ZupanijaGrZupanijaItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.ZupanijaGrZupanija FindID(long id)
           // {
              //  return _context.ZupanijaGrZupanija.SingleOrDefault(p => p.ID_ZupanijaGrZupanija == id);
            //}
    
    
    		public Model.Data.ZupanijaGrZupanija FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_ZupanijaGrZupanija", id.ToString());
    			querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrZupanija");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.ZupanijaGrZupanija>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.ZupanijaGrZupanija> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.ZupanijaGrZupanija
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.ZupanijaGrZupanija
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.ZupanijaGrZupanija.Where(filter).Count();
    
                else
                    return _context.ZupanijaGrZupanija.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.ZupanijaGrZupanija> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "sbj" + "." + "ZupanijaGrZupanija";
    			string model = "InLine.Model.Data.ZupanijaGrZupanija";
    
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
                return _context.Database.SqlQuery<Model.Data.ZupanijaGrZupanija>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.ZupanijaGrZupanija";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrZupanija");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrZupanija");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrZupanija");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrZupanija");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrZupanija");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.ZupanijaGrZupanija>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.ZupanijaGrZupanija> GetData(List<Model.Data.Field.ZupanijaGrZupanija> fields, List<Model.Data.Filter.ZupanijaGrZupanija>  filter, List<Model.Data.Sort.ZupanijaGrZupanija>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "sbj" + "." + "ZupanijaGrZupanija";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.ZupanijaGrZupanija>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
