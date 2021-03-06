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
    
    public partial class PrimitakProsjekGr
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public PrimitakProsjekGr(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.PrimitakProsjekGrItem item)
    			{
    				_context.USP_PrimitakProsjekGr_DELETE(item.ID_PrimitakProsjekGr);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.PrimitakProsjekGrItem item)
    			{
    				return _context.USP_PrimitakProsjekGr_DELETE(item.ID_PrimitakProsjekGr);
    			}	
    									
    			public void Insert(Model.Data.Item.PrimitakProsjekGrItem item)
    			{
    				_context.USP_PrimitakProsjekGr_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    			public ObjectResult<Model.Data.PrimitakProsjekGr> InsertResult(Model.Data.Item.PrimitakProsjekGrItem item)
    			{
    				return _context.USP_PrimitakProsjekGr_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_PrimitakProsjekGr)
    			{
    				_context.USP_PrimitakProsjekGr_SELECT(ID_PrimitakProsjekGr);
    			}
    
    					
    			public ObjectResult<Model.Data.PrimitakProsjekGr> SelectResult(Nullable<long> ID_PrimitakProsjekGr)
            	{
                	return _context.USP_PrimitakProsjekGr_SELECT(ID_PrimitakProsjekGr);
            	}			
    				
    			public void Update(Model.Data.Item.PrimitakProsjekGrItem item)
    			{
    				_context.USP_PrimitakProsjekGr_UPDATE(item.ID_PrimitakProsjekGr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    					
    			public ObjectResult<Model.Data.PrimitakProsjekGr> UpdateResult(Model.Data.Item.PrimitakProsjekGrItem item)
    			{
    				return _context.USP_PrimitakProsjekGr_UPDATE(item.ID_PrimitakProsjekGr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    										
    		
    #endregion
    	
    }
    
}
