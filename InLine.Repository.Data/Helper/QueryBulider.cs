using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;


namespace InLine.Repository.Data.Helper
{
    public static class QueryBulider
    {
        public static string CreateQuery(string entity, dynamic fields, dynamic filter, dynamic sort, long? start = null, long? count = null)
        {
            string query = String.Empty;
            StringBuilder querybilder = new StringBuilder();
            StringBuilder qbSelect = new StringBuilder();
            StringBuilder qbWhere = new StringBuilder();
            StringBuilder qbOrderBy = new StringBuilder();
            string selectString = String.Empty;
            string fromString = String.Empty;
            string filterString = String.Empty;
            string sortString = String.Empty;
            string listafinal = String.Empty;
            string offset = String.Empty;
            string fetch = String.Empty;
            var listbasic = Activator.CreateInstance(typeof(List<>).MakeGenericType(fields.GetType().GetGenericArguments()[0]));
            var listfinal = Activator.CreateInstance(typeof(List<>).MakeGenericType(fields.GetType().GetGenericArguments()[0]));

            string serverversion = CommonFunctions.ServerInformation.ServerVersion;


            Type enumType = fields.GetType().GetGenericArguments()[0];

            foreach (dynamic polje in Enum.GetValues(enumType))
            {

                listbasic.Add((dynamic)polje);
            }

            listfinal = Enumerable.Except(listbasic, fields);



            // SELECT DIO
            if (Enumerable.Any(fields))
            {
                foreach (var polje in fields)
                {
                    qbSelect.Append(polje.ToString() + ", ");
                    qbSelect.Append(System.Environment.NewLine);
                }

                foreach (var polje in listfinal)
                {
                    qbSelect.Append(" NULL AS " + polje.ToString() + ", ");

                    if (polje == Enumerable.Last(listfinal))
                    {
                        qbSelect.Remove(qbSelect.ToString().Length - 2, 2);
                    }

                    qbSelect.Append(System.Environment.NewLine);


                }
            }

            else
            {
                foreach (var polje in listbasic)
                {
                    qbSelect.Append(polje.ToString() + ", ");

                    if (polje == Enumerable.Last(listbasic))
                    {
                        qbSelect.Remove(qbSelect.ToString().Length - 2, 2);
                    }

                    qbSelect.Append(System.Environment.NewLine);
                }

            }

            selectString = qbSelect.ToString();


            // FROM DIO
            fromString = filter.GetType().ToString();
            int zadnjatocka = fromString.LastIndexOf(".");
            fromString = fromString.Substring(zadnjatocka + 1, (fromString.Length - 2) - zadnjatocka);



            // WHERE DIO
            if (Enumerable.Any(filter))
            {
                string filterstring = String.Empty;
                bool stringtype = false;
                dynamic stringvalue = string.Empty;


                foreach (var polje in filter)
                {

                    stringtype = polje.Tip;

                    if (polje.Operator == null)
                        filterstring = GetOperator(ERelationalOperator.Equal);
                    else
                        filterstring = GetOperator(polje.Operator);


                    if (stringtype == true)
                        stringvalue = "'" + polje.Value + "'";
                    else
                        stringvalue = polje.Value;

                    qbWhere.Append(polje.Field.ToString() + filterstring + stringvalue + " AND ");

                    if (polje == Enumerable.Last(filter))
                    {
                        qbWhere.Remove(qbWhere.ToString().Length - 5, 5);
                    }

                    qbWhere.Append(System.Environment.NewLine);
                }


                filterString = qbWhere.ToString();

            }


            // ORDER BY DIO
            if (Enumerable.Any(sort))
            {
                foreach (var polje in sort)
                {
                    if (polje.Descending == false)
                        qbOrderBy.Append(polje.Field + ", ");
                    else
                        qbOrderBy.Append(polje.Field + " DESC, ");

                }

                sortString = qbOrderBy.ToString();
                sortString = sortString.Remove(sortString.Length - 2);
            }

            // PAGING DIO
            switch (serverversion)
            {
                case "11":

                    if (start > 0 && count > 1)
                    {
                        offset = ((Convert.ToInt64(start) - 1) * Convert.ToInt64(count)).ToString();
                        fetch = Convert.ToInt64(count).ToString();
                    }

                    else if (start == 0 && count > 1)
                    {
                        offset = CommonFunctions.ServerInformation.offset_server_11;
                        fetch = Convert.ToInt64(count).ToString();
                    }

                    else
                    {
                        offset = CommonFunctions.ServerInformation.offset_server_11;
                        fetch = CommonFunctions.ServerInformation.fetch_server_11;
                    }

                    break;


                case "10":

                    if (start > 0 && count > 1)
                    {
                        offset = ((Convert.ToInt64(start) - 1) * Convert.ToInt64(count) + 1).ToString();
                        fetch = (Convert.ToInt64(start) * Convert.ToInt64(count)).ToString();
                    }

                    else if (start == 0 && count > 1)
                    {
                        offset = CommonFunctions.ServerInformation.offset_server_10;
                        fetch = Convert.ToInt64(count).ToString();
                    }

                    else
                    {
                        offset = CommonFunctions.ServerInformation.offset_server_10;
                        fetch = CommonFunctions.ServerInformation.fetch_server_10;
                    }

                    break;
            }



            // QUERY BUILDER DIO
            switch (serverversion)
            {
                case "11":
                    querybilder.Append("SELECT ");
                    querybilder.Append(System.Environment.NewLine);
                    querybilder.Append(selectString);
                    querybilder.Append(System.Environment.NewLine);
                    querybilder.Append(" FROM ");
                    querybilder.Append(System.Environment.NewLine);
                    querybilder.Append(entity);
                    querybilder.Append(System.Environment.NewLine);

                    if (!String.IsNullOrEmpty(filterString))
                    {
                        querybilder.Append(System.Environment.NewLine);
                        querybilder.Append(" WHERE ");
                        querybilder.Append(System.Environment.NewLine);
                        querybilder.Append(filterString);
                        querybilder.Append(System.Environment.NewLine);
                    }


                    if (!String.IsNullOrEmpty(sortString))
                    {
                        querybilder.Append(" ORDER BY ");
                        querybilder.Append(System.Environment.NewLine);
                        querybilder.Append(sortString);
                        querybilder.Append(System.Environment.NewLine);
                    }

                    else
                    {
                        querybilder.Append(" ORDER BY ");
                        querybilder.Append(System.Environment.NewLine);
                        querybilder.Append(Enumerable.ElementAt(listbasic, 0) + " DESC ");
                        querybilder.Append(System.Environment.NewLine);
                    }


                    if (!String.IsNullOrEmpty(offset) && !String.IsNullOrEmpty(fetch))
                    {
                        querybilder.Append(System.Environment.NewLine);
                        querybilder.Append(" OFFSET ");
                        querybilder.Append(System.Environment.NewLine);
                        querybilder.Append(offset + " ROWS " + " FETCH NEXT " + fetch + " ROWS ONLY ");
                    }

                    break;



                case "10":
                    querybilder.Append("SELECT * FROM");
                    querybilder.Append(System.Environment.NewLine);
                    querybilder.Append(" (SELECT ROW_NUMBER() over (ORDER BY ");

                    if (!String.IsNullOrEmpty(sortString))
                    {
                        querybilder.Append(sortString);
                    }

                    else
                    {
                        querybilder.Append(Enumerable.ElementAt(listbasic, 0));
                    }


                    querybilder.Append(") AS RowID, ");
                    querybilder.Append(System.Environment.NewLine);
                    querybilder.Append(selectString);
                    querybilder.Append(System.Environment.NewLine);
                    querybilder.Append(" FROM ");
                    querybilder.Append(System.Environment.NewLine);
                    querybilder.Append(entity);
                    querybilder.Append(System.Environment.NewLine);


                    if (!String.IsNullOrEmpty(filterString))
                    {
                        querybilder.Append(System.Environment.NewLine);
                        querybilder.Append(" WHERE ");
                        querybilder.Append(System.Environment.NewLine);
                        querybilder.Append(filterString + ") sve ");
                        querybilder.Append(System.Environment.NewLine);
                    }

                    else
                    {
                        querybilder.Append(System.Environment.NewLine);
                        querybilder.Append(") sve ");
                        querybilder.Append(System.Environment.NewLine);
                    }



                    if (!String.IsNullOrEmpty(offset) && !String.IsNullOrEmpty(fetch))
                    {
                        querybilder.Append(System.Environment.NewLine);
                        querybilder.Append(" WHERE RowID BETWEEN " + offset + " AND " + fetch);
                        querybilder.Append(System.Environment.NewLine);
                    }


                    if (!String.IsNullOrEmpty(sortString))
                    {
                        querybilder.Append(System.Environment.NewLine);
                        querybilder.Append(" ORDER BY ");
                        querybilder.Append(System.Environment.NewLine);
                        querybilder.Append(sortString);
                    }



                    break;
            }


            query = querybilder.ToString();

            return query;
        }

