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
    
    public partial class DatotekaVr
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public DatotekaVr(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DatotekaVrItem item)
    			{
    				_context.USP_DatotekaVr_DELETE(item.ID_DatotekaVr);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DatotekaVrItem item)
    			{
    				return _context.USP_DatotekaVr_DELETE(item.ID_DatotekaVr);
    			}	
    									
    			public void Insert(Model.Data.Item.DatotekaVrItem item)
    			{
    				_context.USP_DatotekaVr_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    			public ObjectResult<Model.Data.DatotekaVr> InsertResult(Model.Data.Item.DatotekaVrItem item)
    			{
    				return _context.USP_DatotekaVr_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_DatotekaVr)
    			{
    				_context.USP_DatotekaVr_SELECT(ID_DatotekaVr);
    			}
    
    					
    			public ObjectResult<Model.Data.DatotekaVr> SelectResult(Nullable<long> ID_DatotekaVr)
            	{
                	return _context.USP_DatotekaVr_SELECT(ID_DatotekaVr);
            	}			
    				
    			public void Update(Model.Data.Item.DatotekaVrItem item)
    			{
    				_context.USP_DatotekaVr_UPDATE(item.ID_DatotekaVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    					
    			public ObjectResult<Model.Data.DatotekaVr> UpdateResult(Model.Data.Item.DatotekaVrItem item)
    			{
    				return _context.USP_DatotekaVr_UPDATE(item.ID_DatotekaVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    										
    		
    #endregion
    	
    }
    
}
