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
    
    public partial class SubjektTelefon
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public SubjektTelefon(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.SubjektTelefonItem item)
    			{
    				_context.USP_SubjektTelefon_DELETE(item.ID_SubjektTelefon);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.SubjektTelefonItem item)
    			{
    				return _context.USP_SubjektTelefon_DELETE(item.ID_SubjektTelefon);
    			}	
    									
    			public void Insert(Model.Data.Item.SubjektTelefonItem item)
    			{
    				_context.USP_SubjektTelefon_INSERT(item.ID_Subjekt, item.Broj);
    			}
    
    			public ObjectResult<Model.Data.SubjektTelefon> InsertResult(Model.Data.Item.SubjektTelefonItem item)
    			{
    				return _context.USP_SubjektTelefon_INSERT(item.ID_Subjekt, item.Broj);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_SubjektTelefon)
    			{
    				_context.USP_SubjektTelefon_SELECT(ID_SubjektTelefon);
    			}
    
    					
    			public ObjectResult<Model.Data.SubjektTelefon> SelectResult(Nullable<long> ID_SubjektTelefon)
            	{
                	return _context.USP_SubjektTelefon_SELECT(ID_SubjektTelefon);
            	}			
    				
    			public void Update(Model.Data.Item.SubjektTelefonItem item)
    			{
    				_context.USP_SubjektTelefon_UPDATE(item.ID_SubjektTelefon, item.ID_Subjekt, item.Broj);
    			}
    
    					
    			public ObjectResult<Model.Data.SubjektTelefon> UpdateResult(Model.Data.Item.SubjektTelefonItem item)
    			{
    				return _context.USP_SubjektTelefon_UPDATE(item.ID_SubjektTelefon, item.ID_Subjekt, item.Broj);
    			}
    										
    		
    #endregion
    	
    }
    
}