        public static string CreateQuerySelect(string entity, string filter, string sort, long? start = null, long? count = null)
        {
            string query = String.Empty;
            StringBuilder querybilder = new StringBuilder();
            string offset = String.Empty;
            string fetch = String.Empty;

            string serverversion = CommonFunctions.ServerInformation.ServerVersion;


            switch (serverversion)
            {
                case "11":

     
                    if (start >= 0 && count > 0 )
                    {
                        offset = (Convert.ToInt64(start)).ToString();
                        fetch = Convert.ToInt64(count).ToString();
                    }

                    else if (count == 0)
                    {
                        offset = (Convert.ToInt64(start)).ToString();
                        fetch = CommonFunctions.ServerInformation.fetch_server_11;
                    }

                    else
                    {
                        offset = CommonFunctions.ServerInformation.offset_server_11;
                        fetch = CommonFunctions.ServerInformation.fetch_server_11;
                    }
                     
                    break;


                case "10":


                    if (start >= 0 && count > 0 )
                    {
                        if (start == 0)
                        {
                            offset = (Convert.ToInt64(start) + 1).ToString();
                            fetch = (Convert.ToInt64(count)).ToString();
                        }
                        else
                        {
                            offset = (Convert.ToInt64(start) + 1).ToString();
                            fetch = (Convert.ToInt64(start) + Convert.ToInt64(count)).ToString();
                        }

                    }

                    else if (count == 0)
                    {
                        offset = ((Convert.ToInt64(start) * Convert.ToInt64(count)) + 1).ToString();
                        fetch = (Convert.ToInt64(start) * Convert.ToInt64(CommonFunctions.ServerInformation.fetch_server_10)).ToString();
                    }

                    else
                    {
                        offset = ((Convert.ToInt64(CommonFunctions.ServerInformation.offset_server_10) * Convert.ToInt64(CommonFunctions.ServerInformation.fetch_server_10)) + 1).ToString();
                        fetch = (Convert.ToInt64(start) * Convert.ToInt64(CommonFunctions.ServerInformation.fetch_server_10)).ToString();
                    }
                     
                    break;
            }


            switch (serverversion)
            {
                case "11":

    
                if (!String.IsNullOrEmpty(filter))
                {
                    querybilder.Append("SELECT * FROM " + entity);
                    querybilder.Append(" WHERE " + filter);
                    querybilder.Append(" ORDER BY " + sort + " OFFSET ");
                    querybilder.Append(offset);
                    querybilder.Append(" ROWS FETCH NEXT ");
                    querybilder.Append(fetch);
                    querybilder.Append(" ROWS ONLY ");
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + entity + " ORDER BY " + sort + " OFFSET ");
                    querybilder.Append(offset);
                    querybilder.Append(" ROWS FETCH NEXT ");
                    querybilder.Append(fetch);
                    querybilder.Append(" ROWS ONLY ");
                }

                    break;



                case "10":
                    querybilder.Append("SELECT * FROM");
                    querybilder.Append(" (SELECT ROW_NUMBER() over (ORDER BY ");

                    if (!String.IsNullOrEmpty(sort))
                    {
                        querybilder.Append(sort);
                    }

                  
                    querybilder.Append(") AS RowID, ");
                    querybilder.Append("*");
                    querybilder.Append(" FROM ");
                    querybilder.Append(entity);


                    if (!String.IsNullOrEmpty(filter))
                    {
                        querybilder.Append(" WHERE ");
                        querybilder.Append(filter + ") sve ");
                    }

                    else
                    {
                        querybilder.Append(") sve ");
                    }



                    if (!String.IsNullOrEmpty(offset) && !String.IsNullOrEmpty(fetch))
                    {
                        querybilder.Append(" WHERE RowID BETWEEN " + offset + " AND " + fetch);
                    }


                    if (!String.IsNullOrEmpty(sort))
                    {
                        querybilder.Append(" ORDER BY ");
                        querybilder.Append(sort);
                    }

                    break;
            }


