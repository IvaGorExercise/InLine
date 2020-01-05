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
    
    public partial class DatotekaIzvodVerzija
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public DatotekaIzvodVerzija(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DatotekaIzvodVerzijaItem item)
    			{
    				_context.USP_DatotekaIzvodVerzija_DELETE(item.IDDatotekaIzvodVerzija);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DatotekaIzvodVerzijaItem item)
    			{
    				return _context.USP_DatotekaIzvodVerzija_DELETE(item.IDDatotekaIzvodVerzija);
    			}	
    									
    			public void Insert(Model.Data.Item.DatotekaIzvodVerzijaItem item)
    			{
    				_context.USP_DatotekaIzvodVerzija_INSERT(item.IDDatotekaIzvodVerzija, item.DatumOd, item.DatumDo, item.Opis, item.Napomena, item.OpisHTML, item.NapomenaHTML);
    			}
    
    			public ObjectResult<Model.Data.DatotekaIzvodVerzija> InsertResult(Model.Data.Item.DatotekaIzvodVerzijaItem item)
    			{
    				return _context.USP_DatotekaIzvodVerzija_INSERT(item.IDDatotekaIzvodVerzija, item.DatumOd, item.DatumDo, item.Opis, item.Napomena, item.OpisHTML, item.NapomenaHTML);
    			}	
    									
    				
    			public void Select(Nullable<int> IDDatotekaIzvodVerzija)
    			{
    				_context.USP_DatotekaIzvodVerzija_SELECT(IDDatotekaIzvodVerzija);
    			}
    
    					
    			public ObjectResult<Model.Data.DatotekaIzvodVerzija> SelectResult(Nullable<int> IDDatotekaIzvodVerzija)
            	{
                	return _context.USP_DatotekaIzvodVerzija_SELECT(IDDatotekaIzvodVerzija);
            	}			
    				
    			public void Update(Model.Data.Item.DatotekaIzvodVerzijaItem item)
    			{
    				_context.USP_DatotekaIzvodVerzija_UPDATE(item.IDDatotekaIzvodVerzija, item.DatumOd, item.DatumDo, item.Opis, item.Napomena, item.OpisHTML, item.NapomenaHTML);
    			}
    
    					
    			public ObjectResult<Model.Data.DatotekaIzvodVerzija> UpdateResult(Model.Data.Item.DatotekaIzvodVerzijaItem item)
    			{
    				return _context.USP_DatotekaIzvodVerzija_UPDATE(item.IDDatotekaIzvodVerzija, item.DatumOd, item.DatumDo, item.Opis, item.Napomena, item.OpisHTML, item.NapomenaHTML);
    			}
    										
    		
    #endregion
    	
    }
    
}