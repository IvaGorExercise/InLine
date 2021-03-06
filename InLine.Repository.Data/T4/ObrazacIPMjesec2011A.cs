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
    
    public partial class ObrazacIPMjesec2011A
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ObrazacIPMjesec2011A(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ObrazacIPMjesec2011AItem item)
    			{
    				_context.USP_ObrazacIPMjesec2011A_DELETE(item.ID_ObrazacIPMjesec2011A);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacIPMjesec2011AItem item)
    			{
    				return _context.USP_ObrazacIPMjesec2011A_DELETE(item.ID_ObrazacIPMjesec2011A);
    			}	
    									
    			public void Insert(Model.Data.Item.ObrazacIPMjesec2011AItem item)
    			{
    				_context.USP_ObrazacIPMjesec2011A_INSERT(item.ID_ObrazacIP, item.Mjesec, item.ID_Opcina, item.SifraOpcina, item.IznosIsplata, item.IznosUplataDoprinosIz, item.IznosDohodak, item.IznosOsobniOdbitak, item.IznosPorezOsnova, item.IznosUplataPorezPrirez, item.IznosIsplataNeto);
    			}
    
    			public ObjectResult<Model.Data.ObrazacIPMjesec2011A> InsertResult(Model.Data.Item.ObrazacIPMjesec2011AItem item)
    			{
    				return _context.USP_ObrazacIPMjesec2011A_INSERT(item.ID_ObrazacIP, item.Mjesec, item.ID_Opcina, item.SifraOpcina, item.IznosIsplata, item.IznosUplataDoprinosIz, item.IznosDohodak, item.IznosOsobniOdbitak, item.IznosPorezOsnova, item.IznosUplataPorezPrirez, item.IznosIsplataNeto);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ObrazacIPMjesec2011A)
    			{
    				_context.USP_ObrazacIPMjesec2011A_SELECT(ID_ObrazacIPMjesec2011A);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacIPMjesec2011A> SelectResult(Nullable<long> ID_ObrazacIPMjesec2011A)
            	{
                	return _context.USP_ObrazacIPMjesec2011A_SELECT(ID_ObrazacIPMjesec2011A);
            	}			
    				
    			public void Update(Model.Data.Item.ObrazacIPMjesec2011AItem item)
    			{
    				_context.USP_ObrazacIPMjesec2011A_UPDATE(item.ID_ObrazacIPMjesec2011A, item.ID_ObrazacIP, item.Mjesec, item.ID_Opcina, item.SifraOpcina, item.IznosIsplata, item.IznosUplataDoprinosIz, item.IznosDohodak, item.IznosOsobniOdbitak, item.IznosPorezOsnova, item.IznosUplataPorezPrirez, item.IznosIsplataNeto);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacIPMjesec2011A> UpdateResult(Model.Data.Item.ObrazacIPMjesec2011AItem item)
    			{
    				return _context.USP_ObrazacIPMjesec2011A_UPDATE(item.ID_ObrazacIPMjesec2011A, item.ID_ObrazacIP, item.Mjesec, item.ID_Opcina, item.SifraOpcina, item.IznosIsplata, item.IznosUplataDoprinosIz, item.IznosDohodak, item.IznosOsobniOdbitak, item.IznosPorezOsnova, item.IznosUplataPorezPrirez, item.IznosIsplataNeto);
    			}
    										
    		
    #endregion
    	
    }
    
}
