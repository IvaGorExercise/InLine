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
    
    
    public static class ZapisRacunUlaz
    {
    	
    
    	public static class ID_Zapis
    	{
    		public const string Item = "ID_Zapis";
    	  public const string DisplayName = "ID_Zapis"; 
    			public const string Required = "*";
    		public const string Formatter = "$.ID_ZapisFormatter";
    		public const string Sortable = "ID_Zapis";
    	}
    
    
    	public static class IDZapisTablica
    	{
    		public const string Item = "IDZapisTablica";
    	  public const string DisplayName = "IDZapisTablica"; 
    			public const string Required = "*";
    		public const string Formatter = "$.IDZapisTablicaFormatter";
    		public const string Sortable = "IDZapisTablica";
    	}
    
    
    	public static class IDZapisVr
    	{
    		public const string Item = "IDZapisVr";
    	  public const string DisplayName = "IDZapisVr"; 
    			public const string Formatter = "$.IDZapisVrFormatter";
    		public const string Sortable = "IDZapisVr";
    	}
    
    
    	public static class IDZapis
    	{
    		public const string Item = "IDZapis";
    	  public const string DisplayName = "IDZapis"; 
    			public const string Required = "*";
    		public const string Formatter = "$.IDZapisFormatter";
    		public const string Sortable = "IDZapis";
    	}
    
    
    	public static class VrijemeUpis
    	{
    		public const string Item = "VrijemeUpis";
    	  public const string DisplayName = "VrijemeUpis"; 
    			public const string Formatter = "$.VrijemeUpisFormatter";
    		public const string Sortable = "VrijemeUpis";
    	}
    
    
    	public static class UrudzbeniBroj
    	{
    		public const string Item = "UrudzbeniBroj";
    	  public const string DisplayName = "UrudzbeniBroj"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Formatter = "$.UrudzbeniBrojFormatter";
    		public const string Sortable = "UrudzbeniBroj";
    	}
    
    
    	public static class Predmet
    	{
    		public const string Item = "Predmet";
    	  public const string DisplayName = "Predmet"; 
    		public const string StringLength = "Najveći broj znakova je 255";
    		public const string Formatter = "$.PredmetFormatter";
    		public const string Sortable = "Predmet";
    	}
    
    
    	public static class ID_Subjekt
    	{
    		public const string Item = "ID_Subjekt";
    	  public const string DisplayName = "ID_Subjekt"; 
    			public const string Formatter = "$.ID_SubjektFormatter";
    		public const string Sortable = "ID_Subjekt";
    	}
    
    
    	public static class ID_SubjektUpis
    	{
    		public const string Item = "ID_SubjektUpis";
    	  public const string DisplayName = "ID_SubjektUpis"; 
    			public const string Formatter = "$.ID_SubjektUpisFormatter";
    		public const string Sortable = "ID_SubjektUpis";
    	}
    
    
    	public static class ID_Temeljnica
    	{
    		public const string Item = "ID_Temeljnica";
    	  public const string DisplayName = "ID_Temeljnica"; 
    			public const string Formatter = "$.ID_TemeljnicaFormatter";
    		public const string Sortable = "ID_Temeljnica";
    	}
    
    
    	public static class Broj
    	{
    		public const string Item = "Broj";
    	  public const string DisplayName = "Broj"; 
    		public const string StringLength = "Najveći broj znakova je 50";
    		public const string Formatter = "$.BrojFormatter";
    		public const string Sortable = "Broj";
    	}
    
    
    	public static class Datum
    	{
    		public const string Item = "Datum";
    	  public const string DisplayName = "Datum"; 
    			public const string Formatter = "$.DatumFormatter";
    		public const string Sortable = "Datum";
    	}
    
    
    	public static class Vrijeme
    	{
    		public const string Item = "Vrijeme";
    	  public const string DisplayName = "Vrijeme"; 
    			public const string Formatter = "$.VrijemeFormatter";
    		public const string Sortable = "Vrijeme";
    	}
    
    
    	public static class TablicaNaziv
    	{
    		public const string Item = "TablicaNaziv";
    	  public const string DisplayName = "TablicaNaziv"; 
    		public const string StringLength = "Najveći broj znakova je 128";
    		public const string Required = "*";
    		public const string Formatter = "$.TablicaNazivFormatter";
    		public const string Sortable = "TablicaNaziv";
    	}
    
    
    	public static class Naziv
    	{
    		public const string Item = "Naziv";
    	  public const string DisplayName = "Naziv"; 
    		public const string StringLength = "Najveći broj znakova je 255";
    		public const string Formatter = "$.NazivFormatter";
    		public const string Sortable = "Naziv";
    	}
    
    
    	public static class NazivKr
    	{
    		public const string Item = "NazivKr";
    	  public const string DisplayName = "NazivKr"; 
    		public const string StringLength = "Najveći broj znakova je 30";
    		public const string Formatter = "$.NazivKrFormatter";
    		public const string Sortable = "NazivKr";
    	}
    
    
    	public static class Odabir
    	{
    		public const string Item = "Odabir";
    	  public const string DisplayName = "Odabir"; 
    			public const string Formatter = "$.OdabirFormatter";
    		public const string Sortable = "Odabir";
    	}
    
    
    	public static class DatumGodina
    	{
    		public const string Item = "DatumGodina";
    	  public const string DisplayName = "DatumGodina"; 
    		public const string StringLength = "Najveći broj znakova je 4";
    		public const string Required = "*";
    		public const string Formatter = "$.DatumGodinaFormatter";
    		public const string Sortable = "DatumGodina";
    	}
    
    
    	public static class VrijemeUpisString
    	{
    		public const string Item = "VrijemeUpisString";
    	  public const string DisplayName = "VrijemeUpisString"; 
    		public const string StringLength = "Najveći broj znakova je 30";
    		public const string Formatter = "$.VrijemeUpisStringFormatter";
    		public const string Sortable = "VrijemeUpisString";
    	}
    
    
    	public static class DatumString
    	{
    		public const string Item = "DatumString";
    	  public const string DisplayName = "DatumString"; 
    		public const string StringLength = "Najveći broj znakova je 30";
    		public const string Required = "*";
    		public const string Formatter = "$.DatumStringFormatter";
    		public const string Sortable = "DatumString";
    	}
    
    
    	public static class ID_RacunUlaz
    	{
    		public const string Item = "ID_RacunUlaz";
    	  public const string DisplayName = "ID_RacunUlaz"; 
    			public const string Required = "*";
    		public const string Formatter = "$.ID_RacunUlazFormatter";
    		public const string Sortable = "ID_RacunUlaz";
    	}
    
    
    	public static class ID_ZapisRacunUlaz
    	{
    		public const string Item = "ID_ZapisRacunUlaz";
    	  public const string DisplayName = "ID_ZapisRacunUlaz"; 
    			public const string Formatter = "$.ID_ZapisRacunUlazFormatter";
    		public const string Sortable = "ID_ZapisRacunUlaz";
    	}
    
    
    	public static class ID_PoslovniSubjekt
    	{
    		public const string Item = "ID_PoslovniSubjekt";
    	  public const string DisplayName = "ID_PoslovniSubjekt"; 
    			public const string Required = "*";
    		public const string Formatter = "$.ID_PoslovniSubjektFormatter";
    		public const string Sortable = "ID_PoslovniSubjekt";
    	}
    
    
    	public static class ID_SubjektRacunUlaz
    	{
    		public const string Item = "ID_SubjektRacunUlaz";
    	  public const string DisplayName = "ID_SubjektRacunUlaz"; 
    			public const string Required = "*";
    		public const string Formatter = "$.ID_SubjektRacunUlazFormatter";
    		public const string Sortable = "ID_SubjektRacunUlaz";
    	}
    
    
    }
}
