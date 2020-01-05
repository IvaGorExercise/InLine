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
    
    public partial class Lokacija
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public Lokacija(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.LokacijaItem item)
    			{
    				_context.USP_Lokacija_DELETE(item.ID_Lokacija);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.LokacijaItem item)
    			{
    				return _context.USP_Lokacija_DELETE(item.ID_Lokacija);
    			}	
    									
    			public void Insert(Model.Data.Item.LokacijaItem item)
    			{
    				_context.USP_Lokacija_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.ID_Mjesto, item.ID_Subjekt, item.ID_Nekretnina);
    			}
    
    			public ObjectResult<Model.Data.Lokacija> InsertResult(Model.Data.Item.LokacijaItem item)
    			{
    				return _context.USP_Lokacija_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.ID_Mjesto, item.ID_Subjekt, item.ID_Nekretnina);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_Lokacija)
    			{
    				_context.USP_Lokacija_SELECT(ID_Lokacija);
    			}
    
    					
    			public ObjectResult<Model.Data.Lokacija> SelectResult(Nullable<long> ID_Lokacija)
            	{
                	return _context.USP_Lokacija_SELECT(ID_Lokacija);
            	}			
    				
    			public void Update(Model.Data.Item.LokacijaItem item)
    			{
    				_context.USP_Lokacija_UPDATE(item.ID_Lokacija, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.ID_Mjesto, item.ID_Subjekt, item.ID_Nekretnina);
    			}
    
    					
    			public ObjectResult<Model.Data.Lokacija> UpdateResult(Model.Data.Item.LokacijaItem item)
    			{
    				return _context.USP_Lokacija_UPDATE(item.ID_Lokacija, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.ID_Mjesto, item.ID_Subjekt, item.ID_Nekretnina);
    			}
    										
    		
    #endregion
    	
    }
    
}