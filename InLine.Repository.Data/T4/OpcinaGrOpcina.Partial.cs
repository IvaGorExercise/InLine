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
    
    public partial class OpcinaGrOpcina : CRUD.OpcinaGrOpcina, IOpcinaGrOpcina
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public OpcinaGrOpcina(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.OpcinaGrOpcinaItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.OpcinaGrOpcinaItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.OpcinaGrOpcinaItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.OpcinaGrOpcina> InsertResult(Model.Data.Item.OpcinaGrOpcinaItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_OpcinaGrOpcina)
    			{
    				base.Select(ID_OpcinaGrOpcina);
    			}
    
    					
    			public ObjectResult<Model.Data.OpcinaGrOpcina> SelectResult (Nullable<long> ID_OpcinaGrOpcina)
    			{
    				return base.SelectResult(ID_OpcinaGrOpcina);
    			}
    										
    				
    			public void Update(Model.Data.Item.OpcinaGrOpcinaItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.OpcinaGrOpcina> UpdateResult (Model.Data.Item.OpcinaGrOpcinaItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.OpcinaGrOpcina FindID(long id)
           // {
              //  return _context.OpcinaGrOpcina.SingleOrDefault(p => p.ID_OpcinaGrOpcina == id);
            //}
    
    
    		public Model.Data.OpcinaGrOpcina FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_OpcinaGrOpcina", id.ToString());
    			querybilder.Append("SELECT * FROM " + "sbj" + "." + "OpcinaGrOpcina");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.OpcinaGrOpcina>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.OpcinaGrOpcina> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.OpcinaGrOpcina
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.OpcinaGrOpcina
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.OpcinaGrOpcina.Where(filter).Count();
    
                else
                    return _context.OpcinaGrOpcina.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.OpcinaGrOpcina> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "sbj" + "." + "OpcinaGrOpcina";
    			string model = "InLine.Model.Data.OpcinaGrOpcina";
    
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
                return _context.Database.SqlQuery<Model.Data.OpcinaGrOpcina>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.OpcinaGrOpcina";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "sbj" + "." + "OpcinaGrOpcina");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "sbj" + "." + "OpcinaGrOpcina");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "sbj" + "." + "OpcinaGrOpcina");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "sbj" + "." + "OpcinaGrOpcina");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "sbj" + "." + "OpcinaGrOpcina");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.OpcinaGrOpcina>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.OpcinaGrOpcina> GetData(List<Model.Data.Field.OpcinaGrOpcina> fields, List<Model.Data.Filter.OpcinaGrOpcina>  filter, List<Model.Data.Sort.OpcinaGrOpcina>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "sbj" + "." + "OpcinaGrOpcina";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.OpcinaGrOpcina>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}