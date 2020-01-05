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
    
    public partial class PrimateljKoeficijent
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public PrimateljKoeficijent(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.PrimateljKoeficijentItem item)
    			{
    				_context.USP_PrimateljKoeficijent_DELETE(item.ID_PrimateljKoeficijent);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.PrimateljKoeficijentItem item)
    			{
    				return _context.USP_PrimateljKoeficijent_DELETE(item.ID_PrimateljKoeficijent);
    			}	
    									
    			public void Insert(Model.Data.Item.PrimateljKoeficijentItem item)
    			{
    				_context.USP_PrimateljKoeficijent_INSERT(item.ID_PrimateljKoeficijentGr, item.ID_Osoba, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Koeficijent);
    			}
    
    			public ObjectResult<Model.Data.PrimateljKoeficijent> InsertResult(Model.Data.Item.PrimateljKoeficijentItem item)
    			{
    				return _context.USP_PrimateljKoeficijent_INSERT(item.ID_PrimateljKoeficijentGr, item.ID_Osoba, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Koeficijent);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_PrimateljKoeficijent)
    			{
    				_context.USP_PrimateljKoeficijent_SELECT(ID_PrimateljKoeficijent);
    			}
    
    					
    			public ObjectResult<Model.Data.PrimateljKoeficijent> SelectResult(Nullable<long> ID_PrimateljKoeficijent)
            	{
                	return _context.USP_PrimateljKoeficijent_SELECT(ID_PrimateljKoeficijent);
            	}			
    				
    			public void Update(Model.Data.Item.PrimateljKoeficijentItem item)
    			{
    				_context.USP_PrimateljKoeficijent_UPDATE(item.ID_PrimateljKoeficijent, item.ID_PrimateljKoeficijentGr, item.ID_Osoba, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Koeficijent);
    			}
    
    					
    			public ObjectResult<Model.Data.PrimateljKoeficijent> UpdateResult(Model.Data.Item.PrimateljKoeficijentItem item)
    			{
    				return _context.USP_PrimateljKoeficijent_UPDATE(item.ID_PrimateljKoeficijent, item.ID_PrimateljKoeficijentGr, item.ID_Osoba, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Koeficijent);
    			}
    										
    		
    #endregion
    	
    }
    
}
