using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.EntityClient;
using System.Data.Metadata.Edm;
using InLine;



namespace InLine.Model.Data
{
    public class ConnectionStringKonstruktor
    {

        public string ProviderName { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
      

        public string GetConnectionString(Model.Admin.KorisnikData userdata)
        {
            string connstring;
            string providerString;

            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

            sqlBuilder.DataSource = userdata.ServerName.Trim();
            sqlBuilder.InitialCatalog = userdata.DatabaseName.Trim();
            sqlBuilder.UserID = userdata.Korisnik.Trim();
            sqlBuilder.Password = userdata.Password.Trim();
            sqlBuilder.MultipleActiveResultSets = true;
            providerString = sqlBuilder.ToString();

            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();

            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = providerString;
            entityBuilder.Metadata = @"res://*/InLine2.csdl|res://*/InLine2.ssdl|res://*/InLine2.msl";
            connstring = entityBuilder.ToString();
            return connstring;
        }

    }
}
