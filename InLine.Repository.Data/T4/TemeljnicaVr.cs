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
    
    public partial class TemeljnicaVr
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public TemeljnicaVr(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.TemeljnicaVrItem item)
    			{
    				_context.USP_TemeljnicaVr_DELETE(item.ID_TemeljnicaVr);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.TemeljnicaVrItem item)
    			{
    				return _context.USP_TemeljnicaVr_DELETE(item.ID_TemeljnicaVr);
    			}	
    									
    			public void Insert(Model.Data.Item.TemeljnicaVrItem item)
    			{
    				_context.USP_TemeljnicaVr_INSERT(item.ID_GlavnaKnjiga, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.IDValuta, item.Tecaj, item.Opis);
    			}
    
    			public ObjectResult<Model.Data.TemeljnicaVr> InsertResult(Model.Data.Item.TemeljnicaVrItem item)
    			{
    				return _context.USP_TemeljnicaVr_INSERT(item.ID_GlavnaKnjiga, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.IDValuta, item.Tecaj, item.Opis);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_TemeljnicaVr)
    			{
    				_context.USP_TemeljnicaVr_SELECT(ID_TemeljnicaVr);
    			}
    
    					
    			public ObjectResult<Model.Data.TemeljnicaVr> SelectResult(Nullable<long> ID_TemeljnicaVr)
            	{
                	return _context.USP_TemeljnicaVr_SELECT(ID_TemeljnicaVr);
            	}			
    				
    			public void Update(Model.Data.Item.TemeljnicaVrItem item)
    			{
    				_context.USP_TemeljnicaVr_UPDATE(item.ID_TemeljnicaVr, item.ID_GlavnaKnjiga, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.IDValuta, item.Tecaj, item.Opis);
    			}
    
    					
    			public ObjectResult<Model.Data.TemeljnicaVr> UpdateResult(Model.Data.Item.TemeljnicaVrItem item)
    			{
    				return _context.USP_TemeljnicaVr_UPDATE(item.ID_TemeljnicaVr, item.ID_GlavnaKnjiga, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.IDValuta, item.Tecaj, item.Opis);
    			}
    										
    		
    #endregion
    	
    }
    
}
