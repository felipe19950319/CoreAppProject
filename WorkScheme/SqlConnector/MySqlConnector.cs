using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Xml.Linq;
using System.IO;
using Newtonsoft.Json;

namespace SqlConnector
{
    public class MySqlConnector : Common
    {
        //private Common c = new Common();
        private MySqlConnection cn = new MySqlConnection();
        private MySqlCommand cmd = new MySqlCommand();
        // public string StoredProcedure = string.Empty;

        public void OpenConnection()
        {
            cn.ConnectionString = this.ConnectionString;
            cn.Open();
        }

        public void CloseConnection() {
            cn.Dispose();
            cn.Close();
        }

        public MySqlConnector ExecQuery()
        {
            OpenConnection();

            cmd = new MySqlCommand(Procedure, cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            foreach (var Item in Parameters)
            {
                cmd.Parameters.AddWithValue(Item.Key, Item.Value);
            }

            cmd.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            //retornaremos finalmente 
            //DataSet ds = new DataSet();
            ds.Dispose();
            ds.Clear();
            adapter.Fill(ds);

            CloseConnection();
            return this;
        }

    }

}
