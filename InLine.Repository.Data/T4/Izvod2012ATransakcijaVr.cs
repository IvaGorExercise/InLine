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
    
    public partial class Izvod2012ATransakcijaVr
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public Izvod2012ATransakcijaVr(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.Izvod2012ATransakcijaVrItem item)
    			{
    				_context.USP_Izvod2012ATransakcijaVr_DELETE(item.IDIzvod2012ATransakcijaVr);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.Izvod2012ATransakcijaVrItem item)
    			{
    				return _context.USP_Izvod2012ATransakcijaVr_DELETE(item.IDIzvod2012ATransakcijaVr);
    			}	
    									
    			public void Insert(Model.Data.Item.Izvod2012ATransakcijaVrItem item)
    			{
    				_context.USP_Izvod2012ATransakcijaVr_INSERT(item.IDIzvod2012ATransakcijaVr, item.Naziv);
    			}
    
    			public ObjectResult<Model.Data.Izvod2012ATransakcijaVr> InsertResult(Model.Data.Item.Izvod2012ATransakcijaVrItem item)
    			{
    				return _context.USP_Izvod2012ATransakcijaVr_INSERT(item.IDIzvod2012ATransakcijaVr, item.Naziv);
    			}	
    									
    				
    			public void Select(Nullable<int> IDIzvod2012ATransakcijaVr)
    			{
    				_context.USP_Izvod2012ATransakcijaVr_SELECT(IDIzvod2012ATransakcijaVr);
    			}
    
    					
    			public ObjectResult<Model.Data.Izvod2012ATransakcijaVr> SelectResult(Nullable<int> IDIzvod2012ATransakcijaVr)
            	{
                	return _context.USP_Izvod2012ATransakcijaVr_SELECT(IDIzvod2012ATransakcijaVr);
            	}			
    				
    			public void Update(Model.Data.Item.Izvod2012ATransakcijaVrItem item)
    			{
    				_context.USP_Izvod2012ATransakcijaVr_UPDATE(item.IDIzvod2012ATransakcijaVr, item.Naziv);
    			}
    
    					
    			public ObjectResult<Model.Data.Izvod2012ATransakcijaVr> UpdateResult(Model.Data.Item.Izvod2012ATransakcijaVrItem item)
    			{
    				return _context.USP_Izvod2012ATransakcijaVr_UPDATE(item.IDIzvod2012ATransakcijaVr, item.Naziv);
    			}
    										
    		
    #endregion
    	
    }
    
}
