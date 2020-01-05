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
    
    public partial class PoslovnaGodinaSubjektGr
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public PoslovnaGodinaSubjektGr(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.PoslovnaGodinaSubjektGrItem item)
    			{
    				_context.USP_PoslovnaGodinaSubjektGr_DELETE(item.ID_PoslovnaGodinaSubjektGr);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.PoslovnaGodinaSubjektGrItem item)
    			{
    				return _context.USP_PoslovnaGodinaSubjektGr_DELETE(item.ID_PoslovnaGodinaSubjektGr);
    			}	
    									
    			public void Insert(Model.Data.Item.PoslovnaGodinaSubjektGrItem item)
    			{
    				_context.USP_PoslovnaGodinaSubjektGr_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    			public ObjectResult<Model.Data.PoslovnaGodinaSubjektGr> InsertResult(Model.Data.Item.PoslovnaGodinaSubjektGrItem item)
    			{
    				return _context.USP_PoslovnaGodinaSubjektGr_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_PoslovnaGodinaSubjektGr)
    			{
    				_context.USP_PoslovnaGodinaSubjektGr_SELECT(ID_PoslovnaGodinaSubjektGr);
    			}
    
    					
    			public ObjectResult<Model.Data.PoslovnaGodinaSubjektGr> SelectResult(Nullable<long> ID_PoslovnaGodinaSubjektGr)
            	{
                	return _context.USP_PoslovnaGodinaSubjektGr_SELECT(ID_PoslovnaGodinaSubjektGr);
            	}			
    				
    			public void Update(Model.Data.Item.PoslovnaGodinaSubjektGrItem item)
    			{
    				_context.USP_PoslovnaGodinaSubjektGr_UPDATE(item.ID_PoslovnaGodinaSubjektGr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    					
    			public ObjectResult<Model.Data.PoslovnaGodinaSubjektGr> UpdateResult(Model.Data.Item.PoslovnaGodinaSubjektGrItem item)
    			{
    				return _context.USP_PoslovnaGodinaSubjektGr_UPDATE(item.ID_PoslovnaGodinaSubjektGr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    										
    		
    #endregion
    	
    }
    
}
