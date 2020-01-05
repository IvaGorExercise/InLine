using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Data.Objects;
using InLine;
using InLine.Repository.Data.Helper;
using System.Data.SqlClient;

namespace InLine.Repository.Data
{
    public partial class Izvod
    {

       public Model.Data.Izvod InsertIzvodIzvod2012A(Glava obc, Labela lab)
        {
            Glava gl = (Glava)obc;

            String query = String.Format("BEGIN TRAN  DECLARE @ID_SubjektRacun bigint SET @ID_SubjektRacun = (SELECT ID_SubjektRacun FROM sbj.SubjektRacun WHERE Broj = @TransakcijskiRacunKlijentaBroj) " +
          " INSERT INTO hub.Izvod (IDIzvodVerzija, ID_SubjektRacun) VALUES(1, @ID_SubjektRacun) DECLARE @ID_Izvod int SET @ID_Izvod = SCOPE_IDENTITY()  " +
          " INSERT INTO hub.Izvod2012A (ID_Izvod, BankaVBDI, BankaNaziv, BankaOIB, IzvadakVr, DatumObrada, BankaBIC, Racun, IDValuta, Naziv, Sjediste, MaticniBroj, OIB, RedniBrojIzvadak, PodbrojIzvadak, DatumIzvadak, RedniBrojGrupa, VrstaIzvadak) " +
" VALUES (@ID_Izvod , @VodeciBrojBanke , @BankaNaziv , @BankaOIB , @VrstaIzvadka , @DatumObrada , @BICrojBanke, @TransakcijskiRacunKlijenta, @ValutaTransakcijskogRacuna, @NazivKlijenta, @SjedisteKlijenta, @MaticniBroj, @OIBKlijenta, @RedniBrojIzvadka, @PodbrojIzvadka, @DatumIzvadka, @RedniBrojGrupePaketa, @VrstaIzvadka)  SELECT * FROM hub.Izvod WHERE ID_Izvod = @ID_Izvod  COMMIT TRAN GO");


            string a = gl.TransakcijskiRacunKlijenta.Substring(11, (gl.TransakcijskiRacunKlijenta.Length - 11));
            SqlParameter VodeciBrojBanke = new SqlParameter("VodeciBrojBanke", gl.VodeciBrojBanke.Trim());
            SqlParameter BankaNaziv = new SqlParameter("BankaNaziv", lab.BankaNaziv.Trim());
            SqlParameter BankaOIB = new SqlParameter("BankaOIB", lab.BankaOIB.Trim());
            SqlParameter VrstaIzvadka = new SqlParameter("VrstaIzvadka", Convert.ToInt32(gl.VrstaIzvadka).ToString());
            SqlParameter DatumObrada = new SqlParameter("DatumObrada",  ConvertStringUDatumString(lab.DatumObrada).ToString());
            SqlParameter BICrojBanke = new SqlParameter("BICrojBanke",  gl.BICrojBanke.Trim());
            SqlParameter TransakcijskiRacunKlijenta = new SqlParameter("TransakcijskiRacunKlijenta", gl.TransakcijskiRacunKlijenta.Trim());
            SqlParameter ValutaTransakcijskogRacuna = new SqlParameter("ValutaTransakcijskogRacuna", gl.ValutaTransakcijskogRacuna.Trim());
            SqlParameter NazivKlijenta = new SqlParameter("NazivKlijenta", gl.NazivKlijenta.Trim());
            SqlParameter SjedisteKlijenta = new SqlParameter("SjedisteKlijenta", gl.SjedisteKlijenta.Trim());
            SqlParameter MaticniBroj = new SqlParameter("MaticniBroj", gl.MaticniBroj.Trim());
            SqlParameter OIBKlijenta = new SqlParameter("OIBKlijenta", gl.OIBKlijenta.Trim());
            SqlParameter RedniBrojIzvadka = new SqlParameter("RedniBrojIzvadka", Int32.Parse(gl.RedniBrojIzvadka).ToString());
            SqlParameter PodbrojIzvadka = new SqlParameter("PodbrojIzvadka", Int32.Parse(gl.PodbrojIzvadka).ToString());
            SqlParameter DatumIzvadka = new SqlParameter("DatumIzvadka", ConvertStringUDatumString(gl.DatumIzvadka).ToString());
            SqlParameter RedniBrojGrupePaketa = new SqlParameter("RedniBrojGrupePaketa", Int32.Parse(gl.RedniBrojGrupePaketa).ToString());
            SqlParameter TransakcijskiRacunKlijentaBroj = new SqlParameter("TransakcijskiRacunKlijentaBroj", gl.TransakcijskiRacunKlijenta.Substring(11, (gl.TransakcijskiRacunKlijenta.Length - 11)));

            Object[] parameters = new object[]
            { 
               VodeciBrojBanke,
               BankaNaziv,
               BankaOIB,
               VrstaIzvadka,
               DatumObrada,
               BICrojBanke,
               TransakcijskiRacunKlijenta,
               ValutaTransakcijskogRacuna,
               NazivKlijenta,
               SjedisteKlijenta,
               MaticniBroj,
               OIBKlijenta,
               RedniBrojIzvadka,
               PodbrojIzvadka,
               DatumIzvadka,
               RedniBrojGrupePaketa,
               TransakcijskiRacunKlijentaBroj
            };


            return _context.Database.SqlQuery<Model.Data.Izvod>(query, parameters).FirstOrDefault();

        }

