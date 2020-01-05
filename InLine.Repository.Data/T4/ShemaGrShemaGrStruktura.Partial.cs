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
    
    public partial class ShemaGrShemaGrStruktura : CRUD.ShemaGrShemaGrStruktura, IShemaGrShemaGrStruktura
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public ShemaGrShemaGrStruktura(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ShemaGrShemaGrStrukturaItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ShemaGrShemaGrStrukturaItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.ShemaGrShemaGrStrukturaItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.ShemaGrShemaGrStruktura> InsertResult(Model.Data.Item.ShemaGrShemaGrStrukturaItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ShemaGrShemaGrStruktura)
    			{
    				base.Select(ID_ShemaGrShemaGrStruktura);
    			}
    
    					
    			public ObjectResult<Model.Data.ShemaGrShemaGrStruktura> SelectResult (Nullable<long> ID_ShemaGrShemaGrStruktura)
    			{
    				return base.SelectResult(ID_ShemaGrShemaGrStruktura);
    			}
    										
    				
    			public void Update(Model.Data.Item.ShemaGrShemaGrStrukturaItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.ShemaGrShemaGrStruktura> UpdateResult (Model.Data.Item.ShemaGrShemaGrStrukturaItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.ShemaGrShemaGrStruktura FindID(long id)
           // {
              //  return _context.ShemaGrShemaGrStruktura.SingleOrDefault(p => p.ID_ShemaGrShemaGrStruktura == id);
            //}
    
    
    		public Model.Data.ShemaGrShemaGrStruktura FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_ShemaGrShemaGrStruktura", id.ToString());
    			querybilder.Append("SELECT * FROM " + "fik" + "." + "ShemaGrShemaGrStruktura");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.ShemaGrShemaGrStruktura>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.ShemaGrShemaGrStruktura> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.ShemaGrShemaGrStruktura
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.ShemaGrShemaGrStruktura
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.ShemaGrShemaGrStruktura.Where(filter).Count();
    
                else
                    return _context.ShemaGrShemaGrStruktura.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.ShemaGrShemaGrStruktura> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "fik" + "." + "ShemaGrShemaGrStruktura";
    			string model = "InLine.Model.Data.ShemaGrShemaGrStruktura";
    
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
                return _context.Database.SqlQuery<Model.Data.ShemaGrShemaGrStruktura>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.ShemaGrShemaGrStruktura";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "fik" + "." + "ShemaGrShemaGrStruktura");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "fik" + "." + "ShemaGrShemaGrStruktura");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "fik" + "." + "ShemaGrShemaGrStruktura");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "fik" + "." + "ShemaGrShemaGrStruktura");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "fik" + "." + "ShemaGrShemaGrStruktura");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.ShemaGrShemaGrStruktura>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.ShemaGrShemaGrStruktura> GetData(List<Model.Data.Field.ShemaGrShemaGrStruktura> fields, List<Model.Data.Filter.ShemaGrShemaGrStruktura>  filter, List<Model.Data.Sort.ShemaGrShemaGrStruktura>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "fik" + "." + "ShemaGrShemaGrStruktura";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.ShemaGrShemaGrStruktura>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
