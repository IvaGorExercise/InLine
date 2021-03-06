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
    
    public partial class HUBVerzija
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public HUBVerzija(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.HUBVerzijaItem item)
    			{
    				_context.USP_HUBVerzija_DELETE(item.IDHUBVerzija);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.HUBVerzijaItem item)
    			{
    				return _context.USP_HUBVerzija_DELETE(item.IDHUBVerzija);
    			}	
    									
    			public void Insert(Model.Data.Item.HUBVerzijaItem item)
    			{
    				_context.USP_HUBVerzija_INSERT(item.IDHUBVerzija, item.DatumOd, item.DatumDo, item.Opis, item.Napomena, item.OpisHTML, item.NapomenaHTML);
    			}
    
    			public ObjectResult<Model.Data.HUBVerzija> InsertResult(Model.Data.Item.HUBVerzijaItem item)
    			{
    				return _context.USP_HUBVerzija_INSERT(item.IDHUBVerzija, item.DatumOd, item.DatumDo, item.Opis, item.Napomena, item.OpisHTML, item.NapomenaHTML);
    			}	
    									
    				
    			public void Select(Nullable<int> IDHUBVerzija)
    			{
    				_context.USP_HUBVerzija_SELECT(IDHUBVerzija);
    			}
    
    					
    			public ObjectResult<Model.Data.HUBVerzija> SelectResult(Nullable<int> IDHUBVerzija)
            	{
                	return _context.USP_HUBVerzija_SELECT(IDHUBVerzija);
            	}			
    				
    			public void Update(Model.Data.Item.HUBVerzijaItem item)
    			{
    				_context.USP_HUBVerzija_UPDATE(item.IDHUBVerzija, item.DatumOd, item.DatumDo, item.Opis, item.Napomena, item.OpisHTML, item.NapomenaHTML);
    			}
    
    					
    			public ObjectResult<Model.Data.HUBVerzija> UpdateResult(Model.Data.Item.HUBVerzijaItem item)
    			{
    				return _context.USP_HUBVerzija_UPDATE(item.IDHUBVerzija, item.DatumOd, item.DatumDo, item.Opis, item.Napomena, item.OpisHTML, item.NapomenaHTML);
    			}
    										
    		
    #endregion
    	
    }
    
}
