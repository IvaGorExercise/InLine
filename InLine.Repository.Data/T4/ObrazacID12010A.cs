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
    
    public partial class ObrazacID12010A
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public ObrazacID12010A(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ObrazacID12010AItem item)
    			{
    				_context.USP_ObrazacID12010A_DELETE(item.ID_ObrazacID12010A);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacID12010AItem item)
    			{
    				return _context.USP_ObrazacID12010A_DELETE(item.ID_ObrazacID12010A);
    			}	
    									
    			public void Insert(Model.Data.Item.ObrazacID12010AItem item)
    			{
    				_context.USP_ObrazacID12010A_INSERT(item.ID_ObrazacID1, item.Naziv, item.Adresa, item.OIB, item.IsplataPrimitak, item.UplataDoprinos, item.UplataDoprinosMIO1, item.UplataDoprinosMIO2, item.UplataDoprinosOstaloIz, item.UplataDohodak, item.UplataOsobniOdbitak, item.UplataPoreznaOsnova, item.ObracunPorezPrirez, item.ObracunPorez, item.ObracunPrirez, item.UplataPorezPrirez, item.BrojPrimatelja, item.ObracunDoprinosMIO1, item.ObracunDoprinosStaz1, item.ObracunDoprinosMIO2, item.ObracunDoprinosStaz2, item.ObracunDoprinosZdravstvo, item.ObracunDoprinosZdravstvoRad, item.ObracunDoprinosZdravstvoIno, item.ObracunDoprinosZaposljavanje, item.ObracunDoprinosZaposljavanjeInv, item.BrojOsiguranihOsoba);
    			}
    
    			public ObjectResult<Model.Data.ObrazacID12010A> InsertResult(Model.Data.Item.ObrazacID12010AItem item)
    			{
    				return _context.USP_ObrazacID12010A_INSERT(item.ID_ObrazacID1, item.Naziv, item.Adresa, item.OIB, item.IsplataPrimitak, item.UplataDoprinos, item.UplataDoprinosMIO1, item.UplataDoprinosMIO2, item.UplataDoprinosOstaloIz, item.UplataDohodak, item.UplataOsobniOdbitak, item.UplataPoreznaOsnova, item.ObracunPorezPrirez, item.ObracunPorez, item.ObracunPrirez, item.UplataPorezPrirez, item.BrojPrimatelja, item.ObracunDoprinosMIO1, item.ObracunDoprinosStaz1, item.ObracunDoprinosMIO2, item.ObracunDoprinosStaz2, item.ObracunDoprinosZdravstvo, item.ObracunDoprinosZdravstvoRad, item.ObracunDoprinosZdravstvoIno, item.ObracunDoprinosZaposljavanje, item.ObracunDoprinosZaposljavanjeInv, item.BrojOsiguranihOsoba);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ObrazacID12010A)
    			{
    				_context.USP_ObrazacID12010A_SELECT(ID_ObrazacID12010A);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacID12010A> SelectResult(Nullable<long> ID_ObrazacID12010A)
            	{
                	return _context.USP_ObrazacID12010A_SELECT(ID_ObrazacID12010A);
            	}			
    				
    			public void Update(Model.Data.Item.ObrazacID12010AItem item)
    			{
    				_context.USP_ObrazacID12010A_UPDATE(item.ID_ObrazacID12010A, item.ID_ObrazacID1, item.Naziv, item.Adresa, item.OIB, item.IsplataPrimitak, item.UplataDoprinos, item.UplataDoprinosMIO1, item.UplataDoprinosMIO2, item.UplataDoprinosOstaloIz, item.UplataDohodak, item.UplataOsobniOdbitak, item.UplataPoreznaOsnova, item.ObracunPorezPrirez, item.ObracunPorez, item.ObracunPrirez, item.UplataPorezPrirez, item.BrojPrimatelja, item.ObracunDoprinosMIO1, item.ObracunDoprinosStaz1, item.ObracunDoprinosMIO2, item.ObracunDoprinosStaz2, item.ObracunDoprinosZdravstvo, item.ObracunDoprinosZdravstvoRad, item.ObracunDoprinosZdravstvoIno, item.ObracunDoprinosZaposljavanje, item.ObracunDoprinosZaposljavanjeInv, item.BrojOsiguranihOsoba);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacID12010A> UpdateResult(Model.Data.Item.ObrazacID12010AItem item)
    			{
    				return _context.USP_ObrazacID12010A_UPDATE(item.ID_ObrazacID12010A, item.ID_ObrazacID1, item.Naziv, item.Adresa, item.OIB, item.IsplataPrimitak, item.UplataDoprinos, item.UplataDoprinosMIO1, item.UplataDoprinosMIO2, item.UplataDoprinosOstaloIz, item.UplataDohodak, item.UplataOsobniOdbitak, item.UplataPoreznaOsnova, item.ObracunPorezPrirez, item.ObracunPorez, item.ObracunPrirez, item.UplataPorezPrirez, item.BrojPrimatelja, item.ObracunDoprinosMIO1, item.ObracunDoprinosStaz1, item.ObracunDoprinosMIO2, item.ObracunDoprinosStaz2, item.ObracunDoprinosZdravstvo, item.ObracunDoprinosZdravstvoRad, item.ObracunDoprinosZdravstvoIno, item.ObracunDoprinosZaposljavanje, item.ObracunDoprinosZaposljavanjeInv, item.BrojOsiguranihOsoba);
    			}
    										
    		
    #endregion
    	
    }
    
}
