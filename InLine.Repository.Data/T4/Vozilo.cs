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
    
    public partial class Vozilo
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public Vozilo(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.VoziloItem item)
    			{
    				_context.USP_Vozilo_DELETE(item.ID_Vozilo);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.VoziloItem item)
    			{
    				return _context.USP_Vozilo_DELETE(item.ID_Vozilo);
    			}	
    									
    			public void Insert(Model.Data.Item.VoziloItem item)
    			{
    				_context.USP_Vozilo_INSERT(item.ID_Objekt, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Registracija);
    			}
    
    			public ObjectResult<Model.Data.Vozilo> InsertResult(Model.Data.Item.VoziloItem item)
    			{
    				return _context.USP_Vozilo_INSERT(item.ID_Objekt, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Registracija);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_Vozilo)
    			{
    				_context.USP_Vozilo_SELECT(ID_Vozilo);
    			}
    
    					
    			public ObjectResult<Model.Data.Vozilo> SelectResult(Nullable<long> ID_Vozilo)
            	{
                	return _context.USP_Vozilo_SELECT(ID_Vozilo);
            	}			
    				
    			public void Update(Model.Data.Item.VoziloItem item)
    			{
    				_context.USP_Vozilo_UPDATE(item.ID_Vozilo, item.ID_Objekt, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Registracija);
    			}
    
    					
    			public ObjectResult<Model.Data.Vozilo> UpdateResult(Model.Data.Item.VoziloItem item)
    			{
    				return _context.USP_Vozilo_UPDATE(item.ID_Vozilo, item.ID_Objekt, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Registracija);
    			}
    										
    		
    #endregion
    	
    }
    
}