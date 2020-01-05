using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data.Objects;
using InLine;

namespace InLine.Repository.Admin
{
    public class DozvoleZabranePoruke : IDozvoleZabranePoruke
    {
        Model.Admin.Context _context = new Model.Admin.Context();

        #region Dozvole i Zabrane Akcije
        public bool GetDozvolaAkcija(long KorisnikID, int AkcijaID)
        {
            bool proof = false;

            ObjectResult<long?> rez = _context.USP_DozvolaAkcija(KorisnikID, AkcijaID);

            if (rez != null)
            {
                if (Convert.ToInt64(rez) > 0)
                {
                    proof = true;
                }

                else
                {
                    proof = false;
                }
            }

            else
            {
                proof = false;
            }

            return proof;
        }
        public bool GetZabranaAkcija(long KorisnikID, int AkcijaID)
        {
            bool proof = false;

            ObjectResult<long?> rez = _context.USP_ZabranaAkcija(KorisnikID, AkcijaID);

            if (rez != null)
            {
                if (Convert.ToInt64(rez) > 0)
                {
                    proof = true;
                }

                else
                {
                    proof = false;
                }
            }

            else
            {
                proof = false;
            }

            return proof;
        }
        public bool AkcijaImaDozvolu(long KorisnikID, int AkcijaID)
        {
            bool proof = false;
            bool imadozvolu = GetDozvolaAkcija(KorisnikID, AkcijaID);
            bool imazabranu = GetZabranaAkcija(KorisnikID, AkcijaID);


            if (imadozvolu == true && imazabranu == false)
            {
                proof = true;
            }

            else
            {
                proof = false;
            }

            return proof;
        }
        public bool GetDozvolaAkcijaOznaka(long KorisnikID, string AkcijaOznaka)
        {
            bool proof = false;

            ObjectResult<long?> rez = _context.USP_DozvolaAkcijaOznaka(KorisnikID, AkcijaOznaka);

            if (rez != null)
            {
                if (Convert.ToInt32(rez.First()) > 0)
                {
                    proof = true;
                }

                else
                {
                    proof = false;
                }
            }

            else
            {
                proof = false;
            }

            return proof;
        }
        public bool GetZabranaAkcijaOznaka(long KorisnikID, string AkcijaOznaka)
        {
            bool proof = false;

            ObjectResult<long?> rez = _context.USP_ZabranaAkcijaOznaka(KorisnikID, AkcijaOznaka);

            if (rez != null)
            {
                if (Convert.ToInt64(rez.First()) > 0)
                {
                    proof = true;
                }

                else
                {
                    proof = false;
                }
            }

            else
            {
                proof = false;
            }

            return proof;
        }
        public bool AkcijaImaDozvoluOznaka(long KorisnikID, string AkcijaOznaka)
        {
            bool proof = false;
            bool imadozvolu = GetDozvolaAkcijaOznaka(KorisnikID, AkcijaOznaka);
            bool imazabranu = GetZabranaAkcijaOznaka(KorisnikID, AkcijaOznaka);


            if (imadozvolu == true && imazabranu == false)
            {
                proof = true;
            }

            else
            {
                proof = false;
            }

            return proof;
        }
        #endregion




        #region Poruke Members

        // Originalna funkcija koja je čitala greške iz baze sad se koristi istoimena ispod
        //public Model.Admin.StatusPoruka GetUserFrendlyPorukaConstraint(string originalporuka, Model.Admin.KorisnikData KorisnikData)
        //{
        //    Model.Admin.StatusPoruka userfrendlyporuka = new Model.Admin.StatusPoruka();

        //    //string userfrendlyporuka = String.Empty;
        //    int slucaj = 0;
        //    string originalnaporukacutcut = String.Empty;
        //    int drugapojavaznaka;

        //    string nazivporuke = string.Empty;
        //    int prvapojavaznaka;

        //    try
        //    {
        //        string originalnaporukacut = originalporuka.Substring(0, 300);

        //        if (originalnaporukacut.Contains("The INSERT statement conflicted"))
        //            slucaj = 1;
        //        else if (originalnaporukacut.Contains("Cannot insert the value NULL"))
        //            slucaj = 2;
        //        else if (originalnaporukacut.Contains("The transaction ended in the trigger"))
        //            slucaj = 3;
        //        else if (originalnaporukacut.Contains("Object reference not set to an instance of an object"))
        //            slucaj = 4;
        //        else if (originalnaporukacut.Contains("The EXECUTE permission"))
        //            slucaj = 5;
        //        else if (originalnaporukacut.Contains("Login failed for user"))
        //            slucaj = 6;
        //        else if (originalnaporukacut.Contains("The SELECT permission"))
        //            slucaj = 7;
        //        else if (originalnaporukacut.Contains("Violation of UNIQUE KEY constraint"))
        //            slucaj = 8;
        //        else if (originalnaporukacut.Contains("System.Transactions.TransactionAbortedException: The transaction has aborted."))
        //            slucaj = 9;
        //        else if (originalnaporukacut.Contains("System.TimeoutException: Transaction Timeout"))
        //            slucaj = 10;
        //        else if (originalnaporukacut.Contains("Invalid object name"))
        //            slucaj = 11;
        //        else if (originalnaporukacut.Contains("The DELETE statement conflicted"))
        //            slucaj = 12;
        //        if (originalnaporukacut.Contains("The UPDATE statement conflicted"))
        //            slucaj = 14;
        //        else if (originalnaporukacut.Contains("The DELETE permission"))
        //            slucaj = 15;





