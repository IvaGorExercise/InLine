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
    
    public partial class KnjigaIRAPDV
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public KnjigaIRAPDV(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.KnjigaIRAPDVItem item)
    			{
    				_context.USP_KnjigaIRAPDV_DELETE(item.ID_KnjigaIRAPDV);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.KnjigaIRAPDVItem item)
    			{
    				return _context.USP_KnjigaIRAPDV_DELETE(item.ID_KnjigaIRAPDV);
    			}	
    									
    			public void Insert(Model.Data.Item.KnjigaIRAPDVItem item)
    			{
    				_context.USP_KnjigaIRAPDV_INSERT(item.ID_KnjigaIRA, item.ID_PDV, item.IznosOsnova, item.Iznos);
    			}
    
    			public ObjectResult<Model.Data.KnjigaIRAPDV> InsertResult(Model.Data.Item.KnjigaIRAPDVItem item)
    			{
    				return _context.USP_KnjigaIRAPDV_INSERT(item.ID_KnjigaIRA, item.ID_PDV, item.IznosOsnova, item.Iznos);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_KnjigaIRAPDV)
    			{
    				_context.USP_KnjigaIRAPDV_SELECT(ID_KnjigaIRAPDV);
    			}
    
    					
    			public ObjectResult<Model.Data.KnjigaIRAPDV> SelectResult(Nullable<long> ID_KnjigaIRAPDV)
            	{
                	return _context.USP_KnjigaIRAPDV_SELECT(ID_KnjigaIRAPDV);
            	}			
    				
    			public void Update(Model.Data.Item.KnjigaIRAPDVItem item)
    			{
    				_context.USP_KnjigaIRAPDV_UPDATE(item.ID_KnjigaIRAPDV, item.ID_KnjigaIRA, item.ID_PDV, item.IznosOsnova, item.Iznos);
    			}
    
    					
    			public ObjectResult<Model.Data.KnjigaIRAPDV> UpdateResult(Model.Data.Item.KnjigaIRAPDVItem item)
    			{
    				return _context.USP_KnjigaIRAPDV_UPDATE(item.ID_KnjigaIRAPDV, item.ID_KnjigaIRA, item.ID_PDV, item.IznosOsnova, item.Iznos);
    			}
    										
    		
    #endregion
    	
    }
    
}