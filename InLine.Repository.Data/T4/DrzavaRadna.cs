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
    
    public partial class DrzavaRadna
    {
    	#region Fields
        
    	public Model.Data.Context _context;
        
    	#endregion
    
    
    
        #region Constructors
        
    	public DrzavaRadna(string connstring)
        {
            _context = new Model.Data.Context(connstring);
        }
        
    	#endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DrzavaRadnaItem item)
    			{
    				_context.USP_DrzavaRadna_DELETE(item.ID_Drzava);
    			}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DrzavaRadnaItem item)
    			{
    				return _context.USP_DrzavaRadna_DELETE(item.ID_Drzava);
    			}	
    									
    			public void Insert(Model.Data.Item.DrzavaRadnaItem item)
    			{
    				_context.USP_DrzavaRadna_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.NazivEn, item.NazivFr, item.Kod, item.Teritorij, item.ID_DrzavaNad, item.SifDrzava, item.OznDrzava, item.ISO3166, item.FIPS104, item.Internet, item.OznHr, item.OznEng, item.NazivHr, item.NazivHrDugi, item.NazivEng, item.NazivEngDugi, item.NazivLokal, item.NazivLokalDugi, item.NazivStariHr, item.NazivStariEng, item.Kratica1, item.Nacija, item.Obuhvat, item.Napomena, item.Komentar, item.StsDrzava, item.IzborDrzava, item.ZastavaV, item.ZastavaM, item.ZastavaMPath, item.ZastavaVPath, item.GrbV, item.GrbM, item.GrbVPath, item.GrbMPath, item.KartaV, item.KartaM, item.KartaMPath, item.KartaVPath, item.DrzavaHtml1, item.DrzavaHtml2, item.DrzavaHtml3, item.DrzavaHtml4);
    			}
    
    			public ObjectResult<Model.Data.DrzavaRadna> InsertResult(Model.Data.Item.DrzavaRadnaItem item)
    			{
    				return _context.USP_DrzavaRadna_INSERT(item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.NazivEn, item.NazivFr, item.Kod, item.Teritorij, item.ID_DrzavaNad, item.SifDrzava, item.OznDrzava, item.ISO3166, item.FIPS104, item.Internet, item.OznHr, item.OznEng, item.NazivHr, item.NazivHrDugi, item.NazivEng, item.NazivEngDugi, item.NazivLokal, item.NazivLokalDugi, item.NazivStariHr, item.NazivStariEng, item.Kratica1, item.Nacija, item.Obuhvat, item.Napomena, item.Komentar, item.StsDrzava, item.IzborDrzava, item.ZastavaV, item.ZastavaM, item.ZastavaMPath, item.ZastavaVPath, item.GrbV, item.GrbM, item.GrbVPath, item.GrbMPath, item.KartaV, item.KartaM, item.KartaMPath, item.KartaVPath, item.DrzavaHtml1, item.DrzavaHtml2, item.DrzavaHtml3, item.DrzavaHtml4);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_Drzava)
    			{
    				_context.USP_DrzavaRadna_SELECT(ID_Drzava);
    			}
    
    					
    			public ObjectResult<Model.Data.DrzavaRadna> SelectResult(Nullable<long> ID_Drzava)
            	{
                	return _context.USP_DrzavaRadna_SELECT(ID_Drzava);
            	}			
    				
    			public void Update(Model.Data.Item.DrzavaRadnaItem item)
    			{
    				_context.USP_DrzavaRadna_UPDATE(item.ID_Drzava, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.NazivEn, item.NazivFr, item.Kod, item.Teritorij, item.ID_DrzavaNad, item.SifDrzava, item.OznDrzava, item.ISO3166, item.FIPS104, item.Internet, item.OznHr, item.OznEng, item.NazivHr, item.NazivHrDugi, item.NazivEng, item.NazivEngDugi, item.NazivLokal, item.NazivLokalDugi, item.NazivStariHr, item.NazivStariEng, item.Kratica1, item.Nacija, item.Obuhvat, item.Napomena, item.Komentar, item.StsDrzava, item.IzborDrzava, item.ZastavaV, item.ZastavaM, item.ZastavaMPath, item.ZastavaVPath, item.GrbV, item.GrbM, item.GrbVPath, item.GrbMPath, item.KartaV, item.KartaM, item.KartaMPath, item.KartaVPath, item.DrzavaHtml1, item.DrzavaHtml2, item.DrzavaHtml3, item.DrzavaHtml4);
    			}
    
    					
    			public ObjectResult<Model.Data.DrzavaRadna> UpdateResult(Model.Data.Item.DrzavaRadnaItem item)
    			{
    				return _context.USP_DrzavaRadna_UPDATE(item.ID_Drzava, item.Oznaka, item.Naziv, item.NazivKr, item.Kratica, item.NazivEn, item.NazivFr, item.Kod, item.Teritorij, item.ID_DrzavaNad, item.SifDrzava, item.OznDrzava, item.ISO3166, item.FIPS104, item.Internet, item.OznHr, item.OznEng, item.NazivHr, item.NazivHrDugi, item.NazivEng, item.NazivEngDugi, item.NazivLokal, item.NazivLokalDugi, item.NazivStariHr, item.NazivStariEng, item.Kratica1, item.Nacija, item.Obuhvat, item.Napomena, item.Komentar, item.StsDrzava, item.IzborDrzava, item.ZastavaV, item.ZastavaM, item.ZastavaMPath, item.ZastavaVPath, item.GrbV, item.GrbM, item.GrbVPath, item.GrbMPath, item.KartaV, item.KartaM, item.KartaMPath, item.KartaVPath, item.DrzavaHtml1, item.DrzavaHtml2, item.DrzavaHtml3, item.DrzavaHtml4);
    			}
    										
    		
    #endregion
    	
    }
    
}
