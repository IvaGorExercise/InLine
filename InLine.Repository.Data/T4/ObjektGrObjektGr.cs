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
    
    public partial class ObjektGrObjektGr
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ObjektGrObjektGr(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ObjektGrObjektGrItem item)
    			{
    				_context.USP_ObjektGrObjektGr_DELETE(item.ID_ObjektGrObjektGr);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ObjektGrObjektGrItem item)
    			{
    				return _context.USP_ObjektGrObjektGr_DELETE(item.ID_ObjektGrObjektGr);
    			}	
    									
    			public void Insert(Model.Data.Item.ObjektGrObjektGrItem item)
    			{
    				_context.USP_ObjektGrObjektGr_INSERT(item.ID_ObjektGr, item.ID_ObjektGrNad);
    			}
    
    			public ObjectResult<Model.Data.ObjektGrObjektGr> InsertResult(Model.Data.Item.ObjektGrObjektGrItem item)
    			{
    				return _context.USP_ObjektGrObjektGr_INSERT(item.ID_ObjektGr, item.ID_ObjektGrNad);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ObjektGrObjektGr)
    			{
    				_context.USP_ObjektGrObjektGr_SELECT(ID_ObjektGrObjektGr);
    			}
    
    					
    			public ObjectResult<Model.Data.ObjektGrObjektGr> SelectResult(Nullable<long> ID_ObjektGrObjektGr)
            	{
                	return _context.USP_ObjektGrObjektGr_SELECT(ID_ObjektGrObjektGr);
            	}			
    				
    			public void Update(Model.Data.Item.ObjektGrObjektGrItem item)
    			{
    				_context.USP_ObjektGrObjektGr_UPDATE(item.ID_ObjektGrObjektGr, item.ID_ObjektGr, item.ID_ObjektGrNad);
    			}
    
    					
    			public ObjectResult<Model.Data.ObjektGrObjektGr> UpdateResult(Model.Data.Item.ObjektGrObjektGrItem item)
    			{
    				return _context.USP_ObjektGrObjektGr_UPDATE(item.ID_ObjektGrObjektGr, item.ID_ObjektGr, item.ID_ObjektGrNad);
    			}
    										
    		
    #endregion
    	
    }
    
}
