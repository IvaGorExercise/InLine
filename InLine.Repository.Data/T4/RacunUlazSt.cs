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
    
    public partial class RacunUlazSt
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public RacunUlazSt(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.RacunUlazStItem item)
    			{
    				_context.USP_RacunUlazSt_DELETE(item.ID_RacunUlazSt);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.RacunUlazStItem item)
    			{
    				return _context.USP_RacunUlazSt_DELETE(item.ID_RacunUlazSt);
    			}	
    									
    			public void Insert(Model.Data.Item.RacunUlazStItem item)
    			{
    				_context.USP_RacunUlazSt_INSERT(item.ID_RacunUlaz, item.RedniBroj, item.ID_Objekt, item.ID_Davanje, item.Cijena, item.Kolicina, item.IznosVrijednost, item.StopaRabat, item.IznosRabat, item.IznosOsnova, item.IznosPorez, item.IznosUkupno, item.IDValuta, item.IznosValuta);
    			}
    
    			public ObjectResult<Model.Data.RacunUlazSt> InsertResult(Model.Data.Item.RacunUlazStItem item)
    			{
    				return _context.USP_RacunUlazSt_INSERT(item.ID_RacunUlaz, item.RedniBroj, item.ID_Objekt, item.ID_Davanje, item.Cijena, item.Kolicina, item.IznosVrijednost, item.StopaRabat, item.IznosRabat, item.IznosOsnova, item.IznosPorez, item.IznosUkupno, item.IDValuta, item.IznosValuta);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_RacunUlazSt)
    			{
    				_context.USP_RacunUlazSt_SELECT(ID_RacunUlazSt);
    			}
    
    					
    			public ObjectResult<Model.Data.RacunUlazSt> SelectResult(Nullable<long> ID_RacunUlazSt)
            	{
                	return _context.USP_RacunUlazSt_SELECT(ID_RacunUlazSt);
            	}			
    				
    			public void Update(Model.Data.Item.RacunUlazStItem item)
    			{
    				_context.USP_RacunUlazSt_UPDATE(item.ID_RacunUlazSt, item.ID_RacunUlaz, item.RedniBroj, item.ID_Objekt, item.ID_Davanje, item.Cijena, item.Kolicina, item.IznosVrijednost, item.StopaRabat, item.IznosRabat, item.IznosOsnova, item.IznosPorez, item.IznosUkupno, item.IDValuta, item.IznosValuta);
    			}
    
    					
    			public ObjectResult<Model.Data.RacunUlazSt> UpdateResult(Model.Data.Item.RacunUlazStItem item)
    			{
    				return _context.USP_RacunUlazSt_UPDATE(item.ID_RacunUlazSt, item.ID_RacunUlaz, item.RedniBroj, item.ID_Objekt, item.ID_Davanje, item.Cijena, item.Kolicina, item.IznosVrijednost, item.StopaRabat, item.IznosRabat, item.IznosOsnova, item.IznosPorez, item.IznosUkupno, item.IDValuta, item.IznosValuta);
    			}
    										
    		
    #endregion
    	
    }
    
}
