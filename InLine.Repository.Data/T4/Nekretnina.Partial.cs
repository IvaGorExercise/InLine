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
    
    public partial class Nekretnina : CRUD.Nekretnina, INekretnina
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public Nekretnina(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.NekretninaItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.NekretninaItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.NekretninaItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.Nekretnina> InsertResult(Model.Data.Item.NekretninaItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_Nekretnina)
    			{
    				base.Select(ID_Nekretnina);
    			}
    
    					
    			public ObjectResult<Model.Data.Nekretnina> SelectResult (Nullable<long> ID_Nekretnina)
    			{
    				return base.SelectResult(ID_Nekretnina);
    			}
    										
    				
    			public void Update(Model.Data.Item.NekretninaItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.Nekretnina> UpdateResult (Model.Data.Item.NekretninaItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.Nekretnina FindID(long id)
           // {
              //  return _context.Nekretnina.SingleOrDefault(p => p.ID_Nekretnina == id);
            //}
    
    
    		public Model.Data.Nekretnina FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_Nekretnina", id.ToString());
    			querybilder.Append("SELECT * FROM " + "obj" + "." + "Nekretnina");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.Nekretnina>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.Nekretnina> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.Nekretnina
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.Nekretnina
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.Nekretnina.Where(filter).Count();
    
                else
                    return _context.Nekretnina.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.Nekretnina> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "obj" + "." + "Nekretnina";
    			string model = "InLine.Model.Data.Nekretnina";
    
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
                return _context.Database.SqlQuery<Model.Data.Nekretnina>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.Nekretnina";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "obj" + "." + "Nekretnina");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "obj" + "." + "Nekretnina");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "obj" + "." + "Nekretnina");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "obj" + "." + "Nekretnina");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "obj" + "." + "Nekretnina");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.Nekretnina>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.Nekretnina> GetData(List<Model.Data.Field.Nekretnina> fields, List<Model.Data.Filter.Nekretnina>  filter, List<Model.Data.Sort.Nekretnina>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "obj" + "." + "Nekretnina";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.Nekretnina>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
