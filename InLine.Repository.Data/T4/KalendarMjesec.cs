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
    
    public partial class KalendarMjesec
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public KalendarMjesec(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.KalendarMjesecItem item)
    			{
    				_context.USP_KalendarMjesec_DELETE(item.Mjesec);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.KalendarMjesecItem item)
    			{
    				return _context.USP_KalendarMjesec_DELETE(item.Mjesec);
    			}	
    									
    			public void Insert(Model.Data.Item.KalendarMjesecItem item)
    			{
    				_context.USP_KalendarMjesec_INSERT(item.Mjesec, item.Oznaka, item.Naziv);
    			}
    
    			public ObjectResult<Model.Data.KalendarMjesec> InsertResult(Model.Data.Item.KalendarMjesecItem item)
    			{
    				return _context.USP_KalendarMjesec_INSERT(item.Mjesec, item.Oznaka, item.Naziv);
    			}	
    									
    				
    			public void Select(Nullable<int> Mjesec)
    			{
    				_context.USP_KalendarMjesec_SELECT(Mjesec);
    			}
    
    					
    			public ObjectResult<Model.Data.KalendarMjesec> SelectResult(Nullable<int> Mjesec)
            	{
                	return _context.USP_KalendarMjesec_SELECT(Mjesec);
            	}			
    				
    			public void Update(Model.Data.Item.KalendarMjesecItem item)
    			{
    				_context.USP_KalendarMjesec_UPDATE(item.Mjesec, item.Oznaka, item.Naziv);
    			}
    
    					
    			public ObjectResult<Model.Data.KalendarMjesec> UpdateResult(Model.Data.Item.KalendarMjesecItem item)
    			{
    				return _context.USP_KalendarMjesec_UPDATE(item.Mjesec, item.Oznaka, item.Naziv);
    			}
    										
    		
    #endregion
    	
    }
    
}