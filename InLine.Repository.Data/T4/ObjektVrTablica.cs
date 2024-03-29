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
    
    public partial class ObjektVrTablica
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ObjektVrTablica(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ObjektVrTablicaItem item)
    			{
    				_context.USP_ObjektVrTablica_DELETE(item.IDObjektVr);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ObjektVrTablicaItem item)
    			{
    				return _context.USP_ObjektVrTablica_DELETE(item.IDObjektVr);
    			}	
    									
    			public void Insert(Model.Data.Item.ObjektVrTablicaItem item)
    			{
    				_context.USP_ObjektVrTablica_INSERT(item.IDObjektVr, item.IDObjektTablica, item.Odabir);
    			}
    
    			public ObjectResult<Model.Data.ObjektVrTablica> InsertResult(Model.Data.Item.ObjektVrTablicaItem item)
    			{
    				return _context.USP_ObjektVrTablica_INSERT(item.IDObjektVr, item.IDObjektTablica, item.Odabir);
    			}	
    									
    				
    			public void Select(Nullable<int> IDObjektVr)
    			{
    				_context.USP_ObjektVrTablica_SELECT(IDObjektVr);
    			}
    
    					
    			public ObjectResult<Model.Data.ObjektVrTablica> SelectResult(Nullable<int> IDObjektVr)
            	{
                	return _context.USP_ObjektVrTablica_SELECT(IDObjektVr);
            	}			
    				
    			public void Update(Model.Data.Item.ObjektVrTablicaItem item)
    			{
    				_context.USP_ObjektVrTablica_UPDATE(item.IDObjektVr, item.IDObjektTablica, item.Odabir);
    			}
    
    					
    			public ObjectResult<Model.Data.ObjektVrTablica> UpdateResult(Model.Data.Item.ObjektVrTablicaItem item)
    			{
    				return _context.USP_ObjektVrTablica_UPDATE(item.IDObjektVr, item.IDObjektTablica, item.Odabir);
    			}
    										
    		
    #endregion
    	
    }
    
}
