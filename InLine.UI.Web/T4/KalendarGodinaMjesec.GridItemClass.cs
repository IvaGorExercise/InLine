//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.UI.Web.T4.GridFormattedTemplate.AtributClass
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
    
    
    public static class KalendarGodinaMjesec
    {
    	
    
    	public static class Godina
    	{
    		public const string Item = "Godina";
    		  public const string DisplayName = "Godina";
    				public const string Required = "*";
    		public const string Formatter = "$.GodinaFormatter";
    		public const string Sortable = "Godina";
    	}
    
    
    	public static class Mjesec
    	{
    		public const string Item = "Mjesec";
    		  public const string DisplayName = "Mjesec";
    				public const string Required = "*";
    		public const string Formatter = "$.MjesecFormatter";
    		public const string Sortable = "Mjesec";
    	}
    
    
    	public static class Odabir
    	{
    		public const string Item = "Odabir";
    	  public const string DisplayName = "Odabir"; 
    			public const string Formatter = "$.OdabirFormatter";
    		public const string Sortable = "Odabir";
    	}
    
    
    }
}