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
    
    public partial class OpcinaGr
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public OpcinaGr(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.OpcinaGrItem item)
    			{
    				_context.USP_OpcinaGr_DELETE(item.ID_OpcinaGr);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.OpcinaGrItem item)
    			{
    				return _context.USP_OpcinaGr_DELETE(item.ID_OpcinaGr);
    			}	
    									
    			public void Insert(Model.Data.Item.OpcinaGrItem item)
    			{
    				_context.USP_OpcinaGr_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis, item.ID_OpcinaGrTip);
    			}
    
    			public ObjectResult<Model.Data.OpcinaGr> InsertResult(Model.Data.Item.OpcinaGrItem item)
    			{
    				return _context.USP_OpcinaGr_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis, item.ID_OpcinaGrTip);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_OpcinaGr)
    			{
    				_context.USP_OpcinaGr_SELECT(ID_OpcinaGr);
    			}
    
    					
    			public ObjectResult<Model.Data.OpcinaGr> SelectResult(Nullable<long> ID_OpcinaGr)
            	{
                	return _context.USP_OpcinaGr_SELECT(ID_OpcinaGr);
            	}			
    				
    			public void Update(Model.Data.Item.OpcinaGrItem item)
    			{
    				_context.USP_OpcinaGr_UPDATE(item.ID_OpcinaGr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis, item.ID_OpcinaGrTip);
    			}
    
    					
    			public ObjectResult<Model.Data.OpcinaGr> UpdateResult(Model.Data.Item.OpcinaGrItem item)
    			{
    				return _context.USP_OpcinaGr_UPDATE(item.ID_OpcinaGr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis, item.ID_OpcinaGrTip);
    			}
    										
    		
    #endregion
    	
    }
    
}
