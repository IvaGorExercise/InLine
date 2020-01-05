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
    
    public partial class DohodakPrimateljKoeficijent : CRUD.DohodakPrimateljKoeficijent, IDohodakPrimateljKoeficijent
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public DohodakPrimateljKoeficijent(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DohodakPrimateljKoeficijentItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DohodakPrimateljKoeficijentItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.DohodakPrimateljKoeficijentItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.DohodakPrimateljKoeficijent> InsertResult(Model.Data.Item.DohodakPrimateljKoeficijentItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_DohodakPrimateljKoeficijent)
    			{
    				base.Select(ID_DohodakPrimateljKoeficijent);
    			}
    
    					
    			public ObjectResult<Model.Data.DohodakPrimateljKoeficijent> SelectResult (Nullable<long> ID_DohodakPrimateljKoeficijent)
    			{
    				return base.SelectResult(ID_DohodakPrimateljKoeficijent);
    			}
    										
    				
    			public void Update(Model.Data.Item.DohodakPrimateljKoeficijentItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.DohodakPrimateljKoeficijent> UpdateResult (Model.Data.Item.DohodakPrimateljKoeficijentItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.DohodakPrimateljKoeficijent FindID(long id)
           // {
              //  return _context.DohodakPrimateljKoeficijent.SingleOrDefault(p => p.ID_DohodakPrimateljKoeficijent == id);
            //}
    
    
    		public Model.Data.DohodakPrimateljKoeficijent FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_DohodakPrimateljKoeficijent", id.ToString());
    			querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljKoeficijent");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.DohodakPrimateljKoeficijent>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.DohodakPrimateljKoeficijent> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.DohodakPrimateljKoeficijent
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.DohodakPrimateljKoeficijent
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.DohodakPrimateljKoeficijent.Where(filter).Count();
    
                else
                    return _context.DohodakPrimateljKoeficijent.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.DohodakPrimateljKoeficijent> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "doh" + "." + "DohodakPrimateljKoeficijent";
    			string model = "InLine.Model.Data.DohodakPrimateljKoeficijent";
    
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
                return _context.Database.SqlQuery<Model.Data.DohodakPrimateljKoeficijent>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.DohodakPrimateljKoeficijent";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljKoeficijent");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljKoeficijent");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljKoeficijent");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljKoeficijent");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljKoeficijent");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.DohodakPrimateljKoeficijent>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.DohodakPrimateljKoeficijent> GetData(List<Model.Data.Field.DohodakPrimateljKoeficijent> fields, List<Model.Data.Filter.DohodakPrimateljKoeficijent>  filter, List<Model.Data.Sort.DohodakPrimateljKoeficijent>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "doh" + "." + "DohodakPrimateljKoeficijent";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.DohodakPrimateljKoeficijent>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
