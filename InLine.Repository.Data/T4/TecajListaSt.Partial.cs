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
    
    public partial class TecajListaSt : CRUD.TecajListaSt, ITecajListaSt
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public TecajListaSt(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.TecajListaStItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.TecajListaStItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.TecajListaStItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.TecajListaSt> InsertResult(Model.Data.Item.TecajListaStItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_TecajListaSt)
    			{
    				base.Select(ID_TecajListaSt);
    			}
    
    					
    			public ObjectResult<Model.Data.TecajListaSt> SelectResult (Nullable<long> ID_TecajListaSt)
    			{
    				return base.SelectResult(ID_TecajListaSt);
    			}
    										
    				
    			public void Update(Model.Data.Item.TecajListaStItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.TecajListaSt> UpdateResult (Model.Data.Item.TecajListaStItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.TecajListaSt FindID(long id)
           // {
              //  return _context.TecajListaSt.SingleOrDefault(p => p.ID_TecajListaSt == id);
            //}
    
    
    		public Model.Data.TecajListaSt FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_TecajListaSt", id.ToString());
    			querybilder.Append("SELECT * FROM " + "val" + "." + "TecajListaSt");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.TecajListaSt>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.TecajListaSt> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.TecajListaSt
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.TecajListaSt
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.TecajListaSt.Where(filter).Count();
    
                else
                    return _context.TecajListaSt.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.TecajListaSt> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "val" + "." + "TecajListaSt";
    			string model = "InLine.Model.Data.TecajListaSt";
    
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
                return _context.Database.SqlQuery<Model.Data.TecajListaSt>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.TecajListaSt";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "val" + "." + "TecajListaSt");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "val" + "." + "TecajListaSt");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "val" + "." + "TecajListaSt");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "val" + "." + "TecajListaSt");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "val" + "." + "TecajListaSt");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.TecajListaSt>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.TecajListaSt> GetData(List<Model.Data.Field.TecajListaSt> fields, List<Model.Data.Filter.TecajListaSt>  filter, List<Model.Data.Sort.TecajListaSt>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "val" + "." + "TecajListaSt";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.TecajListaSt>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
