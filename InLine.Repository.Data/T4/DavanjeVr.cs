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
    
    public partial class DavanjeVr
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public DavanjeVr(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DavanjeVrItem item)
    			{
    				_context.USP_DavanjeVr_DELETE(item.IDDavanjeVr);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DavanjeVrItem item)
    			{
    				return _context.USP_DavanjeVr_DELETE(item.IDDavanjeVr);
    			}	
    									
    			public void Insert(Model.Data.Item.DavanjeVrItem item)
    			{
    				_context.USP_DavanjeVr_INSERT(item.IDDavanjeVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    			public ObjectResult<Model.Data.DavanjeVr> InsertResult(Model.Data.Item.DavanjeVrItem item)
    			{
    				return _context.USP_DavanjeVr_INSERT(item.IDDavanjeVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}	
    									
    				
    			public void Select(Nullable<int> IDDavanjeVr)
    			{
    				_context.USP_DavanjeVr_SELECT(IDDavanjeVr);
    			}
    
    					
    			public ObjectResult<Model.Data.DavanjeVr> SelectResult(Nullable<int> IDDavanjeVr)
            	{
                	return _context.USP_DavanjeVr_SELECT(IDDavanjeVr);
            	}			
    				
    			public void Update(Model.Data.Item.DavanjeVrItem item)
    			{
    				_context.USP_DavanjeVr_UPDATE(item.IDDavanjeVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    					
    			public ObjectResult<Model.Data.DavanjeVr> UpdateResult(Model.Data.Item.DavanjeVrItem item)
    			{
    				return _context.USP_DavanjeVr_UPDATE(item.IDDavanjeVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    										
    		
    #endregion
    	
    }
    
}
