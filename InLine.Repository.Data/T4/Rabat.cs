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
    
    public partial class Rabat
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public Rabat(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.RabatItem item)
    			{
    				_context.USP_Rabat_DELETE(item.ID_Rabat);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.RabatItem item)
    			{
    				return _context.USP_Rabat_DELETE(item.ID_Rabat);
    			}	
    									
    			public void Insert(Model.Data.Item.RabatItem item)
    			{
    				_context.USP_Rabat_INSERT(item.ID_PoslovniSubjekt, item.ID_Subjekt, item.StopaRabat);
    			}
    
    			public ObjectResult<Model.Data.Rabat> InsertResult(Model.Data.Item.RabatItem item)
    			{
    				return _context.USP_Rabat_INSERT(item.ID_PoslovniSubjekt, item.ID_Subjekt, item.StopaRabat);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_Rabat)
    			{
    				_context.USP_Rabat_SELECT(ID_Rabat);
    			}
    
    					
    			public ObjectResult<Model.Data.Rabat> SelectResult(Nullable<long> ID_Rabat)
            	{
                	return _context.USP_Rabat_SELECT(ID_Rabat);
            	}			
    				
    			public void Update(Model.Data.Item.RabatItem item)
    			{
    				_context.USP_Rabat_UPDATE(item.ID_Rabat, item.ID_PoslovniSubjekt, item.ID_Subjekt, item.StopaRabat);
    			}
    
    					
    			public ObjectResult<Model.Data.Rabat> UpdateResult(Model.Data.Item.RabatItem item)
    			{
    				return _context.USP_Rabat_UPDATE(item.ID_Rabat, item.ID_PoslovniSubjekt, item.ID_Subjekt, item.StopaRabat);
    			}
    										
    		
    #endregion
    	
    }
    
}
