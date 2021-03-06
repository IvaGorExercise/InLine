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
    
    public partial class Zapis
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public Zapis(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ZapisItem item)
    			{
    				_context.USP_Zapis_DELETE(item.ID_Zapis);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ZapisItem item)
    			{
    				return _context.USP_Zapis_DELETE(item.ID_Zapis);
    			}	
    									
    			public void Insert(Model.Data.Item.ZapisItem item)
    			{
    				_context.USP_Zapis_INSERT(item.IDZapisTablica, item.IDZapis, item.VrijemeUpis, item.UrudzbeniBroj, item.Predmet, item.ID_Subjekt, item.ID_SubjektUpis, item.ID_Temeljnica, item.Broj, item.Datum, item.Vrijeme);
    			}
    
    			public ObjectResult<Model.Data.Zapis> InsertResult(Model.Data.Item.ZapisItem item)
    			{
    				return _context.USP_Zapis_INSERT(item.IDZapisTablica, item.IDZapis, item.VrijemeUpis, item.UrudzbeniBroj, item.Predmet, item.ID_Subjekt, item.ID_SubjektUpis, item.ID_Temeljnica, item.Broj, item.Datum, item.Vrijeme);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_Zapis)
    			{
    				_context.USP_Zapis_SELECT(ID_Zapis);
    			}
    
    					
    			public ObjectResult<Model.Data.Zapis> SelectResult(Nullable<long> ID_Zapis)
            	{
                	return _context.USP_Zapis_SELECT(ID_Zapis);
            	}			
    				
    			public void Update(Model.Data.Item.ZapisItem item)
    			{
    				_context.USP_Zapis_UPDATE(item.ID_Zapis, item.IDZapisTablica, item.IDZapis, item.VrijemeUpis, item.UrudzbeniBroj, item.Predmet, item.ID_Subjekt, item.ID_SubjektUpis, item.ID_Temeljnica, item.Broj, item.Datum, item.Vrijeme);
    			}
    
    					
    			public ObjectResult<Model.Data.Zapis> UpdateResult(Model.Data.Item.ZapisItem item)
    			{
    				return _context.USP_Zapis_UPDATE(item.ID_Zapis, item.IDZapisTablica, item.IDZapis, item.VrijemeUpis, item.UrudzbeniBroj, item.Predmet, item.ID_Subjekt, item.ID_SubjektUpis, item.ID_Temeljnica, item.Broj, item.Datum, item.Vrijeme);
    			}
    										
    		
    #endregion
    	
    }
    
}
