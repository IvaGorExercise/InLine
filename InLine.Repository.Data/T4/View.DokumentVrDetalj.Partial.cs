//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Repository.Data.View
{
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Diagnostics;
    using System.Data.Objects;
    using InLine;
    
    public partial class DokumentVrDetalj : CRUD.View.DokumentVrDetalj, View.IDokumentVrDetalj
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public DokumentVrDetalj(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       
    		public Model.Data.View.DokumentVrDetalj FindID(long id)
            {
                return null;
            }
    		
    
    
    		public IEnumerable <Model.Data.View.DokumentVrDetalj> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.VIEW_DokumentVrDetalj
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.VIEW_DokumentVrDetalj
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.VIEW_DokumentVrDetalj.Where(filter).Count();
    
                else
                    return _context.VIEW_DokumentVrDetalj.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.View.DokumentVrDetalj> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "ots" + "." + "VIEW_DokumentVrDetalj";
    			string model = "InLine.Model.Data.View.DokumentVrDetalj";
    
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
                return _context.Database.SqlQuery<Model.Data.View.DokumentVrDetalj>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.View.DokumentVrDetalj";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_DokumentVrDetalj");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_DokumentVrDetalj");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_DokumentVrDetalj");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_DokumentVrDetalj");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_DokumentVrDetalj");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.View.DokumentVrDetalj>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.View.DokumentVrDetalj> GetData(List<Model.Data.Field.View.DokumentVrDetalj> fields, List<Model.Data.Filter.View.DokumentVrDetalj>  filter, List<Model.Data.Sort.View.DokumentVrDetalj>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "ots" + "." + "VIEW_DokumentVrDetalj";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.View.DokumentVrDetalj>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