        //        switch (slucaj)
        //        {
        //            case 1:
        //                prvapojavaznaka = originalnaporukacut.IndexOf('\"');
        //                originalnaporukacutcut = originalnaporukacut.Substring(prvapojavaznaka + 1, 70);
        //                drugapojavaznaka = originalnaporukacutcut.IndexOf('\"');
        //                nazivporuke = originalnaporukacutcut.Substring(0, (drugapojavaznaka));

        //                Model.Admin.StatusPorukaKonstruktor poruka;

        //                poruka = (from cp in _context.PorukaConstraint
        //                                 join ps in _context.PorukaStatus on cp.IDPorukaStatus equals ps.IDPorukaStatus
        //                                 where cp.Naziv.Trim() == nazivporuke.Trim()
        //                                 select new Model.Admin.StatusPorukaKonstruktor 
        //                                 {
        //                                    StatusTekst = ps.Status,
        //                                    PorukaTekst = cp.Poruka
        //                                 }
        //                                 ).FirstOrDefault();


        //                if (!String.IsNullOrEmpty(poruka.PorukaTekst))
        //                {
        //                    userfrendlyporuka.PorukaTekst = poruka.PorukaTekst;
        //                    userfrendlyporuka.StatusTekst = poruka.StatusTekst;

        //                }

        //                else
        //                {
        //                    userfrendlyporuka.PorukaTekst = "Pozvano sa The INSERT statement conflicted - nije nađena PorukaConstraint case 1";
        //                    userfrendlyporuka.StatusTekst = "";
        //                }
        //                break;

        //            case 2:
        //                prvapojavaznaka = originalnaporukacut.IndexOf('\'');
        //                originalnaporukacutcut = originalnaporukacut.Substring(prvapojavaznaka + 1, 70);
        //                drugapojavaznaka = originalnaporukacutcut.IndexOf('\'');
        //                nazivporuke = originalnaporukacutcut.Substring(0, (drugapojavaznaka));

        //                // Poruka je iz baze, ali se ne vraca iz tablica Poruka ili PorukaConstraint  njen status je 1 Greska
        //                if (!String.IsNullOrEmpty(nazivporuke.Trim()))
        //                {
        //                    userfrendlyporuka.PorukaTekst = "Polje " + nazivporuke.Trim() + " ne smije biti null vrijednost";
        //                    userfrendlyporuka.StatusTekst = "1";
        //                }

        //                else
        //                {
        //                    userfrendlyporuka.PorukaTekst = "Pozvano sa Cannot insert the value NULL into column - nije nađena kolona case 2";
        //                    userfrendlyporuka.StatusTekst = "";
        //                }
        //                break;

        //            case 3:
        //                prvapojavaznaka = originalnaporukacut.IndexOf(':');
        //                originalnaporukacutcut = originalnaporukacut.Substring(prvapojavaznaka + 1, 150);
        //                drugapojavaznaka = originalnaporukacutcut.IndexOf("The transaction ended in the trigger");
        //                nazivporuke = originalnaporukacutcut.Substring(0, (drugapojavaznaka - 2));


        //                if (!String.IsNullOrEmpty(nazivporuke.Trim()))
        //                {
        //                    // Poruka je iz baze, ali se ne vraca iz tablica Poruka ili PorukaConstraint  njen status je 1 Greska
        //                    userfrendlyporuka.PorukaTekst = nazivporuke.Trim();
        //                    userfrendlyporuka.StatusTekst = "1";
        //                }

        //                else
        //                {
        //                    // Poruka je iz baze, ali se ne vraca iz tablica Poruka ili PorukaConstraint  njen status je 1 Greska
        //                    userfrendlyporuka.PorukaTekst = "Pozvano sa The transaction ended in the trigger - nije vratio tekst trigera koji je upisan u bazu case 3";
        //                    userfrendlyporuka.StatusTekst = "";

        //                }
        //                break;

