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
    
    public partial class ObrazacIDIdentifikator2009A
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ObrazacIDIdentifikator2009A(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ObrazacIDIdentifikator2009AItem item)
    			{
    				_context.USP_ObrazacIDIdentifikator2009A_DELETE(item.IDObrazacIDIdentifikator2009A);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacIDIdentifikator2009AItem item)
    			{
    				return _context.USP_ObrazacIDIdentifikator2009A_DELETE(item.IDObrazacIDIdentifikator2009A);
    			}	
    									
    			public void Insert(Model.Data.Item.ObrazacIDIdentifikator2009AItem item)
    			{
    				_context.USP_ObrazacIDIdentifikator2009A_INSERT(item.IDObrazacIDIdentifikator2009A, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    			public ObjectResult<Model.Data.ObrazacIDIdentifikator2009A> InsertResult(Model.Data.Item.ObrazacIDIdentifikator2009AItem item)
    			{
    				return _context.USP_ObrazacIDIdentifikator2009A_INSERT(item.IDObrazacIDIdentifikator2009A, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}	
    									
    				
    			public void Select(Nullable<int> IDObrazacIDIdentifikator2009A)
    			{
    				_context.USP_ObrazacIDIdentifikator2009A_SELECT(IDObrazacIDIdentifikator2009A);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacIDIdentifikator2009A> SelectResult(Nullable<int> IDObrazacIDIdentifikator2009A)
            	{
                	return _context.USP_ObrazacIDIdentifikator2009A_SELECT(IDObrazacIDIdentifikator2009A);
            	}			
    				
    			public void Update(Model.Data.Item.ObrazacIDIdentifikator2009AItem item)
    			{
    				_context.USP_ObrazacIDIdentifikator2009A_UPDATE(item.IDObrazacIDIdentifikator2009A, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacIDIdentifikator2009A> UpdateResult(Model.Data.Item.ObrazacIDIdentifikator2009AItem item)
    			{
    				return _context.USP_ObrazacIDIdentifikator2009A_UPDATE(item.IDObrazacIDIdentifikator2009A, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    										
    		
    #endregion
    	
    }
    
}