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
    
    public partial class KriterijSt
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public KriterijSt(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.KriterijStItem item)
    			{
    				_context.USP_KriterijSt_DELETE(item.ID_KriterijSt);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.KriterijStItem item)
    			{
    				return _context.USP_KriterijSt_DELETE(item.ID_KriterijSt);
    			}	
    									
    			public void Insert(Model.Data.Item.KriterijStItem item)
    			{
    				_context.USP_KriterijSt_INSERT(item.ID_Kriterij, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    			public ObjectResult<Model.Data.KriterijSt> InsertResult(Model.Data.Item.KriterijStItem item)
    			{
    				return _context.USP_KriterijSt_INSERT(item.ID_Kriterij, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_KriterijSt)
    			{
    				_context.USP_KriterijSt_SELECT(ID_KriterijSt);
    			}
    
    					
    			public ObjectResult<Model.Data.KriterijSt> SelectResult(Nullable<long> ID_KriterijSt)
            	{
                	return _context.USP_KriterijSt_SELECT(ID_KriterijSt);
            	}			
    				
    			public void Update(Model.Data.Item.KriterijStItem item)
    			{
    				_context.USP_KriterijSt_UPDATE(item.ID_KriterijSt, item.ID_Kriterij, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    					
    			public ObjectResult<Model.Data.KriterijSt> UpdateResult(Model.Data.Item.KriterijStItem item)
    			{
    				return _context.USP_KriterijSt_UPDATE(item.ID_KriterijSt, item.ID_Kriterij, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    										
    		
    #endregion
    	
    }
    
}
