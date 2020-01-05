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
    
    public partial class RacunUlaz
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public RacunUlaz(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.RacunUlazItem item)
    			{
    				_context.USP_RacunUlaz_DELETE(item.ID_RacunUlaz);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.RacunUlazItem item)
    			{
    				return _context.USP_RacunUlaz_DELETE(item.ID_RacunUlaz);
    			}	
    									
    			public void Insert(Model.Data.Item.RacunUlazItem item)
    			{
    				_context.USP_RacunUlaz_INSERT(item.ID_Zapis, item.ID_PoslovniSubjekt, item.ID_Subjekt);
    			}
    
    			public ObjectResult<Model.Data.RacunUlaz> InsertResult(Model.Data.Item.RacunUlazItem item)
    			{
    				return _context.USP_RacunUlaz_INSERT(item.ID_Zapis, item.ID_PoslovniSubjekt, item.ID_Subjekt);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_RacunUlaz)
    			{
    				_context.USP_RacunUlaz_SELECT(ID_RacunUlaz);
    			}
    
    					
    			public ObjectResult<Model.Data.RacunUlaz> SelectResult(Nullable<long> ID_RacunUlaz)
            	{
                	return _context.USP_RacunUlaz_SELECT(ID_RacunUlaz);
            	}			
    				
    			public void Update(Model.Data.Item.RacunUlazItem item)
    			{
    				_context.USP_RacunUlaz_UPDATE(item.ID_RacunUlaz, item.ID_Zapis, item.ID_PoslovniSubjekt, item.ID_Subjekt);
    			}
    
    					
    			public ObjectResult<Model.Data.RacunUlaz> UpdateResult(Model.Data.Item.RacunUlazItem item)
    			{
    				return _context.USP_RacunUlaz_UPDATE(item.ID_RacunUlaz, item.ID_Zapis, item.ID_PoslovniSubjekt, item.ID_Subjekt);
    			}
    										
    		
    #endregion
    	
    }
    
}
