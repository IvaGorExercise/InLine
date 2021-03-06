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
    
    
    public static class Mjesto
    {
    	
    
    	public static class ID_Mjesto
    	{
    		public const string Item = "ID_Mjesto";
    		  public const string DisplayName = "ID_Mjesto";
    				public const string Required = "*";
     
      		public const string Formatter = "$.ID_MjestoFormatter";
    		public const string Sortable = "ID_Mjesto";
    	}
    
    
    	public static class Oznaka
    	{
    		public const string Item = "Oznaka";
    		  public const string DisplayName = "Oznaka";
    			public const string StringLength = "Najveći broj znakova je 20";
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
    
    
    	public static class NazivAlt
    	{
    		public const string Item = "NazivAlt";
    		  public const string DisplayName = "NazivAlt";
    			public const string StringLength = "Najveći broj znakova je 255";
    		public const string Formatter = "$.NazivAltFormatter";
    		public const string Sortable = "NazivAlt";
    	}
    
    
    	public static class NazivHPT
    	{
    		public const string Item = "NazivHPT";
    		  public const string DisplayName = "NazivHPT";
    			public const string StringLength = "Najveći broj znakova je 255";
    		public const string Formatter = "$.NazivHPTFormatter";
    		public const string Sortable = "NazivHPT";
    	}
    
    
    	public static class StaroMjesto
    	{
    		public const string Item = "StaroMjesto";
    		  public const string DisplayName = "StaroMjesto";
    				public const string Required = "*";
    		public const string Formatter = "$.StaroMjestoFormatter";
    		public const string Sortable = "StaroMjesto";
    	}
    
    
    	public static class NeOK
    	{
    		public const string Item = "NeOK";
    		  public const string DisplayName = "NeOK";
    				public const string Required = "*";
    		public const string Formatter = "$.NeOKFormatter";
    		public const string Sortable = "NeOK";
    	}
    
    
    	public static class NePosta
    	{
    		public const string Item = "NePosta";
    		  public const string DisplayName = "NePosta";
    				public const string Required = "*";
    		public const string Formatter = "$.NePostaFormatter";
    		public const string Sortable = "NePosta";
    	}
    
    
    	public static class Opis
    	{
    		public const string Item = "Opis";
    		  public const string DisplayName = "Opis";
    			public const string StringLength = "Najveći broj znakova je 255";
    		public const string Required = "*";
    		public const string Formatter = "$.OpisFormatter";
    		public const string Sortable = "Opis";
    	}
    
    
    	public static class StsMjesto
    	{
    		public const string Item = "StsMjesto";
    		  public const string DisplayName = "StsMjesto";
    			public const string StringLength = "Najveći broj znakova je 1";
    		public const string Formatter = "$.StsMjestoFormatter";
    		public const string Sortable = "StsMjesto";
    	}
    
    
    	public static class IzborMjesto
    	{
    		public const string Item = "IzborMjesto";
    		  public const string DisplayName = "IzborMjesto";
    				public const string Required = "*";
    		public const string Formatter = "$.IzborMjestoFormatter";
    		public const string Sortable = "IzborMjesto";
    	}
    
    
    	public static class MBr
    	{
    		public const string Item = "MBr";
    		  public const string DisplayName = "MBr";
    			public const string StringLength = "Najveći broj znakova je 20";
    		public const string Formatter = "$.MBrFormatter";
    		public const string Sortable = "MBr";
    	}
    
    
    	public static class PathSlika
    	{
    		public const string Item = "PathSlika";
    		  public const string DisplayName = "PathSlika";
    			public const string StringLength = "Najveći broj znakova je 255";
    		public const string Formatter = "$.PathSlikaFormatter";
    		public const string Sortable = "PathSlika";
    	}
    
    
    	public static class PathPlan
    	{
    		public const string Item = "PathPlan";
    		  public const string DisplayName = "PathPlan";
    			public const string StringLength = "Najveći broj znakova je 255";
    		public const string Formatter = "$.PathPlanFormatter";
    		public const string Sortable = "PathPlan";
    	}
    
    
    	public static class PathSlika2
    	{
    		public const string Item = "PathSlika2";
    		  public const string DisplayName = "PathSlika2";
    			public const string StringLength = "Najveći broj znakova je 255";
    		public const string Formatter = "$.PathSlika2Formatter";
    		public const string Sortable = "PathSlika2";
    	}
    
    
    	public static class ID_MjestoTip
    	{
    		public const string Item = "ID_MjestoTip";
    		  public const string DisplayName = "ID_MjestoTip";
    				public const string Formatter = "$.ID_MjestoTipFormatter";
    		public const string Sortable = "ID_MjestoTip";
    	}
    
    
    	public static class ID_Opcina
    	{
    		public const string Item = "ID_Opcina";
    		  public const string DisplayName = "ID_Opcina";
    				public const string Formatter = "$.ID_OpcinaFormatter";
    		public const string Sortable = "ID_Opcina";
    	}
    
    
    	public static class IDDrzava
    	{
    		public const string Item = "IDDrzava";
    	  public const string DisplayName = "IDDrzava"; 
    		public const string StringLength = "Najveći broj znakova je 2";
    		public const string Formatter = "$.IDDrzavaFormatter";
    		public const string Sortable = "IDDrzava";
    	}
    
    
    	public static class Opcina
    	{
    		public const string Item = "Opcina";
    		  public const string DisplayName = "Opcina";
    			public const string StringLength = "Najveći broj znakova je 255";
    		public const string Formatter = "$.OpcinaFormatter";
    		public const string Sortable = "Opcina";
    	}
    
    
    	public static class Zupanija
    	{
    		public const string Item = "Zupanija";
    		  public const string DisplayName = "Zupanija";
    			public const string StringLength = "Najveći broj znakova je 255";
    		public const string Formatter = "$.ZupanijaFormatter";
    		public const string Sortable = "Zupanija";
    	}
    
    
    }
}
