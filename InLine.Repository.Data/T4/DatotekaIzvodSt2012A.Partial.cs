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
    
    public partial class DatotekaIzvodSt2012A : CRUD.DatotekaIzvodSt2012A, IDatotekaIzvodSt2012A
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public DatotekaIzvodSt2012A(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DatotekaIzvodSt2012AItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DatotekaIzvodSt2012AItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.DatotekaIzvodSt2012AItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.DatotekaIzvodSt2012A> InsertResult(Model.Data.Item.DatotekaIzvodSt2012AItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_DatotekaIzvodSt2012A)
    			{
    				base.Select(ID_DatotekaIzvodSt2012A);
    			}
    
    					
    			public ObjectResult<Model.Data.DatotekaIzvodSt2012A> SelectResult (Nullable<long> ID_DatotekaIzvodSt2012A)
    			{
    				return base.SelectResult(ID_DatotekaIzvodSt2012A);
    			}
    										
    				
    			public void Update(Model.Data.Item.DatotekaIzvodSt2012AItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.DatotekaIzvodSt2012A> UpdateResult (Model.Data.Item.DatotekaIzvodSt2012AItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.DatotekaIzvodSt2012A FindID(long id)
           // {
              //  return _context.DatotekaIzvodSt2012A.SingleOrDefault(p => p.ID_DatotekaIzvodSt2012A == id);
            //}
    
    
    		public Model.Data.DatotekaIzvodSt2012A FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_DatotekaIzvodSt2012A", id.ToString());
    			querybilder.Append("SELECT * FROM " + "izv" + "." + "DatotekaIzvodSt2012A");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.DatotekaIzvodSt2012A>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.DatotekaIzvodSt2012A> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.DatotekaIzvodSt2012A
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.DatotekaIzvodSt2012A
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.DatotekaIzvodSt2012A.Where(filter).Count();
    
                else
                    return _context.DatotekaIzvodSt2012A.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.DatotekaIzvodSt2012A> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "izv" + "." + "DatotekaIzvodSt2012A";
    			string model = "InLine.Model.Data.DatotekaIzvodSt2012A";
    
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
                return _context.Database.SqlQuery<Model.Data.DatotekaIzvodSt2012A>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.DatotekaIzvodSt2012A";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "izv" + "." + "DatotekaIzvodSt2012A");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "izv" + "." + "DatotekaIzvodSt2012A");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "izv" + "." + "DatotekaIzvodSt2012A");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "izv" + "." + "DatotekaIzvodSt2012A");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "izv" + "." + "DatotekaIzvodSt2012A");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.DatotekaIzvodSt2012A>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.DatotekaIzvodSt2012A> GetData(List<Model.Data.Field.DatotekaIzvodSt2012A> fields, List<Model.Data.Filter.DatotekaIzvodSt2012A>  filter, List<Model.Data.Sort.DatotekaIzvodSt2012A>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "izv" + "." + "DatotekaIzvodSt2012A";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.DatotekaIzvodSt2012A>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
