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
    
    public partial class UgovorStanOtkupObrok : CRUD.UgovorStanOtkupObrok, IUgovorStanOtkupObrok
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public UgovorStanOtkupObrok(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.UgovorStanOtkupObrokItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.UgovorStanOtkupObrokItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.UgovorStanOtkupObrokItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.UgovorStanOtkupObrok> InsertResult(Model.Data.Item.UgovorStanOtkupObrokItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_UgovorStanOtkupObrok)
    			{
    				base.Select(ID_UgovorStanOtkupObrok);
    			}
    
    					
    			public ObjectResult<Model.Data.UgovorStanOtkupObrok> SelectResult (Nullable<long> ID_UgovorStanOtkupObrok)
    			{
    				return base.SelectResult(ID_UgovorStanOtkupObrok);
    			}
    										
    				
    			public void Update(Model.Data.Item.UgovorStanOtkupObrokItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.UgovorStanOtkupObrok> UpdateResult (Model.Data.Item.UgovorStanOtkupObrokItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.UgovorStanOtkupObrok FindID(long id)
           // {
              //  return _context.UgovorStanOtkupObrok.SingleOrDefault(p => p.ID_UgovorStanOtkupObrok == id);
            //}
    
    
    		public Model.Data.UgovorStanOtkupObrok FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_UgovorStanOtkupObrok", id.ToString());
    			querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupObrok");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.UgovorStanOtkupObrok>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.UgovorStanOtkupObrok> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.UgovorStanOtkupObrok
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.UgovorStanOtkupObrok
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.UgovorStanOtkupObrok.Where(filter).Count();
    
                else
                    return _context.UgovorStanOtkupObrok.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.UgovorStanOtkupObrok> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "ots" + "." + "UgovorStanOtkupObrok";
    			string model = "InLine.Model.Data.UgovorStanOtkupObrok";
    
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
                return _context.Database.SqlQuery<Model.Data.UgovorStanOtkupObrok>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.UgovorStanOtkupObrok";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupObrok");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupObrok");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupObrok");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupObrok");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupObrok");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.UgovorStanOtkupObrok>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.UgovorStanOtkupObrok> GetData(List<Model.Data.Field.UgovorStanOtkupObrok> fields, List<Model.Data.Filter.UgovorStanOtkupObrok>  filter, List<Model.Data.Sort.UgovorStanOtkupObrok>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "ots" + "." + "UgovorStanOtkupObrok";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.UgovorStanOtkupObrok>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}