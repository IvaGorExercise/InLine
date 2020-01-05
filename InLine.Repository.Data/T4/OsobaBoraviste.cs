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
    
    public partial class OsobaBoraviste
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public OsobaBoraviste(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.OsobaBoravisteItem item)
    			{
    				_context.USP_OsobaBoraviste_DELETE(item.ID_OsobaBoraviste);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.OsobaBoravisteItem item)
    			{
    				return _context.USP_OsobaBoraviste_DELETE(item.ID_OsobaBoraviste);
    			}	
    									
    			public void Insert(Model.Data.Item.OsobaBoravisteItem item)
    			{
    				_context.USP_OsobaBoraviste_INSERT(item.ID_Osoba, item.ID_Opcina, item.DatumOd, item.DatumDo);
    			}
    
    			public ObjectResult<Model.Data.OsobaBoraviste> InsertResult(Model.Data.Item.OsobaBoravisteItem item)
    			{
    				return _context.USP_OsobaBoraviste_INSERT(item.ID_Osoba, item.ID_Opcina, item.DatumOd, item.DatumDo);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_OsobaBoraviste)
    			{
    				_context.USP_OsobaBoraviste_SELECT(ID_OsobaBoraviste);
    			}
    
    					
    			public ObjectResult<Model.Data.OsobaBoraviste> SelectResult(Nullable<long> ID_OsobaBoraviste)
            	{
                	return _context.USP_OsobaBoraviste_SELECT(ID_OsobaBoraviste);
            	}			
    				
    			public void Update(Model.Data.Item.OsobaBoravisteItem item)
    			{
    				_context.USP_OsobaBoraviste_UPDATE(item.ID_OsobaBoraviste, item.ID_Osoba, item.ID_Opcina, item.DatumOd, item.DatumDo);
    			}
    
    					
    			public ObjectResult<Model.Data.OsobaBoraviste> UpdateResult(Model.Data.Item.OsobaBoravisteItem item)
    			{
    				return _context.USP_OsobaBoraviste_UPDATE(item.ID_OsobaBoraviste, item.ID_Osoba, item.ID_Opcina, item.DatumOd, item.DatumDo);
    			}
    										
    		
    #endregion
    	
    }
    
}