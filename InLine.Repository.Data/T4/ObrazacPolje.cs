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
    
    public partial class ObrazacPolje
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ObrazacPolje(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ObrazacPoljeItem item)
    			{
    				_context.USP_ObrazacPolje_DELETE(item.ID_ObrazacPolje);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacPoljeItem item)
    			{
    				return _context.USP_ObrazacPolje_DELETE(item.ID_ObrazacPolje);
    			}	
    									
    			public void Insert(Model.Data.Item.ObrazacPoljeItem item)
    			{
    				_context.USP_ObrazacPolje_INSERT(item.ID_Obrazac, item.Redak, item.ID_ObrazacVrPolje, item.ValueBit, item.ValueString, item.ValueInt, item.ValueMoney, item.ValueDate, item.ValueTime, item.ValueDateTime, item.ValueDecimal);
    			}
    
    			public ObjectResult<Model.Data.ObrazacPolje> InsertResult(Model.Data.Item.ObrazacPoljeItem item)
    			{
    				return _context.USP_ObrazacPolje_INSERT(item.ID_Obrazac, item.Redak, item.ID_ObrazacVrPolje, item.ValueBit, item.ValueString, item.ValueInt, item.ValueMoney, item.ValueDate, item.ValueTime, item.ValueDateTime, item.ValueDecimal);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ObrazacPolje)
    			{
    				_context.USP_ObrazacPolje_SELECT(ID_ObrazacPolje);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacPolje> SelectResult(Nullable<long> ID_ObrazacPolje)
            	{
                	return _context.USP_ObrazacPolje_SELECT(ID_ObrazacPolje);
            	}			
    				
    			public void Update(Model.Data.Item.ObrazacPoljeItem item)
    			{
    				_context.USP_ObrazacPolje_UPDATE(item.ID_ObrazacPolje, item.ID_Obrazac, item.Redak, item.ID_ObrazacVrPolje, item.ValueBit, item.ValueString, item.ValueInt, item.ValueMoney, item.ValueDate, item.ValueTime, item.ValueDateTime, item.ValueDecimal);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacPolje> UpdateResult(Model.Data.Item.ObrazacPoljeItem item)
    			{
    				return _context.USP_ObrazacPolje_UPDATE(item.ID_ObrazacPolje, item.ID_Obrazac, item.Redak, item.ID_ObrazacVrPolje, item.ValueBit, item.ValueString, item.ValueInt, item.ValueMoney, item.ValueDate, item.ValueTime, item.ValueDateTime, item.ValueDecimal);
    			}
    										
    		
    #endregion
    	
    }
    
}
