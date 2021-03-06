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
    
    public partial class UgovorStanOtkupKupac : CRUD.UgovorStanOtkupKupac, IUgovorStanOtkupKupac
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public UgovorStanOtkupKupac(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.UgovorStanOtkupKupacItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.UgovorStanOtkupKupacItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.UgovorStanOtkupKupacItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.UgovorStanOtkupKupac> InsertResult(Model.Data.Item.UgovorStanOtkupKupacItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_UgovorStanOtkupKupac)
    			{
    				base.Select(ID_UgovorStanOtkupKupac);
    			}
    
    					
    			public ObjectResult<Model.Data.UgovorStanOtkupKupac> SelectResult (Nullable<long> ID_UgovorStanOtkupKupac)
    			{
    				return base.SelectResult(ID_UgovorStanOtkupKupac);
    			}
    										
    				
    			public void Update(Model.Data.Item.UgovorStanOtkupKupacItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.UgovorStanOtkupKupac> UpdateResult (Model.Data.Item.UgovorStanOtkupKupacItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.UgovorStanOtkupKupac FindID(long id)
           // {
              //  return _context.UgovorStanOtkupKupac.SingleOrDefault(p => p.ID_UgovorStanOtkupKupac == id);
            //}
    
    
    		public Model.Data.UgovorStanOtkupKupac FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_UgovorStanOtkupKupac", id.ToString());
    			querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupKupac");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.UgovorStanOtkupKupac>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.UgovorStanOtkupKupac> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.UgovorStanOtkupKupac
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.UgovorStanOtkupKupac
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.UgovorStanOtkupKupac.Where(filter).Count();
    
                else
                    return _context.UgovorStanOtkupKupac.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.UgovorStanOtkupKupac> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "ots" + "." + "UgovorStanOtkupKupac";
    			string model = "InLine.Model.Data.UgovorStanOtkupKupac";
    
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
                return _context.Database.SqlQuery<Model.Data.UgovorStanOtkupKupac>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.UgovorStanOtkupKupac";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupKupac");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupKupac");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupKupac");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupKupac");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "ots" + "." + "UgovorStanOtkupKupac");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.UgovorStanOtkupKupac>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.UgovorStanOtkupKupac> GetData(List<Model.Data.Field.UgovorStanOtkupKupac> fields, List<Model.Data.Filter.UgovorStanOtkupKupac>  filter, List<Model.Data.Sort.UgovorStanOtkupKupac>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "ots" + "." + "UgovorStanOtkupKupac";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.UgovorStanOtkupKupac>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
