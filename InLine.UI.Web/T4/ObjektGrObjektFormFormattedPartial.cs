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
    
    
    public partial class ObjektGrObjektFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ObjektGrObjekt.ID_ObjektGrObjekt.Required)]
    	[DisplayName(AtributClass.ObjektGrObjekt.ID_ObjektGrObjekt.DisplayName)]
        	public long ID_ObjektGrObjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObjektGrObjekt.ID_ObjektGr.Required)]
    	[DisplayName(AtributClass.ObjektGrObjekt.ID_ObjektGr.DisplayName)]
       	public long ID_ObjektGr { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObjektGrObjekt.ID_Objekt.Required)]
    	[DisplayName(AtributClass.ObjektGrObjekt.ID_Objekt.DisplayName)]
       	public long ID_Objekt { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ObjektGrObjektFormFormattedBase()
        { }
    	
    	public ObjektGrObjektFormFormattedBase(Model.Data.ObjektGrObjekt formformated)
    	{
    	    this.ID_ObjektGrObjekt = formformated.ID_ObjektGrObjekt;
    	    this.ID_ObjektGr = formformated.ID_ObjektGr;
    	    this.ID_Objekt = formformated.ID_Objekt;
    	}
    
    	/*
    	    mymodel.ID_ObjektGrObjekt = model.ID_ObjektGrObjekt;
    	    mymodel.ID_ObjektGr = model.ID_ObjektGr;
    	    mymodel.ID_Objekt = model.ID_Objekt;
    		
    	*/
    
    		#endregion
    	
    }
}
