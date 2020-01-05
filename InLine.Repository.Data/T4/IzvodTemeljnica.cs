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
    
    public partial class IzvodTemeljnica
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public IzvodTemeljnica(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.IzvodTemeljnicaItem item)
    			{
    				_context.USP_IzvodTemeljnica_DELETE(item.ID_IzvodTemeljnica);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.IzvodTemeljnicaItem item)
    			{
    				return _context.USP_IzvodTemeljnica_DELETE(item.ID_IzvodTemeljnica);
    			}	
    									
    			public void Insert(Model.Data.Item.IzvodTemeljnicaItem item)
    			{
    				_context.USP_IzvodTemeljnica_INSERT(item.ID_Izvod, item.IznosDuguje, item.IznosPotrazuje, item.SaldoStaro, item.SaldoNovo, item.TemeljnicaStatus, item.TemeljnicaGodina, item.TemeljnicaVrsta, item.TemeljnicaBroj, item.ID_Temeljnica);
    			}
    
    			public ObjectResult<Model.Data.IzvodTemeljnica> InsertResult(Model.Data.Item.IzvodTemeljnicaItem item)
    			{
    				return _context.USP_IzvodTemeljnica_INSERT(item.ID_Izvod, item.IznosDuguje, item.IznosPotrazuje, item.SaldoStaro, item.SaldoNovo, item.TemeljnicaStatus, item.TemeljnicaGodina, item.TemeljnicaVrsta, item.TemeljnicaBroj, item.ID_Temeljnica);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_IzvodTemeljnica)
    			{
    				_context.USP_IzvodTemeljnica_SELECT(ID_IzvodTemeljnica);
    			}
    
    					
    			public ObjectResult<Model.Data.IzvodTemeljnica> SelectResult(Nullable<long> ID_IzvodTemeljnica)
            	{
                	return _context.USP_IzvodTemeljnica_SELECT(ID_IzvodTemeljnica);
            	}			
    				
    			public void Update(Model.Data.Item.IzvodTemeljnicaItem item)
    			{
    				_context.USP_IzvodTemeljnica_UPDATE(item.ID_IzvodTemeljnica, item.ID_Izvod, item.IznosDuguje, item.IznosPotrazuje, item.SaldoStaro, item.SaldoNovo, item.TemeljnicaStatus, item.TemeljnicaGodina, item.TemeljnicaVrsta, item.TemeljnicaBroj, item.ID_Temeljnica);
    			}
    
    					
    			public ObjectResult<Model.Data.IzvodTemeljnica> UpdateResult(Model.Data.Item.IzvodTemeljnicaItem item)
    			{
    				return _context.USP_IzvodTemeljnica_UPDATE(item.ID_IzvodTemeljnica, item.ID_Izvod, item.IznosDuguje, item.IznosPotrazuje, item.SaldoStaro, item.SaldoNovo, item.TemeljnicaStatus, item.TemeljnicaGodina, item.TemeljnicaVrsta, item.TemeljnicaBroj, item.ID_Temeljnica);
    			}
    										
    		
    #endregion
    	
    }
    
}