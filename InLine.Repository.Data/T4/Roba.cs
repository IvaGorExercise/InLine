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
    
    public partial class Roba
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public Roba(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.RobaItem item)
    			{
    				_context.USP_Roba_DELETE(item.ID_Roba);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.RobaItem item)
    			{
    				return _context.USP_Roba_DELETE(item.ID_Roba);
    			}	
    									
    			public void Insert(Model.Data.Item.RobaItem item)
    			{
    				_context.USP_Roba_INSERT(item.ID_Objekt, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    			public ObjectResult<Model.Data.Roba> InsertResult(Model.Data.Item.RobaItem item)
    			{
    				return _context.USP_Roba_INSERT(item.ID_Objekt, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_Roba)
    			{
    				_context.USP_Roba_SELECT(ID_Roba);
    			}
    
    					
    			public ObjectResult<Model.Data.Roba> SelectResult(Nullable<long> ID_Roba)
            	{
                	return _context.USP_Roba_SELECT(ID_Roba);
            	}			
    				
    			public void Update(Model.Data.Item.RobaItem item)
    			{
    				_context.USP_Roba_UPDATE(item.ID_Roba, item.ID_Objekt, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    					
    			public ObjectResult<Model.Data.Roba> UpdateResult(Model.Data.Item.RobaItem item)
    			{
    				return _context.USP_Roba_UPDATE(item.ID_Roba, item.ID_Objekt, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    										
    		
    #endregion
    	
    }
    
}
