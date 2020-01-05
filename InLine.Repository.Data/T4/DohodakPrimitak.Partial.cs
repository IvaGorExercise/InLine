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
    
    public partial class DohodakPrimitak : CRUD.DohodakPrimitak, IDohodakPrimitak
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public DohodakPrimitak(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DohodakPrimitakItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DohodakPrimitakItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.DohodakPrimitakItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.DohodakPrimitak> InsertResult(Model.Data.Item.DohodakPrimitakItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_DohodakPrimitak)
    			{
    				base.Select(ID_DohodakPrimitak);
    			}
    
    					
    			public ObjectResult<Model.Data.DohodakPrimitak> SelectResult (Nullable<long> ID_DohodakPrimitak)
    			{
    				return base.SelectResult(ID_DohodakPrimitak);
    			}
    										
    				
    			public void Update(Model.Data.Item.DohodakPrimitakItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.DohodakPrimitak> UpdateResult (Model.Data.Item.DohodakPrimitakItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.DohodakPrimitak FindID(long id)
           // {
              //  return _context.DohodakPrimitak.SingleOrDefault(p => p.ID_DohodakPrimitak == id);
            //}
    
    
    		public Model.Data.DohodakPrimitak FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_DohodakPrimitak", id.ToString());
    			querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimitak");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.DohodakPrimitak>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.DohodakPrimitak> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.DohodakPrimitak
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.DohodakPrimitak
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.DohodakPrimitak.Where(filter).Count();
    
                else
                    return _context.DohodakPrimitak.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.DohodakPrimitak> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "doh" + "." + "DohodakPrimitak";
    			string model = "InLine.Model.Data.DohodakPrimitak";
    
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
                return _context.Database.SqlQuery<Model.Data.DohodakPrimitak>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.DohodakPrimitak";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimitak");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimitak");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimitak");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimitak");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimitak");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.DohodakPrimitak>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.DohodakPrimitak> GetData(List<Model.Data.Field.DohodakPrimitak> fields, List<Model.Data.Filter.DohodakPrimitak>  filter, List<Model.Data.Sort.DohodakPrimitak>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "doh" + "." + "DohodakPrimitak";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.DohodakPrimitak>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}