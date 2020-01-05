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
    
    public partial class SubjektGrSubjekt : CRUD.SubjektGrSubjekt, ISubjektGrSubjekt
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public SubjektGrSubjekt(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.SubjektGrSubjektItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.SubjektGrSubjektItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.SubjektGrSubjektItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.SubjektGrSubjekt> InsertResult(Model.Data.Item.SubjektGrSubjektItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_SubjektGrSubjekt)
    			{
    				base.Select(ID_SubjektGrSubjekt);
    			}
    
    					
    			public ObjectResult<Model.Data.SubjektGrSubjekt> SelectResult (Nullable<long> ID_SubjektGrSubjekt)
    			{
    				return base.SelectResult(ID_SubjektGrSubjekt);
    			}
    										
    				
    			public void Update(Model.Data.Item.SubjektGrSubjektItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.SubjektGrSubjekt> UpdateResult (Model.Data.Item.SubjektGrSubjektItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.SubjektGrSubjekt FindID(long id)
           // {
              //  return _context.SubjektGrSubjekt.SingleOrDefault(p => p.ID_SubjektGrSubjekt == id);
            //}
    
    
    		public Model.Data.SubjektGrSubjekt FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_SubjektGrSubjekt", id.ToString());
    			querybilder.Append("SELECT * FROM " + "sbj" + "." + "SubjektGrSubjekt");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.SubjektGrSubjekt>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.SubjektGrSubjekt> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.SubjektGrSubjekt
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.SubjektGrSubjekt
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.SubjektGrSubjekt.Where(filter).Count();
    
                else
                    return _context.SubjektGrSubjekt.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.SubjektGrSubjekt> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "sbj" + "." + "SubjektGrSubjekt";
    			string model = "InLine.Model.Data.SubjektGrSubjekt";
    
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
                return _context.Database.SqlQuery<Model.Data.SubjektGrSubjekt>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.SubjektGrSubjekt";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "sbj" + "." + "SubjektGrSubjekt");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "sbj" + "." + "SubjektGrSubjekt");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "sbj" + "." + "SubjektGrSubjekt");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "sbj" + "." + "SubjektGrSubjekt");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "sbj" + "." + "SubjektGrSubjekt");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.SubjektGrSubjekt>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.SubjektGrSubjekt> GetData(List<Model.Data.Field.SubjektGrSubjekt> fields, List<Model.Data.Filter.SubjektGrSubjekt>  filter, List<Model.Data.Sort.SubjektGrSubjekt>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "sbj" + "." + "SubjektGrSubjekt";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.SubjektGrSubjekt>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
