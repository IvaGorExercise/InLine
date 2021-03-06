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
    
    public partial class Praznik
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public Praznik(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.PraznikItem item)
    			{
    				_context.USP_Praznik_DELETE(item.ID_Praznik);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.PraznikItem item)
    			{
    				return _context.USP_Praznik_DELETE(item.ID_Praznik);
    			}	
    									
    			public void Insert(Model.Data.Item.PraznikItem item)
    			{
    				_context.USP_Praznik_INSERT(item.Oznaka, item.Naziv);
    			}
    
    			public ObjectResult<Model.Data.Praznik> InsertResult(Model.Data.Item.PraznikItem item)
    			{
    				return _context.USP_Praznik_INSERT(item.Oznaka, item.Naziv);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_Praznik)
    			{
    				_context.USP_Praznik_SELECT(ID_Praznik);
    			}
    
    					
    			public ObjectResult<Model.Data.Praznik> SelectResult(Nullable<long> ID_Praznik)
            	{
                	return _context.USP_Praznik_SELECT(ID_Praznik);
            	}			
    				
    			public void Update(Model.Data.Item.PraznikItem item)
    			{
    				_context.USP_Praznik_UPDATE(item.ID_Praznik, item.Oznaka, item.Naziv);
    			}
    
    					
    			public ObjectResult<Model.Data.Praznik> UpdateResult(Model.Data.Item.PraznikItem item)
    			{
    				return _context.USP_Praznik_UPDATE(item.ID_Praznik, item.Oznaka, item.Naziv);
    			}
    										
    		
    #endregion
    	
    }
    
}