        //            case 4:
        //                // Poruka je iz baze, ali se ne vraca iz tablica Poruka ili PorukaConstraint  njen status je 1 Greska
        //                    userfrendlyporuka.PorukaTekst = "1_Nije instanciran objekt case 4";
        //                    userfrendlyporuka.StatusTekst = "1";
        //                break;

        //            case 5:

        //                poruka = (from cp in _context.Poruka
        //                          join ps in _context.PorukaStatus on cp.IDPorukaStatus equals ps.IDPorukaStatus
        //                          where cp.Naziv.Trim() == "ExecuteDeniedSQL"
        //                          select new Model.Admin.StatusPorukaKonstruktor 
        //                          {
        //                              StatusTekst = ps.Status,
        //                              PorukaTekst = cp.Tekst
        //                          }
                        
        //                          ).FirstOrDefault();

        //                if (!String.IsNullOrEmpty(poruka.PorukaTekst))
        //                {
        //                    userfrendlyporuka.PorukaTekst = poruka.PorukaTekst;
        //                    userfrendlyporuka.StatusTekst = poruka.StatusTekst;

        //                }

        //                else
        //                {
        //                    // Poruka je iz baze, ali se ne vraca iz tablica Poruka ili PorukaConstraint  njen status je 1 Greska
        //                    userfrendlyporuka.PorukaTekst = "Pozvano sa The INSERT statement conflicted - nije nađena PorukaConstraint case 5";
        //                    userfrendlyporuka.StatusTekst = "";
        //                }
        //                break;

        //            case 6:
        //                prvapojavaznaka = originalnaporukacut.IndexOf('\'');
        //                originalnaporukacutcut = originalnaporukacut.Substring(prvapojavaznaka + 1, 70);
        //                drugapojavaznaka = originalnaporukacutcut.IndexOf('\'');
        //                nazivporuke = originalnaporukacutcut.Substring(0, (drugapojavaznaka));

        //                if (!String.IsNullOrEmpty(nazivporuke.Trim()))
        //                {
        //                    // Poruka je iz baze, ali se ne vraca iz tablica Poruka ili PorukaConstraint  njen status je 2 Upozorenje
        //                    userfrendlyporuka.PorukaTekst = "Neuspješno prijava na bazu za korisnika " + nazivporuke.Trim();
        //                    userfrendlyporuka.StatusTekst = "2";
        //                }

        //                else
        //                {
        //                    userfrendlyporuka.PorukaTekst = "Pozvano nakon logina - nije nađena kolona case 6";
        //                    userfrendlyporuka.StatusTekst = "";
        //                }
        //                break;

        //            case 7:
        //                poruka = (from cp in _context.Poruka
        //                          join ps in _context.PorukaStatus on cp.IDPorukaStatus equals ps.IDPorukaStatus
        //                          where cp.Naziv.Trim() == "ExecuteDeniedSQL"
        //                          select new Model.Admin.StatusPorukaKonstruktor 
        //                          {
        //                              StatusTekst = ps.Status,
        //                              PorukaTekst = cp.Tekst
        //                          }
        //                          ).FirstOrDefault();

        //                if (!String.IsNullOrEmpty(poruka.PorukaTekst))
        //                {
        //                    userfrendlyporuka.PorukaTekst = poruka.PorukaTekst;
        //                    userfrendlyporuka.StatusTekst = poruka.StatusTekst;

        //                }

        //                else
        //                {
        //                    userfrendlyporuka.PorukaTekst = "Pozvano sa nekim SELECTOM statement conflicted - nije nađena PorukaConstraint case 7";
        //                    userfrendlyporuka.StatusTekst = "";
        //                }
        //                break;

        //            case 8:
        //                prvapojavaznaka = originalnaporukacut.IndexOf('\'');
        //                originalnaporukacutcut = originalnaporukacut.Substring(prvapojavaznaka + 1, 70);
        //                drugapojavaznaka = originalnaporukacutcut.IndexOf('\'');
        //                nazivporuke = originalnaporukacutcut.Substring(0, (drugapojavaznaka));

        //                poruka = (from cp in _context.PorukaConstraint
        //                          join ps in _context.PorukaStatus on cp.IDPorukaStatus equals ps.IDPorukaStatus
        //                          where cp.Naziv.Trim() == nazivporuke.Trim()
        //                          select new Model.Admin.StatusPorukaKonstruktor 
        //                          {
        //                              StatusTekst = ps.Status,
        //                              PorukaTekst = cp.Poruka
        //                          } 
        //                          ).FirstOrDefault();

        //                if (!String.IsNullOrEmpty(poruka.PorukaTekst))
        //                {
        //                    userfrendlyporuka.PorukaTekst = poruka.PorukaTekst;
        //                    userfrendlyporuka.StatusTekst = poruka.StatusTekst;

        //                }

