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
    
    public partial class DohodakIsplatitelj
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public DohodakIsplatitelj(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DohodakIsplatiteljItem item)
    			{
    				_context.USP_DohodakIsplatitelj_DELETE(item.ID_DohodakIsplatitelj);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DohodakIsplatiteljItem item)
    			{
    				return _context.USP_DohodakIsplatitelj_DELETE(item.ID_DohodakIsplatitelj);
    			}	
    									
    			public void Insert(Model.Data.Item.DohodakIsplatiteljItem item)
    			{
    				_context.USP_DohodakIsplatitelj_INSERT(item.ID_PoslovniSubjekt, item.ID_SubjektRacun);
    			}
    
    			public ObjectResult<Model.Data.DohodakIsplatitelj> InsertResult(Model.Data.Item.DohodakIsplatiteljItem item)
    			{
    				return _context.USP_DohodakIsplatitelj_INSERT(item.ID_PoslovniSubjekt, item.ID_SubjektRacun);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_DohodakIsplatitelj)
    			{
    				_context.USP_DohodakIsplatitelj_SELECT(ID_DohodakIsplatitelj);
    			}
    
    					
    			public ObjectResult<Model.Data.DohodakIsplatitelj> SelectResult(Nullable<long> ID_DohodakIsplatitelj)
            	{
                	return _context.USP_DohodakIsplatitelj_SELECT(ID_DohodakIsplatitelj);
            	}			
    				
    			public void Update(Model.Data.Item.DohodakIsplatiteljItem item)
    			{
    				_context.USP_DohodakIsplatitelj_UPDATE(item.ID_DohodakIsplatitelj, item.ID_PoslovniSubjekt, item.ID_SubjektRacun);
    			}
    
    					
    			public ObjectResult<Model.Data.DohodakIsplatitelj> UpdateResult(Model.Data.Item.DohodakIsplatiteljItem item)
    			{
    				return _context.USP_DohodakIsplatitelj_UPDATE(item.ID_DohodakIsplatitelj, item.ID_PoslovniSubjekt, item.ID_SubjektRacun);
    			}
    										
    		
    #endregion
    	
    }
    
}