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
    
    public partial class ObrazacID
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ObrazacID(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ObrazacIDItem item)
    			{
    				_context.USP_ObrazacID_DELETE(item.ID_ObrazacID);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacIDItem item)
    			{
    				return _context.USP_ObrazacID_DELETE(item.ID_ObrazacID);
    			}	
    									
    			public void Insert(Model.Data.Item.ObrazacIDItem item)
    			{
    				_context.USP_ObrazacID_INSERT(item.ID_Zapis, item.ID_DohodakIsplatitelj, item.Godina, item.Mjesec, item.IDObrazacIDVerzija, item.DatotekaNaziv, item.Datoteka);
    			}
    
    			public ObjectResult<Model.Data.ObrazacID> InsertResult(Model.Data.Item.ObrazacIDItem item)
    			{
    				return _context.USP_ObrazacID_INSERT(item.ID_Zapis, item.ID_DohodakIsplatitelj, item.Godina, item.Mjesec, item.IDObrazacIDVerzija, item.DatotekaNaziv, item.Datoteka);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ObrazacID)
    			{
    				_context.USP_ObrazacID_SELECT(ID_ObrazacID);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacID> SelectResult(Nullable<long> ID_ObrazacID)
            	{
                	return _context.USP_ObrazacID_SELECT(ID_ObrazacID);
            	}			
    				
    			public void Update(Model.Data.Item.ObrazacIDItem item)
    			{
    				_context.USP_ObrazacID_UPDATE(item.ID_ObrazacID, item.ID_Zapis, item.ID_DohodakIsplatitelj, item.Godina, item.Mjesec, item.IDObrazacIDVerzija, item.DatotekaNaziv, item.Datoteka);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacID> UpdateResult(Model.Data.Item.ObrazacIDItem item)
    			{
    				return _context.USP_ObrazacID_UPDATE(item.ID_ObrazacID, item.ID_Zapis, item.ID_DohodakIsplatitelj, item.Godina, item.Mjesec, item.IDObrazacIDVerzija, item.DatotekaNaziv, item.Datoteka);
    			}
    										
    		
    #endregion
    	
    }
    
}