        //                else
        //                {
        //                    userfrendlyporuka.PorukaTekst = "Pozvano sa The INSERT statement conflicted - nije nađena PorukaConstraint case 8";
        //                    userfrendlyporuka.StatusTekst = "";
        //                }
        //                break;

        //            case 9:

        //                poruka = (from cp in _context.Poruka
        //                          join ps in _context.PorukaStatus on cp.IDPorukaStatus equals ps.IDPorukaStatus
        //                          where cp.Naziv.Trim() == "TransactionAborted"
        //                          select new Model.Admin.StatusPorukaKonstruktor 
        //                          {
        //                              StatusTekst = ps.Status,
        //                              PorukaTekst = cp.Tekst
        //                          }
        //                          ).FirstOrDefault();

        //                if (!String.IsNullOrEmpty(poruka.PorukaTekst))
        //                {
        //                    userfrendlyporuka.PorukaTekst = poruka.PorukaTekst;
        //                    userfrendlyporuka.StatusTekst = poruka.StatusTekst;

        //                }

        //                else
        //                {
        //                    userfrendlyporuka.PorukaTekst = "System.Transactions.TransactionAbortedException: - nije nađena PorukaConstraint case 9";
        //                    userfrendlyporuka.StatusTekst = "";
        //                }
        //                break;

        //            case 10:
        //                poruka = (from cp in _context.Poruka
        //                          join ps in _context.PorukaStatus on cp.IDPorukaStatus equals ps.IDPorukaStatus
        //                          where cp.Naziv.Trim() == "TransactionTimeout"
        //                          select new Model.Admin.StatusPorukaKonstruktor 
        //                          {
        //                              StatusTekst = ps.Status,
        //                              PorukaTekst = cp.Tekst
        //                          } 
        //                          ).FirstOrDefault();

        //                if (!String.IsNullOrEmpty(poruka.PorukaTekst))
        //                {
        //                    userfrendlyporuka.PorukaTekst = poruka.PorukaTekst;
        //                    userfrendlyporuka.StatusTekst = poruka.StatusTekst;

        //                }

        //                else
        //                {
        //                    userfrendlyporuka.PorukaTekst = "System.Transactions.TransactionAbortedException: - nije nađena PorukaConstraint case 10";
        //                    userfrendlyporuka.StatusTekst = "";
        //                }
        //                break;

        //            case 11:
        //                prvapojavaznaka = originalnaporukacut.IndexOf('\'');
        //                originalnaporukacutcut = originalnaporukacut.Substring(prvapojavaznaka + 1, 100);
        //                drugapojavaznaka = originalnaporukacutcut.IndexOf('\'');
        //                nazivporuke = originalnaporukacutcut.Substring(0, (drugapojavaznaka));

        //                if (!String.IsNullOrEmpty(nazivporuke.Trim()))
        //                {
        //                    // Poruka je iz baze, ali se ne vraca iz tablica Poruka ili PorukaConstraint  njen status je 1 Greska
        //                    userfrendlyporuka.PorukaTekst = "Objekt " + nazivporuke.Trim() + " nije nađen ili je netočno ime.";
        //                    userfrendlyporuka.StatusTekst = "1";
        //                }

        //                else
        //                {
        //                    userfrendlyporuka.PorukaTekst = "Provjeriti da li postoji objekt sa tim imenom case 11";
        //                    userfrendlyporuka.StatusTekst = "";
        //                }
        //                break;
        //            case 12:
        //                prvapojavaznaka = originalnaporukacut.IndexOf('\"');
        //                originalnaporukacutcut = originalnaporukacut.Substring(prvapojavaznaka + 1, 70);
        //                drugapojavaznaka = originalnaporukacutcut.IndexOf('\"');
        //                nazivporuke = originalnaporukacutcut.Substring(0, (drugapojavaznaka));


        //                poruka = (from cp in _context.PorukaConstraint
        //                          join ps in _context.PorukaStatus on cp.IDPorukaStatus equals ps.IDPorukaStatus
        //                          where cp.Naziv.Trim() == nazivporuke.Trim()
        //                          select new Model.Admin.StatusPorukaKonstruktor 
        //                          {
        //                             StatusTekst = ps.Status,
        //                             PorukaTekst = cp.Poruka
        //                          } 
        //                          ).FirstOrDefault();

        //                if (!String.IsNullOrEmpty(poruka.PorukaTekst))
        //                {
        //                    userfrendlyporuka.PorukaTekst = poruka.PorukaTekst;
        //                    userfrendlyporuka.StatusTekst = poruka.StatusTekst;

        //                }

        //                else
        //                {
        //                    userfrendlyporuka.PorukaTekst = "Pozvano sa The DELETE statement conflicted - nije nađena PorukaConstraint  case 12";
        //                    userfrendlyporuka.StatusTekst = "";
        //                }
        //                break;
        //            //case 13:

