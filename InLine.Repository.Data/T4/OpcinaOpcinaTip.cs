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
    
    public partial class OpcinaOpcinaTip
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public OpcinaOpcinaTip(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.OpcinaOpcinaTipItem item)
    			{
    				_context.USP_OpcinaOpcinaTip_DELETE(item.ID_OpcinaOpcinaTip);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.OpcinaOpcinaTipItem item)
    			{
    				return _context.USP_OpcinaOpcinaTip_DELETE(item.ID_OpcinaOpcinaTip);
    			}	
    									
    			public void Insert(Model.Data.Item.OpcinaOpcinaTipItem item)
    			{
    				_context.USP_OpcinaOpcinaTip_INSERT(item.ID_Opcina, item.DatOd, item.DatDo, item.AktivU, item.ID_OpcinaTip, item.Opis);
    			}
    
    			public ObjectResult<Model.Data.OpcinaOpcinaTip> InsertResult(Model.Data.Item.OpcinaOpcinaTipItem item)
    			{
    				return _context.USP_OpcinaOpcinaTip_INSERT(item.ID_Opcina, item.DatOd, item.DatDo, item.AktivU, item.ID_OpcinaTip, item.Opis);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_OpcinaOpcinaTip)
    			{
    				_context.USP_OpcinaOpcinaTip_SELECT(ID_OpcinaOpcinaTip);
    			}
    
    					
    			public ObjectResult<Model.Data.OpcinaOpcinaTip> SelectResult(Nullable<long> ID_OpcinaOpcinaTip)
            	{
                	return _context.USP_OpcinaOpcinaTip_SELECT(ID_OpcinaOpcinaTip);
            	}			
    				
    			public void Update(Model.Data.Item.OpcinaOpcinaTipItem item)
    			{
    				_context.USP_OpcinaOpcinaTip_UPDATE(item.ID_OpcinaOpcinaTip, item.ID_Opcina, item.DatOd, item.DatDo, item.AktivU, item.ID_OpcinaTip, item.Opis);
    			}
    
    					
    			public ObjectResult<Model.Data.OpcinaOpcinaTip> UpdateResult(Model.Data.Item.OpcinaOpcinaTipItem item)
    			{
    				return _context.USP_OpcinaOpcinaTip_UPDATE(item.ID_OpcinaOpcinaTip, item.ID_Opcina, item.DatOd, item.DatDo, item.AktivU, item.ID_OpcinaTip, item.Opis);
    			}
    										
    		
    #endregion
    	
    }
    
}
