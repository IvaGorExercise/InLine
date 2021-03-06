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
    
    public partial class ShemaStPolje
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ShemaStPolje(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ShemaStPoljeItem item)
    			{
    				_context.USP_ShemaStPolje_DELETE(item.ID_ShemaStPolje);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ShemaStPoljeItem item)
    			{
    				return _context.USP_ShemaStPolje_DELETE(item.ID_ShemaStPolje);
    			}	
    									
    			public void Insert(Model.Data.Item.ShemaStPoljeItem item)
    			{
    				_context.USP_ShemaStPolje_INSERT(item.ID_ShemaSt, item.TablicaShema, item.TablicaNaziv, item.TablicaPoljeNaziv, item.AritmetickiOperator, item.Operand, item.Negativno);
    			}
    
    			public ObjectResult<Model.Data.ShemaStPolje> InsertResult(Model.Data.Item.ShemaStPoljeItem item)
    			{
    				return _context.USP_ShemaStPolje_INSERT(item.ID_ShemaSt, item.TablicaShema, item.TablicaNaziv, item.TablicaPoljeNaziv, item.AritmetickiOperator, item.Operand, item.Negativno);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ShemaStPolje)
    			{
    				_context.USP_ShemaStPolje_SELECT(ID_ShemaStPolje);
    			}
    
    					
    			public ObjectResult<Model.Data.ShemaStPolje> SelectResult(Nullable<long> ID_ShemaStPolje)
            	{
                	return _context.USP_ShemaStPolje_SELECT(ID_ShemaStPolje);
            	}			
    				
    			public void Update(Model.Data.Item.ShemaStPoljeItem item)
    			{
    				_context.USP_ShemaStPolje_UPDATE(item.ID_ShemaStPolje, item.ID_ShemaSt, item.TablicaShema, item.TablicaNaziv, item.TablicaPoljeNaziv, item.AritmetickiOperator, item.Operand, item.Negativno);
    			}
    
    					
    			public ObjectResult<Model.Data.ShemaStPolje> UpdateResult(Model.Data.Item.ShemaStPoljeItem item)
    			{
    				return _context.USP_ShemaStPolje_UPDATE(item.ID_ShemaStPolje, item.ID_ShemaSt, item.TablicaShema, item.TablicaNaziv, item.TablicaPoljeNaziv, item.AritmetickiOperator, item.Operand, item.Negativno);
    			}
    										
    		
    #endregion
    	
    }
    
}
