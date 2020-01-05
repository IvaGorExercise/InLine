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
    
    public partial class DohodakPrimateljIsplataRacun
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public DohodakPrimateljIsplataRacun(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DohodakPrimateljIsplataRacunItem item)
    			{
    				_context.USP_DohodakPrimateljIsplataRacun_DELETE(item.ID_DohodakPrimateljIsplataRacun);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DohodakPrimateljIsplataRacunItem item)
    			{
    				return _context.USP_DohodakPrimateljIsplataRacun_DELETE(item.ID_DohodakPrimateljIsplataRacun);
    			}	
    									
    			public void Insert(Model.Data.Item.DohodakPrimateljIsplataRacunItem item)
    			{
    				_context.USP_DohodakPrimateljIsplataRacun_INSERT(item.ID_DohodakPrimatelj, item.ID_SubjektRacun, item.Iznos);
    			}
    
    			public ObjectResult<Model.Data.DohodakPrimateljIsplataRacun> InsertResult(Model.Data.Item.DohodakPrimateljIsplataRacunItem item)
    			{
    				return _context.USP_DohodakPrimateljIsplataRacun_INSERT(item.ID_DohodakPrimatelj, item.ID_SubjektRacun, item.Iznos);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_DohodakPrimateljIsplataRacun)
    			{
    				_context.USP_DohodakPrimateljIsplataRacun_SELECT(ID_DohodakPrimateljIsplataRacun);
    			}
    
    					
    			public ObjectResult<Model.Data.DohodakPrimateljIsplataRacun> SelectResult(Nullable<long> ID_DohodakPrimateljIsplataRacun)
            	{
                	return _context.USP_DohodakPrimateljIsplataRacun_SELECT(ID_DohodakPrimateljIsplataRacun);
            	}			
    				
    			public void Update(Model.Data.Item.DohodakPrimateljIsplataRacunItem item)
    			{
    				_context.USP_DohodakPrimateljIsplataRacun_UPDATE(item.ID_DohodakPrimateljIsplataRacun, item.ID_DohodakPrimatelj, item.ID_SubjektRacun, item.Iznos);
    			}
    
    					
    			public ObjectResult<Model.Data.DohodakPrimateljIsplataRacun> UpdateResult(Model.Data.Item.DohodakPrimateljIsplataRacunItem item)
    			{
    				return _context.USP_DohodakPrimateljIsplataRacun_UPDATE(item.ID_DohodakPrimateljIsplataRacun, item.ID_DohodakPrimatelj, item.ID_SubjektRacun, item.Iznos);
    			}
    										
    		
    #endregion
    	
    }
    
}