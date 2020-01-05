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
    
    public partial class IzvodVerzija
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public IzvodVerzija(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.IzvodVerzijaItem item)
    			{
    				_context.USP_IzvodVerzija_DELETE(item.IDIzvodVerzija);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.IzvodVerzijaItem item)
    			{
    				return _context.USP_IzvodVerzija_DELETE(item.IDIzvodVerzija);
    			}	
    									
    			public void Insert(Model.Data.Item.IzvodVerzijaItem item)
    			{
    				_context.USP_IzvodVerzija_INSERT(item.IDIzvodVerzija, item.DatumOd, item.DatumDo, item.Opis, item.Napomena, item.OpisHTML, item.NapomenaHTML);
    			}
    
    			public ObjectResult<Model.Data.IzvodVerzija> InsertResult(Model.Data.Item.IzvodVerzijaItem item)
    			{
    				return _context.USP_IzvodVerzija_INSERT(item.IDIzvodVerzija, item.DatumOd, item.DatumDo, item.Opis, item.Napomena, item.OpisHTML, item.NapomenaHTML);
    			}	
    									
    				
    			public void Select(Nullable<int> IDIzvodVerzija)
    			{
    				_context.USP_IzvodVerzija_SELECT(IDIzvodVerzija);
    			}
    
    					
    			public ObjectResult<Model.Data.IzvodVerzija> SelectResult(Nullable<int> IDIzvodVerzija)
            	{
                	return _context.USP_IzvodVerzija_SELECT(IDIzvodVerzija);
            	}			
    				
    			public void Update(Model.Data.Item.IzvodVerzijaItem item)
    			{
    				_context.USP_IzvodVerzija_UPDATE(item.IDIzvodVerzija, item.DatumOd, item.DatumDo, item.Opis, item.Napomena, item.OpisHTML, item.NapomenaHTML);
    			}
    
    					
    			public ObjectResult<Model.Data.IzvodVerzija> UpdateResult(Model.Data.Item.IzvodVerzijaItem item)
    			{
    				return _context.USP_IzvodVerzija_UPDATE(item.IDIzvodVerzija, item.DatumOd, item.DatumDo, item.Opis, item.Napomena, item.OpisHTML, item.NapomenaHTML);
    			}
    										
    		
    #endregion
    	
    }
    
}