            query = querybilder.ToString();

            return query;
        }

        public static string GetOperator(ERelationalOperator op)
        {
            string operatorString = op.ToString().Trim();

            switch (op)
            {
                case ERelationalOperator.Equal: operatorString = " = "; break;
                case ERelationalOperator.NotEqual: operatorString = " != "; break;
                case ERelationalOperator.Greater: operatorString = " > "; break;
                case ERelationalOperator.Less: operatorString = " < "; break;
                case ERelationalOperator.GreaterEqual: operatorString = " >= "; break;
                case ERelationalOperator.LessEqual: operatorString = " <= "; break;
                case ERelationalOperator.Like: operatorString = " LIKE "; break;
                case ERelationalOperator.NotLike: operatorString = " NOT LIKE "; break;
            }

            return operatorString;

        }

        public static string CreateWhere(string model, string filter)
        {
            string query = String.Empty;
            StringBuilder querybilder = new StringBuilder();
            string[] separator = new string[] { CommonFunctions.KeyWord.And };
            string[] dijelovi;

            dijelovi = filter.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string privremena = String.Empty;

            foreach (string d in dijelovi)
            {
                string prvi = String.Empty;
                string drugi = String.Empty;
                string treci = String.Empty;
                string[] polja;
                string[] sep = new string[] { CommonFunctions.KeyWord.Space };

                privremena = d.ToString().Replace(CommonFunctions.KeyWord.DvostrukiNavodnik, CommonFunctions.KeyWord.Empty);
                polja = privremena.Split(sep, 3, StringSplitOptions.RemoveEmptyEntries);

                prvi = polja.ElementAt(0).ToString().Trim();
                drugi = polja.ElementAt(1).ToString().Trim();
                treci = polja.ElementAt(2).ToString().Trim();

                string modelassemb = (model + CommonFunctions.KeyWord.Zarez + CommonFunctions.KeyWord.Space + CommonFunctions.KeyWord.Assembly).ToString();
                //PropertyInfo pro = Activator.CreateInstance(Type.GetType("InLine.Model.Data.View.HUB2013A, InLine.Model.Data")).GetType().GetProperty(prvi);

                PropertyInfo pro = Activator.CreateInstance(Type.GetType(modelassemb)).GetType().GetProperty(prvi);

                string propType = pro.PropertyType.Name;

                if (propType == CommonFunctions.KeyWord.String)
                {
                    privremena = prvi.ToString() + CommonFunctions.KeyWord.Space +  CommonFunctions.KeyWord.Like + CommonFunctions.KeyWord.Navodnik + CommonFunctions.KeyWord.Posto + treci.ToString() + CommonFunctions.KeyWord.Posto + CommonFunctions.KeyWord.Navodnik;
                }
                else
                {
                    privremena = prvi.ToString() + CommonFunctions.KeyWord.Space + drugi.ToString() + CommonFunctions.KeyWord.Space + treci.ToString();
                }

                querybilder.Append(privremena);
                querybilder.Append(CommonFunctions.KeyWord.Space + CommonFunctions.KeyWord.And + CommonFunctions.KeyWord.Space);

            }

            if (querybilder.ToString().Length > 5)
            {
                querybilder.Remove(querybilder.ToString().Length - 5, 5);
            }

            query = querybilder.ToString();
            return query;
        }

        public static string CreateWhereKeyValue(string key, string value)
        {
            string query = String.Empty;
            StringBuilder querybilder = new StringBuilder();
            querybilder.Append(key + " = " + value);
            query = querybilder.ToString();
            return query;
        }

        public static string CreateWhereFindID(long value, string key)
        {
            string query = String.Empty;
            StringBuilder querybilder = new StringBuilder();
            querybilder.Append(key + " = " + value);
            query = querybilder.ToString();
            return query;
        }

    }
}
