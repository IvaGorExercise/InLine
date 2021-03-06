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
    
    public partial class PraznikGrPraznik
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public PraznikGrPraznik(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.PraznikGrPraznikItem item)
    			{
    				_context.USP_PraznikGrPraznik_DELETE(item.ID_PraznikGrPraznik);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.PraznikGrPraznikItem item)
    			{
    				return _context.USP_PraznikGrPraznik_DELETE(item.ID_PraznikGrPraznik);
    			}	
    									
    			public void Insert(Model.Data.Item.PraznikGrPraznikItem item)
    			{
    				_context.USP_PraznikGrPraznik_INSERT(item.ID_PraznikGr, item.ID_Praznik);
    			}
    
    			public ObjectResult<Model.Data.PraznikGrPraznik> InsertResult(Model.Data.Item.PraznikGrPraznikItem item)
    			{
    				return _context.USP_PraznikGrPraznik_INSERT(item.ID_PraznikGr, item.ID_Praznik);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_PraznikGrPraznik)
    			{
    				_context.USP_PraznikGrPraznik_SELECT(ID_PraznikGrPraznik);
    			}
    
    					
    			public ObjectResult<Model.Data.PraznikGrPraznik> SelectResult(Nullable<long> ID_PraznikGrPraznik)
            	{
                	return _context.USP_PraznikGrPraznik_SELECT(ID_PraznikGrPraznik);
            	}			
    				
    			public void Update(Model.Data.Item.PraznikGrPraznikItem item)
    			{
    				_context.USP_PraznikGrPraznik_UPDATE(item.ID_PraznikGrPraznik, item.ID_PraznikGr, item.ID_Praznik);
    			}
    
    					
    			public ObjectResult<Model.Data.PraznikGrPraznik> UpdateResult(Model.Data.Item.PraznikGrPraznikItem item)
    			{
    				return _context.USP_PraznikGrPraznik_UPDATE(item.ID_PraznikGrPraznik, item.ID_PraznikGr, item.ID_Praznik);
    			}
    										
    		
    #endregion
    	
    }
    
}
