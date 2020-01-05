//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.UI.Web.T4.FormFormattedTemplate
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
    
    
    public partial class KnjigaOSFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.KnjigaOS.ID_KnjigaOS.Required)]
    	[DisplayName(AtributClass.KnjigaOS.ID_KnjigaOS.DisplayName)]
        	public long ID_KnjigaOS { get; set; }
    
    	[DisplayName(AtributClass.KnjigaOS.ID_Zapis.DisplayName)]
       	public Nullable<long> ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.KnjigaOS.ID_PoslovniSubjekt.Required)]
    	[DisplayName(AtributClass.KnjigaOS.ID_PoslovniSubjekt.DisplayName)]
       	public long ID_PoslovniSubjekt { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public KnjigaOSFormFormattedBase()
        { }
    	
    	public KnjigaOSFormFormattedBase(Model.Data.KnjigaOS formformated)
    	{
    	    this.ID_KnjigaOS = formformated.ID_KnjigaOS;
    	    this.ID_Zapis = formformated.ID_Zapis;
    	    this.ID_PoslovniSubjekt = formformated.ID_PoslovniSubjekt;
    	}
    
    	/*
    	    mymodel.ID_KnjigaOS = model.ID_KnjigaOS;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.ID_PoslovniSubjekt = model.ID_PoslovniSubjekt;
    		
    	*/
    
    		#endregion
    	
    }
}