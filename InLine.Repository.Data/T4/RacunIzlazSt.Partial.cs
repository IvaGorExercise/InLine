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
    
    public partial class RacunIzlazSt : CRUD.RacunIzlazSt, IRacunIzlazSt
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public RacunIzlazSt(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.RacunIzlazStItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.RacunIzlazStItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.RacunIzlazStItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.RacunIzlazSt> InsertResult(Model.Data.Item.RacunIzlazStItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_RacunIzlazSt)
    			{
    				base.Select(ID_RacunIzlazSt);
    			}
    
    					
    			public ObjectResult<Model.Data.RacunIzlazSt> SelectResult (Nullable<long> ID_RacunIzlazSt)
    			{
    				return base.SelectResult(ID_RacunIzlazSt);
    			}
    										
    				
    			public void Update(Model.Data.Item.RacunIzlazStItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.RacunIzlazSt> UpdateResult (Model.Data.Item.RacunIzlazStItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.RacunIzlazSt FindID(long id)
           // {
              //  return _context.RacunIzlazSt.SingleOrDefault(p => p.ID_RacunIzlazSt == id);
            //}
    
    
    		public Model.Data.RacunIzlazSt FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_RacunIzlazSt", id.ToString());
    			querybilder.Append("SELECT * FROM " + "kom" + "." + "RacunIzlazSt");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.RacunIzlazSt>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.RacunIzlazSt> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.RacunIzlazSt
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.RacunIzlazSt
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.RacunIzlazSt.Where(filter).Count();
    
                else
                    return _context.RacunIzlazSt.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.RacunIzlazSt> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "kom" + "." + "RacunIzlazSt";
    			string model = "InLine.Model.Data.RacunIzlazSt";
    
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
                return _context.Database.SqlQuery<Model.Data.RacunIzlazSt>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.RacunIzlazSt";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "kom" + "." + "RacunIzlazSt");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "kom" + "." + "RacunIzlazSt");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "kom" + "." + "RacunIzlazSt");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "kom" + "." + "RacunIzlazSt");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "kom" + "." + "RacunIzlazSt");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.RacunIzlazSt>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.RacunIzlazSt> GetData(List<Model.Data.Field.RacunIzlazSt> fields, List<Model.Data.Filter.RacunIzlazSt>  filter, List<Model.Data.Sort.RacunIzlazSt>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "kom" + "." + "RacunIzlazSt";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.RacunIzlazSt>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}