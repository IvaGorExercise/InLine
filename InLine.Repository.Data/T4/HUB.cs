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
    
    public partial class HUB
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public HUB(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.HUBItem item)
    			{
    				_context.USP_HUB_DELETE(item.ID_HUB);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.HUBItem item)
    			{
    				return _context.USP_HUB_DELETE(item.ID_HUB);
    			}	
    									
    			public void Insert(Model.Data.Item.HUBItem item)
    			{
    				_context.USP_HUB_INSERT(item.ID_Zapis, item.IDHUBVerzija);
    			}
    
    			public ObjectResult<Model.Data.HUB> InsertResult(Model.Data.Item.HUBItem item)
    			{
    				return _context.USP_HUB_INSERT(item.ID_Zapis, item.IDHUBVerzija);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_HUB)
    			{
    				_context.USP_HUB_SELECT(ID_HUB);
    			}
    
    					
    			public ObjectResult<Model.Data.HUB> SelectResult(Nullable<long> ID_HUB)
            	{
                	return _context.USP_HUB_SELECT(ID_HUB);
            	}			
    				
    			public void Update(Model.Data.Item.HUBItem item)
    			{
    				_context.USP_HUB_UPDATE(item.ID_HUB, item.ID_Zapis, item.IDHUBVerzija);
    			}
    
    					
    			public ObjectResult<Model.Data.HUB> UpdateResult(Model.Data.Item.HUBItem item)
    			{
    				return _context.USP_HUB_UPDATE(item.ID_HUB, item.ID_Zapis, item.IDHUBVerzija);
    			}
    										
    		
    #endregion
    	
    }
    
}
