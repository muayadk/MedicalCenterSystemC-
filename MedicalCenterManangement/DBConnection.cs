using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace MedicalCenterManangement
{
    class DBConnection
    {
        FormLogin f = (FormLogin)Application.OpenForms["FormLogin"];
        public string conn_Str;
        public SqlConnection master_Conn, sqlconnection;



      public  DBConnection()
        {
           // sqlconnection = masterConn();
          sqlconnection =new SqlConnection("Data Source=MUAYAD-ESMAIL;Initial Catalog=MedicalCenterDb;Integrated Security=True");
        }


        public SqlConnection createConn_new(string path_db)
        {
            conn_Str = f.conn_type.Text + path_db;
            master_Conn = new SqlConnection(conn_Str);
            return master_Conn;
        }
        public string conn_type()
        {
            //string ss = f.conn_type.Text.Substring(0, f.conn_type.Text.LastIndexOf("; In") + 1);
            return f.conn_type.Text.Substring(0, f.conn_type.Text.LastIndexOf("; database=") + 1);

        }
        public SqlConnection masterConn()
        {
            string connStr;
            SqlConnection Connect;
            connStr = FormLogin.connfordata_tayp+ FormLogin.path_databas ;
            Connect = new SqlConnection(connStr);
            connStr = Connect.DataSource;
            try
            {
                Connect.Close();
                Connect.Open();
                Connect.Close();
            }
            catch
            {
                
            }
            return Connect;
        }



        // Method to open connection
        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }

        //Method to close connection
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
        // Method to read Data from DataSete

        public DataTable SelectData(string stored_procedure, SqlParameter[] param)



        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        //Method to insert , update and delete data from DataSets
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            try
            {
                sqlcmd.Connection = sqlconnection;
                sqlcmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

    }
}
