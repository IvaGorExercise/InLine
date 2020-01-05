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
    
    public partial class MjestoPosta : CRUD.MjestoPosta, IMjestoPosta
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public MjestoPosta(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.MjestoPostaItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.MjestoPostaItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.MjestoPostaItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.MjestoPosta> InsertResult(Model.Data.Item.MjestoPostaItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_MjestoPosta)
    			{
    				base.Select(ID_MjestoPosta);
    			}
    
    					
    			public ObjectResult<Model.Data.MjestoPosta> SelectResult (Nullable<long> ID_MjestoPosta)
    			{
    				return base.SelectResult(ID_MjestoPosta);
    			}
    										
    				
    			public void Update(Model.Data.Item.MjestoPostaItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.MjestoPosta> UpdateResult (Model.Data.Item.MjestoPostaItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.MjestoPosta FindID(long id)
           // {
              //  return _context.MjestoPosta.SingleOrDefault(p => p.ID_MjestoPosta == id);
            //}
    
    
    		public Model.Data.MjestoPosta FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_MjestoPosta", id.ToString());
    			querybilder.Append("SELECT * FROM " + "lok" + "." + "MjestoPosta");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.MjestoPosta>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.MjestoPosta> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.MjestoPosta
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.MjestoPosta
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.MjestoPosta.Where(filter).Count();
    
                else
                    return _context.MjestoPosta.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.MjestoPosta> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "lok" + "." + "MjestoPosta";
    			string model = "InLine.Model.Data.MjestoPosta";
    
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
                return _context.Database.SqlQuery<Model.Data.MjestoPosta>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.MjestoPosta";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "lok" + "." + "MjestoPosta");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "lok" + "." + "MjestoPosta");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "lok" + "." + "MjestoPosta");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "lok" + "." + "MjestoPosta");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "lok" + "." + "MjestoPosta");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.MjestoPosta>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.MjestoPosta> GetData(List<Model.Data.Field.MjestoPosta> fields, List<Model.Data.Filter.MjestoPosta>  filter, List<Model.Data.Sort.MjestoPosta>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "lok" + "." + "MjestoPosta";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.MjestoPosta>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}