        //            //    if (!String.IsNullOrEmpty(originalnaporukacut))
        //            //    {
        //            //        userfrendlyporuka = "Za tu grešku trenutno nema poruka potrebno provjeriti u bazi detaljan opis greške casea 13";

        //            //    }

        //            //    else
        //            //    {
        //            //        userfrendlyporuka = "Prazna poruka provjeriti";
        //            //    }
        //            //    break;
        //            case 14:
        //                prvapojavaznaka = originalnaporukacut.IndexOf('\"');
        //                originalnaporukacutcut = originalnaporukacut.Substring(prvapojavaznaka + 1, 70);
        //                drugapojavaznaka = originalnaporukacutcut.IndexOf('\"');
        //                nazivporuke = originalnaporukacutcut.Substring(0, (drugapojavaznaka));


        //                poruka = (from cp in _context.PorukaConstraint
        //                          join ps in _context.PorukaStatus on cp.IDPorukaStatus equals ps.IDPorukaStatus
        //                          where cp.Naziv.Trim() == nazivporuke.Trim()
        //                          select new Model.Admin.StatusPorukaKonstruktor 
        //                          {
        //                             StatusTekst = ps.Status,
        //                             PorukaTekst = cp.Poruka
        //                          }
        //                          ).FirstOrDefault();

        //                if (!String.IsNullOrEmpty(poruka.PorukaTekst))
        //                {
        //                    userfrendlyporuka.PorukaTekst = poruka.PorukaTekst;
        //                    userfrendlyporuka.StatusTekst = poruka.StatusTekst;

        //                }

        //                else
        //                {
        //                    userfrendlyporuka.PorukaTekst = "Pozvano sa The UPDATE statement conflicted - nije nađena PorukaConstraint case 14";
        //                    userfrendlyporuka.StatusTekst = "";
        //                }
        //                break;

        //            case 15:

        //                poruka = (from cp in _context.Poruka
        //                          join ps in _context.PorukaStatus on cp.IDPorukaStatus equals ps.IDPorukaStatus
        //                          where cp.Naziv.Trim() == "ExecuteDeniedSQL"
        //                          select new Model.Admin.StatusPorukaKonstruktor 
        //                          {
        //                             StatusTekst = ps.Status,
        //                             PorukaTekst = cp.Tekst
        //                          } 
        //                          ).FirstOrDefault();

        //                if (!String.IsNullOrEmpty(poruka.PorukaTekst))
        //                {
        //                    userfrendlyporuka.PorukaTekst = poruka.PorukaTekst;
        //                    userfrendlyporuka.StatusTekst = poruka.StatusTekst;

        //                }

        //                else
        //                {
        //                    userfrendlyporuka.PorukaTekst = "Pozvano sa nekim DELETE statement conflicted - nije nađena PorukaConstraint case 15";
        //                    userfrendlyporuka.StatusTekst = "";
        //                }
        //                break;
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        userfrendlyporuka.PorukaTekst = (ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString());
        //        AddLog(System.DateTime.Now, KorisnikData.KorisnikID, KorisnikData.ID_Database, KorisnikData.ServerName, KorisnikData.DatabaseName, KorisnikData.Korisnik, userfrendlyporuka.PorukaTekst, originalporuka.ToString(), ex.StackTrace.ToString());
        //    }

        //    return userfrendlyporuka;
        //}

