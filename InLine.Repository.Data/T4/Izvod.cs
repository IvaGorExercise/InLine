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
    
    public partial class Izvod
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public Izvod(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.IzvodItem item)
    			{
    				_context.USP_Izvod_DELETE(item.ID_Izvod);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.IzvodItem item)
    			{
    				return _context.USP_Izvod_DELETE(item.ID_Izvod);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_Izvod)
    			{
    				_context.USP_Izvod_SELECT(ID_Izvod);
    			}
    
    					
    			public ObjectResult<Model.Data.Izvod> SelectResult(Nullable<long> ID_Izvod)
            	{
                	return _context.USP_Izvod_SELECT(ID_Izvod);
            	}			
    			public void Insert(Model.Data.Item.IzvodItem item)
    			{
    				_context.USP_Izvod_INSERT(item.ID_Zapis, item.IDIzvodVerzija, item.IznosDuguje, item.IznosPotrazuje, item.SaldoStaro, item.SaldoNovo, item.ID_SubjektRacun);
    			}
    
    			public ObjectResult<Model.Data.Izvod> InsertResult(Model.Data.Item.IzvodItem item)
    			{
    				return _context.USP_Izvod_INSERT(item.ID_Zapis, item.IDIzvodVerzija, item.IznosDuguje, item.IznosPotrazuje, item.SaldoStaro, item.SaldoNovo, item.ID_SubjektRacun);
    			}	
    									
    				
    			public void Update(Model.Data.Item.IzvodItem item)
    			{
    				_context.USP_Izvod_UPDATE(item.ID_Izvod, item.ID_Zapis, item.IDIzvodVerzija, item.IznosDuguje, item.IznosPotrazuje, item.SaldoStaro, item.SaldoNovo, item.ID_SubjektRacun);
    			}
    
    					
    			public ObjectResult<Model.Data.Izvod> UpdateResult(Model.Data.Item.IzvodItem item)
    			{
    				return _context.USP_Izvod_UPDATE(item.ID_Izvod, item.ID_Zapis, item.IDIzvodVerzija, item.IznosDuguje, item.IznosPotrazuje, item.SaldoStaro, item.SaldoNovo, item.ID_SubjektRacun);
    			}
    										
    		
    #endregion
    	
    }
    
}
