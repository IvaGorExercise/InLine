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
    
    public partial class ZupanijaGrTip : CRUD.ZupanijaGrTip, IZupanijaGrTip
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public ZupanijaGrTip(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ZupanijaGrTipItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ZupanijaGrTipItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.ZupanijaGrTipItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.ZupanijaGrTip> InsertResult(Model.Data.Item.ZupanijaGrTipItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ZupanijaGrTip)
    			{
    				base.Select(ID_ZupanijaGrTip);
    			}
    
    					
    			public ObjectResult<Model.Data.ZupanijaGrTip> SelectResult (Nullable<long> ID_ZupanijaGrTip)
    			{
    				return base.SelectResult(ID_ZupanijaGrTip);
    			}
    										
    				
    			public void Update(Model.Data.Item.ZupanijaGrTipItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.ZupanijaGrTip> UpdateResult (Model.Data.Item.ZupanijaGrTipItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.ZupanijaGrTip FindID(long id)
           // {
              //  return _context.ZupanijaGrTip.SingleOrDefault(p => p.ID_ZupanijaGrTip == id);
            //}
    
    
    		public Model.Data.ZupanijaGrTip FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_ZupanijaGrTip", id.ToString());
    			querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrTip");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.ZupanijaGrTip>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.ZupanijaGrTip> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.ZupanijaGrTip
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.ZupanijaGrTip
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.ZupanijaGrTip.Where(filter).Count();
    
                else
                    return _context.ZupanijaGrTip.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.ZupanijaGrTip> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "sbj" + "." + "ZupanijaGrTip";
    			string model = "InLine.Model.Data.ZupanijaGrTip";
    
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
                return _context.Database.SqlQuery<Model.Data.ZupanijaGrTip>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.ZupanijaGrTip";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrTip");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrTip");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrTip");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrTip");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "sbj" + "." + "ZupanijaGrTip");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.ZupanijaGrTip>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.ZupanijaGrTip> GetData(List<Model.Data.Field.ZupanijaGrTip> fields, List<Model.Data.Filter.ZupanijaGrTip>  filter, List<Model.Data.Sort.ZupanijaGrTip>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "sbj" + "." + "ZupanijaGrTip";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.ZupanijaGrTip>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
