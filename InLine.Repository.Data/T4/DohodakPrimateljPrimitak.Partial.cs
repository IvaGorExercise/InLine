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
    
    public partial class DohodakPrimateljPrimitak : CRUD.DohodakPrimateljPrimitak, IDohodakPrimateljPrimitak
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public DohodakPrimateljPrimitak(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DohodakPrimateljPrimitakItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DohodakPrimateljPrimitakItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.DohodakPrimateljPrimitakItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.DohodakPrimateljPrimitak> InsertResult(Model.Data.Item.DohodakPrimateljPrimitakItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_DohodakPrimateljPrimitak)
    			{
    				base.Select(ID_DohodakPrimateljPrimitak);
    			}
    
    					
    			public ObjectResult<Model.Data.DohodakPrimateljPrimitak> SelectResult (Nullable<long> ID_DohodakPrimateljPrimitak)
    			{
    				return base.SelectResult(ID_DohodakPrimateljPrimitak);
    			}
    										
    				
    			public void Update(Model.Data.Item.DohodakPrimateljPrimitakItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.DohodakPrimateljPrimitak> UpdateResult (Model.Data.Item.DohodakPrimateljPrimitakItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.DohodakPrimateljPrimitak FindID(long id)
           // {
              //  return _context.DohodakPrimateljPrimitak.SingleOrDefault(p => p.ID_DohodakPrimateljPrimitak == id);
            //}
    
    
    		public Model.Data.DohodakPrimateljPrimitak FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_DohodakPrimateljPrimitak", id.ToString());
    			querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljPrimitak");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.DohodakPrimateljPrimitak>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.DohodakPrimateljPrimitak> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.DohodakPrimateljPrimitak
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.DohodakPrimateljPrimitak
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.DohodakPrimateljPrimitak.Where(filter).Count();
    
                else
                    return _context.DohodakPrimateljPrimitak.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.DohodakPrimateljPrimitak> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "doh" + "." + "DohodakPrimateljPrimitak";
    			string model = "InLine.Model.Data.DohodakPrimateljPrimitak";
    
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
                return _context.Database.SqlQuery<Model.Data.DohodakPrimateljPrimitak>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.DohodakPrimateljPrimitak";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljPrimitak");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljPrimitak");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljPrimitak");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljPrimitak");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljPrimitak");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.DohodakPrimateljPrimitak>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.DohodakPrimateljPrimitak> GetData(List<Model.Data.Field.DohodakPrimateljPrimitak> fields, List<Model.Data.Filter.DohodakPrimateljPrimitak>  filter, List<Model.Data.Sort.DohodakPrimateljPrimitak>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "doh" + "." + "DohodakPrimateljPrimitak";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.DohodakPrimateljPrimitak>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}