using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Xml.Linq;
using System.IO;

namespace SqlConnector
{
    public class MySqlConnector : Common
    {
        //private Common c = new Common();
        private MySqlConnection cn = new MySqlConnection();
        private MySqlCommand cmd = new MySqlCommand();
        public string ConnectionString = string.Empty;
        public  DataSet ds = new DataSet();
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
            adapter.Fill(ds);

            CloseConnection();
            return this;
        }

    }
    public static class ConnectorOverload
    {
        public static DataTable toDataTable(this MySqlConnector ms)
        {
          return  ms.ds.Tables[0];
        }

        public static XDocument toXml(this MySqlConnector ms)
        {
            string result=string.Empty;
            using (MemoryStream ms_ = new MemoryStream())
            {
                ms.ds.Tables[0].WriteXml(ms_, System.Data.XmlWriteMode.IgnoreSchema);
                result = System.Text.Encoding.Default.GetString(ms_.ToArray());
            }

            XDocument xdoc = XDocument.Parse(result);
            return xdoc;
        }

    }


}
