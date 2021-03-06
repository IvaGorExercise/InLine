//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.UI.Web.T4.GridFormattedTemplate.View.AtributClass
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
    
    
    public static class Osoba
    {
    	
    
    	public static class ID_Osoba
    	{
    		public const string Item = "ID_Osoba";
    	  public const string DisplayName = "ID_Osoba"; 
    			public const string Required = "*";
    		public const string Formatter = "$.ID_OsobaFormatter";
    		public const string Sortable = "ID_Osoba";
    	}
    
    
    	public static class ID_Subjekt
    	{
    		public const string Item = "ID_Subjekt";
    	  public const string DisplayName = "ID_Subjekt"; 
    			public const string Formatter = "$.ID_SubjektFormatter";
    		public const string Sortable = "ID_Subjekt";
    	}
    
    
    	public static class Prezime
    	{
    		public const string Item = "Prezime";
    	  public const string DisplayName = "Prezime"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Required = "*";
    		public const string Formatter = "$.PrezimeFormatter";
    		public const string Sortable = "Prezime";
    	}
    
    
    	public static class Ime
    	{
    		public const string Item = "Ime";
    	  public const string DisplayName = "Ime"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Required = "*";
    		public const string Formatter = "$.ImeFormatter";
    		public const string Sortable = "Ime";
    	}
    
    
    	public static class DatumRodenja
    	{
    		public const string Item = "DatumRodenja";
    	  public const string DisplayName = "DatumRodenja"; 
    			public const string Required = "*";
    		public const string Formatter = "$.DatumRodenjaFormatter";
    		public const string Sortable = "DatumRodenja";
    	}
    
    
    	public static class MjestoRodenja
    	{
    		public const string Item = "MjestoRodenja";
    	  public const string DisplayName = "MjestoRodenja"; 
    		public const string StringLength = "Najveći broj znakova je 255";
    		public const string Formatter = "$.MjestoRodenjaFormatter";
    		public const string Sortable = "MjestoRodenja";
    	}
    
    
    	public static class ID_Narodnost
    	{
    		public const string Item = "ID_Narodnost";
    	  public const string DisplayName = "ID_Narodnost"; 
    			public const string Formatter = "$.ID_NarodnostFormatter";
    		public const string Sortable = "ID_Narodnost";
    	}
    
    
    	public static class ID_Drzavljanstvo
    	{
    		public const string Item = "ID_Drzavljanstvo";
    	  public const string DisplayName = "ID_Drzavljanstvo"; 
    			public const string Formatter = "$.ID_DrzavljanstvoFormatter";
    		public const string Sortable = "ID_Drzavljanstvo";
    	}
    
    
    	public static class OIB
    	{
    		public const string Item = "OIB";
    	  public const string DisplayName = "OIB"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Formatter = "$.OIBFormatter";
    		public const string Sortable = "OIB";
    	}
    
    
    	public static class OIBHR
    	{
    		public const string Item = "OIBHR";
    	  public const string DisplayName = "OIBHR"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Formatter = "$.OIBHRFormatter";
    		public const string Sortable = "OIBHR";
    	}
    
    
    	public static class OtacIme
    	{
    		public const string Item = "OtacIme";
    	  public const string DisplayName = "OtacIme"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Formatter = "$.OtacImeFormatter";
    		public const string Sortable = "OtacIme";
    	}
    
    
    	public static class MajkaPrezime
    	{
    		public const string Item = "MajkaPrezime";
    	  public const string DisplayName = "MajkaPrezime"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Formatter = "$.MajkaPrezimeFormatter";
    		public const string Sortable = "MajkaPrezime";
    	}
    
    
    	public static class MajkaIme
    	{
    		public const string Item = "MajkaIme";
    	  public const string DisplayName = "MajkaIme"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Formatter = "$.MajkaImeFormatter";
    		public const string Sortable = "MajkaIme";
    	}
    
    
    	public static class MajkaPrezimeDjevojacko
    	{
    		public const string Item = "MajkaPrezimeDjevojacko";
    	  public const string DisplayName = "MajkaPrezimeDjevojacko"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Formatter = "$.MajkaPrezimeDjevojackoFormatter";
    		public const string Sortable = "MajkaPrezimeDjevojacko";
    	}
    
    
    	public static class NazivDrzavljanstvo
    	{
    		public const string Item = "NazivDrzavljanstvo";
    	  public const string DisplayName = "NazivDrzavljanstvo"; 
    		public const string StringLength = "Najveći broj znakova je 255";
    		public const string Formatter = "$.NazivDrzavljanstvoFormatter";
    		public const string Sortable = "NazivDrzavljanstvo";
    	}
    
    
    	public static class NazivNarodnost
    	{
    		public const string Item = "NazivNarodnost";
    	  public const string DisplayName = "NazivNarodnost"; 
    		public const string StringLength = "Najveći broj znakova je 255";
    		public const string Formatter = "$.NazivNarodnostFormatter";
    		public const string Sortable = "NazivNarodnost";
    	}
    
    
    	public static class ID_PoslovniSubjekt
    	{
    		public const string Item = "ID_PoslovniSubjekt";
    	  public const string DisplayName = "ID_PoslovniSubjekt"; 
    			public const string Formatter = "$.ID_PoslovniSubjektFormatter";
    		public const string Sortable = "ID_PoslovniSubjekt";
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
    
    
    	public static class JMBG
    	{
    		public const string Item = "JMBG";
    	  public const string DisplayName = "JMBG"; 
    		public const string StringLength = "Najveći broj znakova je 13";
    		public const string Formatter = "$.JMBGFormatter";
    		public const string Sortable = "JMBG";
    	}
    
    
    }
}
