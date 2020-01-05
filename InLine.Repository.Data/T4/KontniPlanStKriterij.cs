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
    
    public partial class KontniPlanStKriterij
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public KontniPlanStKriterij(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.KontniPlanStKriterijItem item)
    			{
    				_context.USP_KontniPlanStKriterij_DELETE(item.ID_KontniPlanStKriterij);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.KontniPlanStKriterijItem item)
    			{
    				return _context.USP_KontniPlanStKriterij_DELETE(item.ID_KontniPlanStKriterij);
    			}	
    									
    			public void Insert(Model.Data.Item.KontniPlanStKriterijItem item)
    			{
    				_context.USP_KontniPlanStKriterij_INSERT(item.ID_KontniPlanSt, item.ID_Kriterij, item.ID_KriterijSt, item.Obavezno);
    			}
    
    			public ObjectResult<Model.Data.KontniPlanStKriterij> InsertResult(Model.Data.Item.KontniPlanStKriterijItem item)
    			{
    				return _context.USP_KontniPlanStKriterij_INSERT(item.ID_KontniPlanSt, item.ID_Kriterij, item.ID_KriterijSt, item.Obavezno);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_KontniPlanStKriterij)
    			{
    				_context.USP_KontniPlanStKriterij_SELECT(ID_KontniPlanStKriterij);
    			}
    
    					
    			public ObjectResult<Model.Data.KontniPlanStKriterij> SelectResult(Nullable<long> ID_KontniPlanStKriterij)
            	{
                	return _context.USP_KontniPlanStKriterij_SELECT(ID_KontniPlanStKriterij);
            	}			
    				
    			public void Update(Model.Data.Item.KontniPlanStKriterijItem item)
    			{
    				_context.USP_KontniPlanStKriterij_UPDATE(item.ID_KontniPlanStKriterij, item.ID_KontniPlanSt, item.ID_Kriterij, item.ID_KriterijSt, item.Obavezno);
    			}
    
    					
    			public ObjectResult<Model.Data.KontniPlanStKriterij> UpdateResult(Model.Data.Item.KontniPlanStKriterijItem item)
    			{
    				return _context.USP_KontniPlanStKriterij_UPDATE(item.ID_KontniPlanStKriterij, item.ID_KontniPlanSt, item.ID_Kriterij, item.ID_KriterijSt, item.Obavezno);
    			}
    										
    		
    #endregion
    	
    }
    
}