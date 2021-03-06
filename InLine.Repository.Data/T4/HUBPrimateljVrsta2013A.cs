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
    
    public partial class HUBPrimateljVrsta2013A
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public HUBPrimateljVrsta2013A(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.HUBPrimateljVrsta2013AItem item)
    			{
    				_context.USP_HUBPrimateljVrsta2013A_DELETE(item.IDHUBPrimateljVrsta2013A);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.HUBPrimateljVrsta2013AItem item)
    			{
    				return _context.USP_HUBPrimateljVrsta2013A_DELETE(item.IDHUBPrimateljVrsta2013A);
    			}	
    									
    			public void Insert(Model.Data.Item.HUBPrimateljVrsta2013AItem item)
    			{
    				_context.USP_HUBPrimateljVrsta2013A_INSERT(item.IDHUBPrimateljVrsta2013A, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis, item.Koristi);
    			}
    
    			public ObjectResult<Model.Data.HUBPrimateljVrsta2013A> InsertResult(Model.Data.Item.HUBPrimateljVrsta2013AItem item)
    			{
    				return _context.USP_HUBPrimateljVrsta2013A_INSERT(item.IDHUBPrimateljVrsta2013A, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis, item.Koristi);
    			}	
    									
    				
    			public void Select(Nullable<int> IDHUBPrimateljVrsta2013A)
    			{
    				_context.USP_HUBPrimateljVrsta2013A_SELECT(IDHUBPrimateljVrsta2013A);
    			}
    
    					
    			public ObjectResult<Model.Data.HUBPrimateljVrsta2013A> SelectResult(Nullable<int> IDHUBPrimateljVrsta2013A)
            	{
                	return _context.USP_HUBPrimateljVrsta2013A_SELECT(IDHUBPrimateljVrsta2013A);
            	}			
    				
    			public void Update(Model.Data.Item.HUBPrimateljVrsta2013AItem item)
    			{
    				_context.USP_HUBPrimateljVrsta2013A_UPDATE(item.IDHUBPrimateljVrsta2013A, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis, item.Koristi);
    			}
    
    					
    			public ObjectResult<Model.Data.HUBPrimateljVrsta2013A> UpdateResult(Model.Data.Item.HUBPrimateljVrsta2013AItem item)
    			{
    				return _context.USP_HUBPrimateljVrsta2013A_UPDATE(item.IDHUBPrimateljVrsta2013A, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis, item.Koristi);
    			}
    										
    		
    #endregion
    	
    }
    
}
