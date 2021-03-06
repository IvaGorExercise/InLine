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
    
    public partial class TecajListaSt
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public TecajListaSt(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.TecajListaStItem item)
    			{
    				_context.USP_TecajListaSt_DELETE(item.ID_TecajListaSt);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.TecajListaStItem item)
    			{
    				return _context.USP_TecajListaSt_DELETE(item.ID_TecajListaSt);
    			}	
    									
    			public void Insert(Model.Data.Item.TecajListaStItem item)
    			{
    				_context.USP_TecajListaSt_INSERT(item.ID_TecajLista, item.IDDrzavaIz, item.IDDrzavaU, item.IDValutaIz, item.IDValutaU, item.BrojJedinica);
    			}
    
    			public ObjectResult<Model.Data.TecajListaSt> InsertResult(Model.Data.Item.TecajListaStItem item)
    			{
    				return _context.USP_TecajListaSt_INSERT(item.ID_TecajLista, item.IDDrzavaIz, item.IDDrzavaU, item.IDValutaIz, item.IDValutaU, item.BrojJedinica);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_TecajListaSt)
    			{
    				_context.USP_TecajListaSt_SELECT(ID_TecajListaSt);
    			}
    
    					
    			public ObjectResult<Model.Data.TecajListaSt> SelectResult(Nullable<long> ID_TecajListaSt)
            	{
                	return _context.USP_TecajListaSt_SELECT(ID_TecajListaSt);
            	}			
    				
    			public void Update(Model.Data.Item.TecajListaStItem item)
    			{
    				_context.USP_TecajListaSt_UPDATE(item.ID_TecajListaSt, item.ID_TecajLista, item.IDDrzavaIz, item.IDDrzavaU, item.IDValutaIz, item.IDValutaU, item.BrojJedinica);
    			}
    
    					
    			public ObjectResult<Model.Data.TecajListaSt> UpdateResult(Model.Data.Item.TecajListaStItem item)
    			{
    				return _context.USP_TecajListaSt_UPDATE(item.ID_TecajListaSt, item.ID_TecajLista, item.IDDrzavaIz, item.IDDrzavaU, item.IDValutaIz, item.IDValutaU, item.BrojJedinica);
    			}
    										
    		
    #endregion
    	
    }
    
}
