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
    
    public partial class OpcinaTip
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public OpcinaTip(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.OpcinaTipItem item)
    			{
    				_context.USP_OpcinaTip_DELETE(item.ID_OpcinaTip);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.OpcinaTipItem item)
    			{
    				return _context.USP_OpcinaTip_DELETE(item.ID_OpcinaTip);
    			}	
    									
    			public void Insert(Model.Data.Item.OpcinaTipItem item)
    			{
    				_context.USP_OpcinaTip_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis, item.StsOpcinaTip);
    			}
    
    			public ObjectResult<Model.Data.OpcinaTip> InsertResult(Model.Data.Item.OpcinaTipItem item)
    			{
    				return _context.USP_OpcinaTip_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis, item.StsOpcinaTip);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_OpcinaTip)
    			{
    				_context.USP_OpcinaTip_SELECT(ID_OpcinaTip);
    			}
    
    					
    			public ObjectResult<Model.Data.OpcinaTip> SelectResult(Nullable<long> ID_OpcinaTip)
            	{
                	return _context.USP_OpcinaTip_SELECT(ID_OpcinaTip);
            	}			
    				
    			public void Update(Model.Data.Item.OpcinaTipItem item)
    			{
    				_context.USP_OpcinaTip_UPDATE(item.ID_OpcinaTip, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis, item.StsOpcinaTip);
    			}
    
    					
    			public ObjectResult<Model.Data.OpcinaTip> UpdateResult(Model.Data.Item.OpcinaTipItem item)
    			{
    				return _context.USP_OpcinaTip_UPDATE(item.ID_OpcinaTip, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis, item.StsOpcinaTip);
    			}
    										
    		
    #endregion
    	
    }
    
}
