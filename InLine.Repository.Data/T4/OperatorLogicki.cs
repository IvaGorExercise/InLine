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
    
    public partial class OperatorLogicki
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public OperatorLogicki(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.OperatorLogickiItem item)
    			{
    				_context.USP_OperatorLogicki_DELETE(item.LogickiOperator);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.OperatorLogickiItem item)
    			{
    				return _context.USP_OperatorLogicki_DELETE(item.LogickiOperator);
    			}	
    									
    			public void Insert(Model.Data.Item.OperatorLogickiItem item)
    			{
    				_context.USP_OperatorLogicki_INSERT(item.LogickiOperator, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    			public ObjectResult<Model.Data.OperatorLogicki> InsertResult(Model.Data.Item.OperatorLogickiItem item)
    			{
    				return _context.USP_OperatorLogicki_INSERT(item.LogickiOperator, item.Naziv, item.NazivKr, item.Kratica);
    			}	
    									
    				
    			public void Select(string LogickiOperator)
    			{
    				_context.USP_OperatorLogicki_SELECT(LogickiOperator);
    			}
    
    					
    			public ObjectResult<Model.Data.OperatorLogicki> SelectResult(string LogickiOperator)
            	{
                	return _context.USP_OperatorLogicki_SELECT(LogickiOperator);
            	}			
    				
    			public void Update(Model.Data.Item.OperatorLogickiItem item)
    			{
    				_context.USP_OperatorLogicki_UPDATE(item.LogickiOperator, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    					
    			public ObjectResult<Model.Data.OperatorLogicki> UpdateResult(Model.Data.Item.OperatorLogickiItem item)
    			{
    				return _context.USP_OperatorLogicki_UPDATE(item.LogickiOperator, item.Naziv, item.NazivKr, item.Kratica);
    			}
    										
    		
    #endregion
    	
    }
    
}
