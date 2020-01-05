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
    
    public partial class SubjektTablica
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public SubjektTablica(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.SubjektTablicaItem item)
    			{
    				_context.USP_SubjektTablica_DELETE(item.IDSubjektTablica);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.SubjektTablicaItem item)
    			{
    				return _context.USP_SubjektTablica_DELETE(item.IDSubjektTablica);
    			}	
    									
    			public void Insert(Model.Data.Item.SubjektTablicaItem item)
    			{
    				_context.USP_SubjektTablica_INSERT(item.IDSubjektTablica, item.TablicaShema, item.TablicaNaziv);
    			}
    
    			public ObjectResult<Model.Data.SubjektTablica> InsertResult(Model.Data.Item.SubjektTablicaItem item)
    			{
    				return _context.USP_SubjektTablica_INSERT(item.IDSubjektTablica, item.TablicaShema, item.TablicaNaziv);
    			}	
    									
    				
    			public void Select(Nullable<int> IDSubjektTablica)
    			{
    				_context.USP_SubjektTablica_SELECT(IDSubjektTablica);
    			}
    
    					
    			public ObjectResult<Model.Data.SubjektTablica> SelectResult(Nullable<int> IDSubjektTablica)
            	{
                	return _context.USP_SubjektTablica_SELECT(IDSubjektTablica);
            	}			
    				
    			public void Update(Model.Data.Item.SubjektTablicaItem item)
    			{
    				_context.USP_SubjektTablica_UPDATE(item.IDSubjektTablica, item.TablicaShema, item.TablicaNaziv);
    			}
    
    					
    			public ObjectResult<Model.Data.SubjektTablica> UpdateResult(Model.Data.Item.SubjektTablicaItem item)
    			{
    				return _context.USP_SubjektTablica_UPDATE(item.IDSubjektTablica, item.TablicaShema, item.TablicaNaziv);
    			}
    										
    		
    #endregion
    	
    }
    
}
