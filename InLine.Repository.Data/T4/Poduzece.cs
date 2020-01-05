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
    
    public partial class Poduzece
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public Poduzece(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.PoduzeceItem item)
    			{
    				_context.USP_Poduzece_DELETE(item.ID_Poduzece);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.PoduzeceItem item)
    			{
    				return _context.USP_Poduzece_DELETE(item.ID_Poduzece);
    			}	
    									
    			public void Insert(Model.Data.Item.PoduzeceItem item)
    			{
    				_context.USP_Poduzece_INSERT(item.ID_Subjekt, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.IDDrzava, item.OIB);
    			}
    
    			public ObjectResult<Model.Data.Poduzece> InsertResult(Model.Data.Item.PoduzeceItem item)
    			{
    				return _context.USP_Poduzece_INSERT(item.ID_Subjekt, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.IDDrzava, item.OIB);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_Poduzece)
    			{
    				_context.USP_Poduzece_SELECT(ID_Poduzece);
    			}
    
    					
    			public ObjectResult<Model.Data.Poduzece> SelectResult(Nullable<long> ID_Poduzece)
            	{
                	return _context.USP_Poduzece_SELECT(ID_Poduzece);
            	}			
    				
    			public void Update(Model.Data.Item.PoduzeceItem item)
    			{
    				_context.USP_Poduzece_UPDATE(item.ID_Poduzece, item.ID_Subjekt, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.IDDrzava, item.OIB);
    			}
    
    					
    			public ObjectResult<Model.Data.Poduzece> UpdateResult(Model.Data.Item.PoduzeceItem item)
    			{
    				return _context.USP_Poduzece_UPDATE(item.ID_Poduzece, item.ID_Subjekt, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.IDDrzava, item.OIB);
    			}
    										
    		
    #endregion
    	
    }
    
}