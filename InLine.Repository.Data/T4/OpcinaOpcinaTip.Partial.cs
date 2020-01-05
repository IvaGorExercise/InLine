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
    
    public partial class OpcinaOpcinaTip : CRUD.OpcinaOpcinaTip, IOpcinaOpcinaTip
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public OpcinaOpcinaTip(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.OpcinaOpcinaTipItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.OpcinaOpcinaTipItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.OpcinaOpcinaTipItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.OpcinaOpcinaTip> InsertResult(Model.Data.Item.OpcinaOpcinaTipItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_OpcinaOpcinaTip)
    			{
    				base.Select(ID_OpcinaOpcinaTip);
    			}
    
    					
    			public ObjectResult<Model.Data.OpcinaOpcinaTip> SelectResult (Nullable<long> ID_OpcinaOpcinaTip)
    			{
    				return base.SelectResult(ID_OpcinaOpcinaTip);
    			}
    										
    				
    			public void Update(Model.Data.Item.OpcinaOpcinaTipItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.OpcinaOpcinaTip> UpdateResult (Model.Data.Item.OpcinaOpcinaTipItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.OpcinaOpcinaTip FindID(long id)
           // {
              //  return _context.OpcinaOpcinaTip.SingleOrDefault(p => p.ID_OpcinaOpcinaTip == id);
            //}
    
    
    		public Model.Data.OpcinaOpcinaTip FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_OpcinaOpcinaTip", id.ToString());
    			querybilder.Append("SELECT * FROM " + "sbj" + "." + "OpcinaOpcinaTip");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.OpcinaOpcinaTip>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.OpcinaOpcinaTip> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.OpcinaOpcinaTip
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.OpcinaOpcinaTip
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.OpcinaOpcinaTip.Where(filter).Count();
    
                else
                    return _context.OpcinaOpcinaTip.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.OpcinaOpcinaTip> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "sbj" + "." + "OpcinaOpcinaTip";
    			string model = "InLine.Model.Data.OpcinaOpcinaTip";
    
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
                return _context.Database.SqlQuery<Model.Data.OpcinaOpcinaTip>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.OpcinaOpcinaTip";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "sbj" + "." + "OpcinaOpcinaTip");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "sbj" + "." + "OpcinaOpcinaTip");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "sbj" + "." + "OpcinaOpcinaTip");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "sbj" + "." + "OpcinaOpcinaTip");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "sbj" + "." + "OpcinaOpcinaTip");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.OpcinaOpcinaTip>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.OpcinaOpcinaTip> GetData(List<Model.Data.Field.OpcinaOpcinaTip> fields, List<Model.Data.Filter.OpcinaOpcinaTip>  filter, List<Model.Data.Sort.OpcinaOpcinaTip>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "sbj" + "." + "OpcinaOpcinaTip";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.OpcinaOpcinaTip>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}