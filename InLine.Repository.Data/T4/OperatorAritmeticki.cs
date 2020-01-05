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
    
    public partial class OperatorAritmeticki
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public OperatorAritmeticki(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.OperatorAritmetickiItem item)
    			{
    				_context.USP_OperatorAritmeticki_DELETE(item.AritmetickiOperator);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.OperatorAritmetickiItem item)
    			{
    				return _context.USP_OperatorAritmeticki_DELETE(item.AritmetickiOperator);
    			}	
    									
    			public void Insert(Model.Data.Item.OperatorAritmetickiItem item)
    			{
    				_context.USP_OperatorAritmeticki_INSERT(item.AritmetickiOperator, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    			public ObjectResult<Model.Data.OperatorAritmeticki> InsertResult(Model.Data.Item.OperatorAritmetickiItem item)
    			{
    				return _context.USP_OperatorAritmeticki_INSERT(item.AritmetickiOperator, item.Naziv, item.NazivKr, item.Kratica);
    			}	
    									
    				
    			public void Select(string AritmetickiOperator)
    			{
    				_context.USP_OperatorAritmeticki_SELECT(AritmetickiOperator);
    			}
    
    					
    			public ObjectResult<Model.Data.OperatorAritmeticki> SelectResult(string AritmetickiOperator)
            	{
                	return _context.USP_OperatorAritmeticki_SELECT(AritmetickiOperator);
            	}			
    				
    			public void Update(Model.Data.Item.OperatorAritmetickiItem item)
    			{
    				_context.USP_OperatorAritmeticki_UPDATE(item.AritmetickiOperator, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    					
    			public ObjectResult<Model.Data.OperatorAritmeticki> UpdateResult(Model.Data.Item.OperatorAritmetickiItem item)
    			{
    				return _context.USP_OperatorAritmeticki_UPDATE(item.AritmetickiOperator, item.Naziv, item.NazivKr, item.Kratica);
    			}
    										
    		
    #endregion
    	
    }
    
}