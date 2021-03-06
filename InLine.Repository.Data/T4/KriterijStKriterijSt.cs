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
    
    public partial class KriterijStKriterijSt
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public KriterijStKriterijSt(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.KriterijStKriterijStItem item)
    			{
    				_context.USP_KriterijStKriterijSt_DELETE(item.ID_KriterijStKriterijSt);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.KriterijStKriterijStItem item)
    			{
    				return _context.USP_KriterijStKriterijSt_DELETE(item.ID_KriterijStKriterijSt);
    			}	
    									
    			public void Insert(Model.Data.Item.KriterijStKriterijStItem item)
    			{
    				_context.USP_KriterijStKriterijSt_INSERT(item.ID_Kriterij, item.ID_KriterijSt, item.ID_KriterijStNad, item.Nivo, item.Put);
    			}
    
    			public ObjectResult<Model.Data.KriterijStKriterijSt> InsertResult(Model.Data.Item.KriterijStKriterijStItem item)
    			{
    				return _context.USP_KriterijStKriterijSt_INSERT(item.ID_Kriterij, item.ID_KriterijSt, item.ID_KriterijStNad, item.Nivo, item.Put);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_KriterijStKriterijSt)
    			{
    				_context.USP_KriterijStKriterijSt_SELECT(ID_KriterijStKriterijSt);
    			}
    
    					
    			public ObjectResult<Model.Data.KriterijStKriterijSt> SelectResult(Nullable<long> ID_KriterijStKriterijSt)
            	{
                	return _context.USP_KriterijStKriterijSt_SELECT(ID_KriterijStKriterijSt);
            	}			
    				
    			public void Update(Model.Data.Item.KriterijStKriterijStItem item)
    			{
    				_context.USP_KriterijStKriterijSt_UPDATE(item.ID_KriterijStKriterijSt, item.ID_Kriterij, item.ID_KriterijSt, item.ID_KriterijStNad, item.Nivo, item.Put);
    			}
    
    					
    			public ObjectResult<Model.Data.KriterijStKriterijSt> UpdateResult(Model.Data.Item.KriterijStKriterijStItem item)
    			{
    				return _context.USP_KriterijStKriterijSt_UPDATE(item.ID_KriterijStKriterijSt, item.ID_Kriterij, item.ID_KriterijSt, item.ID_KriterijStNad, item.Nivo, item.Put);
    			}
    										
    		
    #endregion
    	
    }
    
}
