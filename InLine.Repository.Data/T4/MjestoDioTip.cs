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
    
    public partial class MjestoDioTip
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public MjestoDioTip(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.MjestoDioTipItem item)
    			{
    				_context.USP_MjestoDioTip_DELETE(item.ID_MjestoDioTip);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.MjestoDioTipItem item)
    			{
    				return _context.USP_MjestoDioTip_DELETE(item.ID_MjestoDioTip);
    			}	
    									
    			public void Insert(Model.Data.Item.MjestoDioTipItem item)
    			{
    				_context.USP_MjestoDioTip_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis);
    			}
    
    			public ObjectResult<Model.Data.MjestoDioTip> InsertResult(Model.Data.Item.MjestoDioTipItem item)
    			{
    				return _context.USP_MjestoDioTip_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_MjestoDioTip)
    			{
    				_context.USP_MjestoDioTip_SELECT(ID_MjestoDioTip);
    			}
    
    					
    			public ObjectResult<Model.Data.MjestoDioTip> SelectResult(Nullable<long> ID_MjestoDioTip)
            	{
                	return _context.USP_MjestoDioTip_SELECT(ID_MjestoDioTip);
            	}			
    				
    			public void Update(Model.Data.Item.MjestoDioTipItem item)
    			{
    				_context.USP_MjestoDioTip_UPDATE(item.ID_MjestoDioTip, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis);
    			}
    
    					
    			public ObjectResult<Model.Data.MjestoDioTip> UpdateResult(Model.Data.Item.MjestoDioTipItem item)
    			{
    				return _context.USP_MjestoDioTip_UPDATE(item.ID_MjestoDioTip, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.Opis);
    			}
    										
    		
    #endregion
    	
    }
    
}