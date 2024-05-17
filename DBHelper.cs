using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DB
{
    internal class DBHelper
    {
        private SqlConnection _cnn;
        private static DBHelper _Instance;

        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DBHelper();
                }
                return _Instance;
            }
            private set { }
        }
        public DBHelper()
        {
            String strCon = @"Data Source=LAPTOP-IL246S2S\SQLEXPRESS01;Initial Catalog=DEMO_GYMSYSTEM;Integrated Security=True;";
            _cnn = new SqlConnection(strCon);
        }
        public DataTable GetRecord(string query, params SqlParameter[] p)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, _cnn);
            da.SelectCommand.Parameters.AddRange(p);
            _cnn.Open();
            da.Fill(dt);
            _cnn.Close();
            return dt;
        }
        public void ExecuteDB(string sql, params SqlParameter[] p)
        {
            SqlCommand cmd = new SqlCommand(sql, _cnn);
            cmd.Parameters.AddRange(p);
            _cnn.Open();
            cmd.ExecuteNonQuery();
            _cnn.Close();
        }
        public object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (SqlCommand command = new SqlCommand(query, _cnn))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                _cnn.Open();
                object result = command.ExecuteScalar();
                _cnn.Close();
                return result;
            }
        }        
    }
}