        public Model.Admin.StatusPoruka GetUserFrendlyPorukaConstraint(string originalnaporukacut, Model.Admin.KorisnikData KorisnikData)
        {
            Model.Admin.StatusPoruka userfrendlyporuka = new Model.Admin.StatusPoruka();

            int slucaj = 0;
            string porukazaprikaz = String.Empty;
            int pocetak;

            string nazivporuke = string.Empty;
            int kraj;


            if (originalnaporukacut.Contains("The INSERT statement conflicted"))
                slucaj = 1;
            else if (originalnaporukacut.Contains("Cannot insert the value NULL"))
                slucaj = 2;
            else if (originalnaporukacut.Contains("The transaction ended in the trigger"))
            {
                pocetak = originalnaporukacut.IndexOf("):");
                kraj = originalnaporukacut.IndexOf("The transaction ended in the trigger");
                porukazaprikaz = originalnaporukacut.Substring(pocetak + 2, (kraj - (pocetak + 2)));
                slucaj = 3;
            }
            else if (originalnaporukacut.Contains("Object reference not set to an instance of an object"))
                slucaj = 4;
            else if (originalnaporukacut.Contains("The EXECUTE permission"))
                slucaj = 5;
            else if (originalnaporukacut.Contains("Login failed for user"))
                slucaj = 6;
            else if (originalnaporukacut.Contains("The SELECT permission"))
                slucaj = 7;
            else if (originalnaporukacut.Contains("Violation of UNIQUE KEY constraint"))
                slucaj = 8;
            else if (originalnaporukacut.Contains("System.Transactions.TransactionAbortedException: The transaction has aborted."))
                slucaj = 9;
            else if (originalnaporukacut.Contains("System.TimeoutException: Transaction Timeout"))
                slucaj = 10;
            else if (originalnaporukacut.Contains("Invalid object name"))
                slucaj = 11;
            else if (originalnaporukacut.Contains("The DELETE statement conflicted"))
                slucaj = 12;
            if (originalnaporukacut.Contains("The UPDATE statement conflicted"))
                slucaj = 13;
            else if (originalnaporukacut.Contains("The DELETE permission"))
                slucaj = 14;


            switch (slucaj)
            {
                case 1:
                    userfrendlyporuka.PorukaTekst = ErrorMessage.UserFriendlyMessage.InsertConflict;
                    userfrendlyporuka.StatusTekst = ErrorMessage.MessageStatus.Jedan;
                    break;

                case 2:
                    userfrendlyporuka.PorukaTekst = ErrorMessage.UserFriendlyMessage.InsertNullValue;
                    userfrendlyporuka.StatusTekst = ErrorMessage.MessageStatus.Jedan;
                    break;

                case 3:
                    userfrendlyporuka.PorukaTekst = porukazaprikaz + " - " + ErrorMessage.UserFriendlyMessage.TransactionEnded;
                    userfrendlyporuka.StatusTekst = ErrorMessage.MessageStatus.Jedan;
                    break;

                case 4:
                    userfrendlyporuka.PorukaTekst = ErrorMessage.UserFriendlyMessage.ObjectReferenceNotSet;
                    userfrendlyporuka.StatusTekst = ErrorMessage.MessageStatus.Jedan;
                    break;

                case 5:
                    userfrendlyporuka.PorukaTekst = ErrorMessage.UserFriendlyMessage.ExecutePermission;
                    userfrendlyporuka.StatusTekst = ErrorMessage.MessageStatus.Jedan;
                    break;

                case 6:
                    userfrendlyporuka.PorukaTekst = ErrorMessage.UserFriendlyMessage.LoginFailed;
                    userfrendlyporuka.StatusTekst = ErrorMessage.MessageStatus.Jedan;
                    break;

                case 7:
                    userfrendlyporuka.PorukaTekst = ErrorMessage.UserFriendlyMessage.SelectPermission;
                    userfrendlyporuka.StatusTekst = ErrorMessage.MessageStatus.Jedan;
                    break;

                case 8:
                    userfrendlyporuka.PorukaTekst = ErrorMessage.UserFriendlyMessage.UniqueKeyConstraint;
                    userfrendlyporuka.StatusTekst = ErrorMessage.MessageStatus.Jedan;
                    break;

                case 9:
                    userfrendlyporuka.PorukaTekst = ErrorMessage.UserFriendlyMessage.TransactionAbortedException;
                    userfrendlyporuka.StatusTekst = ErrorMessage.MessageStatus.Jedan;
                    break;

                case 10:
                    userfrendlyporuka.PorukaTekst = ErrorMessage.UserFriendlyMessage.TimeoutException;
                    userfrendlyporuka.StatusTekst = ErrorMessage.MessageStatus.Jedan;
                    break;

                case 11:
                    userfrendlyporuka.PorukaTekst = ErrorMessage.UserFriendlyMessage.InvalidObjectName;
                    userfrendlyporuka.StatusTekst = ErrorMessage.MessageStatus.Jedan;
                    break;

                case 12:
                    userfrendlyporuka.PorukaTekst = ErrorMessage.UserFriendlyMessage.DeleteConflicted;
                    userfrendlyporuka.StatusTekst = ErrorMessage.MessageStatus.Jedan;
                    break;

                case 13: ;
                    userfrendlyporuka.PorukaTekst = ErrorMessage.UserFriendlyMessage.UpdateConflicted;
                    userfrendlyporuka.StatusTekst = ErrorMessage.MessageStatus.Jedan;
                    break;

                case 14:
                    userfrendlyporuka.PorukaTekst = ErrorMessage.UserFriendlyMessage.DeletePermission;
                    userfrendlyporuka.StatusTekst = ErrorMessage.MessageStatus.Jedan;
                    break;
            }


            return userfrendlyporuka;
        }

