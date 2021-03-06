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
    
    public partial class HUBKontrolaModelPodatak2013A : CRUD.HUBKontrolaModelPodatak2013A, IHUBKontrolaModelPodatak2013A
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public HUBKontrolaModelPodatak2013A(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.HUBKontrolaModelPodatak2013AItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.HUBKontrolaModelPodatak2013AItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.HUBKontrolaModelPodatak2013AItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.HUBKontrolaModelPodatak2013A> InsertResult(Model.Data.Item.HUBKontrolaModelPodatak2013AItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<int> IDHUBKontrolaModelPodatak2013A)
    			{
    				base.Select(IDHUBKontrolaModelPodatak2013A);
    			}
    
    					
    			public ObjectResult<Model.Data.HUBKontrolaModelPodatak2013A> SelectResult (Nullable<int> IDHUBKontrolaModelPodatak2013A)
    			{
    				return base.SelectResult(IDHUBKontrolaModelPodatak2013A);
    			}
    										
    				
    			public void Update(Model.Data.Item.HUBKontrolaModelPodatak2013AItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.HUBKontrolaModelPodatak2013A> UpdateResult (Model.Data.Item.HUBKontrolaModelPodatak2013AItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    		public Model.Data.HUBKontrolaModelPodatak2013A FindID(long id)
            {
                return null;
            }
    		
    
    
    		public IEnumerable <Model.Data.HUBKontrolaModelPodatak2013A> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.HUBKontrolaModelPodatak2013A
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.HUBKontrolaModelPodatak2013A
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.HUBKontrolaModelPodatak2013A.Where(filter).Count();
    
                else
                    return _context.HUBKontrolaModelPodatak2013A.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.HUBKontrolaModelPodatak2013A> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "sis" + "." + "HUBKontrolaModelPodatak2013A";
    			string model = "InLine.Model.Data.HUBKontrolaModelPodatak2013A";
    
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
                return _context.Database.SqlQuery<Model.Data.HUBKontrolaModelPodatak2013A>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.HUBKontrolaModelPodatak2013A";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "sis" + "." + "HUBKontrolaModelPodatak2013A");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "sis" + "." + "HUBKontrolaModelPodatak2013A");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "sis" + "." + "HUBKontrolaModelPodatak2013A");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "sis" + "." + "HUBKontrolaModelPodatak2013A");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "sis" + "." + "HUBKontrolaModelPodatak2013A");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.HUBKontrolaModelPodatak2013A>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.HUBKontrolaModelPodatak2013A> GetData(List<Model.Data.Field.HUBKontrolaModelPodatak2013A> fields, List<Model.Data.Filter.HUBKontrolaModelPodatak2013A>  filter, List<Model.Data.Sort.HUBKontrolaModelPodatak2013A>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "sis" + "." + "HUBKontrolaModelPodatak2013A";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.HUBKontrolaModelPodatak2013A>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
