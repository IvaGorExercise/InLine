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
    
    public partial class Izvod : CRUD.Izvod, IIzvod
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public Izvod(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.IzvodItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.IzvodItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    				
    			public void Select(Nullable<long> ID_Izvod)
    			{
    				base.Select(ID_Izvod);
    			}
    
    					
    			public ObjectResult<Model.Data.Izvod> SelectResult (Nullable<long> ID_Izvod)
    			{
    				return base.SelectResult(ID_Izvod);
    			}
    										
    			public void Insert(Model.Data.Item.IzvodItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.Izvod> InsertResult(Model.Data.Item.IzvodItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Update(Model.Data.Item.IzvodItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.Izvod> UpdateResult (Model.Data.Item.IzvodItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.Izvod FindID(long id)
           // {
              //  return _context.Izvod.SingleOrDefault(p => p.ID_Izvod == id);
            //}
    
    
    		public Model.Data.Izvod FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_Izvod", id.ToString());
    			querybilder.Append("SELECT * FROM " + "hub" + "." + "Izvod");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.Izvod>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.Izvod> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.Izvod
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.Izvod
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.Izvod.Where(filter).Count();
    
                else
                    return _context.Izvod.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.Izvod> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "hub" + "." + "Izvod";
    			string model = "InLine.Model.Data.Izvod";
    
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
                return _context.Database.SqlQuery<Model.Data.Izvod>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.Izvod";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "hub" + "." + "Izvod");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "hub" + "." + "Izvod");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "hub" + "." + "Izvod");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "hub" + "." + "Izvod");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "hub" + "." + "Izvod");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.Izvod>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.Izvod> GetData(List<Model.Data.Field.Izvod> fields, List<Model.Data.Filter.Izvod>  filter, List<Model.Data.Sort.Izvod>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "hub" + "." + "Izvod";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.Izvod>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
