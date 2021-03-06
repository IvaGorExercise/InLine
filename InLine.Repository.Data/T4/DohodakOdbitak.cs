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
    
    public partial class DohodakOdbitak
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public DohodakOdbitak(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DohodakOdbitakItem item)
    			{
    				_context.USP_DohodakOdbitak_DELETE(item.ID_DohodakOdbitak);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DohodakOdbitakItem item)
    			{
    				return _context.USP_DohodakOdbitak_DELETE(item.ID_DohodakOdbitak);
    			}	
    									
    			public void Insert(Model.Data.Item.DohodakOdbitakItem item)
    			{
    				_context.USP_DohodakOdbitak_INSERT(item.ID_Dohodak, item.ID_Odbitak);
    			}
    
    			public ObjectResult<Model.Data.DohodakOdbitak> InsertResult(Model.Data.Item.DohodakOdbitakItem item)
    			{
    				return _context.USP_DohodakOdbitak_INSERT(item.ID_Dohodak, item.ID_Odbitak);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_DohodakOdbitak)
    			{
    				_context.USP_DohodakOdbitak_SELECT(ID_DohodakOdbitak);
    			}
    
    					
    			public ObjectResult<Model.Data.DohodakOdbitak> SelectResult(Nullable<long> ID_DohodakOdbitak)
            	{
                	return _context.USP_DohodakOdbitak_SELECT(ID_DohodakOdbitak);
            	}			
    				
    			public void Update(Model.Data.Item.DohodakOdbitakItem item)
    			{
    				_context.USP_DohodakOdbitak_UPDATE(item.ID_DohodakOdbitak, item.ID_Dohodak, item.ID_Odbitak);
    			}
    
    					
    			public ObjectResult<Model.Data.DohodakOdbitak> UpdateResult(Model.Data.Item.DohodakOdbitakItem item)
    			{
    				return _context.USP_DohodakOdbitak_UPDATE(item.ID_DohodakOdbitak, item.ID_Dohodak, item.ID_Odbitak);
    			}
    										
    		
    #endregion
    	
    }
    
}
