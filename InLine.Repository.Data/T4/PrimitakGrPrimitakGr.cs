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
    
    public partial class PrimitakGrPrimitakGr
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public PrimitakGrPrimitakGr(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.PrimitakGrPrimitakGrItem item)
    			{
    				_context.USP_PrimitakGrPrimitakGr_DELETE(item.ID_PrimitakGrPrimitakGr);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.PrimitakGrPrimitakGrItem item)
    			{
    				return _context.USP_PrimitakGrPrimitakGr_DELETE(item.ID_PrimitakGrPrimitakGr);
    			}	
    									
    			public void Insert(Model.Data.Item.PrimitakGrPrimitakGrItem item)
    			{
    				_context.USP_PrimitakGrPrimitakGr_INSERT(item.ID_PrimitakGr, item.ID_PrimitakGrNad);
    			}
    
    			public ObjectResult<Model.Data.PrimitakGrPrimitakGr> InsertResult(Model.Data.Item.PrimitakGrPrimitakGrItem item)
    			{
    				return _context.USP_PrimitakGrPrimitakGr_INSERT(item.ID_PrimitakGr, item.ID_PrimitakGrNad);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_PrimitakGrPrimitakGr)
    			{
    				_context.USP_PrimitakGrPrimitakGr_SELECT(ID_PrimitakGrPrimitakGr);
    			}
    
    					
    			public ObjectResult<Model.Data.PrimitakGrPrimitakGr> SelectResult(Nullable<long> ID_PrimitakGrPrimitakGr)
            	{
                	return _context.USP_PrimitakGrPrimitakGr_SELECT(ID_PrimitakGrPrimitakGr);
            	}			
    				
    			public void Update(Model.Data.Item.PrimitakGrPrimitakGrItem item)
    			{
    				_context.USP_PrimitakGrPrimitakGr_UPDATE(item.ID_PrimitakGrPrimitakGr, item.ID_PrimitakGr, item.ID_PrimitakGrNad);
    			}
    
    					
    			public ObjectResult<Model.Data.PrimitakGrPrimitakGr> UpdateResult(Model.Data.Item.PrimitakGrPrimitakGrItem item)
    			{
    				return _context.USP_PrimitakGrPrimitakGr_UPDATE(item.ID_PrimitakGrPrimitakGr, item.ID_PrimitakGr, item.ID_PrimitakGrNad);
    			}
    										
    		
    #endregion
    	
    }
    
}