        public Model.Admin.StatusPoruka GetUserFrendlyPoruka(string originalporuka)
        {
            Model.Admin.StatusPoruka userfrendlyporuka = new Model.Admin.StatusPoruka();

            try
            {
                Model.Admin.StatusPorukaKonstruktor poruka;

                 poruka = (from cp in _context.Poruka
                                 join ps in _context.PorukaStatus on cp.IDPorukaStatus equals ps.IDPorukaStatus
                                 where cp.Naziv.Trim() == originalporuka.Trim()
                                 select new Model.Admin.StatusPorukaKonstruktor 
                                 {
                                     StatusTekst = ps.Status,
                                     PorukaTekst = cp.Tekst
                                 }
                ).FirstOrDefault();

                if (!String.IsNullOrEmpty(poruka.PorukaTekst))
                {
                    userfrendlyporuka.PorukaTekst = poruka.PorukaTekst;
                    userfrendlyporuka.StatusTekst = poruka.StatusTekst;
                }

                else
                {
                    userfrendlyporuka.PorukaTekst = "Nedefinirano";
                    userfrendlyporuka.StatusTekst = "";
                }

            }

            catch (Exception ex)
            {
                userfrendlyporuka.PorukaTekst = "Za ovo provjeriti originalnu poruku i u tablici Poruka -  " + (ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString());
                userfrendlyporuka.StatusTekst = "";
            }


            return userfrendlyporuka;
        }

        public Model.Admin.StatusPoruka NemaDozvolaAkcijaPoruka()
        {
            Model.Admin.StatusPoruka userfrendlyporuka = new Model.Admin.StatusPoruka();
           return userfrendlyporuka = GetUserFrendlyPoruka("NemaDozvolaAkcija");

        }

        public Model.Admin.StatusPoruka NemaDozvolaAkcijaPorukaAdLog(string imefunkcije, Model.Admin.KorisnikData KorisnikData)
        {
            Model.Admin.StatusPoruka userfrendlyporuka = new Model.Admin.StatusPoruka();
            userfrendlyporuka = GetUserFrendlyPoruka("NemaDozvolaAkcija");
            AddLog(System.DateTime.Now, KorisnikData.KorisnikID, KorisnikData.ID_Database, KorisnikData.ServerName, KorisnikData.DatabaseName, KorisnikData.Korisnik, userfrendlyporuka.PorukaTekst, imefunkcije, "");
            return userfrendlyporuka;
        }

        public Model.Admin.StatusPoruka RezulatatJeNull()
        {
            Model.Admin.StatusPoruka userfrendlyporuka = new Model.Admin.StatusPoruka();
            return userfrendlyporuka = GetUserFrendlyPoruka("RezultatJeNull");
        }


        #endregion





        #region ExceptionLog Members

        public void AddLog(DateTime? vrijeme, long? ID_Korisnik, long? ID_Baza, string server, string baza, string korisnik, string poruka, string exception, string trace)
        {
            _context.USP_Log_INSERT(vrijeme, ID_Korisnik, ID_Baza, server, baza, korisnik, poruka, exception, trace);
        }

        public void UpdateLog(long? ID_Log, DateTime? vrijeme, long? ID_Korisnik, long? ID_Baza, string server, string baza, string korisnik, string poruka, string exception, string trace)
        {
            _context.USP_Log_UPDATE(ID_Log, vrijeme, ID_Korisnik, ID_Baza, server, baza, korisnik, poruka, exception, trace);
        }

        public void DeleteLog(long? ID_Log)
        {
            _context.USP_Log_DELETE(ID_Log);
        }

        public Model.Admin.StatusPoruka AddLogGetPorukaConstraint(string exception, string trace, Model.Admin.KorisnikData KorisnikData)
        {
            Model.Admin.StatusPoruka userfrendlyporuka = new Model.Admin.StatusPoruka();
            userfrendlyporuka = GetUserFrendlyPorukaConstraint(exception, KorisnikData);
            AddLog(System.DateTime.Now, KorisnikData.KorisnikID, KorisnikData.ID_Database, KorisnikData.ServerName, KorisnikData.DatabaseName, KorisnikData.Korisnik, userfrendlyporuka.PorukaTekst, exception, trace);
            return userfrendlyporuka;
        }

        public Model.Admin.StatusPoruka AddLogGetPorukaConstraintIzTransakcije(string poruka, string exception, string trace, Model.Admin.KorisnikData KorisnikData)
        {
            Model.Admin.StatusPoruka userfrendlyporuka = new Model.Admin.StatusPoruka();
            userfrendlyporuka.PorukaTekst = poruka + "" + GetUserFrendlyPorukaConstraint(exception, KorisnikData);
            AddLog(System.DateTime.Now, KorisnikData.KorisnikID, KorisnikData.ID_Database, KorisnikData.ServerName, KorisnikData.DatabaseName, KorisnikData.Korisnik, userfrendlyporuka.PorukaTekst, exception, trace);
            return userfrendlyporuka;
        }

        public Model.Admin.StatusPoruka GetPorukaConstraint(string exception, string trace, Model.Admin.KorisnikData KorisnikData)
        {
            Model.Admin.StatusPoruka userfrendlyporuka = new Model.Admin.StatusPoruka();
            userfrendlyporuka = GetUserFrendlyPorukaConstraint(exception, KorisnikData);
            return userfrendlyporuka;
        }

