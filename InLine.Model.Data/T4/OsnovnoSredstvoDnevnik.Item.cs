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
    
    public partial class OsnovnoSredstvoDnevnikItem 
    {
    
    	public OsnovnoSredstvoDnevnikItem() {}
    	public OsnovnoSredstvoDnevnikItem(long? id_OsnovnoSredstvoDnevnik)
    	{
    		ID_OsnovnoSredstvoDnevnik = id_OsnovnoSredstvoDnevnik;
    	}
    
        public long? ID
    	{
    		get { return this.ID_OsnovnoSredstvoDnevnik; }
    		set { this.ID_OsnovnoSredstvoDnevnik = value; }
    	}
        public long? ID_OsnovnoSredstvoDnevnik { get; set; }
        public long? ID_OsnovnoSredstvo { get; set; }
        public int? IDOsnovnoSredstvoDogadaj { get; set; }
    
    	public OsnovnoSredstvoDnevnikItem(Model.Data.OsnovnoSredstvoDnevnik item)
    	{
    	    this.ID_OsnovnoSredstvoDnevnik = item.ID_OsnovnoSredstvoDnevnik;
        this.ID_OsnovnoSredstvo = item.ID_OsnovnoSredstvo;
        this.IDOsnovnoSredstvoDogadaj = item.IDOsnovnoSredstvoDogadaj;
    	}
    
    	public OsnovnoSredstvoDnevnikItem(dynamic item)
    	{
    	    this.ID_OsnovnoSredstvoDnevnik = item.ID_OsnovnoSredstvoDnevnik;
        this.ID_OsnovnoSredstvo = item.ID_OsnovnoSredstvo;
        this.IDOsnovnoSredstvoDogadaj = item.IDOsnovnoSredstvoDogadaj;
    	}
    }
}