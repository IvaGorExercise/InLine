using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.EntityClient;
using System.Data.Metadata.Edm;
using InLine;


namespace InLine.Model.Admin
{
    public class InLineConnectionStringKonstruktor
    {
        public static string ProviderName { get; set; }
        public static string ServerName { get; set; }
        public static string DatabaseName { get; set; }
        public static string UserID { get; set; }
        public static string Password { get; set; }


        public static string GetConnectionString(KorisnikData userdata)
        {
            string connstring;
            string providerString;

            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

            sqlBuilder.DataSource = userdata.ServerName.Trim();
            sqlBuilder.MultipleActiveResultSets = true;
            sqlBuilder.InitialCatalog = userdata.DatabaseName.Trim();
            sqlBuilder.UserID = userdata.Korisnik.Trim();
            sqlBuilder.Password = userdata.Password.Trim();
            sqlBuilder.Enlist = true;
            providerString = sqlBuilder.ToString();

            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();

            //entityBuilder.Provider = conkon.ProviderName;
            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = providerString;
            entityBuilder.Metadata = @"res://*/InLineData.csdl|res://*/InLineData.ssdl|res://*/InLineData.msl";
            connstring = entityBuilder.ToString();
            return connstring;
        }


        public static string GetConnectionStringNoMetadata(KorisnikData userdata)
        {
            string connstring;

            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

            sqlBuilder.DataSource = userdata.ServerName.Trim();
            sqlBuilder.MultipleActiveResultSets = true;
            sqlBuilder.InitialCatalog = userdata.DatabaseName.Trim();
            sqlBuilder.UserID = userdata.Korisnik.Trim();
            sqlBuilder.Password = userdata.Password.Trim();
            connstring = sqlBuilder.ToString();


            return connstring;
        }
    }
}
