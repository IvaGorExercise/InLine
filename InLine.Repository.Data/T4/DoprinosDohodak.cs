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
    
    public partial class DoprinosDohodak
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public DoprinosDohodak(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DoprinosDohodakItem item)
    			{
    				_context.USP_DoprinosDohodak_DELETE(item.ID_DoprinosDohodak);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DoprinosDohodakItem item)
    			{
    				return _context.USP_DoprinosDohodak_DELETE(item.ID_DoprinosDohodak);
    			}	
    									
    			public void Insert(Model.Data.Item.DoprinosDohodakItem item)
    			{
    				_context.USP_DoprinosDohodak_INSERT(item.ID_DoprinosDohodakVr, item.ID_Davanje, item.DatumOd, item.DatumDo, item.Stopa, item.IzBruto, item.IDMirovinskiStup, item.IDPoticanjeZaposljavanja, item.PrvoZaposlenje);
    			}
    
    			public ObjectResult<Model.Data.DoprinosDohodak> InsertResult(Model.Data.Item.DoprinosDohodakItem item)
    			{
    				return _context.USP_DoprinosDohodak_INSERT(item.ID_DoprinosDohodakVr, item.ID_Davanje, item.DatumOd, item.DatumDo, item.Stopa, item.IzBruto, item.IDMirovinskiStup, item.IDPoticanjeZaposljavanja, item.PrvoZaposlenje);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_DoprinosDohodak)
    			{
    				_context.USP_DoprinosDohodak_SELECT(ID_DoprinosDohodak);
    			}
    
    					
    			public ObjectResult<Model.Data.DoprinosDohodak> SelectResult(Nullable<long> ID_DoprinosDohodak)
            	{
                	return _context.USP_DoprinosDohodak_SELECT(ID_DoprinosDohodak);
            	}			
    				
    			public void Update(Model.Data.Item.DoprinosDohodakItem item)
    			{
    				_context.USP_DoprinosDohodak_UPDATE(item.ID_DoprinosDohodak, item.ID_DoprinosDohodakVr, item.ID_Davanje, item.DatumOd, item.DatumDo, item.Stopa, item.IzBruto, item.IDMirovinskiStup, item.IDPoticanjeZaposljavanja, item.PrvoZaposlenje);
    			}
    
    					
    			public ObjectResult<Model.Data.DoprinosDohodak> UpdateResult(Model.Data.Item.DoprinosDohodakItem item)
    			{
    				return _context.USP_DoprinosDohodak_UPDATE(item.ID_DoprinosDohodak, item.ID_DoprinosDohodakVr, item.ID_Davanje, item.DatumOd, item.DatumDo, item.Stopa, item.IzBruto, item.IDMirovinskiStup, item.IDPoticanjeZaposljavanja, item.PrvoZaposlenje);
    			}
    										
    		
    #endregion
    	
    }
    
}