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
    
    public partial class KnjigaURA
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public KnjigaURA(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.KnjigaURAItem item)
    			{
    				_context.USP_KnjigaURA_DELETE(item.ID_KnjigaURA);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.KnjigaURAItem item)
    			{
    				return _context.USP_KnjigaURA_DELETE(item.ID_KnjigaURA);
    			}	
    									
    			public void Insert(Model.Data.Item.KnjigaURAItem item)
    			{
    				_context.USP_KnjigaURA_INSERT(item.ID_Zapis, item.ID_PoslovnaGodina, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.ID_RacunUlaz);
    			}
    
    			public ObjectResult<Model.Data.KnjigaURA> InsertResult(Model.Data.Item.KnjigaURAItem item)
    			{
    				return _context.USP_KnjigaURA_INSERT(item.ID_Zapis, item.ID_PoslovnaGodina, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.ID_RacunUlaz);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_KnjigaURA)
    			{
    				_context.USP_KnjigaURA_SELECT(ID_KnjigaURA);
    			}
    
    					
    			public ObjectResult<Model.Data.KnjigaURA> SelectResult(Nullable<long> ID_KnjigaURA)
            	{
                	return _context.USP_KnjigaURA_SELECT(ID_KnjigaURA);
            	}			
    				
    			public void Update(Model.Data.Item.KnjigaURAItem item)
    			{
    				_context.USP_KnjigaURA_UPDATE(item.ID_KnjigaURA, item.ID_Zapis, item.ID_PoslovnaGodina, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.ID_RacunUlaz);
    			}
    
    					
    			public ObjectResult<Model.Data.KnjigaURA> UpdateResult(Model.Data.Item.KnjigaURAItem item)
    			{
    				return _context.USP_KnjigaURA_UPDATE(item.ID_KnjigaURA, item.ID_Zapis, item.ID_PoslovnaGodina, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.ID_RacunUlaz);
    			}
    										
    		
    #endregion
    	
    }
    
}