        public Model.Data.IzvodSt InsertIzvodStIzvod2012ASt(Stavka obc)
        {
            Stavka st = (Stavka)obc;


            String query = String.Format("BEGIN TRAN " +
                 " INSERT INTO [hub].[IzvodSt] ([ID_Izvod]) VALUES(@ID_Izvod) DECLARE @ID_IzvodSt int SET @ID_IzvodSt = SCOPE_IDENTITY()  " +
                 "INSERT INTO [hub].[Izvod2012ASt] (ID_IzvodSt, IDIzvod2012ATransakcijaVr, Racun, Naziv, Adresa, Sjediste, DatumValuta, DatumIzvrsenje, IDValuta, Tecaj, IznosValuta, Iznos, PlatiteljPozivNaBroj, PrimateljPozivNaBroj, OpisPlacanje, IdentifikatorTransakcijeFINA, IdentifikatorTransakcije) " +
" VALUES (@ID_IzvodSt , @OznakaTransakcije , @RacunPrPl , @NazivPrPl , @AdresaPrPl , @SjedistePrPl, @DatumValuta, @DatumIzvrsenje, @ValutaPokrice, @Tecaj, @IznosValutaPokrice, @Iznos, @PozivNaBrojPlatitelja, @PozivNaBrojPrimatelja, @OpisPlacanje, @IdentifikatorTransakcijeFINA , @IdentifikatorTransakcije)  SELECT * FROM hub.IzvodSt WHERE ID_IzvodSt = @ID_IzvodSt  COMMIT TRAN GO");


            SqlParameter ID_Izvod = new SqlParameter ("ID_Izvod", st.ID_Izvod.Trim());
            SqlParameter OznakaTransakcije = new SqlParameter ("OznakaTransakcije", Int32.Parse(st.OznakaTransakcije).ToString());
            SqlParameter RacunPrPl = new SqlParameter ("RacunPrPl", st.RacunPrPl.Trim());
            SqlParameter NazivPrPl = new SqlParameter ("NazivPrPl", st.NazivPrPl.Trim());
            SqlParameter AdresaPrPl = new SqlParameter ("AdresaPrPl", st.AdresaPrPl.Trim());
            SqlParameter SjedistePrPl = new SqlParameter ("SjedistePrPl", st.SjedistePrPl.Trim());
            SqlParameter DatumValuta = new SqlParameter ("DatumValuta", ConvertStringUDatumString(st.DatumValuta).ToString());
            SqlParameter DatumIzvrsenje = new SqlParameter ("DatumIzvrsenje", ConvertStringUDatumString(st.DatumIzvrsenje).ToString());
            SqlParameter ValutaPokrice = new SqlParameter ("ValutaPokrice", st.ValutaPokrice != "   " ? (object)st.ValutaPokrice : DBNull.Value);
            SqlParameter Tecaj = new SqlParameter("Tecaj", string.Format("{0:F6}", st.Tecaj.Substring(0, 9) + "." + st.Tecaj.Substring(9, 6)).ToString());
            SqlParameter IznosValutaPokrice = new SqlParameter("IznosValutaPokrice", string.Format("{0:F2}", st.IznosValutaPokrice.Substring(0, 13) + "." + st.IznosValutaPokrice.Substring(13, 2)).ToString());
            SqlParameter Iznos = new SqlParameter("Iznos", string.Format("{0:F2}", st.Iznos.Substring(0, 13) + "." + st.Iznos.Substring(13, 2)));
            SqlParameter PozivNaBrojPlatitelja = new SqlParameter ("PozivNaBrojPlatitelja", st.PozivNaBrojPlatitelja.Trim());
            SqlParameter PozivNaBrojPrimatelja = new SqlParameter ("PozivNaBrojPrimatelja", st.PozivNaBrojPrimatelja.Trim());
            SqlParameter OpisPlacanje = new SqlParameter ("OpisPlacanje", st.OpisPlacanje.Trim());
            SqlParameter IdentifikatorTransakcijeFINA = new SqlParameter ("IdentifikatorTransakcijeFINA", st.IdentifikatorTransakcijeFINA.Trim());
            SqlParameter IdentifikatorTransakcije = new SqlParameter ("IdentifikatorTransakcije", st.IdentifikatorTransakcije.Trim());


            Object[] parameters = new object[]
            { 
               ID_Izvod,
               OznakaTransakcije,
               RacunPrPl,
               NazivPrPl,
               AdresaPrPl,
               SjedistePrPl,
               DatumValuta,
               DatumIzvrsenje,
               ValutaPokrice,
               Tecaj,
               IznosValutaPokrice,
               Iznos,
               PozivNaBrojPlatitelja,
               PozivNaBrojPrimatelja,
               OpisPlacanje,
               IdentifikatorTransakcijeFINA,
               IdentifikatorTransakcije
            };

            return _context.Database.SqlQuery<Model.Data.IzvodSt>(query, parameters).FirstOrDefault();

        }

    
        public string ConvertStringUDatumString(string datum)
        {

            String rezult = String.Empty;
            string godinaString = datum.Substring(0, 4);
            string mjesecString = datum.Substring(4, 2);
            string danString = datum.Substring(6, 2);
            rezult = godinaString + "-" + mjesecString + "-" + danString;
            return rezult;
        }
    }
}


