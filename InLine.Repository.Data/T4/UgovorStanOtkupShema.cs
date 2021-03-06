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
    
    public partial class UgovorStanOtkupShema
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public UgovorStanOtkupShema(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.UgovorStanOtkupShemaItem item)
    			{
    				_context.USP_UgovorStanOtkupShema_DELETE(item.ID_UgovorStanOtkupShema);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.UgovorStanOtkupShemaItem item)
    			{
    				return _context.USP_UgovorStanOtkupShema_DELETE(item.ID_UgovorStanOtkupShema);
    			}	
    									
    			public void Insert(Model.Data.Item.UgovorStanOtkupShemaItem item)
    			{
    				_context.USP_UgovorStanOtkupShema_INSERT(item.ID_UgovorStanOtkup, item.ID_Shema);
    			}
    
    			public ObjectResult<Model.Data.UgovorStanOtkupShema> InsertResult(Model.Data.Item.UgovorStanOtkupShemaItem item)
    			{
    				return _context.USP_UgovorStanOtkupShema_INSERT(item.ID_UgovorStanOtkup, item.ID_Shema);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_UgovorStanOtkupShema)
    			{
    				_context.USP_UgovorStanOtkupShema_SELECT(ID_UgovorStanOtkupShema);
    			}
    
    					
    			public ObjectResult<Model.Data.UgovorStanOtkupShema> SelectResult(Nullable<long> ID_UgovorStanOtkupShema)
            	{
                	return _context.USP_UgovorStanOtkupShema_SELECT(ID_UgovorStanOtkupShema);
            	}			
    				
    			public void Update(Model.Data.Item.UgovorStanOtkupShemaItem item)
    			{
    				_context.USP_UgovorStanOtkupShema_UPDATE(item.ID_UgovorStanOtkupShema, item.ID_UgovorStanOtkup, item.ID_Shema);
    			}
    
    					
    			public ObjectResult<Model.Data.UgovorStanOtkupShema> UpdateResult(Model.Data.Item.UgovorStanOtkupShemaItem item)
    			{
    				return _context.USP_UgovorStanOtkupShema_UPDATE(item.ID_UgovorStanOtkupShema, item.ID_UgovorStanOtkup, item.ID_Shema);
    			}
    										
    		
    #endregion
    	
    }
    
}
