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
    
    public partial class RacunIzlaz
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public RacunIzlaz(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.RacunIzlazItem item)
    			{
    				_context.USP_RacunIzlaz_DELETE(item.ID_RacunIzlaz);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.RacunIzlazItem item)
    			{
    				return _context.USP_RacunIzlaz_DELETE(item.ID_RacunIzlaz);
    			}	
    									
    			public void Insert(Model.Data.Item.RacunIzlazItem item)
    			{
    				_context.USP_RacunIzlaz_INSERT(item.ID_Zapis, item.ID_PoslovniSubjekt, item.ID_Subjekt);
    			}
    
    			public ObjectResult<Model.Data.RacunIzlaz> InsertResult(Model.Data.Item.RacunIzlazItem item)
    			{
    				return _context.USP_RacunIzlaz_INSERT(item.ID_Zapis, item.ID_PoslovniSubjekt, item.ID_Subjekt);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_RacunIzlaz)
    			{
    				_context.USP_RacunIzlaz_SELECT(ID_RacunIzlaz);
    			}
    
    					
    			public ObjectResult<Model.Data.RacunIzlaz> SelectResult(Nullable<long> ID_RacunIzlaz)
            	{
                	return _context.USP_RacunIzlaz_SELECT(ID_RacunIzlaz);
            	}			
    				
    			public void Update(Model.Data.Item.RacunIzlazItem item)
    			{
    				_context.USP_RacunIzlaz_UPDATE(item.ID_RacunIzlaz, item.ID_Zapis, item.ID_PoslovniSubjekt, item.ID_Subjekt);
    			}
    
    					
    			public ObjectResult<Model.Data.RacunIzlaz> UpdateResult(Model.Data.Item.RacunIzlazItem item)
    			{
    				return _context.USP_RacunIzlaz_UPDATE(item.ID_RacunIzlaz, item.ID_Zapis, item.ID_PoslovniSubjekt, item.ID_Subjekt);
    			}
    										
    		
    #endregion
    	
    }
    
}