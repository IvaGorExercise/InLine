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
    
    public partial class MjernaJedinica
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public MjernaJedinica(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.MjernaJedinicaItem item)
    			{
    				_context.USP_MjernaJedinica_DELETE(item.ID_MjernaJedinica);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.MjernaJedinicaItem item)
    			{
    				return _context.USP_MjernaJedinica_DELETE(item.ID_MjernaJedinica);
    			}	
    									
    			public void Insert(Model.Data.Item.MjernaJedinicaItem item)
    			{
    				_context.USP_MjernaJedinica_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    			public ObjectResult<Model.Data.MjernaJedinica> InsertResult(Model.Data.Item.MjernaJedinicaItem item)
    			{
    				return _context.USP_MjernaJedinica_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_MjernaJedinica)
    			{
    				_context.USP_MjernaJedinica_SELECT(ID_MjernaJedinica);
    			}
    
    					
    			public ObjectResult<Model.Data.MjernaJedinica> SelectResult(Nullable<long> ID_MjernaJedinica)
            	{
                	return _context.USP_MjernaJedinica_SELECT(ID_MjernaJedinica);
            	}			
    				
    			public void Update(Model.Data.Item.MjernaJedinicaItem item)
    			{
    				_context.USP_MjernaJedinica_UPDATE(item.ID_MjernaJedinica, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    					
    			public ObjectResult<Model.Data.MjernaJedinica> UpdateResult(Model.Data.Item.MjernaJedinicaItem item)
    			{
    				return _context.USP_MjernaJedinica_UPDATE(item.ID_MjernaJedinica, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    										
    		
    #endregion
    	
    }
    
}
