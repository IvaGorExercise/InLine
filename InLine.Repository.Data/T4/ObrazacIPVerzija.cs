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
    
    public partial class ObrazacIPVerzija
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ObrazacIPVerzija(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ObrazacIPVerzijaItem item)
    			{
    				_context.USP_ObrazacIPVerzija_DELETE(item.IDObrazacIPVerzija);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacIPVerzijaItem item)
    			{
    				return _context.USP_ObrazacIPVerzija_DELETE(item.IDObrazacIPVerzija);
    			}	
    									
    			public void Insert(Model.Data.Item.ObrazacIPVerzijaItem item)
    			{
    				_context.USP_ObrazacIPVerzija_INSERT(item.IDObrazacIPVerzija, item.DatumOd, item.DatumDo, item.Opis, item.Napomena, item.OpisHTML, item.NapomenaHTML);
    			}
    
    			public ObjectResult<Model.Data.ObrazacIPVerzija> InsertResult(Model.Data.Item.ObrazacIPVerzijaItem item)
    			{
    				return _context.USP_ObrazacIPVerzija_INSERT(item.IDObrazacIPVerzija, item.DatumOd, item.DatumDo, item.Opis, item.Napomena, item.OpisHTML, item.NapomenaHTML);
    			}	
    									
    				
    			public void Select(Nullable<int> IDObrazacIPVerzija)
    			{
    				_context.USP_ObrazacIPVerzija_SELECT(IDObrazacIPVerzija);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacIPVerzija> SelectResult(Nullable<int> IDObrazacIPVerzija)
            	{
                	return _context.USP_ObrazacIPVerzija_SELECT(IDObrazacIPVerzija);
            	}			
    				
    			public void Update(Model.Data.Item.ObrazacIPVerzijaItem item)
    			{
    				_context.USP_ObrazacIPVerzija_UPDATE(item.IDObrazacIPVerzija, item.DatumOd, item.DatumDo, item.Opis, item.Napomena, item.OpisHTML, item.NapomenaHTML);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacIPVerzija> UpdateResult(Model.Data.Item.ObrazacIPVerzijaItem item)
    			{
    				return _context.USP_ObrazacIPVerzija_UPDATE(item.IDObrazacIPVerzija, item.DatumOd, item.DatumDo, item.Opis, item.Napomena, item.OpisHTML, item.NapomenaHTML);
    			}
    										
    		
    #endregion
    	
    }
    
}