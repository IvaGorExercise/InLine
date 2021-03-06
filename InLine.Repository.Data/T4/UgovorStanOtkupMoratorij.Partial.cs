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
    
    public partial class UgovorStanOtkupMoratorij : CRUD.UgovorStanOtkupMoratorij, IUgovorStanOtkupMoratorij
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public UgovorStanOtkupMoratorij(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.UgovorStanOtkupMoratorijItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.UgovorStanOtkupMoratorijItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.UgovorStanOtkupMoratorijItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.UgovorStanOtkupMoratorij> InsertResult(Model.Data.Item.UgovorStanOtkupMoratorijItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_UgovorStanOtkupMoratorij)
    			{
    				base.Select(ID_UgovorStanOtkupMoratorij);
    			}
    
    					
    			public ObjectResult<Model.Data.UgovorStanOtkupMoratorij> SelectResult (Nullable<long> ID_UgovorStanOtkupMoratorij)
    			{
    				return base.SelectResult(ID_UgovorStanOtkupMoratorij);
    			}
    										
    				
    			public void Update(Model.Data.Item.UgovorStanOtkupMoratorijItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.UgovorStanOtkupMoratorij> UpdateResult (Model.Data.Item.UgovorStanOtkupMoratorijItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.UgovorStanOtkupMoratorij FindID(long id)
           // {
              //  return _context.UgovorStanOtkupMoratorij.SingleOrDefault(p => p.ID_UgovorStanOtkupMoratorij == id);
            //}
    
    
    		public Model.Data.UgovorStanOtkupMoratorij FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_UgovorStanOtkupMoratorij", id.ToString());
    			querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupMoratorij");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.UgovorStanOtkupMoratorij>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.UgovorStanOtkupMoratorij> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.UgovorStanOtkupMoratorij
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.UgovorStanOtkupMoratorij
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.UgovorStanOtkupMoratorij.Where(filter).Count();
    
                else
                    return _context.UgovorStanOtkupMoratorij.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.UgovorStanOtkupMoratorij> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "ots" + "." + "UgovorStanOtkupMoratorij";
    			string model = "InLine.Model.Data.UgovorStanOtkupMoratorij";
    
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
                return _context.Database.SqlQuery<Model.Data.UgovorStanOtkupMoratorij>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.UgovorStanOtkupMoratorij";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupMoratorij");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupMoratorij");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupMoratorij");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupMoratorij");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupMoratorij");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.UgovorStanOtkupMoratorij>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.UgovorStanOtkupMoratorij> GetData(List<Model.Data.Field.UgovorStanOtkupMoratorij> fields, List<Model.Data.Filter.UgovorStanOtkupMoratorij>  filter, List<Model.Data.Sort.UgovorStanOtkupMoratorij>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "ots" + "." + "UgovorStanOtkupMoratorij";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.UgovorStanOtkupMoratorij>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
