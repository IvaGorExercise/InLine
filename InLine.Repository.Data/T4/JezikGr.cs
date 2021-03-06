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
    
    public partial class JezikGr
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public JezikGr(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.JezikGrItem item)
    			{
    				_context.USP_JezikGr_DELETE(item.ID_JezikGr);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.JezikGrItem item)
    			{
    				return _context.USP_JezikGr_DELETE(item.ID_JezikGr);
    			}	
    									
    			public void Insert(Model.Data.Item.JezikGrItem item)
    			{
    				_context.USP_JezikGr_INSERT(item.Oznaka, item.Naziv);
    			}
    
    			public ObjectResult<Model.Data.JezikGr> InsertResult(Model.Data.Item.JezikGrItem item)
    			{
    				return _context.USP_JezikGr_INSERT(item.Oznaka, item.Naziv);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_JezikGr)
    			{
    				_context.USP_JezikGr_SELECT(ID_JezikGr);
    			}
    
    					
    			public ObjectResult<Model.Data.JezikGr> SelectResult(Nullable<long> ID_JezikGr)
            	{
                	return _context.USP_JezikGr_SELECT(ID_JezikGr);
            	}			
    				
    			public void Update(Model.Data.Item.JezikGrItem item)
    			{
    				_context.USP_JezikGr_UPDATE(item.ID_JezikGr, item.Oznaka, item.Naziv);
    			}
    
    					
    			public ObjectResult<Model.Data.JezikGr> UpdateResult(Model.Data.Item.JezikGrItem item)
    			{
    				return _context.USP_JezikGr_UPDATE(item.ID_JezikGr, item.Oznaka, item.Naziv);
    			}
    										
    		
    #endregion
    	
    }
    
}
