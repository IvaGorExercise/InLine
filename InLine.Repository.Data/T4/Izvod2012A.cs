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
    
    public partial class Izvod2012A
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public Izvod2012A(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.Izvod2012AItem item)
    			{
    				_context.USP_Izvod2012A_DELETE(item.ID_Izvod2012A);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.Izvod2012AItem item)
    			{
    				return _context.USP_Izvod2012A_DELETE(item.ID_Izvod2012A);
    			}	
    									
    			public void Insert(Model.Data.Item.Izvod2012AItem item)
    			{
    				_context.USP_Izvod2012A_INSERT(item.ID_Izvod, item.BankaVBDI, item.BankaNaziv, item.BankaOIB, item.IzvadakVr, item.DatumObrada, item.BankaBIC, item.Racun, item.IDValuta, item.Naziv, item.Sjediste, item.MaticniBroj, item.OIB, item.RedniBrojIzvadak, item.PodbrojIzvadak, item.DatumIzvadak, item.RedniBrojGrupa, item.VrstaIzvadak);
    			}
    
    			public ObjectResult<Model.Data.Izvod2012A> InsertResult(Model.Data.Item.Izvod2012AItem item)
    			{
    				return _context.USP_Izvod2012A_INSERT(item.ID_Izvod, item.BankaVBDI, item.BankaNaziv, item.BankaOIB, item.IzvadakVr, item.DatumObrada, item.BankaBIC, item.Racun, item.IDValuta, item.Naziv, item.Sjediste, item.MaticniBroj, item.OIB, item.RedniBrojIzvadak, item.PodbrojIzvadak, item.DatumIzvadak, item.RedniBrojGrupa, item.VrstaIzvadak);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_Izvod2012A)
    			{
    				_context.USP_Izvod2012A_SELECT(ID_Izvod2012A);
    			}
    
    					
    			public ObjectResult<Model.Data.Izvod2012A> SelectResult(Nullable<long> ID_Izvod2012A)
            	{
                	return _context.USP_Izvod2012A_SELECT(ID_Izvod2012A);
            	}			
    				
    			public void Update(Model.Data.Item.Izvod2012AItem item)
    			{
    				_context.USP_Izvod2012A_UPDATE(item.ID_Izvod2012A, item.ID_Izvod, item.BankaVBDI, item.BankaNaziv, item.BankaOIB, item.IzvadakVr, item.DatumObrada, item.BankaBIC, item.Racun, item.IDValuta, item.Naziv, item.Sjediste, item.MaticniBroj, item.OIB, item.RedniBrojIzvadak, item.PodbrojIzvadak, item.DatumIzvadak, item.RedniBrojGrupa, item.VrstaIzvadak);
    			}
    
    					
    			public ObjectResult<Model.Data.Izvod2012A> UpdateResult(Model.Data.Item.Izvod2012AItem item)
    			{
    				return _context.USP_Izvod2012A_UPDATE(item.ID_Izvod2012A, item.ID_Izvod, item.BankaVBDI, item.BankaNaziv, item.BankaOIB, item.IzvadakVr, item.DatumObrada, item.BankaBIC, item.Racun, item.IDValuta, item.Naziv, item.Sjediste, item.MaticniBroj, item.OIB, item.RedniBrojIzvadak, item.PodbrojIzvadak, item.DatumIzvadak, item.RedniBrojGrupa, item.VrstaIzvadak);
    			}
    										
    		
    #endregion
    	
    }
    
}
