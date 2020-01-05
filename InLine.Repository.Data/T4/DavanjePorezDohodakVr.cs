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
    
    public partial class DavanjePorezDohodakVr
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public DavanjePorezDohodakVr(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DavanjePorezDohodakVrItem item)
    			{
    				_context.USP_DavanjePorezDohodakVr_DELETE(item.IDDavanjePorezDohodakVr);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DavanjePorezDohodakVrItem item)
    			{
    				return _context.USP_DavanjePorezDohodakVr_DELETE(item.IDDavanjePorezDohodakVr);
    			}	
    									
    			public void Insert(Model.Data.Item.DavanjePorezDohodakVrItem item)
    			{
    				_context.USP_DavanjePorezDohodakVr_INSERT(item.IDDavanjePorezDohodakVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.DatumOd, item.DatumDo, item.OsobniOdbitak, item.NNGodina, item.NNBroj, item.NNClanak, item.NNDatum);
    			}
    
    			public ObjectResult<Model.Data.DavanjePorezDohodakVr> InsertResult(Model.Data.Item.DavanjePorezDohodakVrItem item)
    			{
    				return _context.USP_DavanjePorezDohodakVr_INSERT(item.IDDavanjePorezDohodakVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.DatumOd, item.DatumDo, item.OsobniOdbitak, item.NNGodina, item.NNBroj, item.NNClanak, item.NNDatum);
    			}	
    									
    				
    			public void Select(Nullable<int> IDDavanjePorezDohodakVr)
    			{
    				_context.USP_DavanjePorezDohodakVr_SELECT(IDDavanjePorezDohodakVr);
    			}
    
    					
    			public ObjectResult<Model.Data.DavanjePorezDohodakVr> SelectResult(Nullable<int> IDDavanjePorezDohodakVr)
            	{
                	return _context.USP_DavanjePorezDohodakVr_SELECT(IDDavanjePorezDohodakVr);
            	}			
    				
    			public void Update(Model.Data.Item.DavanjePorezDohodakVrItem item)
    			{
    				_context.USP_DavanjePorezDohodakVr_UPDATE(item.IDDavanjePorezDohodakVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.DatumOd, item.DatumDo, item.OsobniOdbitak, item.NNGodina, item.NNBroj, item.NNClanak, item.NNDatum);
    			}
    
    					
    			public ObjectResult<Model.Data.DavanjePorezDohodakVr> UpdateResult(Model.Data.Item.DavanjePorezDohodakVrItem item)
    			{
    				return _context.USP_DavanjePorezDohodakVr_UPDATE(item.IDDavanjePorezDohodakVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.DatumOd, item.DatumDo, item.OsobniOdbitak, item.NNGodina, item.NNBroj, item.NNClanak, item.NNDatum);
    			}
    										
    		
    #endregion
    	
    }
    
}