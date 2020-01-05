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
    
    public partial class DavanjeTablica
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public DavanjeTablica(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DavanjeTablicaItem item)
    			{
    				_context.USP_DavanjeTablica_DELETE(item.IDDavanjeTablica);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DavanjeTablicaItem item)
    			{
    				return _context.USP_DavanjeTablica_DELETE(item.IDDavanjeTablica);
    			}	
    									
    			public void Insert(Model.Data.Item.DavanjeTablicaItem item)
    			{
    				_context.USP_DavanjeTablica_INSERT(item.IDDavanjeTablica, item.TablicaShema, item.TablicaNaziv);
    			}
    
    			public ObjectResult<Model.Data.DavanjeTablica> InsertResult(Model.Data.Item.DavanjeTablicaItem item)
    			{
    				return _context.USP_DavanjeTablica_INSERT(item.IDDavanjeTablica, item.TablicaShema, item.TablicaNaziv);
    			}	
    									
    				
    			public void Select(Nullable<int> IDDavanjeTablica)
    			{
    				_context.USP_DavanjeTablica_SELECT(IDDavanjeTablica);
    			}
    
    					
    			public ObjectResult<Model.Data.DavanjeTablica> SelectResult(Nullable<int> IDDavanjeTablica)
            	{
                	return _context.USP_DavanjeTablica_SELECT(IDDavanjeTablica);
            	}			
    				
    			public void Update(Model.Data.Item.DavanjeTablicaItem item)
    			{
    				_context.USP_DavanjeTablica_UPDATE(item.IDDavanjeTablica, item.TablicaShema, item.TablicaNaziv);
    			}
    
    					
    			public ObjectResult<Model.Data.DavanjeTablica> UpdateResult(Model.Data.Item.DavanjeTablicaItem item)
    			{
    				return _context.USP_DavanjeTablica_UPDATE(item.IDDavanjeTablica, item.TablicaShema, item.TablicaNaziv);
    			}
    										
    		
    #endregion
    	
    }
    
}
