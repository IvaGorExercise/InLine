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
    
    public partial class DatotekaIzvodVerzijaTablica
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public DatotekaIzvodVerzijaTablica(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DatotekaIzvodVerzijaTablicaItem item)
    			{
    				_context.USP_DatotekaIzvodVerzijaTablica_DELETE(item.IDDatotekaIzvodVerzijaTablica);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DatotekaIzvodVerzijaTablicaItem item)
    			{
    				return _context.USP_DatotekaIzvodVerzijaTablica_DELETE(item.IDDatotekaIzvodVerzijaTablica);
    			}	
    									
    			public void Insert(Model.Data.Item.DatotekaIzvodVerzijaTablicaItem item)
    			{
    				_context.USP_DatotekaIzvodVerzijaTablica_INSERT(item.IDDatotekaIzvodVerzija, item.IDDatotekaIzvodVerzijaTablica, item.TablicaShema, item.TablicaNaziv);
    			}
    
    			public ObjectResult<Model.Data.DatotekaIzvodVerzijaTablica> InsertResult(Model.Data.Item.DatotekaIzvodVerzijaTablicaItem item)
    			{
    				return _context.USP_DatotekaIzvodVerzijaTablica_INSERT(item.IDDatotekaIzvodVerzija, item.IDDatotekaIzvodVerzijaTablica, item.TablicaShema, item.TablicaNaziv);
    			}	
    									
    				
    			public void Select(Nullable<int> IDDatotekaIzvodVerzijaTablica)
    			{
    				_context.USP_DatotekaIzvodVerzijaTablica_SELECT(IDDatotekaIzvodVerzijaTablica);
    			}
    
    					
    			public ObjectResult<Model.Data.DatotekaIzvodVerzijaTablica> SelectResult(Nullable<int> IDDatotekaIzvodVerzijaTablica)
            	{
                	return _context.USP_DatotekaIzvodVerzijaTablica_SELECT(IDDatotekaIzvodVerzijaTablica);
            	}			
    				
    			public void Update(Model.Data.Item.DatotekaIzvodVerzijaTablicaItem item)
    			{
    				_context.USP_DatotekaIzvodVerzijaTablica_UPDATE(item.IDDatotekaIzvodVerzija, item.IDDatotekaIzvodVerzijaTablica, item.TablicaShema, item.TablicaNaziv);
    			}
    
    					
    			public ObjectResult<Model.Data.DatotekaIzvodVerzijaTablica> UpdateResult(Model.Data.Item.DatotekaIzvodVerzijaTablicaItem item)
    			{
    				return _context.USP_DatotekaIzvodVerzijaTablica_UPDATE(item.IDDatotekaIzvodVerzija, item.IDDatotekaIzvodVerzijaTablica, item.TablicaShema, item.TablicaNaziv);
    			}
    										
    		
    #endregion
    	
    }
    
}
