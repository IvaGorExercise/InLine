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
    
    public partial class DatotekaVrPolje
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public DatotekaVrPolje(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DatotekaVrPoljeItem item)
    			{
    				_context.USP_DatotekaVrPolje_DELETE(item.ID_DatotekaVrPolje);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DatotekaVrPoljeItem item)
    			{
    				return _context.USP_DatotekaVrPolje_DELETE(item.ID_DatotekaVrPolje);
    			}	
    									
    			public void Insert(Model.Data.Item.DatotekaVrPoljeItem item)
    			{
    				_context.USP_DatotekaVrPolje_INSERT(item.ID_DatotekaVrVerzija, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.ID_DatotekaVrPoljeTip, item.Duljina, item.Pozicija);
    			}
    
    			public ObjectResult<Model.Data.DatotekaVrPolje> InsertResult(Model.Data.Item.DatotekaVrPoljeItem item)
    			{
    				return _context.USP_DatotekaVrPolje_INSERT(item.ID_DatotekaVrVerzija, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.ID_DatotekaVrPoljeTip, item.Duljina, item.Pozicija);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_DatotekaVrPolje)
    			{
    				_context.USP_DatotekaVrPolje_SELECT(ID_DatotekaVrPolje);
    			}
    
    					
    			public ObjectResult<Model.Data.DatotekaVrPolje> SelectResult(Nullable<long> ID_DatotekaVrPolje)
            	{
                	return _context.USP_DatotekaVrPolje_SELECT(ID_DatotekaVrPolje);
            	}			
    				
    			public void Update(Model.Data.Item.DatotekaVrPoljeItem item)
    			{
    				_context.USP_DatotekaVrPolje_UPDATE(item.ID_DatotekaVrPolje, item.ID_DatotekaVrVerzija, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.ID_DatotekaVrPoljeTip, item.Duljina, item.Pozicija);
    			}
    
    					
    			public ObjectResult<Model.Data.DatotekaVrPolje> UpdateResult(Model.Data.Item.DatotekaVrPoljeItem item)
    			{
    				return _context.USP_DatotekaVrPolje_UPDATE(item.ID_DatotekaVrPolje, item.ID_DatotekaVrVerzija, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.ID_DatotekaVrPoljeTip, item.Duljina, item.Pozicija);
    			}
    										
    		
    #endregion
    	
    }
    
}