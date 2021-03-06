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
    
    public partial class KnjigaOS
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public KnjigaOS(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.KnjigaOSItem item)
    			{
    				_context.USP_KnjigaOS_DELETE(item.ID_KnjigaOS);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.KnjigaOSItem item)
    			{
    				return _context.USP_KnjigaOS_DELETE(item.ID_KnjigaOS);
    			}	
    									
    			public void Insert(Model.Data.Item.KnjigaOSItem item)
    			{
    				_context.USP_KnjigaOS_INSERT(item.ID_Zapis, item.ID_PoslovniSubjekt);
    			}
    
    			public ObjectResult<Model.Data.KnjigaOS> InsertResult(Model.Data.Item.KnjigaOSItem item)
    			{
    				return _context.USP_KnjigaOS_INSERT(item.ID_Zapis, item.ID_PoslovniSubjekt);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_KnjigaOS)
    			{
    				_context.USP_KnjigaOS_SELECT(ID_KnjigaOS);
    			}
    
    					
    			public ObjectResult<Model.Data.KnjigaOS> SelectResult(Nullable<long> ID_KnjigaOS)
            	{
                	return _context.USP_KnjigaOS_SELECT(ID_KnjigaOS);
            	}			
    				
    			public void Update(Model.Data.Item.KnjigaOSItem item)
    			{
    				_context.USP_KnjigaOS_UPDATE(item.ID_KnjigaOS, item.ID_Zapis, item.ID_PoslovniSubjekt);
    			}
    
    					
    			public ObjectResult<Model.Data.KnjigaOS> UpdateResult(Model.Data.Item.KnjigaOSItem item)
    			{
    				return _context.USP_KnjigaOS_UPDATE(item.ID_KnjigaOS, item.ID_Zapis, item.ID_PoslovniSubjekt);
    			}
    										
    		
    #endregion
    	
    }
    
}
