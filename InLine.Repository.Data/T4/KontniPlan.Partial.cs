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
    
    public partial class KontniPlan : CRUD.KontniPlan, IKontniPlan
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public KontniPlan(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.KontniPlanItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.KontniPlanItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.KontniPlanItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.KontniPlan> InsertResult(Model.Data.Item.KontniPlanItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_KontniPlan)
    			{
    				base.Select(ID_KontniPlan);
    			}
    
    					
    			public ObjectResult<Model.Data.KontniPlan> SelectResult (Nullable<long> ID_KontniPlan)
    			{
    				return base.SelectResult(ID_KontniPlan);
    			}
    										
    				
    			public void Update(Model.Data.Item.KontniPlanItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.KontniPlan> UpdateResult (Model.Data.Item.KontniPlanItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.KontniPlan FindID(long id)
           // {
              //  return _context.KontniPlan.SingleOrDefault(p => p.ID_KontniPlan == id);
            //}
    
    
    		public Model.Data.KontniPlan FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_KontniPlan", id.ToString());
    			querybilder.Append("SELECT * FROM " + "fik" + "." + "KontniPlan");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.KontniPlan>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.KontniPlan> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.KontniPlan
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.KontniPlan
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.KontniPlan.Where(filter).Count();
    
                else
                    return _context.KontniPlan.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.KontniPlan> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "fik" + "." + "KontniPlan";
    			string model = "InLine.Model.Data.KontniPlan";
    
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
                return _context.Database.SqlQuery<Model.Data.KontniPlan>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.KontniPlan";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "fik" + "." + "KontniPlan");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "fik" + "." + "KontniPlan");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "fik" + "." + "KontniPlan");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "fik" + "." + "KontniPlan");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "fik" + "." + "KontniPlan");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.KontniPlan>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.KontniPlan> GetData(List<Model.Data.Field.KontniPlan> fields, List<Model.Data.Filter.KontniPlan>  filter, List<Model.Data.Sort.KontniPlan>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "fik" + "." + "KontniPlan";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.KontniPlan>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
