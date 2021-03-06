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
    
    public partial class Obrazac
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public Obrazac(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ObrazacItem item)
    			{
    				_context.USP_Obrazac_DELETE(item.ID_Obrazac);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacItem item)
    			{
    				return _context.USP_Obrazac_DELETE(item.ID_Obrazac);
    			}	
    									
    			public void Insert(Model.Data.Item.ObrazacItem item)
    			{
    				_context.USP_Obrazac_INSERT(item.ID_ObrazacVr, item.ID_Zapis, item.ID_Poduzece, item.ID_Primatelj);
    			}
    
    			public ObjectResult<Model.Data.Obrazac> InsertResult(Model.Data.Item.ObrazacItem item)
    			{
    				return _context.USP_Obrazac_INSERT(item.ID_ObrazacVr, item.ID_Zapis, item.ID_Poduzece, item.ID_Primatelj);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_Obrazac)
    			{
    				_context.USP_Obrazac_SELECT(ID_Obrazac);
    			}
    
    					
    			public ObjectResult<Model.Data.Obrazac> SelectResult(Nullable<long> ID_Obrazac)
            	{
                	return _context.USP_Obrazac_SELECT(ID_Obrazac);
            	}			
    				
    			public void Update(Model.Data.Item.ObrazacItem item)
    			{
    				_context.USP_Obrazac_UPDATE(item.ID_Obrazac, item.ID_ObrazacVr, item.ID_Zapis, item.ID_Poduzece, item.ID_Primatelj);
    			}
    
    					
    			public ObjectResult<Model.Data.Obrazac> UpdateResult(Model.Data.Item.ObrazacItem item)
    			{
    				return _context.USP_Obrazac_UPDATE(item.ID_Obrazac, item.ID_ObrazacVr, item.ID_Zapis, item.ID_Poduzece, item.ID_Primatelj);
    			}
    										
    		
    #endregion
    	
    }
    
}
