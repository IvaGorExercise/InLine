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
    
    public partial class KnjigaOS : CRUD.KnjigaOS, IKnjigaOS
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public KnjigaOS(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.KnjigaOSItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.KnjigaOSItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.KnjigaOSItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.KnjigaOS> InsertResult(Model.Data.Item.KnjigaOSItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_KnjigaOS)
    			{
    				base.Select(ID_KnjigaOS);
    			}
    
    					
    			public ObjectResult<Model.Data.KnjigaOS> SelectResult (Nullable<long> ID_KnjigaOS)
    			{
    				return base.SelectResult(ID_KnjigaOS);
    			}
    										
    				
    			public void Update(Model.Data.Item.KnjigaOSItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.KnjigaOS> UpdateResult (Model.Data.Item.KnjigaOSItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.KnjigaOS FindID(long id)
           // {
              //  return _context.KnjigaOS.SingleOrDefault(p => p.ID_KnjigaOS == id);
            //}
    
    
    		public Model.Data.KnjigaOS FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_KnjigaOS", id.ToString());
    			querybilder.Append("SELECT * FROM " + "osn" + "." + "KnjigaOS");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.KnjigaOS>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.KnjigaOS> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.KnjigaOS
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.KnjigaOS
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.KnjigaOS.Where(filter).Count();
    
                else
                    return _context.KnjigaOS.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.KnjigaOS> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "osn" + "." + "KnjigaOS";
    			string model = "InLine.Model.Data.KnjigaOS";
    
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
                return _context.Database.SqlQuery<Model.Data.KnjigaOS>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.KnjigaOS";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "osn" + "." + "KnjigaOS");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "osn" + "." + "KnjigaOS");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "osn" + "." + "KnjigaOS");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "osn" + "." + "KnjigaOS");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "osn" + "." + "KnjigaOS");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.KnjigaOS>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.KnjigaOS> GetData(List<Model.Data.Field.KnjigaOS> fields, List<Model.Data.Filter.KnjigaOS>  filter, List<Model.Data.Sort.KnjigaOS>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "osn" + "." + "KnjigaOS";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.KnjigaOS>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
