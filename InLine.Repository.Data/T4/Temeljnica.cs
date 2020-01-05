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
    
    public partial class Temeljnica
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public Temeljnica(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.TemeljnicaItem item)
    			{
    				_context.USP_Temeljnica_DELETE(item.ID_Temeljnica);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.TemeljnicaItem item)
    			{
    				return _context.USP_Temeljnica_DELETE(item.ID_Temeljnica);
    			}	
    									
    			public void Insert(Model.Data.Item.TemeljnicaItem item)
    			{
    				_context.USP_Temeljnica_INSERT(item.ID_TemeljnicaVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Datum, item.IDValuta, item.DatumKnjizenje, item.Tecaj, item.Knjizeno, item.Storno, item.PocetnoStanje, item.ZavrsnoKnjizenje, item.Opis);
    			}
    
    			public ObjectResult<Model.Data.Temeljnica> InsertResult(Model.Data.Item.TemeljnicaItem item)
    			{
    				return _context.USP_Temeljnica_INSERT(item.ID_TemeljnicaVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Datum, item.IDValuta, item.DatumKnjizenje, item.Tecaj, item.Knjizeno, item.Storno, item.PocetnoStanje, item.ZavrsnoKnjizenje, item.Opis);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_Temeljnica)
    			{
    				_context.USP_Temeljnica_SELECT(ID_Temeljnica);
    			}
    
    					
    			public ObjectResult<Model.Data.Temeljnica> SelectResult(Nullable<long> ID_Temeljnica)
            	{
                	return _context.USP_Temeljnica_SELECT(ID_Temeljnica);
            	}			
    				
    			public void Update(Model.Data.Item.TemeljnicaItem item)
    			{
    				_context.USP_Temeljnica_UPDATE(item.ID_Temeljnica, item.ID_TemeljnicaVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Datum, item.IDValuta, item.DatumKnjizenje, item.Tecaj, item.Knjizeno, item.Storno, item.PocetnoStanje, item.ZavrsnoKnjizenje, item.Opis);
    			}
    
    					
    			public ObjectResult<Model.Data.Temeljnica> UpdateResult(Model.Data.Item.TemeljnicaItem item)
    			{
    				return _context.USP_Temeljnica_UPDATE(item.ID_Temeljnica, item.ID_TemeljnicaVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Datum, item.IDValuta, item.DatumKnjizenje, item.Tecaj, item.Knjizeno, item.Storno, item.PocetnoStanje, item.ZavrsnoKnjizenje, item.Opis);
    			}
    										
    		
    #endregion
    	
    }
    
}
