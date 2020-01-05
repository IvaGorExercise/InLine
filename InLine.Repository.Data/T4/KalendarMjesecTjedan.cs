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
    
    public partial class KalendarMjesecTjedan
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public KalendarMjesecTjedan(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.KalendarMjesecTjedanItem item)
    			{
    				_context.USP_KalendarMjesecTjedan_DELETE(item.MjesecTjedan);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.KalendarMjesecTjedanItem item)
    			{
    				return _context.USP_KalendarMjesecTjedan_DELETE(item.MjesecTjedan);
    			}	
    									
    			public void Insert(Model.Data.Item.KalendarMjesecTjedanItem item)
    			{
    				_context.USP_KalendarMjesecTjedan_INSERT(item.MjesecTjedan, item.Oznaka, item.Naziv);
    			}
    
    			public ObjectResult<Model.Data.KalendarMjesecTjedan> InsertResult(Model.Data.Item.KalendarMjesecTjedanItem item)
    			{
    				return _context.USP_KalendarMjesecTjedan_INSERT(item.MjesecTjedan, item.Oznaka, item.Naziv);
    			}	
    									
    				
    			public void Select(Nullable<int> MjesecTjedan)
    			{
    				_context.USP_KalendarMjesecTjedan_SELECT(MjesecTjedan);
    			}
    
    					
    			public ObjectResult<Model.Data.KalendarMjesecTjedan> SelectResult(Nullable<int> MjesecTjedan)
            	{
                	return _context.USP_KalendarMjesecTjedan_SELECT(MjesecTjedan);
            	}			
    				
    			public void Update(Model.Data.Item.KalendarMjesecTjedanItem item)
    			{
    				_context.USP_KalendarMjesecTjedan_UPDATE(item.MjesecTjedan, item.Oznaka, item.Naziv);
    			}
    
    					
    			public ObjectResult<Model.Data.KalendarMjesecTjedan> UpdateResult(Model.Data.Item.KalendarMjesecTjedanItem item)
    			{
    				return _context.USP_KalendarMjesecTjedan_UPDATE(item.MjesecTjedan, item.Oznaka, item.Naziv);
    			}
    										
    		
    #endregion
    	
    }
    
}