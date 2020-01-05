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
    
    public partial class DrzavaRadna : CRUD.DrzavaRadna, IDrzavaRadna
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public DrzavaRadna(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DrzavaRadnaItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DrzavaRadnaItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.DrzavaRadnaItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.DrzavaRadna> InsertResult(Model.Data.Item.DrzavaRadnaItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_Drzava)
    			{
    				base.Select(ID_Drzava);
    			}
    
    					
    			public ObjectResult<Model.Data.DrzavaRadna> SelectResult (Nullable<long> ID_Drzava)
    			{
    				return base.SelectResult(ID_Drzava);
    			}
    										
    				
    			public void Update(Model.Data.Item.DrzavaRadnaItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.DrzavaRadna> UpdateResult (Model.Data.Item.DrzavaRadnaItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.DrzavaRadna FindID(long id)
           // {
              //  return _context.DrzavaRadna.SingleOrDefault(p => p.ID_Drzava == id);
            //}
    
    
    		public Model.Data.DrzavaRadna FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_Drzava", id.ToString());
    			querybilder.Append("SELECT * FROM " + "lok" + "." + "DrzavaRadna");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.DrzavaRadna>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.DrzavaRadna> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.DrzavaRadna
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.DrzavaRadna
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.DrzavaRadna.Where(filter).Count();
    
                else
                    return _context.DrzavaRadna.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.DrzavaRadna> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "lok" + "." + "DrzavaRadna";
    			string model = "InLine.Model.Data.DrzavaRadna";
    
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
                return _context.Database.SqlQuery<Model.Data.DrzavaRadna>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.DrzavaRadna";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "lok" + "." + "DrzavaRadna");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "lok" + "." + "DrzavaRadna");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "lok" + "." + "DrzavaRadna");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "lok" + "." + "DrzavaRadna");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "lok" + "." + "DrzavaRadna");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.DrzavaRadna>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.DrzavaRadna> GetData(List<Model.Data.Field.DrzavaRadna> fields, List<Model.Data.Filter.DrzavaRadna>  filter, List<Model.Data.Sort.DrzavaRadna>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "lok" + "." + "DrzavaRadna";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.DrzavaRadna>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
