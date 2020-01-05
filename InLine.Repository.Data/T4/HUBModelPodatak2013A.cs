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
    
    public partial class HUBModelPodatak2013A
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public HUBModelPodatak2013A(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.HUBModelPodatak2013AItem item)
    			{
    				_context.USP_HUBModelPodatak2013A_DELETE(item.IDHUBModelPodatak2013A);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.HUBModelPodatak2013AItem item)
    			{
    				return _context.USP_HUBModelPodatak2013A_DELETE(item.IDHUBModelPodatak2013A);
    			}	
    									
    			public void Insert(Model.Data.Item.HUBModelPodatak2013AItem item)
    			{
    				_context.USP_HUBModelPodatak2013A_INSERT(item.IDHUBModelPodatak2013A, item.IDHUBModel2013A, item.Oznaka, item.Naziv, item.Fiksni, item.ZnamenkaMin, item.ZnamenkaMax, item.KontrolaZajedno, item.PozicijaMin, item.PozicijaMax, item.Koristi, item.ImaKontrola);
    			}
    
    			public ObjectResult<Model.Data.HUBModelPodatak2013A> InsertResult(Model.Data.Item.HUBModelPodatak2013AItem item)
    			{
    				return _context.USP_HUBModelPodatak2013A_INSERT(item.IDHUBModelPodatak2013A, item.IDHUBModel2013A, item.Oznaka, item.Naziv, item.Fiksni, item.ZnamenkaMin, item.ZnamenkaMax, item.KontrolaZajedno, item.PozicijaMin, item.PozicijaMax, item.Koristi, item.ImaKontrola);
    			}	
    									
    				
    			public void Select(Nullable<int> IDHUBModelPodatak2013A)
    			{
    				_context.USP_HUBModelPodatak2013A_SELECT(IDHUBModelPodatak2013A);
    			}
    
    					
    			public ObjectResult<Model.Data.HUBModelPodatak2013A> SelectResult(Nullable<int> IDHUBModelPodatak2013A)
            	{
                	return _context.USP_HUBModelPodatak2013A_SELECT(IDHUBModelPodatak2013A);
            	}			
    				
    			public void Update(Model.Data.Item.HUBModelPodatak2013AItem item)
    			{
    				_context.USP_HUBModelPodatak2013A_UPDATE(item.IDHUBModelPodatak2013A, item.IDHUBModel2013A, item.Oznaka, item.Naziv, item.Fiksni, item.ZnamenkaMin, item.ZnamenkaMax, item.KontrolaZajedno, item.PozicijaMin, item.PozicijaMax, item.Koristi, item.ImaKontrola);
    			}
    
    					
    			public ObjectResult<Model.Data.HUBModelPodatak2013A> UpdateResult(Model.Data.Item.HUBModelPodatak2013AItem item)
    			{
    				return _context.USP_HUBModelPodatak2013A_UPDATE(item.IDHUBModelPodatak2013A, item.IDHUBModel2013A, item.Oznaka, item.Naziv, item.Fiksni, item.ZnamenkaMin, item.ZnamenkaMax, item.KontrolaZajedno, item.PozicijaMin, item.PozicijaMax, item.Koristi, item.ImaKontrola);
    			}
    										
    		
    #endregion
    	
    }
    
}