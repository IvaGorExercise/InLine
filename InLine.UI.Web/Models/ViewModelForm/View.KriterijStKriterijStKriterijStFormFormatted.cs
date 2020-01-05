
namespace InLine.UI.Web.T4.FormFormattedTemplate.View
{

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Web;
    using System.ComponentModel;
    using Lib.Web.Mvc.JQuery.JqGrid.DataAnnotations;
    using Lib.Web.Mvc.JQuery.JqGrid;
    using System.ComponentModel.DataAnnotations;
    using Lib.Web.Mvc.JQuery.JqGrid.Constants;
    using System.Web.Mvc;
    using InLine;
    using InLine.UI.Web.T4.FormFormattedTemplate;
    using InLine.UI.Web.Helper;


    public partial class KriterijStKriterijStKriterijStFormFormatted
    {
      	#region Properities
    
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijSt.Required)]
    	[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijSt.DisplayName)]
       	public long ID_KriterijSt { get; set; }
    
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.ID_Kriterij.Required)]
    	[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.ID_Kriterij.DisplayName)]
       	public long ID_Kriterij { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.Oznaka.Required)]
    	[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.Naziv.Required)]
    	[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.NazivKr.Required)]
    	[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.Kratica.Required)]
    	[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijStKriterijSt.DisplayName)]
       	public Nullable<long> ID_KriterijStKriterijSt { get; set; }
    
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijKSKS.Required)]
    	[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijKSKS.DisplayName)]
       	public long ID_KriterijKSKS { get; set; }
    
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijStKSKS.Required)]
    	[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijStKSKS.DisplayName)]
       	public long ID_KriterijStKSKS { get; set; }
    
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijStNad.Required)]
    	[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijStNad.DisplayName)]
       	public long ID_KriterijStNad { get; set; }
    
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.Nivo.Required)]
    	[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.Nivo.DisplayName)]
       	public int Nivo { get; set; }
    
    	[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.Put.DisplayName)]
       	public string Put { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.KriterijNaziv.StringLength)]
    	[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.KriterijNaziv.DisplayName)]
       	public string KriterijNaziv { get; set; }
    
    	[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.RedniBroj.DisplayName)]
       	public Nullable<int> RedniBroj { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public KriterijStKriterijStKriterijStFormFormatted()
        { }
    	
    	public KriterijStKriterijStKriterijStFormFormatted(Model.Data.View.KriterijStKriterijStKriterijSt formformated)
    	{
    	    this.ID_KriterijSt = formformated.ID_KriterijSt;
    	    this.ID_Kriterij = formformated.ID_Kriterij;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	    this.ID_KriterijStKriterijSt = formformated.ID_KriterijStKriterijSt;
    	    this.ID_KriterijKSKS = formformated.ID_KriterijKSKS;
    	    this.ID_KriterijStKSKS = formformated.ID_KriterijStKSKS;
    	    this.ID_KriterijStNad = formformated.ID_KriterijStNad;
    	    this.Nivo = formformated.Nivo;
    	    this.Put = formformated.Put;
    	    this.KriterijNaziv = formformated.KriterijNaziv;
    	    this.RedniBroj = formformated.RedniBroj;
    	}
    
   
    		#endregion

    }
}
