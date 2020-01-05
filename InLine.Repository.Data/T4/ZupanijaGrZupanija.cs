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
    
    public partial class ZupanijaGrZupanija
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ZupanijaGrZupanija(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ZupanijaGrZupanijaItem item)
    			{
    				_context.USP_ZupanijaGrZupanija_DELETE(item.ID_ZupanijaGrZupanija);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ZupanijaGrZupanijaItem item)
    			{
    				return _context.USP_ZupanijaGrZupanija_DELETE(item.ID_ZupanijaGrZupanija);
    			}	
    									
    			public void Insert(Model.Data.Item.ZupanijaGrZupanijaItem item)
    			{
    				_context.USP_ZupanijaGrZupanija_INSERT(item.ID_ZupanijaGr, item.ID_Zupanija, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis);
    			}
    
    			public ObjectResult<Model.Data.ZupanijaGrZupanija> InsertResult(Model.Data.Item.ZupanijaGrZupanijaItem item)
    			{
    				return _context.USP_ZupanijaGrZupanija_INSERT(item.ID_ZupanijaGr, item.ID_Zupanija, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ZupanijaGrZupanija)
    			{
    				_context.USP_ZupanijaGrZupanija_SELECT(ID_ZupanijaGrZupanija);
    			}
    
    					
    			public ObjectResult<Model.Data.ZupanijaGrZupanija> SelectResult(Nullable<long> ID_ZupanijaGrZupanija)
            	{
                	return _context.USP_ZupanijaGrZupanija_SELECT(ID_ZupanijaGrZupanija);
            	}			
    				
    			public void Update(Model.Data.Item.ZupanijaGrZupanijaItem item)
    			{
    				_context.USP_ZupanijaGrZupanija_UPDATE(item.ID_ZupanijaGrZupanija, item.ID_ZupanijaGr, item.ID_Zupanija, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis);
    			}
    
    					
    			public ObjectResult<Model.Data.ZupanijaGrZupanija> UpdateResult(Model.Data.Item.ZupanijaGrZupanijaItem item)
    			{
    				return _context.USP_ZupanijaGrZupanija_UPDATE(item.ID_ZupanijaGrZupanija, item.ID_ZupanijaGr, item.ID_Zupanija, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis);
    			}
    										
    		
    #endregion
    	
    }
    
}