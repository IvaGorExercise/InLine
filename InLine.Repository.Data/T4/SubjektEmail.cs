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
    
    public partial class SubjektEmail
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public SubjektEmail(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.SubjektEmailItem item)
    			{
    				_context.USP_SubjektEmail_DELETE(item.ID_SubjektEmail);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.SubjektEmailItem item)
    			{
    				return _context.USP_SubjektEmail_DELETE(item.ID_SubjektEmail);
    			}	
    									
    			public void Insert(Model.Data.Item.SubjektEmailItem item)
    			{
    				_context.USP_SubjektEmail_INSERT(item.ID_Subjekt, item.URL, item.Opis);
    			}
    
    			public ObjectResult<Model.Data.SubjektEmail> InsertResult(Model.Data.Item.SubjektEmailItem item)
    			{
    				return _context.USP_SubjektEmail_INSERT(item.ID_Subjekt, item.URL, item.Opis);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_SubjektEmail)
    			{
    				_context.USP_SubjektEmail_SELECT(ID_SubjektEmail);
    			}
    
    					
    			public ObjectResult<Model.Data.SubjektEmail> SelectResult(Nullable<long> ID_SubjektEmail)
            	{
                	return _context.USP_SubjektEmail_SELECT(ID_SubjektEmail);
            	}			
    				
    			public void Update(Model.Data.Item.SubjektEmailItem item)
    			{
    				_context.USP_SubjektEmail_UPDATE(item.ID_SubjektEmail, item.ID_Subjekt, item.URL, item.Opis);
    			}
    
    					
    			public ObjectResult<Model.Data.SubjektEmail> UpdateResult(Model.Data.Item.SubjektEmailItem item)
    			{
    				return _context.USP_SubjektEmail_UPDATE(item.ID_SubjektEmail, item.ID_Subjekt, item.URL, item.Opis);
    			}
    										
    		
    #endregion
    	
    }
    
}
