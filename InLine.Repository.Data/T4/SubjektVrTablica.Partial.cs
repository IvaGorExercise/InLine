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
    
    public partial class SubjektVrTablica : CRUD.SubjektVrTablica, ISubjektVrTablica
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public SubjektVrTablica(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.SubjektVrTablicaItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.SubjektVrTablicaItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.SubjektVrTablicaItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.SubjektVrTablica> InsertResult(Model.Data.Item.SubjektVrTablicaItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<int> IDSubjektVr)
    			{
    				base.Select(IDSubjektVr);
    			}
    
    					
    			public ObjectResult<Model.Data.SubjektVrTablica> SelectResult (Nullable<int> IDSubjektVr)
    			{
    				return base.SelectResult(IDSubjektVr);
    			}
    										
    				
    			public void Update(Model.Data.Item.SubjektVrTablicaItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.SubjektVrTablica> UpdateResult (Model.Data.Item.SubjektVrTablicaItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    		public Model.Data.SubjektVrTablica FindID(long id)
            {
                return null;
            }
    		
    
    
    		public IEnumerable <Model.Data.SubjektVrTablica> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.SubjektVrTablica
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.SubjektVrTablica
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.SubjektVrTablica.Where(filter).Count();
    
                else
                    return _context.SubjektVrTablica.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.SubjektVrTablica> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "sis" + "." + "SubjektVrTablica";
    			string model = "InLine.Model.Data.SubjektVrTablica";
    
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
                return _context.Database.SqlQuery<Model.Data.SubjektVrTablica>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.SubjektVrTablica";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "sis" + "." + "SubjektVrTablica");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "sis" + "." + "SubjektVrTablica");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "sis" + "." + "SubjektVrTablica");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "sis" + "." + "SubjektVrTablica");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "sis" + "." + "SubjektVrTablica");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.SubjektVrTablica>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.SubjektVrTablica> GetData(List<Model.Data.Field.SubjektVrTablica> fields, List<Model.Data.Filter.SubjektVrTablica>  filter, List<Model.Data.Sort.SubjektVrTablica>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "sis" + "." + "SubjektVrTablica";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.SubjektVrTablica>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
