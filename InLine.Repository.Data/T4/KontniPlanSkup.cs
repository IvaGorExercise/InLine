//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace InLine.Repository.Data.CRUD
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Diagnostics;
    using System.Data.Objects;
    using InLine;
    
    public partial class KontniPlanSkup
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public KontniPlanSkup(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.KontniPlanSkupItem item)
    			{
    				_context.USP_KontniPlanSkup_DELETE(item.ID_KontniPlanSkup);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.KontniPlanSkupItem item)
    			{
    				return _context.USP_KontniPlanSkup_DELETE(item.ID_KontniPlanSkup);
    			}	
    									
    			public void Insert(Model.Data.Item.KontniPlanSkupItem item)
    			{
    				_context.USP_KontniPlanSkup_INSERT(item.ID_KontniPlan, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    			public ObjectResult<Model.Data.KontniPlanSkup> InsertResult(Model.Data.Item.KontniPlanSkupItem item)
    			{
    				return _context.USP_KontniPlanSkup_INSERT(item.ID_KontniPlan, item.Naziv, item.NazivKr, item.Kratica);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_KontniPlanSkup)
    			{
    				_context.USP_KontniPlanSkup_SELECT(ID_KontniPlanSkup);
    			}
    
    					
    			public ObjectResult<Model.Data.KontniPlanSkup> SelectResult(Nullable<long> ID_KontniPlanSkup)
            	{
                	return _context.USP_KontniPlanSkup_SELECT(ID_KontniPlanSkup);
            	}			
    				
    			public void Update(Model.Data.Item.KontniPlanSkupItem item)
    			{
    				_context.USP_KontniPlanSkup_UPDATE(item.ID_KontniPlanSkup, item.ID_KontniPlan, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    					
    			public ObjectResult<Model.Data.KontniPlanSkup> UpdateResult(Model.Data.Item.KontniPlanSkupItem item)
    			{
    				return _context.USP_KontniPlanSkup_UPDATE(item.ID_KontniPlanSkup, item.ID_KontniPlan, item.Naziv, item.NazivKr, item.Kratica);
    			}
    										
    		
    #endregion
    	
    }
    
}