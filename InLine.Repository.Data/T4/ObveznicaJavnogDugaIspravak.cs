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
    
    public partial class ObveznicaJavnogDugaIspravak
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ObveznicaJavnogDugaIspravak(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ObveznicaJavnogDugaIspravakItem item)
    			{
    				_context.USP_ObveznicaJavnogDugaIspravak_DELETE(item.ID_ObveznicaJavnogDugaIspravak);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ObveznicaJavnogDugaIspravakItem item)
    			{
    				return _context.USP_ObveznicaJavnogDugaIspravak_DELETE(item.ID_ObveznicaJavnogDugaIspravak);
    			}	
    									
    			public void Insert(Model.Data.Item.ObveznicaJavnogDugaIspravakItem item)
    			{
    				_context.USP_ObveznicaJavnogDugaIspravak_INSERT(item.GodinaIzvod, item.RacunIzvod, item.RacunVrIzvod, item.BrojIzvod, item.BrojIzvodSt, item.IDValuta, item.ID_ObveznicaJavnogDuga, item.RedniBroj, item.Aktivno, item.Iznos, item.IznosValuta);
    			}
    
    			public ObjectResult<Model.Data.ObveznicaJavnogDugaIspravak> InsertResult(Model.Data.Item.ObveznicaJavnogDugaIspravakItem item)
    			{
    				return _context.USP_ObveznicaJavnogDugaIspravak_INSERT(item.GodinaIzvod, item.RacunIzvod, item.RacunVrIzvod, item.BrojIzvod, item.BrojIzvodSt, item.IDValuta, item.ID_ObveznicaJavnogDuga, item.RedniBroj, item.Aktivno, item.Iznos, item.IznosValuta);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ObveznicaJavnogDugaIspravak)
    			{
    				_context.USP_ObveznicaJavnogDugaIspravak_SELECT(ID_ObveznicaJavnogDugaIspravak);
    			}
    
    					
    			public ObjectResult<Model.Data.ObveznicaJavnogDugaIspravak> SelectResult(Nullable<long> ID_ObveznicaJavnogDugaIspravak)
            	{
                	return _context.USP_ObveznicaJavnogDugaIspravak_SELECT(ID_ObveznicaJavnogDugaIspravak);
            	}			
    				
    			public void Update(Model.Data.Item.ObveznicaJavnogDugaIspravakItem item)
    			{
    				_context.USP_ObveznicaJavnogDugaIspravak_UPDATE(item.ID_ObveznicaJavnogDugaIspravak, item.GodinaIzvod, item.RacunIzvod, item.RacunVrIzvod, item.BrojIzvod, item.BrojIzvodSt, item.IDValuta, item.ID_ObveznicaJavnogDuga, item.RedniBroj, item.Aktivno, item.Iznos, item.IznosValuta);
    			}
    
    					
    			public ObjectResult<Model.Data.ObveznicaJavnogDugaIspravak> UpdateResult(Model.Data.Item.ObveznicaJavnogDugaIspravakItem item)
    			{
    				return _context.USP_ObveznicaJavnogDugaIspravak_UPDATE(item.ID_ObveznicaJavnogDugaIspravak, item.GodinaIzvod, item.RacunIzvod, item.RacunVrIzvod, item.BrojIzvod, item.BrojIzvodSt, item.IDValuta, item.ID_ObveznicaJavnogDuga, item.RedniBroj, item.Aktivno, item.Iznos, item.IznosValuta);
    			}
    										
    		
    #endregion
    	
    }
    
}
