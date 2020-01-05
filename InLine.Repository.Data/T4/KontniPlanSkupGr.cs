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
    
    public partial class KontniPlanSkupGr
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public KontniPlanSkupGr(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.KontniPlanSkupGrItem item)
    			{
    				_context.USP_KontniPlanSkupGr_DELETE(item.ID_KontniPlanSkupGr);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.KontniPlanSkupGrItem item)
    			{
    				return _context.USP_KontniPlanSkupGr_DELETE(item.ID_KontniPlanSkupGr);
    			}	
    									
    			public void Insert(Model.Data.Item.KontniPlanSkupGrItem item)
    			{
    				_context.USP_KontniPlanSkupGr_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    			public ObjectResult<Model.Data.KontniPlanSkupGr> InsertResult(Model.Data.Item.KontniPlanSkupGrItem item)
    			{
    				return _context.USP_KontniPlanSkupGr_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_KontniPlanSkupGr)
    			{
    				_context.USP_KontniPlanSkupGr_SELECT(ID_KontniPlanSkupGr);
    			}
    
    					
    			public ObjectResult<Model.Data.KontniPlanSkupGr> SelectResult(Nullable<long> ID_KontniPlanSkupGr)
            	{
                	return _context.USP_KontniPlanSkupGr_SELECT(ID_KontniPlanSkupGr);
            	}			
    				
    			public void Update(Model.Data.Item.KontniPlanSkupGrItem item)
    			{
    				_context.USP_KontniPlanSkupGr_UPDATE(item.ID_KontniPlanSkupGr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    					
    			public ObjectResult<Model.Data.KontniPlanSkupGr> UpdateResult(Model.Data.Item.KontniPlanSkupGrItem item)
    			{
    				return _context.USP_KontniPlanSkupGr_UPDATE(item.ID_KontniPlanSkupGr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    										
    		
    #endregion
    	
    }
    
}