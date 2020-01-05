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
    
    public partial class RacunIzlazKontniPlan
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public RacunIzlazKontniPlan(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.RacunIzlazKontniPlanItem item)
    			{
    				_context.USP_RacunIzlazKontniPlan_DELETE(item.ID_RacunIzlazKontniPlan);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.RacunIzlazKontniPlanItem item)
    			{
    				return _context.USP_RacunIzlazKontniPlan_DELETE(item.ID_RacunIzlazKontniPlan);
    			}	
    									
    			public void Insert(Model.Data.Item.RacunIzlazKontniPlanItem item)
    			{
    				_context.USP_RacunIzlazKontniPlan_INSERT(item.ID_RacunIzlaz, item.ID_KontniPlan, item.ID_Shema, item.ID_KontniPlanAnalitika);
    			}
    
    			public ObjectResult<Model.Data.RacunIzlazKontniPlan> InsertResult(Model.Data.Item.RacunIzlazKontniPlanItem item)
    			{
    				return _context.USP_RacunIzlazKontniPlan_INSERT(item.ID_RacunIzlaz, item.ID_KontniPlan, item.ID_Shema, item.ID_KontniPlanAnalitika);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_RacunIzlazKontniPlan)
    			{
    				_context.USP_RacunIzlazKontniPlan_SELECT(ID_RacunIzlazKontniPlan);
    			}
    
    					
    			public ObjectResult<Model.Data.RacunIzlazKontniPlan> SelectResult(Nullable<long> ID_RacunIzlazKontniPlan)
            	{
                	return _context.USP_RacunIzlazKontniPlan_SELECT(ID_RacunIzlazKontniPlan);
            	}			
    				
    			public void Update(Model.Data.Item.RacunIzlazKontniPlanItem item)
    			{
    				_context.USP_RacunIzlazKontniPlan_UPDATE(item.ID_RacunIzlazKontniPlan, item.ID_RacunIzlaz, item.ID_KontniPlan, item.ID_Shema, item.ID_KontniPlanAnalitika);
    			}
    
    					
    			public ObjectResult<Model.Data.RacunIzlazKontniPlan> UpdateResult(Model.Data.Item.RacunIzlazKontniPlanItem item)
    			{
    				return _context.USP_RacunIzlazKontniPlan_UPDATE(item.ID_RacunIzlazKontniPlan, item.ID_RacunIzlaz, item.ID_KontniPlan, item.ID_Shema, item.ID_KontniPlanAnalitika);
    			}
    										
    		
    #endregion
    	
    }
    
}