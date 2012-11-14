using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.Configuration;

namespace WinAutoComplete
{
    public static class DataHelper
    {
        public static DataTable LoadDataTable()
        {
            DataTable dt = new DataTable();

            string connectionstring = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlCeConnection conn = new SqlCeConnection(connectionstring);

            SqlCeCommand command = new SqlCeCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Clientes";

            SqlCeDataAdapter da = new SqlCeDataAdapter(command);

            da.Fill(dt);

            return dt;
        }

        public static AutoCompleteStringCollection LoadAutoComplete()
        {
            DataTable dt = LoadDataTable();

            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row["Nombre"]));
            }

            return stringCol;
        }

    }
}
