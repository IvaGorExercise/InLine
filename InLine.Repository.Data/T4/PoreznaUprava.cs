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
    
    public partial class PoreznaUprava
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public PoreznaUprava(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.PoreznaUpravaItem item)
    			{
    				_context.USP_PoreznaUprava_DELETE(item.ID_PoreznaUprava);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.PoreznaUpravaItem item)
    			{
    				return _context.USP_PoreznaUprava_DELETE(item.ID_PoreznaUprava);
    			}	
    									
    			public void Insert(Model.Data.Item.PoreznaUpravaItem item)
    			{
    				_context.USP_PoreznaUprava_INSERT(item.ID_Subjekt, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.OIB);
    			}
    
    			public ObjectResult<Model.Data.PoreznaUprava> InsertResult(Model.Data.Item.PoreznaUpravaItem item)
    			{
    				return _context.USP_PoreznaUprava_INSERT(item.ID_Subjekt, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.OIB);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_PoreznaUprava)
    			{
    				_context.USP_PoreznaUprava_SELECT(ID_PoreznaUprava);
    			}
    
    					
    			public ObjectResult<Model.Data.PoreznaUprava> SelectResult(Nullable<long> ID_PoreznaUprava)
            	{
                	return _context.USP_PoreznaUprava_SELECT(ID_PoreznaUprava);
            	}			
    				
    			public void Update(Model.Data.Item.PoreznaUpravaItem item)
    			{
    				_context.USP_PoreznaUprava_UPDATE(item.ID_PoreznaUprava, item.ID_Subjekt, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.OIB);
    			}
    
    					
    			public ObjectResult<Model.Data.PoreznaUprava> UpdateResult(Model.Data.Item.PoreznaUpravaItem item)
    			{
    				return _context.USP_PoreznaUprava_UPDATE(item.ID_PoreznaUprava, item.ID_Subjekt, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.OIB);
    			}
    										
    		
    #endregion
    	
    }
    
}
