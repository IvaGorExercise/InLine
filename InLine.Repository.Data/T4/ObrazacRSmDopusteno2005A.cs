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
    
    public partial class ObrazacRSmDopusteno2005A
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ObrazacRSmDopusteno2005A(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ObrazacRSmDopusteno2005AItem item)
    			{
    				_context.USP_ObrazacRSmDopusteno2005A_DELETE(item.IDObrazacRSmObveznikVr2005A);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacRSmDopusteno2005AItem item)
    			{
    				return _context.USP_ObrazacRSmDopusteno2005A_DELETE(item.IDObrazacRSmObveznikVr2005A);
    			}	
    									
    			public void Insert(Model.Data.Item.ObrazacRSmDopusteno2005AItem item)
    			{
    				_context.USP_ObrazacRSmDopusteno2005A_INSERT(item.IDObrazacRSmObveznikVr2005A, item.IDObrazacRSmObracunVr2005A, item.IDObrazacRSmOsiguranjeOsnova2005A);
    			}
    
    			public ObjectResult<Model.Data.ObrazacRSmDopusteno2005A> InsertResult(Model.Data.Item.ObrazacRSmDopusteno2005AItem item)
    			{
    				return _context.USP_ObrazacRSmDopusteno2005A_INSERT(item.IDObrazacRSmObveznikVr2005A, item.IDObrazacRSmObracunVr2005A, item.IDObrazacRSmOsiguranjeOsnova2005A);
    			}	
    									
    				
    			public void Select(Nullable<int> IDObrazacRSmObveznikVr2005A)
    			{
    				_context.USP_ObrazacRSmDopusteno2005A_SELECT(IDObrazacRSmObveznikVr2005A);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacRSmDopusteno2005A> SelectResult(Nullable<int> IDObrazacRSmObveznikVr2005A)
            	{
                	return _context.USP_ObrazacRSmDopusteno2005A_SELECT(IDObrazacRSmObveznikVr2005A);
            	}			
    				
    			public void Update(Model.Data.Item.ObrazacRSmDopusteno2005AItem item)
    			{
    				_context.USP_ObrazacRSmDopusteno2005A_UPDATE(item.IDObrazacRSmObveznikVr2005A, item.IDObrazacRSmObracunVr2005A, item.IDObrazacRSmOsiguranjeOsnova2005A);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacRSmDopusteno2005A> UpdateResult(Model.Data.Item.ObrazacRSmDopusteno2005AItem item)
    			{
    				return _context.USP_ObrazacRSmDopusteno2005A_UPDATE(item.IDObrazacRSmObveznikVr2005A, item.IDObrazacRSmObracunVr2005A, item.IDObrazacRSmOsiguranjeOsnova2005A);
    			}
    										
    		
    #endregion
    	
    }
    
}
