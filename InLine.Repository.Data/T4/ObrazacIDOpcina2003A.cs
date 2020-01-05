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
    
    public partial class ObrazacIDOpcina2003A
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ObrazacIDOpcina2003A(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ObrazacIDOpcina2003AItem item)
    			{
    				_context.USP_ObrazacIDOpcina2003A_DELETE(item.ID_ObrazacIDOpcina2003A);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacIDOpcina2003AItem item)
    			{
    				return _context.USP_ObrazacIDOpcina2003A_DELETE(item.ID_ObrazacIDOpcina2003A);
    			}	
    									
    			public void Insert(Model.Data.Item.ObrazacIDOpcina2003AItem item)
    			{
    				_context.USP_ObrazacIDOpcina2003A_INSERT(item.ID_ObrazacID, item.ID_Opcina, item.RedniBroj, item.SifraOpcina, item.NazivOpcina, item.IznosPorez, item.IznosPrirez, item.IznosUkupno);
    			}
    
    			public ObjectResult<Model.Data.ObrazacIDOpcina2003A> InsertResult(Model.Data.Item.ObrazacIDOpcina2003AItem item)
    			{
    				return _context.USP_ObrazacIDOpcina2003A_INSERT(item.ID_ObrazacID, item.ID_Opcina, item.RedniBroj, item.SifraOpcina, item.NazivOpcina, item.IznosPorez, item.IznosPrirez, item.IznosUkupno);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ObrazacIDOpcina2003A)
    			{
    				_context.USP_ObrazacIDOpcina2003A_SELECT(ID_ObrazacIDOpcina2003A);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacIDOpcina2003A> SelectResult(Nullable<long> ID_ObrazacIDOpcina2003A)
            	{
                	return _context.USP_ObrazacIDOpcina2003A_SELECT(ID_ObrazacIDOpcina2003A);
            	}			
    				
    			public void Update(Model.Data.Item.ObrazacIDOpcina2003AItem item)
    			{
    				_context.USP_ObrazacIDOpcina2003A_UPDATE(item.ID_ObrazacIDOpcina2003A, item.ID_ObrazacID, item.ID_Opcina, item.RedniBroj, item.SifraOpcina, item.NazivOpcina, item.IznosPorez, item.IznosPrirez, item.IznosUkupno);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacIDOpcina2003A> UpdateResult(Model.Data.Item.ObrazacIDOpcina2003AItem item)
    			{
    				return _context.USP_ObrazacIDOpcina2003A_UPDATE(item.ID_ObrazacIDOpcina2003A, item.ID_ObrazacID, item.ID_Opcina, item.RedniBroj, item.SifraOpcina, item.NazivOpcina, item.IznosPorez, item.IznosPrirez, item.IznosUkupno);
    			}
    										
    		
    #endregion
    	
    }
    
}