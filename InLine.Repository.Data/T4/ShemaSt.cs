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
    
    public partial class ShemaSt
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ShemaSt(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ShemaStItem item)
    			{
    				_context.USP_ShemaSt_DELETE(item.ID_ShemaSt);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ShemaStItem item)
    			{
    				return _context.USP_ShemaSt_DELETE(item.ID_ShemaSt);
    			}	
    									
    			public void Insert(Model.Data.Item.ShemaStItem item)
    			{
    				_context.USP_ShemaSt_INSERT(item.ID_Shema, item.ID_KontniPlanSt, item.Potrazuje, item.Negativno, item.Sintetika);
    			}
    
    			public ObjectResult<Model.Data.ShemaSt> InsertResult(Model.Data.Item.ShemaStItem item)
    			{
    				return _context.USP_ShemaSt_INSERT(item.ID_Shema, item.ID_KontniPlanSt, item.Potrazuje, item.Negativno, item.Sintetika);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ShemaSt)
    			{
    				_context.USP_ShemaSt_SELECT(ID_ShemaSt);
    			}
    
    					
    			public ObjectResult<Model.Data.ShemaSt> SelectResult(Nullable<long> ID_ShemaSt)
            	{
                	return _context.USP_ShemaSt_SELECT(ID_ShemaSt);
            	}			
    				
    			public void Update(Model.Data.Item.ShemaStItem item)
    			{
    				_context.USP_ShemaSt_UPDATE(item.ID_ShemaSt, item.ID_Shema, item.ID_KontniPlanSt, item.Potrazuje, item.Negativno, item.Sintetika);
    			}
    
    					
    			public ObjectResult<Model.Data.ShemaSt> UpdateResult(Model.Data.Item.ShemaStItem item)
    			{
    				return _context.USP_ShemaSt_UPDATE(item.ID_ShemaSt, item.ID_Shema, item.ID_KontniPlanSt, item.Potrazuje, item.Negativno, item.Sintetika);
    			}
    										
    		
    #endregion
    	
    }
    
}