        public Model.Admin.StatusPoruka AddLogGetPoruka(string exception, string trace, Model.Admin.KorisnikData KorisnikData)
        {
            Model.Admin.StatusPoruka userfrendlyporuka = new Model.Admin.StatusPoruka();
            userfrendlyporuka = GetUserFrendlyPoruka(exception);
            AddLog(System.DateTime.Now, KorisnikData.KorisnikID, KorisnikData.ID_Database, KorisnikData.ServerName, KorisnikData.DatabaseName, KorisnikData.Korisnik, userfrendlyporuka.PorukaTekst, exception, trace);
            return userfrendlyporuka;
        }

        public Model.Admin.StatusPoruka GetPoruka(string exception, string trace, Model.Admin.KorisnikData KorisnikData)
        {
            Model.Admin.StatusPoruka userfrendlyporuka = new Model.Admin.StatusPoruka();
            userfrendlyporuka = GetUserFrendlyPoruka(exception);
            return userfrendlyporuka;
        }

        public Model.Admin.StatusPoruka AddLogGetException(string exception, string trace, Model.Admin.KorisnikData KorisnikData)
        {
            Model.Admin.StatusPoruka exceptionporuka = new Model.Admin.StatusPoruka();
            exceptionporuka.PorukaTekst = GetUserFrendlyPorukaConstraint(exception, KorisnikData).PorukaTekst;
            exceptionporuka.StatusTekst = GetUserFrendlyPorukaConstraint(exception, KorisnikData).StatusTekst;
            AddLog(System.DateTime.Now, KorisnikData.KorisnikID, KorisnikData.ID_Database, KorisnikData.ServerName, KorisnikData.DatabaseName, KorisnikData.Korisnik, exceptionporuka.PorukaTekst, exception, trace);
            return exceptionporuka;
        }

        public void AddExceptionInLogInicijacijaServisa(string exception, string trace)
        {
            AddLog(System.DateTime.Now, null, null, String.Empty, String.Empty, String.Empty, "Greška kod inicijacije servisa", exception, trace);
        }

        public void AddExceptionInLogInicijacijaRepositorijaUGridFormated(string exception, string trace)
        {
            AddLog(System.DateTime.Now, null, null, String.Empty, String.Empty, String.Empty, "Greška kod inicijacije repozitorija u GridFormated dijelu", exception, trace);
        }

        public void AddExceptionInLogKodLogiranja(string poruka, string exception, string trace)
        {
            AddLog(System.DateTime.Now, null, null, String.Empty, String.Empty, String.Empty, poruka, exception, trace);
        }

        public string PorukeIzListeUString(IEnumerable<String> lista)
        {
            string poruka = String.Empty;
            string poruka_lista = String.Empty;
            IEnumerable<string> strings = lista;
            poruka_lista = string.Join(",", strings.ToArray());
            // Poruka je iz baze, ali se ne vraca iz tablica Poruka ili PorukaConstraint  njen status je 1 Greska
            poruka = "1_Poruke koje prethode prekidu transakcije:" + poruka_lista + " --- Poruka same neuspjele transakcije: ";
            return poruka;
        }

        public void AddExceptionInLog(string poruka, string exception, string trace, Model.Admin.KorisnikData KorisnikData)
        {
            AddLog(System.DateTime.Now, KorisnikData.KorisnikID, KorisnikData.ID_Database, KorisnikData.ServerName, KorisnikData.DatabaseName, KorisnikData.Korisnik, poruka, exception, trace);
        }

        #endregion
    }

    public static class ErrorMessage
    {
        public static class UserFriendlyMessage
        {
            public static string InsertConflict = "Konflikt kod unosa";
            public static string InsertNullValue = "Nije moguć unos NULL vrijednost";
            public static string TransactionEnded = "Transakcija završena kod trigera";
            public static string ObjectReferenceNotSet = "Nije instanciran objekt";
            public static string ExecutePermission = "EXECUTE dozvola";
            public static string LoginFailed = "Login nije uspio";
            public static string SelectPermission = "SELECT dozvola";
            public static string UniqueKeyConstraint = "UNIQUE KEY";
            public static string TransactionAbortedException = "Transakcija prekinuta";
            public static string TimeoutException = "TTimeout ";
            public static string InvalidObjectName = "Krivo ime objekta";
            public static string DeleteConflicted = "DELETE konflikt";
            public static string UpdateConflicted = "UPDATE konflikt";
            public static string DeletePermission = "DELETE dozvola";

        }

        public static class MessageStatus
        {
            public static string Jedan = "1";
            public static string Dva = "2";
            public static string Tri = "3";

        }

    }
}
