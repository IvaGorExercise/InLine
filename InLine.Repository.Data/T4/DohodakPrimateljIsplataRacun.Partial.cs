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
    
    public partial class DohodakPrimateljIsplataRacun : CRUD.DohodakPrimateljIsplataRacun, IDohodakPrimateljIsplataRacun
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public DohodakPrimateljIsplataRacun(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DohodakPrimateljIsplataRacunItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DohodakPrimateljIsplataRacunItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.DohodakPrimateljIsplataRacunItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.DohodakPrimateljIsplataRacun> InsertResult(Model.Data.Item.DohodakPrimateljIsplataRacunItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_DohodakPrimateljIsplataRacun)
    			{
    				base.Select(ID_DohodakPrimateljIsplataRacun);
    			}
    
    					
    			public ObjectResult<Model.Data.DohodakPrimateljIsplataRacun> SelectResult (Nullable<long> ID_DohodakPrimateljIsplataRacun)
    			{
    				return base.SelectResult(ID_DohodakPrimateljIsplataRacun);
    			}
    										
    				
    			public void Update(Model.Data.Item.DohodakPrimateljIsplataRacunItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.DohodakPrimateljIsplataRacun> UpdateResult (Model.Data.Item.DohodakPrimateljIsplataRacunItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.DohodakPrimateljIsplataRacun FindID(long id)
           // {
              //  return _context.DohodakPrimateljIsplataRacun.SingleOrDefault(p => p.ID_DohodakPrimateljIsplataRacun == id);
            //}
    
    
    		public Model.Data.DohodakPrimateljIsplataRacun FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_DohodakPrimateljIsplataRacun", id.ToString());
    			querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljIsplataRacun");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.DohodakPrimateljIsplataRacun>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.DohodakPrimateljIsplataRacun> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.DohodakPrimateljIsplataRacun
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.DohodakPrimateljIsplataRacun
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.DohodakPrimateljIsplataRacun.Where(filter).Count();
    
                else
                    return _context.DohodakPrimateljIsplataRacun.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.DohodakPrimateljIsplataRacun> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "doh" + "." + "DohodakPrimateljIsplataRacun";
    			string model = "InLine.Model.Data.DohodakPrimateljIsplataRacun";
    
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
                return _context.Database.SqlQuery<Model.Data.DohodakPrimateljIsplataRacun>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.DohodakPrimateljIsplataRacun";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljIsplataRacun");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljIsplataRacun");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljIsplataRacun");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljIsplataRacun");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "doh" + "." + "DohodakPrimateljIsplataRacun");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.DohodakPrimateljIsplataRacun>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.DohodakPrimateljIsplataRacun> GetData(List<Model.Data.Field.DohodakPrimateljIsplataRacun> fields, List<Model.Data.Filter.DohodakPrimateljIsplataRacun>  filter, List<Model.Data.Sort.DohodakPrimateljIsplataRacun>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "doh" + "." + "DohodakPrimateljIsplataRacun";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.DohodakPrimateljIsplataRacun>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
