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
    
    public partial class ZbrojniNalogHUB
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ZbrojniNalogHUB(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ZbrojniNalogHUBItem item)
    			{
    				_context.USP_ZbrojniNalogHUB_DELETE(item.ID_ZbrojniNalogHUB);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ZbrojniNalogHUBItem item)
    			{
    				return _context.USP_ZbrojniNalogHUB_DELETE(item.ID_ZbrojniNalogHUB);
    			}	
    									
    			public void Insert(Model.Data.Item.ZbrojniNalogHUBItem item)
    			{
    				_context.USP_ZbrojniNalogHUB_INSERT(item.ID_ZbrojniNalog, item.ID_HUB);
    			}
    
    			public ObjectResult<Model.Data.ZbrojniNalogHUB> InsertResult(Model.Data.Item.ZbrojniNalogHUBItem item)
    			{
    				return _context.USP_ZbrojniNalogHUB_INSERT(item.ID_ZbrojniNalog, item.ID_HUB);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ZbrojniNalogHUB)
    			{
    				_context.USP_ZbrojniNalogHUB_SELECT(ID_ZbrojniNalogHUB);
    			}
    
    					
    			public ObjectResult<Model.Data.ZbrojniNalogHUB> SelectResult(Nullable<long> ID_ZbrojniNalogHUB)
            	{
                	return _context.USP_ZbrojniNalogHUB_SELECT(ID_ZbrojniNalogHUB);
            	}			
    				
    			public void Update(Model.Data.Item.ZbrojniNalogHUBItem item)
    			{
    				_context.USP_ZbrojniNalogHUB_UPDATE(item.ID_ZbrojniNalogHUB, item.ID_ZbrojniNalog, item.ID_HUB);
    			}
    
    					
    			public ObjectResult<Model.Data.ZbrojniNalogHUB> UpdateResult(Model.Data.Item.ZbrojniNalogHUBItem item)
    			{
    				return _context.USP_ZbrojniNalogHUB_UPDATE(item.ID_ZbrojniNalogHUB, item.ID_ZbrojniNalog, item.ID_HUB);
    			}
    										
    		
    #endregion
    	
    }
    
}