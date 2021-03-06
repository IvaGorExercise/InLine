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
    
    public partial class OsobaBoraviste : CRUD.OsobaBoraviste, IOsobaBoraviste
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public OsobaBoraviste(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.OsobaBoravisteItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.OsobaBoravisteItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.OsobaBoravisteItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.OsobaBoraviste> InsertResult(Model.Data.Item.OsobaBoravisteItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_OsobaBoraviste)
    			{
    				base.Select(ID_OsobaBoraviste);
    			}
    
    					
    			public ObjectResult<Model.Data.OsobaBoraviste> SelectResult (Nullable<long> ID_OsobaBoraviste)
    			{
    				return base.SelectResult(ID_OsobaBoraviste);
    			}
    										
    				
    			public void Update(Model.Data.Item.OsobaBoravisteItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.OsobaBoraviste> UpdateResult (Model.Data.Item.OsobaBoravisteItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.OsobaBoraviste FindID(long id)
           // {
              //  return _context.OsobaBoraviste.SingleOrDefault(p => p.ID_OsobaBoraviste == id);
            //}
    
    
    		public Model.Data.OsobaBoraviste FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_OsobaBoraviste", id.ToString());
    			querybilder.Append("SELECT * FROM " + "sbj" + "." + "OsobaBoraviste");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.OsobaBoraviste>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.OsobaBoraviste> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.OsobaBoraviste
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.OsobaBoraviste
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.OsobaBoraviste.Where(filter).Count();
    
                else
                    return _context.OsobaBoraviste.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.OsobaBoraviste> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "sbj" + "." + "OsobaBoraviste";
    			string model = "InLine.Model.Data.OsobaBoraviste";
    
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
                return _context.Database.SqlQuery<Model.Data.OsobaBoraviste>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.OsobaBoraviste";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "sbj" + "." + "OsobaBoraviste");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "sbj" + "." + "OsobaBoraviste");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "sbj" + "." + "OsobaBoraviste");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "sbj" + "." + "OsobaBoraviste");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "sbj" + "." + "OsobaBoraviste");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.OsobaBoraviste>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.OsobaBoraviste> GetData(List<Model.Data.Field.OsobaBoraviste> fields, List<Model.Data.Filter.OsobaBoraviste>  filter, List<Model.Data.Sort.OsobaBoraviste>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "sbj" + "." + "OsobaBoraviste";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.OsobaBoraviste>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
