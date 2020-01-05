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
    
    public partial class OperatorVremenski
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public OperatorVremenski(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.OperatorVremenskiItem item)
    			{
    				_context.USP_OperatorVremenski_DELETE(item.VremenskiOperator);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.OperatorVremenskiItem item)
    			{
    				return _context.USP_OperatorVremenski_DELETE(item.VremenskiOperator);
    			}	
    									
    			public void Insert(Model.Data.Item.OperatorVremenskiItem item)
    			{
    				_context.USP_OperatorVremenski_INSERT(item.VremenskiOperator, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    			public ObjectResult<Model.Data.OperatorVremenski> InsertResult(Model.Data.Item.OperatorVremenskiItem item)
    			{
    				return _context.USP_OperatorVremenski_INSERT(item.VremenskiOperator, item.Naziv, item.NazivKr, item.Kratica);
    			}	
    									
    				
    			public void Select(string VremenskiOperator)
    			{
    				_context.USP_OperatorVremenski_SELECT(VremenskiOperator);
    			}
    
    					
    			public ObjectResult<Model.Data.OperatorVremenski> SelectResult(string VremenskiOperator)
            	{
                	return _context.USP_OperatorVremenski_SELECT(VremenskiOperator);
            	}			
    				
    			public void Update(Model.Data.Item.OperatorVremenskiItem item)
    			{
    				_context.USP_OperatorVremenski_UPDATE(item.VremenskiOperator, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    					
    			public ObjectResult<Model.Data.OperatorVremenski> UpdateResult(Model.Data.Item.OperatorVremenskiItem item)
    			{
    				return _context.USP_OperatorVremenski_UPDATE(item.VremenskiOperator, item.Naziv, item.NazivKr, item.Kratica);
    			}
    										
    		
    #endregion
    	
    }
    
}