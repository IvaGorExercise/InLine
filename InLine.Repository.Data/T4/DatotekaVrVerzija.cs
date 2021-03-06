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
    
    public partial class DatotekaVrVerzija
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public DatotekaVrVerzija(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DatotekaVrVerzijaItem item)
    			{
    				_context.USP_DatotekaVrVerzija_DELETE(item.ID_DatotekaVrVerzija);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DatotekaVrVerzijaItem item)
    			{
    				return _context.USP_DatotekaVrVerzija_DELETE(item.ID_DatotekaVrVerzija);
    			}	
    									
    			public void Insert(Model.Data.Item.DatotekaVrVerzijaItem item)
    			{
    				_context.USP_DatotekaVrVerzija_INSERT(item.ID_DatotekaVr, item.DatumOd, item.DatumDo);
    			}
    
    			public ObjectResult<Model.Data.DatotekaVrVerzija> InsertResult(Model.Data.Item.DatotekaVrVerzijaItem item)
    			{
    				return _context.USP_DatotekaVrVerzija_INSERT(item.ID_DatotekaVr, item.DatumOd, item.DatumDo);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_DatotekaVrVerzija)
    			{
    				_context.USP_DatotekaVrVerzija_SELECT(ID_DatotekaVrVerzija);
    			}
    
    					
    			public ObjectResult<Model.Data.DatotekaVrVerzija> SelectResult(Nullable<long> ID_DatotekaVrVerzija)
            	{
                	return _context.USP_DatotekaVrVerzija_SELECT(ID_DatotekaVrVerzija);
            	}			
    				
    			public void Update(Model.Data.Item.DatotekaVrVerzijaItem item)
    			{
    				_context.USP_DatotekaVrVerzija_UPDATE(item.ID_DatotekaVrVerzija, item.ID_DatotekaVr, item.DatumOd, item.DatumDo);
    			}
    
    					
    			public ObjectResult<Model.Data.DatotekaVrVerzija> UpdateResult(Model.Data.Item.DatotekaVrVerzijaItem item)
    			{
    				return _context.USP_DatotekaVrVerzija_UPDATE(item.ID_DatotekaVrVerzija, item.ID_DatotekaVr, item.DatumOd, item.DatumDo);
    			}
    										
    		
    #endregion
    	
    }
    
}
