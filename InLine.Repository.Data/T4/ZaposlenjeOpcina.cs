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
    
    public partial class ZaposlenjeOpcina
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ZaposlenjeOpcina(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ZaposlenjeOpcinaItem item)
    			{
    				_context.USP_ZaposlenjeOpcina_DELETE(item.ID_ZaposlenjeOpcina);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ZaposlenjeOpcinaItem item)
    			{
    				return _context.USP_ZaposlenjeOpcina_DELETE(item.ID_ZaposlenjeOpcina);
    			}	
    									
    			public void Insert(Model.Data.Item.ZaposlenjeOpcinaItem item)
    			{
    				_context.USP_ZaposlenjeOpcina_INSERT(item.ID_Zaposlenje, item.ID_Opcina, item.DatumOd, item.DatumDo);
    			}
    
    			public ObjectResult<Model.Data.ZaposlenjeOpcina> InsertResult(Model.Data.Item.ZaposlenjeOpcinaItem item)
    			{
    				return _context.USP_ZaposlenjeOpcina_INSERT(item.ID_Zaposlenje, item.ID_Opcina, item.DatumOd, item.DatumDo);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ZaposlenjeOpcina)
    			{
    				_context.USP_ZaposlenjeOpcina_SELECT(ID_ZaposlenjeOpcina);
    			}
    
    					
    			public ObjectResult<Model.Data.ZaposlenjeOpcina> SelectResult(Nullable<long> ID_ZaposlenjeOpcina)
            	{
                	return _context.USP_ZaposlenjeOpcina_SELECT(ID_ZaposlenjeOpcina);
            	}			
    				
    			public void Update(Model.Data.Item.ZaposlenjeOpcinaItem item)
    			{
    				_context.USP_ZaposlenjeOpcina_UPDATE(item.ID_ZaposlenjeOpcina, item.ID_Zaposlenje, item.ID_Opcina, item.DatumOd, item.DatumDo);
    			}
    
    					
    			public ObjectResult<Model.Data.ZaposlenjeOpcina> UpdateResult(Model.Data.Item.ZaposlenjeOpcinaItem item)
    			{
    				return _context.USP_ZaposlenjeOpcina_UPDATE(item.ID_ZaposlenjeOpcina, item.ID_Zaposlenje, item.ID_Opcina, item.DatumOd, item.DatumDo);
    			}
    										
    		
    #endregion
    	
    }
    
}
