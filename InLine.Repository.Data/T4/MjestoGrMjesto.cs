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
    
    public partial class MjestoGrMjesto
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public MjestoGrMjesto(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.MjestoGrMjestoItem item)
    			{
    				_context.USP_MjestoGrMjesto_DELETE(item.ID_MjestoGrMjesto);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.MjestoGrMjestoItem item)
    			{
    				return _context.USP_MjestoGrMjesto_DELETE(item.ID_MjestoGrMjesto);
    			}	
    									
    			public void Insert(Model.Data.Item.MjestoGrMjestoItem item)
    			{
    				_context.USP_MjestoGrMjesto_INSERT(item.ID_MjestoGr, item.ID_Mjesto, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis);
    			}
    
    			public ObjectResult<Model.Data.MjestoGrMjesto> InsertResult(Model.Data.Item.MjestoGrMjestoItem item)
    			{
    				return _context.USP_MjestoGrMjesto_INSERT(item.ID_MjestoGr, item.ID_Mjesto, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_MjestoGrMjesto)
    			{
    				_context.USP_MjestoGrMjesto_SELECT(ID_MjestoGrMjesto);
    			}
    
    					
    			public ObjectResult<Model.Data.MjestoGrMjesto> SelectResult(Nullable<long> ID_MjestoGrMjesto)
            	{
                	return _context.USP_MjestoGrMjesto_SELECT(ID_MjestoGrMjesto);
            	}			
    				
    			public void Update(Model.Data.Item.MjestoGrMjestoItem item)
    			{
    				_context.USP_MjestoGrMjesto_UPDATE(item.ID_MjestoGrMjesto, item.ID_MjestoGr, item.ID_Mjesto, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis);
    			}
    
    					
    			public ObjectResult<Model.Data.MjestoGrMjesto> UpdateResult(Model.Data.Item.MjestoGrMjestoItem item)
    			{
    				return _context.USP_MjestoGrMjesto_UPDATE(item.ID_MjestoGrMjesto, item.ID_MjestoGr, item.ID_Mjesto, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis);
    			}
    										
    		
    #endregion
    	
    }
    
}
