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
    
    
    public static class PoticanjeZaposljavanja
    {
    	
    
    	public static class IDPoticanjeZaposljavanja
    	{
    		public const string Item = "IDPoticanjeZaposljavanja";
    		  public const string DisplayName = "IDPoticanjeZaposljavanja";
    				public const string Required = "*";
    		public const string Formatter = "$.IDPoticanjeZaposljavanjaFormatter";
    		public const string Sortable = "IDPoticanjeZaposljavanja";
    	}
    
    
    	public static class Oznaka
    	{
    		public const string Item = "Oznaka";
    		  public const string DisplayName = "Oznaka";
    			public const string StringLength = "Najveći broj znakova je 2";
    		public const string Required = "*";
    		public const string Formatter = "$.OznakaFormatter";
    		public const string Sortable = "Oznaka";
    	}
    
    
    	public static class Naziv
    	{
    		public const string Item = "Naziv";
    		  public const string DisplayName = "Naziv";
    			public const string StringLength = "Najveći broj znakova je 255";
    		public const string Required = "*";
    		public const string Formatter = "$.NazivFormatter";
    		public const string Sortable = "Naziv";
    	}
    
    
    	public static class NazivKr
    	{
    		public const string Item = "NazivKr";
    		  public const string DisplayName = "NazivKr";
    			public const string StringLength = "Najveći broj znakova je 30";
    		public const string Required = "*";
    		public const string Formatter = "$.NazivKrFormatter";
    		public const string Sortable = "NazivKr";
    	}
    
    
    	public static class Kratica
    	{
    		public const string Item = "Kratica";
    		  public const string DisplayName = "Kratica";
    			public const string StringLength = "Najveći broj znakova je 10";
    		public const string Required = "*";
    		public const string Formatter = "$.KraticaFormatter";
    		public const string Sortable = "Kratica";
    	}
    
    
    }
}
