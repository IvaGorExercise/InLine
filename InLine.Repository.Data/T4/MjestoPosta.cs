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
    
    public partial class MjestoPosta
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public MjestoPosta(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.MjestoPostaItem item)
    			{
    				_context.USP_MjestoPosta_DELETE(item.ID_MjestoPosta);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.MjestoPostaItem item)
    			{
    				return _context.USP_MjestoPosta_DELETE(item.ID_MjestoPosta);
    			}	
    									
    			public void Insert(Model.Data.Item.MjestoPostaItem item)
    			{
    				_context.USP_MjestoPosta_INSERT(item.ID_Mjesto, item.ID_Posta, item.DioMjesta, item.StsMjestoPosta, item.IzborMjestoPosta, item.PBrStari, item.Oznaka, item.Naziv, item.NazivAlt, item.NazivHPT, item.NazivKr, item.Kratica, item.Opis, item.OpisHPT, item.AdresaBezMjesta);
    			}
    
    			public ObjectResult<Model.Data.MjestoPosta> InsertResult(Model.Data.Item.MjestoPostaItem item)
    			{
    				return _context.USP_MjestoPosta_INSERT(item.ID_Mjesto, item.ID_Posta, item.DioMjesta, item.StsMjestoPosta, item.IzborMjestoPosta, item.PBrStari, item.Oznaka, item.Naziv, item.NazivAlt, item.NazivHPT, item.NazivKr, item.Kratica, item.Opis, item.OpisHPT, item.AdresaBezMjesta);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_MjestoPosta)
    			{
    				_context.USP_MjestoPosta_SELECT(ID_MjestoPosta);
    			}
    
    					
    			public ObjectResult<Model.Data.MjestoPosta> SelectResult(Nullable<long> ID_MjestoPosta)
            	{
                	return _context.USP_MjestoPosta_SELECT(ID_MjestoPosta);
            	}			
    				
    			public void Update(Model.Data.Item.MjestoPostaItem item)
    			{
    				_context.USP_MjestoPosta_UPDATE(item.ID_MjestoPosta, item.ID_Mjesto, item.ID_Posta, item.DioMjesta, item.StsMjestoPosta, item.IzborMjestoPosta, item.PBrStari, item.Oznaka, item.Naziv, item.NazivAlt, item.NazivHPT, item.NazivKr, item.Kratica, item.Opis, item.OpisHPT, item.AdresaBezMjesta);
    			}
    
    					
    			public ObjectResult<Model.Data.MjestoPosta> UpdateResult(Model.Data.Item.MjestoPostaItem item)
    			{
    				return _context.USP_MjestoPosta_UPDATE(item.ID_MjestoPosta, item.ID_Mjesto, item.ID_Posta, item.DioMjesta, item.StsMjestoPosta, item.IzborMjestoPosta, item.PBrStari, item.Oznaka, item.Naziv, item.NazivAlt, item.NazivHPT, item.NazivKr, item.Kratica, item.Opis, item.OpisHPT, item.AdresaBezMjesta);
    			}
    										
    		
    #endregion
    	
    }
    
}
