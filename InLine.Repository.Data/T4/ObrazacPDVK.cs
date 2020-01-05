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
    
    public partial class ObrazacPDVK
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ObrazacPDVK(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ObrazacPDVKItem item)
    			{
    				_context.USP_ObrazacPDVK_DELETE(item.ID_ObrazacPDVK);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacPDVKItem item)
    			{
    				return _context.USP_ObrazacPDVK_DELETE(item.ID_ObrazacPDVK);
    			}	
    									
    			public void Insert(Model.Data.Item.ObrazacPDVKItem item)
    			{
    				_context.USP_ObrazacPDVK_INSERT(item.ID_Zapis, item.ID_PoslovnaGodina);
    			}
    
    			public ObjectResult<Model.Data.ObrazacPDVK> InsertResult(Model.Data.Item.ObrazacPDVKItem item)
    			{
    				return _context.USP_ObrazacPDVK_INSERT(item.ID_Zapis, item.ID_PoslovnaGodina);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ObrazacPDVK)
    			{
    				_context.USP_ObrazacPDVK_SELECT(ID_ObrazacPDVK);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacPDVK> SelectResult(Nullable<long> ID_ObrazacPDVK)
            	{
                	return _context.USP_ObrazacPDVK_SELECT(ID_ObrazacPDVK);
            	}			
    				
    			public void Update(Model.Data.Item.ObrazacPDVKItem item)
    			{
    				_context.USP_ObrazacPDVK_UPDATE(item.ID_ObrazacPDVK, item.ID_Zapis, item.ID_PoslovnaGodina);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacPDVK> UpdateResult(Model.Data.Item.ObrazacPDVKItem item)
    			{
    				return _context.USP_ObrazacPDVK_UPDATE(item.ID_ObrazacPDVK, item.ID_Zapis, item.ID_PoslovnaGodina);
    			}
    										
    		
    #endregion
    	
    }
    
}
