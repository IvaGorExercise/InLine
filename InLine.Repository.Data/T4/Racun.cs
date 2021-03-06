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
    
    public partial class Racun
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public Racun(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.RacunItem item)
    			{
    				_context.USP_Racun_DELETE(item.ID_Racun);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.RacunItem item)
    			{
    				return _context.USP_Racun_DELETE(item.ID_Racun);
    			}	
    									
    			public void Insert(Model.Data.Item.RacunItem item)
    			{
    				_context.USP_Racun_INSERT(item.ID_RacunVr, item.Oznaka, item.Naziv, item.VBDI, item.Broj, item.IBAN);
    			}
    
    			public ObjectResult<Model.Data.Racun> InsertResult(Model.Data.Item.RacunItem item)
    			{
    				return _context.USP_Racun_INSERT(item.ID_RacunVr, item.Oznaka, item.Naziv, item.VBDI, item.Broj, item.IBAN);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_Racun)
    			{
    				_context.USP_Racun_SELECT(ID_Racun);
    			}
    
    					
    			public ObjectResult<Model.Data.Racun> SelectResult(Nullable<long> ID_Racun)
            	{
                	return _context.USP_Racun_SELECT(ID_Racun);
            	}			
    				
    			public void Update(Model.Data.Item.RacunItem item)
    			{
    				_context.USP_Racun_UPDATE(item.ID_Racun, item.ID_RacunVr, item.Oznaka, item.Naziv, item.VBDI, item.Broj, item.IBAN);
    			}
    
    					
    			public ObjectResult<Model.Data.Racun> UpdateResult(Model.Data.Item.RacunItem item)
    			{
    				return _context.USP_Racun_UPDATE(item.ID_Racun, item.ID_RacunVr, item.Oznaka, item.Naziv, item.VBDI, item.Broj, item.IBAN);
    			}
    										
    		
    #endregion
    	
    }
    
}
