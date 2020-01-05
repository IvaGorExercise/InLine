//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.UI.Web.T4.FormFormattedTemplate.View.AtributClass
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
    
    
    public static class OsobaDetalj
    {
    	
    
    	public static class ID_Osoba
    	{
    		public const string Item = "ID_Osoba";
    	  public const string DisplayName = "ID_Osoba"; 
    			public const string Required = "*";
     
      		public const string Sortable = "ID_Osoba";
    	}
    
    
    	public static class ID_Subjekt
    	{
    		public const string Item = "ID_Subjekt";
    	  public const string DisplayName = "ID_Subjekt"; 
    			public const string Sortable = "ID_Subjekt";
    	}
    
    
    	public static class Oznaka
    	{
    		public const string Item = "Oznaka";
    	  public const string DisplayName = "Oznaka"; 
    		public const string StringLength = "Najveći broj znakova je 20";
    		public const string Required = "*";
    		public const string Sortable = "Oznaka";
    	}
    
    
    	public static class Prezime
    	{
    		public const string Item = "Prezime";
    	  public const string DisplayName = "Prezime"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Required = "*";
    		public const string Sortable = "Prezime";
    	}
    
    
    	public static class Ime
    	{
    		public const string Item = "Ime";
    	  public const string DisplayName = "Ime"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Required = "*";
    		public const string Sortable = "Ime";
    	}
    
    
    	public static class DatumRodenja
    	{
    		public const string Item = "DatumRodenja";
    	  public const string DisplayName = "DatumRodenja"; 
    			public const string Required = "*";
    		public const string Sortable = "DatumRodenja";
    	}
    
    
    	public static class MjestoRodenja
    	{
    		public const string Item = "MjestoRodenja";
    	  public const string DisplayName = "MjestoRodenja"; 
    		public const string StringLength = "Najveći broj znakova je 255";
    		public const string Sortable = "MjestoRodenja";
    	}
    
    
    	public static class OtacPrezime
    	{
    		public const string Item = "OtacPrezime";
    	  public const string DisplayName = "OtacPrezime"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Sortable = "OtacPrezime";
    	}
    
    
    	public static class OtacIme
    	{
    		public const string Item = "OtacIme";
    	  public const string DisplayName = "OtacIme"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Sortable = "OtacIme";
    	}
    
    
    	public static class OtacDatumRodenja
    	{
    		public const string Item = "OtacDatumRodenja";
    	  public const string DisplayName = "OtacDatumRodenja"; 
    			public const string Sortable = "OtacDatumRodenja";
    	}
    
    
    	public static class OtacMjestoRodenja
    	{
    		public const string Item = "OtacMjestoRodenja";
    	  public const string DisplayName = "OtacMjestoRodenja"; 
    		public const string StringLength = "Najveći broj znakova je 255";
    		public const string Sortable = "OtacMjestoRodenja";
    	}
    
    
    	public static class MajkaPrezime
    	{
    		public const string Item = "MajkaPrezime";
    	  public const string DisplayName = "MajkaPrezime"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Sortable = "MajkaPrezime";
    	}
    
    
    	public static class MajkaIme
    	{
    		public const string Item = "MajkaIme";
    	  public const string DisplayName = "MajkaIme"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Sortable = "MajkaIme";
    	}
    
    
    	public static class MajkaPrezimeDjevojacko
    	{
    		public const string Item = "MajkaPrezimeDjevojacko";
    	  public const string DisplayName = "MajkaPrezimeDjevojacko"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Sortable = "MajkaPrezimeDjevojacko";
    	}
    
    
    	public static class MajkaDatumRodenja
    	{
    		public const string Item = "MajkaDatumRodenja";
    	  public const string DisplayName = "MajkaDatumRodenja"; 
    			public const string Sortable = "MajkaDatumRodenja";
    	}
    
    
    	public static class MajkaMjestoRodenja
    	{
    		public const string Item = "MajkaMjestoRodenja";
    	  public const string DisplayName = "MajkaMjestoRodenja"; 
    		public const string StringLength = "Najveći broj znakova je 255";
    		public const string Sortable = "MajkaMjestoRodenja";
    	}
    
    
    	public static class ID_Narodnost
    	{
    		public const string Item = "ID_Narodnost";
    	  public const string DisplayName = "ID_Narodnost"; 
    			public const string Sortable = "ID_Narodnost";
    	}
    
    
    	public static class ID_Drzavljanstvo
    	{
    		public const string Item = "ID_Drzavljanstvo";
    	  public const string DisplayName = "ID_Drzavljanstvo"; 
    			public const string Sortable = "ID_Drzavljanstvo";
    	}
    
    
    	public static class DatumSmrti
    	{
    		public const string Item = "DatumSmrti";
    	  public const string DisplayName = "DatumSmrti"; 
    			public const string Sortable = "DatumSmrti";
    	}
    
    
    	public static class OIB
    	{
    		public const string Item = "OIB";
    	  public const string DisplayName = "OIB"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Sortable = "OIB";
    	}
    
    
    	public static class OIBHR
    	{
    		public const string Item = "OIBHR";
    	  public const string DisplayName = "OIBHR"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Sortable = "OIBHR";
    	}
    
    
    	public static class JMBG
    	{
    		public const string Item = "JMBG";
    	  public const string DisplayName = "JMBG"; 
    		public const string StringLength = "Najveći broj znakova je 13";
    		public const string Sortable = "JMBG";
    	}
    
    
    }
}
