//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data.Item
{
    using System;
    using System.Collections.Generic;
    
    public partial class DohodakPrimitakItem 
    {
    
    	public DohodakPrimitakItem() {}
    	public DohodakPrimitakItem(long? id_DohodakPrimitak)
    	{
    		ID_DohodakPrimitak = id_DohodakPrimitak;
    	}
    
        public long? ID
    	{
    		get { return this.ID_DohodakPrimitak; }
    		set { this.ID_DohodakPrimitak = value; }
    	}
        public long? ID_DohodakPrimitak { get; set; }
        public long? ID_Dohodak { get; set; }
        public long? ID_Primitak { get; set; }
        public decimal? IznosBruto { get; set; }
        public decimal? IznosDoprinosIz { get; set; }
        public decimal? IznosDohodak { get; set; }
        public decimal? IznosPorezOsnova { get; set; }
        public decimal? IznosPorez { get; set; }
        public decimal? IznosPrirez { get; set; }
        public decimal? IznosNeto { get; set; }
        public decimal? IznosNaknada { get; set; }
    
    	public DohodakPrimitakItem(Model.Data.DohodakPrimitak item)
    	{
    	    this.ID_DohodakPrimitak = item.ID_DohodakPrimitak;
        this.ID_Dohodak = item.ID_Dohodak;
        this.ID_Primitak = item.ID_Primitak;
        this.IznosBruto = item.IznosBruto;
        this.IznosDoprinosIz = item.IznosDoprinosIz;
        this.IznosDohodak = item.IznosDohodak;
        this.IznosPorezOsnova = item.IznosPorezOsnova;
        this.IznosPorez = item.IznosPorez;
        this.IznosPrirez = item.IznosPrirez;
        this.IznosNeto = item.IznosNeto;
        this.IznosNaknada = item.IznosNaknada;
    	}
    
    	public DohodakPrimitakItem(dynamic item)
    	{
    	    this.ID_DohodakPrimitak = item.ID_DohodakPrimitak;
        this.ID_Dohodak = item.ID_Dohodak;
        this.ID_Primitak = item.ID_Primitak;
        this.IznosBruto = item.IznosBruto;
        this.IznosDoprinosIz = item.IznosDoprinosIz;
        this.IznosDohodak = item.IznosDohodak;
        this.IznosPorezOsnova = item.IznosPorezOsnova;
        this.IznosPorez = item.IznosPorez;
        this.IznosPrirez = item.IznosPrirez;
        this.IznosNeto = item.IznosNeto;
        this.IznosNaknada = item.IznosNaknada;
    	}
    }
}
