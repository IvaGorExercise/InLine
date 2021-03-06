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
    
    public partial class MjestoGrMjestoDatum
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public MjestoGrMjestoDatum(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.MjestoGrMjestoDatumItem item)
    			{
    				_context.USP_MjestoGrMjestoDatum_DELETE(item.ID_MjestoGrMjestoDatum);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.MjestoGrMjestoDatumItem item)
    			{
    				return _context.USP_MjestoGrMjestoDatum_DELETE(item.ID_MjestoGrMjestoDatum);
    			}	
    									
    			public void Insert(Model.Data.Item.MjestoGrMjestoDatumItem item)
    			{
    				_context.USP_MjestoGrMjestoDatum_INSERT(item.ID_MjestoGrMjesto, item.DatumOd, item.DatumDo, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis);
    			}
    
    			public ObjectResult<Model.Data.MjestoGrMjestoDatum> InsertResult(Model.Data.Item.MjestoGrMjestoDatumItem item)
    			{
    				return _context.USP_MjestoGrMjestoDatum_INSERT(item.ID_MjestoGrMjesto, item.DatumOd, item.DatumDo, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_MjestoGrMjestoDatum)
    			{
    				_context.USP_MjestoGrMjestoDatum_SELECT(ID_MjestoGrMjestoDatum);
    			}
    
    					
    			public ObjectResult<Model.Data.MjestoGrMjestoDatum> SelectResult(Nullable<long> ID_MjestoGrMjestoDatum)
            	{
                	return _context.USP_MjestoGrMjestoDatum_SELECT(ID_MjestoGrMjestoDatum);
            	}			
    				
    			public void Update(Model.Data.Item.MjestoGrMjestoDatumItem item)
    			{
    				_context.USP_MjestoGrMjestoDatum_UPDATE(item.ID_MjestoGrMjestoDatum, item.ID_MjestoGrMjesto, item.DatumOd, item.DatumDo, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis);
    			}
    
    					
    			public ObjectResult<Model.Data.MjestoGrMjestoDatum> UpdateResult(Model.Data.Item.MjestoGrMjestoDatumItem item)
    			{
    				return _context.USP_MjestoGrMjestoDatum_UPDATE(item.ID_MjestoGrMjestoDatum, item.ID_MjestoGrMjesto, item.DatumOd, item.DatumDo, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis);
    			}
    										
    		
    #endregion
    	
    }
    
}
