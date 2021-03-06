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
    
    public partial class StrucnaSprema
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public StrucnaSprema(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.StrucnaSpremaItem item)
    			{
    				_context.USP_StrucnaSprema_DELETE(item.ID_StrucnaSprema);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.StrucnaSpremaItem item)
    			{
    				return _context.USP_StrucnaSprema_DELETE(item.ID_StrucnaSprema);
    			}	
    									
    			public void Insert(Model.Data.Item.StrucnaSpremaItem item)
    			{
    				_context.USP_StrucnaSprema_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    			public ObjectResult<Model.Data.StrucnaSprema> InsertResult(Model.Data.Item.StrucnaSpremaItem item)
    			{
    				return _context.USP_StrucnaSprema_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_StrucnaSprema)
    			{
    				_context.USP_StrucnaSprema_SELECT(ID_StrucnaSprema);
    			}
    
    					
    			public ObjectResult<Model.Data.StrucnaSprema> SelectResult(Nullable<long> ID_StrucnaSprema)
            	{
                	return _context.USP_StrucnaSprema_SELECT(ID_StrucnaSprema);
            	}			
    				
    			public void Update(Model.Data.Item.StrucnaSpremaItem item)
    			{
    				_context.USP_StrucnaSprema_UPDATE(item.ID_StrucnaSprema, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    
    					
    			public ObjectResult<Model.Data.StrucnaSprema> UpdateResult(Model.Data.Item.StrucnaSpremaItem item)
    			{
    				return _context.USP_StrucnaSprema_UPDATE(item.ID_StrucnaSprema, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica);
    			}
    										
    		
    #endregion
    	
    }
    
}
