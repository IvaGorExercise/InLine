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
    
    public partial class PrimateljKoeficijentGr : CRUD.PrimateljKoeficijentGr, IPrimateljKoeficijentGr
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public PrimateljKoeficijentGr(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.PrimateljKoeficijentGrItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.PrimateljKoeficijentGrItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.PrimateljKoeficijentGrItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.PrimateljKoeficijentGr> InsertResult(Model.Data.Item.PrimateljKoeficijentGrItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_PrimateljKoeficijentGr)
    			{
    				base.Select(ID_PrimateljKoeficijentGr);
    			}
    
    					
    			public ObjectResult<Model.Data.PrimateljKoeficijentGr> SelectResult (Nullable<long> ID_PrimateljKoeficijentGr)
    			{
    				return base.SelectResult(ID_PrimateljKoeficijentGr);
    			}
    										
    				
    			public void Update(Model.Data.Item.PrimateljKoeficijentGrItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.PrimateljKoeficijentGr> UpdateResult (Model.Data.Item.PrimateljKoeficijentGrItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.PrimateljKoeficijentGr FindID(long id)
           // {
              //  return _context.PrimateljKoeficijentGr.SingleOrDefault(p => p.ID_PrimateljKoeficijentGr == id);
            //}
    
    
    		public Model.Data.PrimateljKoeficijentGr FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_PrimateljKoeficijentGr", id.ToString());
    			querybilder.Append("SELECT * FROM " + "doh" + "." + "PrimateljKoeficijentGr");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.PrimateljKoeficijentGr>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.PrimateljKoeficijentGr> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.PrimateljKoeficijentGr
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.PrimateljKoeficijentGr
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.PrimateljKoeficijentGr.Where(filter).Count();
    
                else
                    return _context.PrimateljKoeficijentGr.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.PrimateljKoeficijentGr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "doh" + "." + "PrimateljKoeficijentGr";
    			string model = "InLine.Model.Data.PrimateljKoeficijentGr";
    
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
                return _context.Database.SqlQuery<Model.Data.PrimateljKoeficijentGr>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.PrimateljKoeficijentGr";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "doh" + "." + "PrimateljKoeficijentGr");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "doh" + "." + "PrimateljKoeficijentGr");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "doh" + "." + "PrimateljKoeficijentGr");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "doh" + "." + "PrimateljKoeficijentGr");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "doh" + "." + "PrimateljKoeficijentGr");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.PrimateljKoeficijentGr>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.PrimateljKoeficijentGr> GetData(List<Model.Data.Field.PrimateljKoeficijentGr> fields, List<Model.Data.Filter.PrimateljKoeficijentGr>  filter, List<Model.Data.Sort.PrimateljKoeficijentGr>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "doh" + "." + "PrimateljKoeficijentGr";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.PrimateljKoeficijentGr>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
