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
    
    public partial class DavanjePosebanPorezDohodakVr
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public DavanjePosebanPorezDohodakVr(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DavanjePosebanPorezDohodakVrItem item)
    			{
    				_context.USP_DavanjePosebanPorezDohodakVr_DELETE(item.IDDavanjePosebanPorezDohodakVr);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DavanjePosebanPorezDohodakVrItem item)
    			{
    				return _context.USP_DavanjePosebanPorezDohodakVr_DELETE(item.IDDavanjePosebanPorezDohodakVr);
    			}	
    									
    			public void Insert(Model.Data.Item.DavanjePosebanPorezDohodakVrItem item)
    			{
    				_context.USP_DavanjePosebanPorezDohodakVr_INSERT(item.IDDavanjePosebanPorezDohodakVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.DatumOd, item.DatumDo, item.NNGodina, item.NNBroj, item.NNClanak, item.NNDatum);
    			}
    
    			public ObjectResult<Model.Data.DavanjePosebanPorezDohodakVr> InsertResult(Model.Data.Item.DavanjePosebanPorezDohodakVrItem item)
    			{
    				return _context.USP_DavanjePosebanPorezDohodakVr_INSERT(item.IDDavanjePosebanPorezDohodakVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.DatumOd, item.DatumDo, item.NNGodina, item.NNBroj, item.NNClanak, item.NNDatum);
    			}	
    									
    				
    			public void Select(Nullable<int> IDDavanjePosebanPorezDohodakVr)
    			{
    				_context.USP_DavanjePosebanPorezDohodakVr_SELECT(IDDavanjePosebanPorezDohodakVr);
    			}
    
    					
    			public ObjectResult<Model.Data.DavanjePosebanPorezDohodakVr> SelectResult(Nullable<int> IDDavanjePosebanPorezDohodakVr)
            	{
                	return _context.USP_DavanjePosebanPorezDohodakVr_SELECT(IDDavanjePosebanPorezDohodakVr);
            	}			
    				
    			public void Update(Model.Data.Item.DavanjePosebanPorezDohodakVrItem item)
    			{
    				_context.USP_DavanjePosebanPorezDohodakVr_UPDATE(item.IDDavanjePosebanPorezDohodakVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.DatumOd, item.DatumDo, item.NNGodina, item.NNBroj, item.NNClanak, item.NNDatum);
    			}
    
    					
    			public ObjectResult<Model.Data.DavanjePosebanPorezDohodakVr> UpdateResult(Model.Data.Item.DavanjePosebanPorezDohodakVrItem item)
    			{
    				return _context.USP_DavanjePosebanPorezDohodakVr_UPDATE(item.IDDavanjePosebanPorezDohodakVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.DatumOd, item.DatumDo, item.NNGodina, item.NNBroj, item.NNClanak, item.NNDatum);
    			}
    										
    		
    #endregion
    	
    }
    
}
