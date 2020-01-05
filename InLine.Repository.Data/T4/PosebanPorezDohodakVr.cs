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
    
    public partial class PosebanPorezDohodakVr
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public PosebanPorezDohodakVr(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.PosebanPorezDohodakVrItem item)
    			{
    				_context.USP_PosebanPorezDohodakVr_DELETE(item.ID_PosebanPorezDohodakVr);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.PosebanPorezDohodakVrItem item)
    			{
    				return _context.USP_PosebanPorezDohodakVr_DELETE(item.ID_PosebanPorezDohodakVr);
    			}	
    									
    			public void Insert(Model.Data.Item.PosebanPorezDohodakVrItem item)
    			{
    				_context.USP_PosebanPorezDohodakVr_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.DatumOd, item.DatumDo, item.NNGodina, item.NNBroj, item.NNClanak, item.NNDatum);
    			}
    
    			public ObjectResult<Model.Data.PosebanPorezDohodakVr> InsertResult(Model.Data.Item.PosebanPorezDohodakVrItem item)
    			{
    				return _context.USP_PosebanPorezDohodakVr_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.DatumOd, item.DatumDo, item.NNGodina, item.NNBroj, item.NNClanak, item.NNDatum);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_PosebanPorezDohodakVr)
    			{
    				_context.USP_PosebanPorezDohodakVr_SELECT(ID_PosebanPorezDohodakVr);
    			}
    
    					
    			public ObjectResult<Model.Data.PosebanPorezDohodakVr> SelectResult(Nullable<long> ID_PosebanPorezDohodakVr)
            	{
                	return _context.USP_PosebanPorezDohodakVr_SELECT(ID_PosebanPorezDohodakVr);
            	}			
    				
    			public void Update(Model.Data.Item.PosebanPorezDohodakVrItem item)
    			{
    				_context.USP_PosebanPorezDohodakVr_UPDATE(item.ID_PosebanPorezDohodakVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.DatumOd, item.DatumDo, item.NNGodina, item.NNBroj, item.NNClanak, item.NNDatum);
    			}
    
    					
    			public ObjectResult<Model.Data.PosebanPorezDohodakVr> UpdateResult(Model.Data.Item.PosebanPorezDohodakVrItem item)
    			{
    				return _context.USP_PosebanPorezDohodakVr_UPDATE(item.ID_PosebanPorezDohodakVr, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.DatumOd, item.DatumDo, item.NNGodina, item.NNBroj, item.NNClanak, item.NNDatum);
    			}
    										
    		
    #endregion
    	
    }
    
}